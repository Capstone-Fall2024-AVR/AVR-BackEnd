using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.AppointmentRequests;
using AVR.Application.ViewModels.Response.AppointmentRequests;
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

        public AppointmentRequestService(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration, UserManager<Account> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configuration = configuration;
            _userManager = userManager;
        }

        //Assign Staff
        public async Task<AppointmentRequestResponse> AssignStaffAsync(Guid requestId, Guid staffId)
        {

            // Kiểm tra xem nhân viên có tồn tại không
            var staff = await _userManager.FindByIdAsync(staffId.ToString());
            if (staff == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy nhân viên này.");
            }

            // Kiểm tra xem tài khoản có vai trò 'Staff' hay không
            var isStaff = await _userManager.IsInRoleAsync(staff, "Staff");
            if (!isStaff)
            {
                throw new CustomException.InvalidDataException("Tài khoản này không có vai trò nhân viên (Staff).");
            }


            var request = await _unitOfWork.AppointmentRequestRepository.GetByIdAsync(requestId);
            if (request == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu.");
            }
                
            request.StaffID = staffId;
            request.Status = RequestStatus.InProgessing;  // Cập nhật trạng thái thành InProgressing
            request.AssignedDate = CoreHelper.SystemTimeNow;
            request.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.AppointmentRequestRepository.Update(request);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<AppointmentRequestResponse>(request);
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

            var newRequest = _mapper.Map<AppointmentRequest>(request);
            newRequest.Status = RequestStatus.Pending;  // Mặc định là Pending
            newRequest.CreateDate = CoreHelper.SystemTimeNow;
            newRequest.UpdateDate = CoreHelper.SystemTimeNow;
            newRequest.RequestType = AppointmentTypes.Viewing;

            _unitOfWork.AppointmentRequestRepository.Insert(newRequest);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<AppointmentRequestResponse>(newRequest);
        }


        //Get All
        public async Task<IEnumerable<AppointmentRequestResponse>> GetAllRequestsAsync()
        {
            var requests = await _unitOfWork.AppointmentRequestRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<AppointmentRequestResponse>>(requests);
        }


        //Get By Id
        public async Task<AppointmentRequestResponse> GetRequestByIdAsync(Guid requestId)
        {
            var request = await _unitOfWork.AppointmentRequestRepository.GetByIdAsync(requestId);
            if (request == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu.");
            }
                

            return _mapper.Map<AppointmentRequestResponse>(request);
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

            return _mapper.Map<AppointmentRequestResponse>(request);
        }
    }
}
