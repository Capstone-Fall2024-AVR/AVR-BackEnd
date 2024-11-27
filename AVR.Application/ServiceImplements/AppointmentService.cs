using AutoMapper;
using AVR.Application.Services;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public AppointmentService(IConfiguration configuration, IUnitOfWork unitOfWork, IMapper mapper, UserManager<Account> userManager, INotificationService notificationService)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
            _notificationService = notificationService;
        }

        //Create Appointment
        public async Task<CreateAppointmentResponse> CreateAppointmentAsync(CreateAppointmentRequest request)
        {
            // Kiểm tra thời gian cuộc hẹn
            var currentTime = CoreHelper.SystemTimeNow;
            if (request.AppointmentDate < currentTime.AddHours(1))
            {
                throw new CustomException.InvalidDataException("Thời gian cuộc hẹn phải nằm trong tương lai và cách hiện tại ít nhất 1 tiếng.");
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

            // Tạo đối tượng Appointment
            var appointment = _mapper.Map<Appointment>(request);
            appointment.CreateDate = CoreHelper.SystemTimeNow;
            appointment.UpdatedDate = CoreHelper.SystemTimeNow;
            appointment.AppointmentStatus = Domain.Enums.AppointmentStatus.Confirmed;
            apartment.AssignedTeamMemberID = teamMember.TeamMemberID;

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
            response.AssignedTeamMemberID = teamMember.TeamMemberID;
            response.AssigndAccountID = request.AssignedStaffAccountID;
            return response;
        }


        public async Task<IEnumerable<CreateAppointmentResponse>> GetAllAppointmentAsync()
        {
            var appointments = await _unitOfWork.AppointmentRepository.GetAllAsync();
            if (appointments == null)
            {
                throw new CustomException.DataNotFoundException("List trống.");

            }

            var accountResponses = _mapper.Map<IEnumerable<CreateAppointmentResponse>>(appointments);
            return accountResponses;
        }

        public async Task<CreateAppointmentResponse> GetById(Guid id)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(id);
            if (appointment == null) 
            {
                throw new CustomException.DataNotFoundException("Không thấy apointment.");
            }

            var response = _mapper.Map<CreateAppointmentResponse>(appointment);
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

            return _mapper.Map<CreateAppointmentResponse>(appointment);
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

            return _mapper.Map<CreateAppointmentResponse>(appointment);
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

            return _mapper.Map<CreateAppointmentResponse>(appointment);
        }

        // Update Appointment Date and Status to Updated
        public async Task<CreateAppointmentResponse> UpdateAppointmentDate(Guid appointmentId, DateTimeOffset newDate, TimeSpan newStartTime, TimeSpan newEndTime)
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

            appointment.AppointmentDate = newDate;
            appointment.StartTime = newStartTime;
            appointment.EndTime = newEndTime;
            appointment.AppointmentStatus = AppointmentStatus.Updated;
            appointment.UpdatedDate = CoreHelper.SystemTimeNow;

            _unitOfWork.AppointmentRepository.Update(appointment);

            // Tạo thông báo khi cập nhật cuộc hẹn
            var notificationRequest = new NotificationRequest
            {
                AccountID = appointment.CustomerID,
                Title = "Cập nhật cuộc hẹn",
                Description = $"Cuộc hẹn của bạn tại căn hộ {apartment.ApartmentName} đã được cập nhật. Ngày mới: {newDate:dd/MM/yyyy} từ {newStartTime} đến {newEndTime}.",
                NotificationTypes = NotificationType.Appointment,
                ReferenceId = appointment.AppointmentID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            await _unitOfWork.SaveAsync();

            return _mapper.Map<CreateAppointmentResponse>(appointment);
        }


        public async Task<(IEnumerable<CreateAppointmentResponse> Results, int TotalItems, int TotalPages)> SearchAppointmentsAsync(
            Guid? customerId = null,
            Guid? apartmentId = null,
            AppointmentStatus? status = null,
            DateTimeOffset? startDate = null,
            DateTimeOffset? endDate = null,
            string? title = null,
            int pageIndex = 1,
            int pageSize = 10)
        {
            // Biểu thức lọc dựa trên các tham số tìm kiếm
            Expression<Func<Appointment, bool>> filter = appointment =>
                (!customerId.HasValue || appointment.CustomerID == customerId.Value) &&
                (!apartmentId.HasValue || appointment.ApartmentID == apartmentId.Value) &&
                (!status.HasValue || appointment.AppointmentStatus == status) &&
                (!startDate.HasValue || appointment.AppointmentDate >= startDate.Value) &&
                (!endDate.HasValue || appointment.AppointmentDate <= endDate.Value) &&
                (string.IsNullOrEmpty(title) || appointment.Title.Contains(title));

            // Đếm tổng số lượng cuộc hẹn phù hợp
            int totalItems = await _unitOfWork.AppointmentRepository.CountAsync(filter);

            // Lấy danh sách cuộc hẹn theo phân trang
            var appointments = _unitOfWork.AppointmentRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(a => a.AppointmentDate),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Tính tổng số trang
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Map danh sách kết quả sang `CreateAppointmentResponse`
            var results = _mapper.Map<IEnumerable<CreateAppointmentResponse>>(appointments);

            return (results, totalItems, totalPages);
        }

    }
}
