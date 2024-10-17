using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.PropertyVerifications;
using AVR.Application.ViewModels.Response.PropertyVerifications;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class PropertyVerificationService : IPropertyVerificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PropertyVerificationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<CreatePropertyVerificationResponse> CreatePropertyVerification(CreatePropertyVerificationRequest request)
        {
            // Kiểm tra xem yêu cầu ký gửi có tồn tại không
            var propertyRequest = await _unitOfWork.PropertyRequestRepository.GetByIdAsync(request.PropertyRequestID);
            if (propertyRequest == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu ký gửi.");
            }

            // Kiểm tra xem nhân viên xác nhận có tồn tại không
            var staff = await _unitOfWork.AccountRepository.GetByIdAsync(request.VerifiedBy);
            if (staff == null)
            {
                throw new CustomException.DataNotFoundException("Nhân viên xác nhận không tồn tại.");
            }

            var propertyVerification = _mapper.Map<PropertyVerification>(request);
            propertyVerification.CreateDate = DateTimeOffset.Now;
            propertyVerification.VerificationStatus = Domain.Enums.VerificationStatus.Pending;

            _unitOfWork.PropertyVerificationRepository.Insert(propertyVerification);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreatePropertyVerificationResponse>(propertyVerification);
            return response;

        }

        public async Task<CreatePropertyVerificationResponse> GetPropertyVerificationById(Guid verificationId)
        {
            var verification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (verification == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy xác nhận ký gửi này.");
            }

            var response = _mapper.Map<CreatePropertyVerificationResponse>(verification);
            return response;
        }

        public async Task<IEnumerable<CreatePropertyVerificationResponse>> GetPropertyVerifications()
        {
            var verifications = await _unitOfWork.PropertyVerificationRepository.GetAllAsync();
            if (verifications == null)
            {
                throw new CustomException.DataNotFoundException("Không có xác nhận ký gửi nào.");
            }

            var response = _mapper.Map<IEnumerable<CreatePropertyVerificationResponse>>(verifications);
            return response;
        }
    }
}
