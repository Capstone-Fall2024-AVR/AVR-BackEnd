using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Request.PropertyRequests;
using AVR.Application.ViewModels.Response.PropertyRequests;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class PropertyRequestService : IPropertyRequestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<Account> _userManager;
        private readonly IRequestAssignmentService _requestAssignmentService;
        private readonly INotificationService _notificationService;

        public PropertyRequestService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<Account> userManager, IRequestAssignmentService requestAssignmentService, INotificationService notificationService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
            _requestAssignmentService = requestAssignmentService;
            _notificationService = notificationService;
        }

        //Xác nhận property request
        public async Task<AcceptPropertyRequestResponse> AssignPropertyRequest(Guid requestId, Guid AssignedTeamMemberID)
        {
            // Kiểm tra xem yêu cầu ký gửi có tồn tại không
            var propertyRequest = await _unitOfWork.PropertyRequestRepository.GetByIdAsync(requestId);
            if (propertyRequest == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu ký gửi.");
            }

            // Kiểm tra nếu yêu cầu đã được chấp nhận
            if (propertyRequest.RequestStatus == RequestStatus.Accepted)
            {
                throw new CustomException.InvalidDataException("Yêu cầu ký gửi đã được chấp nhận trước đó.");
            }

            


            //Gắn để kiểm soát staff
            await _requestAssignmentService.AssignRequestAsync(requestId, AssignedTeamMemberID, RequestType.Appointment);


            // Gán ID của nhân viên xử lý và chuyển trạng thái thành 'InProgessing'
            //propertyRequest.StaffID = staffId;
            propertyRequest.RequestStatus = RequestStatus.InProgessing;
            propertyRequest.UpdateDate = CoreHelper.SystemTimeNow;

            // Cập nhật thông tin vào cơ sở dữ liệu
            _unitOfWork.PropertyRequestRepository.Update(propertyRequest);
            await _unitOfWork.SaveAsync();


            // Gửi thông báo cho nhân viên
            await _notificationService.CreateNotificationAsync(new NotificationRequest
            {
                //AccountID = staffId,
                Title = "Yêu cầu ký gửi đã được gán",
                Description = $"Bạn đã được gán vào yêu cầu ký gửi: {propertyRequest.PropertyName}.",
                NotificationTypes = NotificationType.PropertyRequest,
            });

            // Trả về kết quả sau khi cập nhật
            var response = _mapper.Map<AcceptPropertyRequestResponse>(propertyRequest);
            return response;
        }

        public async Task<CreatePropertyRequestResponse> CreatePropertyRequest(CreatePropertyRequestRequest request)
        {
            var account = await _unitOfWork.AccountRepository.GetByIdAsync(request.OwnerID);
            if(account == null)
            {
                throw new CustomException.DataNotFoundException("Account không tồn tại trong hệ thống");
            }

            var proPertyrequest = _mapper.Map<PropertyRequest>(request);
            proPertyrequest.RequestDate = CoreHelper.SystemTimeNow;
            proPertyrequest.UpdateDate = CoreHelper.SystemTimeNow;
            proPertyrequest.RequestStatus = Domain.Enums.RequestStatus.Pending;

            _unitOfWork.PropertyRequestRepository.Insert(proPertyrequest);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreatePropertyRequestResponse>(proPertyrequest);
            return response;
        }


        //GetById
        public async Task<CreatePropertyRequestResponse> GetPropertyRequestById(Guid requestId)
        {
            var propertyRequest = await _unitOfWork.PropertyRequestRepository.GetByIdAsync(requestId);
            if(propertyRequest == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy yêu cầu kí gửi này !");
            }
            var response = _mapper.Map<CreatePropertyRequestResponse>(propertyRequest);

            return response;
        }


        //GetAll
        public async Task<IEnumerable<CreatePropertyRequestResponse>> GetPropertyRequests()
        {
            var propertyRequest = await _unitOfWork.PropertyRequestRepository.GetAllAsync();
            if (propertyRequest == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy yêu cầu kí gửi nào !.");
            }
            var response = _mapper.Map<IEnumerable<CreatePropertyRequestResponse>>(propertyRequest);

            return response;
        }

        
        //Reject Property
        public async Task<CreatePropertyRequestResponse> RejectPropertyRequest(Guid requestId)
        {
            var propertyRequest = await _unitOfWork.PropertyRequestRepository.GetByIdAsync(requestId);
            if (propertyRequest == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu ký gửi.");
            }

            if (propertyRequest.RequestStatus != RequestStatus.InProgessing)
            {
                throw new CustomException.InvalidDataException("Yêu cầu này không trong trạng thái InProgessing.");
            }

            var assignment = _unitOfWork.RequestAssignmentRepository.Get(ra => ra.RequestId == requestId && ra.Status == RequestAssignmentStatus.InProgress).FirstOrDefault();

            if (assignment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy assignment tương ứng cho yêu cầu này.");
            }

            // Cập nhật trạng thái assignment
            await _requestAssignmentService.UpdateAssignRequestAsync(assignment.AssignmentId, RequestAssignmentStatus.Rejected);
            // Update status to Rejected
            propertyRequest.RequestStatus = RequestStatus.Rejected;
            propertyRequest.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.PropertyRequestRepository.Update(propertyRequest);
            await _unitOfWork.SaveAsync();

            // Gửi thông báo cho chủ tài khoản
            await _notificationService.CreateNotificationAsync(new NotificationRequest
            {
                AccountID = propertyRequest.OwnerID,
                Title = "Yêu cầu ký gửi đã bị từ chối",
                Description = $"Yêu cầu ký gửi của bạn với tên: {propertyRequest.PropertyName} đã bị từ chối.",
                NotificationTypes = NotificationType.PropertyRequest,
            });

            // Map response
            var response = _mapper.Map<CreatePropertyRequestResponse>(propertyRequest);
            return response;
        }

        //Accept Property
        public async Task<CreatePropertyRequestResponse> AcceptPropertyRequest(Guid requestId)
        {
            var propertyRequest = await _unitOfWork.PropertyRequestRepository.GetByIdAsync(requestId);
            if (propertyRequest == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu ký gửi.");
            }

            if (propertyRequest.RequestStatus != RequestStatus.InProgessing)
            {
                throw new CustomException.InvalidDataException("Yêu cầu này không trong trạng thái InProgessing.");
            }

            var assignment = _unitOfWork.RequestAssignmentRepository.Get(ra => ra.RequestId == requestId && ra.Status == RequestAssignmentStatus.InProgress).FirstOrDefault();

            if (assignment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy assignment tương ứng cho yêu cầu này.");
            }

            // Cập nhật trạng thái assignment
            await _requestAssignmentService.UpdateAssignRequestAsync(assignment.AssignmentId, RequestAssignmentStatus.Accepted);

            // Update status to Rejected
            propertyRequest.RequestStatus = RequestStatus.Accepted;
            propertyRequest.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.PropertyRequestRepository.Update(propertyRequest);
            await _unitOfWork.SaveAsync();

            // Gửi thông báo cho chủ tài khoản
            await _notificationService.CreateNotificationAsync(new NotificationRequest
            {
                AccountID = propertyRequest.OwnerID,
                Title = "Yêu cầu ký gửi đã bị từ chối",
                Description = $"Yêu cầu ký gửi của bạn với tên: {propertyRequest.PropertyName} đã bị từ chối.",
                NotificationTypes = NotificationType.PropertyRequest,
            });

            // Map response
            var response = _mapper.Map<CreatePropertyRequestResponse>(propertyRequest);
            return response;
        }

        public async Task<(IEnumerable<CreatePropertyRequestResponse> Results, int TotalItems, int TotalPages)> SearchPropertyRequests(
                 Guid? ownerId,
                 Guid? assignedTeamMemberId,
                 string? propertyName,
                 decimal? minExpectedPrice,
                 decimal? maxExpectedPrice,
                 string? address,
                 List<RequestStatus>? requestStatuses,
                 string? userName,
                 string? email,
                 string? phoneNumber,
                 int pageIndex = 1,
                 int pageSize = 5)
        {
            // Tạo bộ lọc dựa trên các điều kiện tìm kiếm
            Expression<Func<PropertyRequest, bool>> filter = pr =>
                (!ownerId.HasValue || pr.OwnerID == ownerId.Value) &&
                (!assignedTeamMemberId.HasValue || pr.AssignedTeamMemberID == assignedTeamMemberId.Value) &&
                (string.IsNullOrEmpty(propertyName) || pr.PropertyName.Contains(propertyName)) &&
                (!minExpectedPrice.HasValue || pr.ExpectedPrice >= minExpectedPrice.Value) &&
                (!maxExpectedPrice.HasValue || pr.ExpectedPrice <= maxExpectedPrice.Value) &&
                (string.IsNullOrEmpty(address) || pr.Address.Contains(address)) &&
                (requestStatuses == null || requestStatuses.Count == 0 || requestStatuses.Contains(pr.RequestStatus)) &&
                (string.IsNullOrEmpty(userName) || pr.UserName.Contains(userName)) &&
                (string.IsNullOrEmpty(email) || pr.Email.Contains(email)) &&
                (string.IsNullOrEmpty(phoneNumber) || pr.PhoneNumber.Contains(phoneNumber));

            // Đếm tổng số bản ghi phù hợp với bộ lọc (Total Items)
            int totalItems = await _unitOfWork.PropertyRequestRepository.CountAsync(filter);

            // Lấy dữ liệu từ repository với bộ lọc và phân trang
            var propertyRequests = _unitOfWork.PropertyRequestRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(pr => pr.RequestDate),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Tính tổng số trang (Total Pages)
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Map kết quả sang DTO
            var results = _mapper.Map<IEnumerable<CreatePropertyRequestResponse>>(propertyRequests);

            return (results, totalItems, totalPages);
        }


    }

}
