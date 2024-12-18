using AutoMapper;
using AVR.Application.Services;
using AVR.Application.Utils.GenerateCode;
using AVR.Application.ViewModels.Request.AppointmentRequests;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Response.AppointmentRequests;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class AppointmentRequestService : IAppointmentRequestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly UserManager<Account> _userManager;
        private readonly IRequestAssignmentService _requestAssignmentService;
        private readonly INotificationService _notificationService;
        private readonly IGenerateCode _generateCode;

        public AppointmentRequestService(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration, UserManager<Account> userManager, IRequestAssignmentService requestAssignmentService, INotificationService notificationService, IGenerateCode generateCode)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configuration = configuration;
            _userManager = userManager;
            _requestAssignmentService = requestAssignmentService;
            _notificationService = notificationService;
            _generateCode = generateCode;
        }

        //Assign Staff
       public async Task<AppointmentRequestResponse> AssignStaffAsync(Guid requestId, Guid accountId)
        {
            // Truy xuất yêu cầu từ requestId
            var request = await _unitOfWork.AppointmentRequestRepository.GetByIdAsync(requestId);
            if (request == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu.");
            }
        
            // Truy xuất Apartment liên quan đến AppointmentRequest và đảm bảo nó tồn tại
            var apartment = _unitOfWork.ApartmentRepository.Get(
                a => a.ApartmentID == request.ApartmentID,
                includeProperties: "ProjectApartment.Team"
            ).FirstOrDefault();
        
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ liên quan đến yêu cầu.");
            }
        
            // Đảm bảo rằng dự án căn hộ có thông tin Team
            var projectApartment = apartment.ProjectApartment;
            if (projectApartment?.Team == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy Team chịu trách nhiệm quản lý căn hộ này.");
            }
        
            // Lấy TeamID từ ProjectApartment
            var teamId = projectApartment.Team.TeamID;
        
            // Tìm TeamMember dựa trên AccountID và TeamID
            var teamMember = _unitOfWork.TeamMemberRepository.Get(
                tm => tm.TeamID == teamId && tm.AccountID == accountId
            ).FirstOrDefault();
        
            if (teamMember == null)
            {
                throw new CustomException.DataNotFoundException("Thành viên được chỉ định không thuộc Team quản lý căn hộ này.");
            }
        
            // Gắn teamMember vào yêu cầu và cập nhật trạng thái
            request.AssignedDate = CoreHelper.SystemTimeNow;
            request.UpdateDate = CoreHelper.SystemTimeNow;
            request.AssignedTeamMemberID = teamMember.TeamMemberID;
            request.SellerID = accountId;


            _unitOfWork.AppointmentRequestRepository.Update(request);
        
            // Gửi thông báo cho Customer
            var notificationRequest = new NotificationRequest
            {
                AccountID = accountId, // Gửi cho Customer
                Title = "Có một yêu cầu xem căn hộ cần bạn giải quyết!",
                Description = $"Căn hộ {apartment.ApartmentCode ?? "không xác định"} mong được tư vấn từ bạn! Vui lòng nhanh chống giải quyết yêu cầu của khách hàng!",
                NotificationTypes = NotificationType.RequestAppointment,
                ReferenceId = requestId,
            };
        
            await _notificationService.CreateNotificationAsync(notificationRequest);
            await _unitOfWork.SaveAsync();
        
            var response = _mapper.Map<AppointmentRequestResponse>(request);
            response.ApartmentCode = apartment.ApartmentCode;
            response.AssignedTeamMemberID = teamMember.TeamMemberID;

            return response;
        }




        //Create appointment request
        public async Task<AppointmentRequestResponse> CreateRequestAsync(CreateAppointmentReqRequest request)
        {
            var currentTime = CoreHelper.SystemTimeNow;

            // Kiểm tra xem PreferredDate có nằm ở tương lai không
            if (request.PreferredDate.HasValue && request.PreferredDate.Value < currentTime)
            {
                throw new CustomException.InvalidDataException("PreferredDate phải nằm trong tương lai.");
            }

            // Kiểm tra xem PreferredTime có cách ít nhất 1 tiếng từ hiện tại không
            if (request.PreferredDate.HasValue && request.PreferredTime.HasValue)
            {
                var preferredDateTime = request.PreferredDate.Value.Add(request.PreferredTime.Value);

                if (preferredDateTime < currentTime.AddHours(1))
                {
                    throw new CustomException.InvalidDataException("PreferredTime phải cách ít nhất 1 tiếng từ bây giờ.");
                }
            }

            var customer = await _userManager.FindByIdAsync(request.CustomerID.ToString());
            if (customer == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy khách hàng này.");
            }

            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ này.");
            }

            // Lấy team quản lý dự án của căn hộ
            var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);
            if (projectApartment?.TeamID == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy team quản lý dự án của căn hộ này.");
            }

            var teamMembers = _unitOfWork.TeamMemberRepository.Get(tm => tm.TeamID == projectApartment.TeamID).ToList();
            if (teamMembers == null || !teamMembers.Any())
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thành viên trong team quản lý dự án.");
            }

            var newRequest = _mapper.Map<AppointmentRequest>(request);
            var aptrID = Guid.NewGuid();
            newRequest.RequestID = aptrID;
            newRequest.AppointmentRequestCode = await _generateCode.GenerateAppointmentRequestCode(aptrID);
            newRequest.Status = RequestStatus.Pending;  // Mặc định là Pending
            newRequest.CreateDate = CoreHelper.SystemTimeNow;
            newRequest.UpdateDate = CoreHelper.SystemTimeNow;
            newRequest.RequestType = AppointmentTypes.Appointment;
            
            _unitOfWork.AppointmentRequestRepository.Insert(newRequest);
            await _unitOfWork.SaveAsync();

            // Gửi thông báo đến toàn bộ thành viên trong team
            foreach (var member in teamMembers)
            {
                var notificationRequest = new NotificationRequest
                {
                    AccountID = member.AccountID,
                    Title = "Yêu cầu xem căn hộ mới",
                    Description = $"Yêu cầu xem căn hộ {apartment.ApartmentCode ?? "không xác định"} đã được tạo.",
                    NotificationTypes = NotificationType.RequestAppointment,
                    ReferenceId = newRequest.RequestID
                };

                // Gọi hàm gửi thông báo cho từng thành viên
                await _notificationService.CreateNotificationAsync(notificationRequest);
            }

            var response = _mapper.Map<AppointmentRequestResponse>(newRequest);
            response.ApartmentCode = apartment.ApartmentCode;

            return response;
        }


        //Get All
        public async Task<IEnumerable<AppointmentRequestResponse>> GetAllRequestsAsync()
        {
            var requests = _unitOfWork.AppointmentRequestRepository.Get(
                includeProperties: "Apartment"
            );

            var response = requests.Select(ar =>
            {
                var appointmentResponse = _mapper.Map<AppointmentRequestResponse>(ar);
                appointmentResponse.ApartmentCode = ar.Apartment?.ApartmentCode; // Ensure ApartmentCode is included
                return appointmentResponse;
            });

            return response;
        }


        //Get By Id
        public async Task<AppointmentRequestResponse> GetRequestByIdAsync(Guid requestId)
        {
            var request = await _unitOfWork.AppointmentRequestRepository.GetByIdAsync(requestId);
            if (request == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu.");
            }
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            var response = _mapper.Map<AppointmentRequestResponse>(request);
            response.ApartmentCode = apartment.ApartmentCode;

            return response;
        }

        //Update status
        public async Task<AppointmentRequestResponse> UpdateRequestStatusAsync(Guid requestId, RequestStatus newStatus)
        {
            var request = await _unitOfWork.AppointmentRequestRepository.GetByIdAsync(requestId);
            if (request == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu.");

            request.Status = newStatus;
            request.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.AppointmentRequestRepository.Update(request);
            await _unitOfWork.SaveAsync();

            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            var response = _mapper.Map<AppointmentRequestResponse>(request);
            response.ApartmentCode = apartment.ApartmentCode;

            return response;
        }

        // Accept Request
        public async Task<AppointmentRequestResponse> AcceptRequestAsync(Guid requestId, Guid seller)
        {
            var request = await _unitOfWork.AppointmentRequestRepository.GetByIdAsync(requestId);
            if (request == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu.");
            }

            // Kiểm tra xem yêu cầu có đang trong trạng thái Pending hay không
            if (request.Status != RequestStatus.Pending)
            {
                throw new CustomException.InvalidDataException("Chỉ có thể chấp nhận các yêu cầu đang ở trạng thái Pending.");
            }

            request.Status = RequestStatus.Accepted;
            request.UpdateDate = CoreHelper.SystemTimeNow;
            request.SellerID = seller;

            _unitOfWork.AppointmentRequestRepository.Update(request);


            // Gửi thông báo
            var notificationRequest = new NotificationRequest
            {
                AccountID = request.CustomerID,  // Giả sử CustomerID là ID của người nhận thông báo
                Title = "Yêu cầu của bạn đã được chấp nhận",
                Description = $"Yêu cầu của bạn cho căn hộ {request.Apartment?.ApartmentCode ?? "không xác định"} đã được chấp nhận.",
                NotificationTypes = NotificationType.RequestAppointment,
                ReferenceId = requestId,
            };
            await _notificationService.CreateNotificationAsync(notificationRequest);

            await _unitOfWork.SaveAsync();

            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            var response = _mapper.Map<AppointmentRequestResponse>(request);
            response.ApartmentCode = apartment.ApartmentCode;

            return response;
        }

        // Reject Request
        public async Task<AppointmentRequestResponse> RejectRequestAsync(Guid requestId, Guid seller, string? note)
        {
            var request = await _unitOfWork.AppointmentRequestRepository.GetByIdAsync(requestId);
            if (request == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu.");
            }

            // Kiểm tra xem yêu cầu có đang trong trạng thái Pending hay không
            if (request.Status != RequestStatus.Pending)
            {
                throw new CustomException.InvalidDataException("Chỉ có thể từ chối các yêu cầu đang ở trạng thái Pending.");
            }

            request.Status = RequestStatus.Rejected;
            request.UpdateDate = CoreHelper.SystemTimeNow;
            request.Note = note;
            request.SellerID = seller;

            _unitOfWork.AppointmentRequestRepository.Update(request);

            var notificationRequest = new NotificationRequest
            {
                AccountID = request.CustomerID,  // Giả sử CustomerID là ID của người nhận thông báo
                Title = "Yêu cầu của bạn đã bị từ chối",
                Description = $"Yêu cầu của bạn cho căn hộ {request.Apartment?.ApartmentCode ?? "không xác định"} đã bị từ chối.",
                NotificationTypes = NotificationType.RequestAppointment,
                ReferenceId = requestId,
            };
            await _notificationService.CreateNotificationAsync(notificationRequest);

            await _unitOfWork.SaveAsync();

            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            var response = _mapper.Map<AppointmentRequestResponse>(request);
            response.ApartmentCode = apartment.ApartmentCode;

            return response;
        }


        public async Task<(IEnumerable<AppointmentRequestResponse> Results, int TotalItems, int TotalPages)> SearchAppointmentRequestsAsync(
            Guid? customerId = null,
            Guid? apartmentId = null,
            RequestStatus? status = null,
            AppointmentTypes? requestType = null,
            Guid? assignedTeamMemberID = null,
            DateTimeOffset? preferredDate = null,
            DateTimeOffset? startDate = null,
            DateTimeOffset? endDate = null,
            Guid? teamId = null,
            string? keyword = null,
            int pageIndex = 1,
            int pageSize = 10
)
        {
            // Xây dựng biểu thức lọc
            Expression<Func<AppointmentRequest, bool>> filter = ar =>
                (!customerId.HasValue || ar.CustomerID == customerId) &&
                (!apartmentId.HasValue || ar.ApartmentID == apartmentId) &&
                (!status.HasValue || ar.Status == status) &&
                (!requestType.HasValue || ar.RequestType == requestType) &&
                (!assignedTeamMemberID.HasValue || ar.AssignedTeamMemberID == assignedTeamMemberID) &&
                (!teamId.HasValue || ar.Apartment.AssignedTeamMember.TeamID == teamId) &&
                (!preferredDate.HasValue || ar.PreferredDate.Value.Date == preferredDate.Value.Date) &&
                (string.IsNullOrEmpty(keyword) || ar.AppointmentRequestCode.Contains(keyword) || ar.Apartment.ApartmentCode.Contains(keyword)) &&
                (!startDate.HasValue || ar.CreateDate >= startDate) &&
                (!endDate.HasValue || ar.CreateDate <= endDate);

            // Đếm tổng số bản ghi phù hợp với bộ lọc (Total Items)
            int totalItems = await _unitOfWork.AppointmentRequestRepository.CountAsync(filter);

            // Truy vấn dữ liệu từ repository với phân trang và include Apartment to get ApartmentCode
            var appointmentRequests = _unitOfWork.AppointmentRequestRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(ar => ar.CreateDate),
                pageIndex: pageIndex,
                pageSize: pageSize,
                includeProperties: "Apartment"
            );

            // Tính tổng số trang (Total Pages)
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Ánh xạ kết quả sang response và include ApartmentCode
            var results = appointmentRequests.Select(ar =>
            {
                var appointmentResponse = _mapper.Map<AppointmentRequestResponse>(ar);
                appointmentResponse.ApartmentCode = ar.Apartment?.ApartmentCode; // Ensure ApartmentCode is included
                return appointmentResponse;
            });

            return (results, totalItems, totalPages);
        }

    }
}
