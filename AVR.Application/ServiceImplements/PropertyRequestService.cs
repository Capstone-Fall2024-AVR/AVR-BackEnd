using AutoMapper;
using AVR.Application.Services;
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
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class PropertyRequestService : IPropertyRequestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<Account> _userManager;

        public PropertyRequestService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<Account> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }

        //Xác nhận property request
        public async Task<AcceptPropertyRequestResponse> AcceptPropertyRequest(Guid requestId, Guid staffId)
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

            // Kiểm tra xem nhân viên có tồn tại không
            var staff = await _userManager.FindByIdAsync(staffId.ToString());
            if (staff == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy nhân viên.");
            }

            // Kiểm tra xem tài khoản có vai trò 'Staff' hay không
            var isStaff = await _userManager.IsInRoleAsync(staff, "Staff");
            if (!isStaff)
            {
                throw new CustomException.InvalidDataException("Tài khoản này không có vai trò nhân viên (Staff).");
            }

            // Gán ID của nhân viên xử lý và chuyển trạng thái thành 'Accepted'
            propertyRequest.StaffID = staffId;
            propertyRequest.RequestStatus = RequestStatus.InProgessing;
            propertyRequest.UpdateDate = CoreHelper.SystemTimeNow;

            // Cập nhật thông tin vào cơ sở dữ liệu
            _unitOfWork.PropertyRequestRepository.Update(propertyRequest);
            await _unitOfWork.SaveAsync();

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
            // Update status to Rejected
            propertyRequest.RequestStatus = RequestStatus.Rejected;
            propertyRequest.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.PropertyRequestRepository.Update(propertyRequest);
            await _unitOfWork.SaveAsync();

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

            // Update status to Rejected
            propertyRequest.RequestStatus = RequestStatus.Accepted;
            propertyRequest.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.PropertyRequestRepository.Update(propertyRequest);
            await _unitOfWork.SaveAsync();

            // Map response
            var response = _mapper.Map<CreatePropertyRequestResponse>(propertyRequest);
            return response;
        }
    }
    
}
