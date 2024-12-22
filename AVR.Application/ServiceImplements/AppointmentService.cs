using AutoMapper;
using AVR.Application.Services;
using AVR.Application.Utils.GenerateCode;
using AVR.Application.ViewModels.Request.Appointments;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Response.Accounts;
using AVR.Application.ViewModels.Response.Appointments;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly UserManager<Account> _userManager;
        private readonly INotificationService _notificationService;
        private readonly IGenerateCode _generateCode;

        public AppointmentService(IConfiguration configuration, IUnitOfWork unitOfWork, IMapper mapper, UserManager<Account> userManager, INotificationService notificationService, IGenerateCode generateCode)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
            _notificationService = notificationService;
            _generateCode = generateCode;
        }

        //Create Appointment
        public async Task<CreateAppointmentResponse> CreateAppointmentAsync(CreateAppointmentRequest request)
        {
            // Lấy thời gian hiện tại
            var currentDateTime = CoreHelper.SystemTimeNow;
        
            // Kiểm tra ngày cuộc hẹn
            if (request.AppointmentDate.Date < currentDateTime.Date ||
                (request.AppointmentDate.Date == currentDateTime.Date && request.StartTime <= currentDateTime.TimeOfDay))
            {
                throw new CustomException.InvalidDataException("Ngày và giờ cuộc hẹn phải nằm trong tương lai.");
            }
        
            // Kiểm tra StartTime cách ít nhất 3 tiếng nếu cùng ngày
            if (request.AppointmentDate.Date == currentDateTime.Date)
            {
                var futureTime = currentDateTime.AddHours(3).TimeOfDay;
                if (request.StartTime < futureTime)
                {
                    throw new CustomException.InvalidDataException("Giờ bắt đầu cuộc hẹn phải cách hiện tại ít nhất 3 tiếng.");
                }
            }
        
        
            // Kiểm tra khách hàng
            var customer = await _userManager.FindByIdAsync(request.CustomerID.ToString());
            if (customer == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy khách hàng này.");
            }
        
            // Kiểm tra căn hộ
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ này.");
            }
        
            // Kiểm tra dự án căn hộ
            var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);
            if (projectApartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy dự án căn hộ liên quan.");
            }
        
            // Tìm TeamMember dựa trên AssignedStaffAccountID
            var teamMember = _unitOfWork.TeamMemberRepository
                .Get(tm => tm.AccountID == request.AssignedStaffAccountID && tm.TeamID == projectApartment.TeamID)
                .FirstOrDefault();
        
            if (teamMember == null)
            {
                throw new CustomException.InvalidDataException("Nhân viên được chỉ định không thuộc team quản lý dự án của căn hộ.");
            }
        
        
        
            // Lấy danh sách các cuộc hẹn hiện có của nhân viên trong cùng ngày
            var existingAppointments = _unitOfWork.AppointmentRepository.Get(a =>
                a.AssignedTeamMemberID == teamMember.TeamMemberID &&
                a.AppointmentDate.Date == request.AppointmentDate.Date);
        
            if (!existingAppointments.Any())
            {
                // Log cảnh báo nếu không có cuộc hẹn nào trong danh sách
                Console.WriteLine("Không có cuộc hẹn nào trong danh sách.");
            }
        
            // Duyệt qua các cuộc hẹn để kiểm tra khoảng cách thời gian
            foreach (var existingAppointment in existingAppointments)
            {
                var existingStartTime = existingAppointment.StartTime.Value;
                var newStartTime = request.StartTime;
        
                // Kiểm tra nếu khoảng thời gian giữa các cuộc hẹn nhỏ hơn 3 tiếng
                if (Math.Abs((newStartTime - existingStartTime).TotalHours) < 3)
                {
                    throw new CustomException.InvalidDataException("Cuộc hẹn mới phải cách ít nhất 3 tiếng so với cuộc hẹn hiện tại.");
                }
            }
        
        
        
        
            // Tạo đối tượng Appointment
            var appointment = _mapper.Map<Appointment>(request);
            var atID = Guid.NewGuid();
            appointment.AppointmentID = atID;
            appointment.AppointmentCode = await _generateCode.GenerateAppointmentCode(atID);
            appointment.CreateDate = CoreHelper.SystemTimeNow;
            appointment.UpdatedDate = CoreHelper.SystemTimeNow;
            appointment.AppointmentStatus = Domain.Enums.AppointmentStatus.Confirmed;
            appointment.AssignedTeamMemberID = teamMember.TeamMemberID;
        
            // **Determine RequestType based on ReferenceCode**
            if (!string.IsNullOrEmpty(request.ReferenceCode))
            {
                if (request.ReferenceCode.StartsWith("ATR"))
                {
                    appointment.AppointmentTypes = AppointmentTypes.Appointment;
                }
                else if (request.ReferenceCode.StartsWith("DPS"))
                {
                    appointment.AppointmentTypes = AppointmentTypes.Deposit;
                }
                else if (request.ReferenceCode.StartsWith("CT"))
                {
                    appointment.AppointmentTypes = AppointmentTypes.Verification;
                }
                else if (request.ReferenceCode.StartsWith("PRR"))
                {
                    appointment.AppointmentTypes = AppointmentTypes.Property;
                }
                else
                {
                    throw new CustomException.InvalidDataException("ReferenceCode không hợp lệ.");
                }
            }
            else
            {
                throw new CustomException.InvalidDataException("ReferenceCode không được để trống.");
            }
        
            // Lưu cuộc hẹn
            _unitOfWork.AppointmentRepository.Insert(appointment);
        
            // Gửi thông báo cho Customer
            var notificationRequest = new NotificationRequest
            {
                AccountID = request.CustomerID,
                Title = "Cuộc hẹn đã được xác nhận",
                Description = $"Cuộc hẹn của bạn tại căn hộ {apartment.ApartmentCode} đã được xác nhận.",
                NotificationTypes = NotificationType.Appointment,
                ReferenceId = appointment.AppointmentID
            };
        
            await _notificationService.CreateNotificationAsync(notificationRequest);
        
            await _unitOfWork.SaveAsync();
        
            var response = _mapper.Map<CreateAppointmentResponse>(appointment);
            response.ApartmentCode = apartment.ApartmentCode;
            response.AssignedTeamMemberID = teamMember.TeamMemberID;
            response.AssigndAccountID = request.AssignedStaffAccountID;
            return response;
        }


        public async Task<IEnumerable<CreateAppointmentResponse>> GetAllAppointmentAsync()
        {
            // Include Apartments and AssignedTeamMember in the query
            var appointments = _unitOfWork.AppointmentRepository.Get(
                includeProperties: "Apartments,AssignedTeamMember" // Ensure to load Apartments and AssignedTeamMember
            );

            if (appointments == null || !appointments.Any())
            {
                throw new CustomException.DataNotFoundException("Danh sách cuộc hẹn trống.");
            }

            // Map the list of appointments to CreateAppointmentResponse
            var response = appointments.Select(appointment =>
            {
                var appointmentResponse = _mapper.Map<CreateAppointmentResponse>(appointment);
                appointmentResponse.ApartmentCode = appointment.Apartments?.ApartmentCode; // Extract ApartmentCode
                appointmentResponse.AssigndAccountID = appointment.AssignedTeamMember?.AccountID; // Extract AccountID from AssignedTeamMember
                return appointmentResponse;
            });

            return response;
        }



        public async Task<CreateAppointmentResponse> GetById(Guid id)
        {
            var appointment = _unitOfWork.AppointmentRepository.Get(
            filter: a => a.AppointmentID == id,
            includeProperties: "Apartments,AssignedTeamMember.Account"
             ).FirstOrDefault();

            if (appointment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy cuộc hẹn.");
            }

            var response = _mapper.Map<CreateAppointmentResponse>(appointment);
            response.ApartmentCode = appointment.Apartments?.ApartmentCode;
            response.AssigndAccountID = appointment.AssignedTeamMember?.Account?.Id; // Include Account ID
            return response;
        }


        // Set Appointment Status to InProcessing
        public async Task<CreateAppointmentResponse> StartAppointment(Guid appointmentId)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(appointmentId);
            if (appointment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy cuộc hẹn.");
            }
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(appointment.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ.");
            }


            appointment.AppointmentStatus = AppointmentStatus.InProcessing;
            appointment.UpdatedDate = CoreHelper.SystemTimeNow;

            _unitOfWork.AppointmentRepository.Update(appointment);

            // Gửi thông báo cho Customer
            var notificationRequest = new NotificationRequest
            {
                AccountID = appointment.CustomerID,
                Title = "Cuộc hẹn đang được xử lý",
                Description = $"Cuộc hẹn của bạn tại căn hộ {apartment.ApartmentCode} đang được xử lý.",
                NotificationTypes = NotificationType.Appointment,
                ReferenceId = appointment.AppointmentID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreateAppointmentResponse>(appointment);
            response.ApartmentCode = apartment.ApartmentCode;
            return response;
        }

        // Set Appointment Status to Done and update EndTime
        public async Task<CreateAppointmentResponse> CompleteAppointment(Guid appointmentId)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(appointmentId);
            if (appointment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy cuộc hẹn.");
            }


            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(appointment.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ.");
            }

            appointment.AppointmentStatus = AppointmentStatus.Done;
            appointment.UpdatedDate = CoreHelper.SystemTimeNow;
            appointment.EndTime = TimeSpan.FromTicks(CoreHelper.SystemTimeNow.TimeOfDay.Ticks); // Set EndTime to current time

            _unitOfWork.AppointmentRepository.Update(appointment);


            // Gửi thông báo cho Customer
            var notificationRequest = new NotificationRequest
            {
                AccountID = appointment.CustomerID,
                Title = "Cuộc hẹn hoàn thành",
                Description = $"Cuộc hẹn của bạn tại căn hộ {apartment.ApartmentCode} đã hoàn thành.",
                NotificationTypes = NotificationType.Appointment,
                ReferenceId = appointment.AppointmentID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreateAppointmentResponse>(appointment);
            response.ApartmentCode = apartment.ApartmentCode;
            return response;
        }

        // Cancel Appointment and set EndTime to cancellation time
        public async Task<CreateAppointmentResponse> CancelAppointment(Guid appointmentId)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(appointmentId);
            if (appointment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy cuộc hẹn.");
            }


            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(appointment.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ.");
            }

            appointment.AppointmentStatus = AppointmentStatus.Canceled;
            appointment.UpdatedDate = CoreHelper.SystemTimeNow;
            appointment.EndTime = TimeSpan.FromTicks(CoreHelper.SystemTimeNow.TimeOfDay.Ticks); // Set EndTime to current time

            _unitOfWork.AppointmentRepository.Update(appointment);



            // Gửi thông báo cho Customer
            var notificationRequest = new NotificationRequest
            {
                AccountID = appointment.CustomerID,
                Title = "Cuộc hẹn đã bị hủy",
                Description = $"Cuộc hẹn của bạn tại căn hộ {apartment.ApartmentCode} đã bị hủy.",
                NotificationTypes = NotificationType.Appointment,
                ReferenceId = appointment.AppointmentID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreateAppointmentResponse>(appointment);
            response.ApartmentCode = apartment.ApartmentCode;
            return response;
        }

        // Update Appointment Date and Status to Updated
        public async Task<CreateAppointmentResponse> UpdateAppointmentDate(Guid appointmentId, UpdateAppointmentRequest request)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(appointmentId);
            if (appointment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy cuộc hẹn.");
            }

            // Lấy thông tin căn hộ
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(appointment.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ.");
            }

            appointment.AppointmentDate = request.NewAppointmentDate;
            appointment.StartTime = request.NewStartTime;
            appointment.AppointmentStatus = request.NewStatus;
            appointment.Description = request.UpdatedDescription;
            appointment.UpdatedDate = CoreHelper.SystemTimeNow;

            // **Kiểm tra xem có cuộc hẹn nào trùng trong khoảng 3 giờ không**
            var startRange = request.NewAppointmentDate.AddHours(-3);
            var endRange = request.NewAppointmentDate.AddHours(3);

            var overlappingAppointments = _unitOfWork.AppointmentRepository.Get(
                a => a.ApartmentID == apartment.ApartmentID
                && a.AppointmentDate >= startRange
                && a.AppointmentDate <= endRange
            );

            if (overlappingAppointments.Any())
            {
                throw new CustomException.InvalidDataException("Không thể đặt cuộc hẹn vì đã có một cuộc hẹn khác trong khoảng thời gian 3 giờ.");
            }

            _unitOfWork.AppointmentRepository.Update(appointment);

            // Tạo thông báo khi cập nhật cuộc hẹn
            var notificationRequest = new NotificationRequest
            {
                AccountID = appointment.CustomerID,
                Title = "Cập nhật cuộc hẹn",
                Description = $"Cuộc hẹn của bạn tại căn hộ {apartment.ApartmentName} đã được cập nhật. Ngày mới: {request.NewAppointmentDate:dd/MM/yyyy} từ {request.NewStartTime}.",
                NotificationTypes = NotificationType.Appointment,
                ReferenceId = appointment.AppointmentID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreateAppointmentResponse>(appointment);
            response.ApartmentCode = apartment.ApartmentCode;

            return response;
        }


        public async Task<(IEnumerable<CreateAppointmentResponse> Results, int TotalItems, int TotalPages)> SearchAppointmentsAsync(
            Guid? customerId = null,
            Guid? apartmentId = null,
            AppointmentStatus? status = null,
            DateTimeOffset? startDate = null,
            DateTimeOffset? endDate = null,
            string? title = null,
            Guid? teamId = null,
            string? referenceCode = null,
            int pageIndex = 1,
            int pageSize = 10)
        {
            // Biểu thức lọc dựa trên các tham số tìm kiếm
            Expression<Func<Appointment, bool>> filter = appointment =>
                (!customerId.HasValue || appointment.CustomerID == customerId) &&
                (!apartmentId.HasValue || appointment.ApartmentID == apartmentId) &&
                (!status.HasValue || appointment.AppointmentStatus == status) &&
                (!startDate.HasValue || appointment.AppointmentDate >= startDate) &&
                (!endDate.HasValue || appointment.AppointmentDate <= endDate) &&
                (string.IsNullOrEmpty(title) || appointment.Title.Contains(title)) &&
                (!teamId.HasValue || appointment.Apartments.AssignedTeamMember.TeamID == teamId) &&
                (string.IsNullOrEmpty(referenceCode) || appointment.ReferenceCode.Contains(referenceCode));

            // Đếm tổng số lượng cuộc hẹn phù hợp
            int totalItems = await _unitOfWork.AppointmentRepository.CountAsync(filter);

            // Lấy danh sách cuộc hẹn theo phân trang
            var appointments = _unitOfWork.AppointmentRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(a => a.AppointmentDate),
                pageIndex: pageIndex,
                pageSize: pageSize,
                includeProperties: "Apartments.AssignedTeamMember,AssignedTeamMember.Account"
            );

            // Tính tổng số trang
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Map danh sách kết quả sang `CreateAppointmentResponse`
            var results = appointments.Select(appointment =>
            {
                var response = _mapper.Map<CreateAppointmentResponse>(appointment);
                response.ApartmentCode = appointment.Apartments?.ApartmentCode; // Gán ApartmentCode vào Response
                response.AssigndAccountID = appointment.AssignedTeamMember?.AccountID;
                return response;
            });

            return (results, totalItems, totalPages);
        }



    }
}
