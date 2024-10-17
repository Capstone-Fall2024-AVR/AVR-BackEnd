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

            if(propertyRequest.RequestStatus != Domain.Enums.RequestStatus.Accepted)
            {
                throw new CustomException.InvalidDataException("Yêu cầu ký gửi phải ở trạng thái 'Accepted' để được xác minh.");
            }

            var propertyVerification = _mapper.Map<PropertyVerification>(request);
            propertyVerification.CreateDate = DateTimeOffset.Now;
            propertyVerification.UpdateDate = DateTimeOffset.Now;
            propertyVerification.VerificationStatus = Domain.Enums.VerificationStatus.Pending;

            _unitOfWork.PropertyVerificationRepository.Insert(propertyVerification);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreatePropertyVerificationResponse>(propertyVerification);
            return response; 

        }

        //Get by id
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


        //Get all   
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


        // Accept a property verification
        public async Task<CreatePropertyVerificationResponse> AcceptPropertyVerification(Guid verificationId)
        {
            // Check if the verification exists
            var propertyVerification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (propertyVerification == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy xác nhận ký gửi.");
            }

            /*// Ensure it's in Pending status
            if (propertyVerification.VerificationStatus != Domain.Enums.VerificationStatus.Pending)
            {
                throw new CustomException.InvalidDataException("Xác nhận ký gửi phải ở trạng thái 'Pending' để được chấp nhận.");
            }*/

            // Update the verification status to Accepted
            propertyVerification.VerificationStatus = Domain.Enums.VerificationStatus.Accepted;
            propertyVerification.UpdateDate = DateTimeOffset.Now;

            _unitOfWork.PropertyVerificationRepository.Update(propertyVerification);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreatePropertyVerificationResponse>(propertyVerification);
            return response;
        }

        // Reject a property verification
        public async Task<CreatePropertyVerificationResponse> RejectPropertyVerification(Guid verificationId, string rejectionReason)
        {
            // Check if the verification exists
            var propertyVerification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (propertyVerification == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy xác nhận ký gửi.");
            }

            /*// Ensure it's in Pending status
            if (propertyVerification.VerificationStatus != Domain.Enums.VerificationStatus.Pending)
            {
                throw new CustomException.InvalidDataException("Xác nhận ký gửi phải ở trạng thái 'Pending' để bị từ chối.");
            }*/

            // Update the verification status to Rejected and add comments
            propertyVerification.VerificationStatus = Domain.Enums.VerificationStatus.Rejected;
            propertyVerification.Comments = rejectionReason;
            propertyVerification.UpdateDate = DateTimeOffset.Now;

            _unitOfWork.PropertyVerificationRepository.Update(propertyVerification);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreatePropertyVerificationResponse>(propertyVerification);
            return response;
        }


    }
}
