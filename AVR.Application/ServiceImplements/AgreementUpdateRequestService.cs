using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ProjectProviders;
using AVR.Application.ViewModels.Response.ProjectProviders;
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
    public class AgreementUpdateRequestService : IAgreementUpdateRequestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<Account> _userManager;

        public AgreementUpdateRequestService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<Account> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }

        //Accepted
        public async Task<AgreementUpdateRequestResponse> AcceptRequestAsync(Guid id)
        {
            var request = await _unitOfWork.AgreementUpdateRequestRepository.GetByIdAsync(id);
            if (request == null)
            {
                throw new CustomException.DataNotFoundException("Update request not found.");
            }

            request.AgreementUpdateStatus = AgreementUpdateStatus.Accepted;
            request.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.AgreementUpdateRequestRepository.Update(request);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<AgreementUpdateRequestResponse>(request);
        }


        //Create
        public async Task<AgreementUpdateRequestResponse> CreateAsync(CreateAgreementUpdateRequest request)
        {
            // Kiểm tra tài khoản
            var account = await _unitOfWork.AccountRepository.GetByIdAsync(request.AccountID);
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Account not found.");
            }

            // Kiểm tra vai trò Provider
            var isProvider = await _userManager.IsInRoleAsync(account, "Project Provider");
            if (!isProvider)
            {
                throw new CustomException.InvalidDataException("Only providers can create an agreement update request.");
            }

            // Tạo mới yêu cầu
            var agreementUpdateRequest = _mapper.Map<AgreementUpdateRequest>(request);
            agreementUpdateRequest.RequestDate = CoreHelper.SystemTimeNow;
            agreementUpdateRequest.UpdateDate = CoreHelper.SystemTimeNow;
            agreementUpdateRequest.AgreementUpdateStatus = AgreementUpdateStatus.Pending;

            // Lưu yêu cầu vào CSDL
            _unitOfWork.AgreementUpdateRequestRepository.Insert(agreementUpdateRequest);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<AgreementUpdateRequestResponse>(agreementUpdateRequest);
        }


        //GetAll
        public async Task<IEnumerable<AgreementUpdateRequestResponse>> GetAllAsync()
        {
            var requests = await _unitOfWork.AgreementUpdateRequestRepository.GetAllAsync();
            if (!requests.Any())
            {
                throw new CustomException.DataNotFoundException("No update requests found.");
            }

            return _mapper.Map<IEnumerable<AgreementUpdateRequestResponse>>(requests);
        }

        //GetById
        public async Task<AgreementUpdateRequestResponse> GetByIdAsync(Guid requestId)
        {
            var request = await _unitOfWork.AgreementUpdateRequestRepository.GetByIdAsync(requestId);
            if (request == null)
            {
                throw new CustomException.DataNotFoundException("Update request not found.");
            }

            return _mapper.Map<AgreementUpdateRequestResponse>(request);
        }

        //Rejected
        public async Task<AgreementUpdateRequestResponse> RejectRequestAsync(Guid requestId)
        {
            var request = await _unitOfWork.AgreementUpdateRequestRepository.GetByIdAsync(requestId);
            if (request == null)
            {
                throw new CustomException.DataNotFoundException("Update request not found.");
            }

            request.AgreementUpdateStatus = AgreementUpdateStatus.Rejected;
            request.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.AgreementUpdateRequestRepository.Update(request);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<AgreementUpdateRequestResponse>(request);
        }

        public async Task<(IEnumerable<AgreementUpdateRequestResponse> Results, int TotalItems, int TotalPages)> SearchAsync(
             AgreementUpdateType? updateType,
             AgreementUpdateStatus? updateStatus,
             Guid? accountId,
             string? title,
             int pageIndex = 1,
             int pageSize = 10)
        {
            Expression<Func<AgreementUpdateRequest, bool>> filter = r =>
                (!updateStatus.HasValue || r.AgreementUpdateStatus == updateStatus) &&
                (!accountId.HasValue || r.AccountID == accountId) &&
                (string.IsNullOrEmpty(title) || r.RequestTitle.Contains(title));

            // Đếm tổng số bản ghi (Total Items) phù hợp với bộ lọc
            int totalItems = await _unitOfWork.AgreementUpdateRequestRepository.CountAsync(filter);

            // Lấy dữ liệu phân trang từ repository
            var requests = _unitOfWork.AgreementUpdateRequestRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(r => r.RequestDate),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Tính tổng số trang (Total Pages)
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Map kết quả sang DTO
            var results = _mapper.Map<IEnumerable<AgreementUpdateRequestResponse>>(requests);

            return (results, totalItems, totalPages);
        }

    }
}
