using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.PropertyVerifications;
using AVR.Application.ViewModels.Response.PropertyVerifications;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
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
        private readonly IFirebaseConfig _firebaseConfig;

        public PropertyVerificationService(IUnitOfWork unitOfWork, IMapper mapper, IFirebaseConfig firebaseConfig)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _firebaseConfig = firebaseConfig;
        }
        public async Task<CreatePropertyVerificationResponse> CreatePropertyVerification(CreatePropertyVerificationRequest request)
        {

            // Kiểm tra xem căn hộ có tồn tại hay không
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (apartment == null)
            {
                throw new ArgumentException("Căn hộ không tồn tại.");
            }

            // Kiểm tra xem căn hộ đã có xác minh trước đó hay chưa
            var existingVerification =  _unitOfWork.PropertyVerificationRepository.Get(pv => pv.ApartmentID == request.ApartmentID);

            if (existingVerification != null)
            {
                throw new InvalidOperationException("Căn hộ này đã có xác minh trước đó.");
            }

            
            var propertyVerification = _mapper.Map<PropertyVerification>(request);
            
            propertyVerification.CreateDate = CoreHelper.SystemTimeNow;
            propertyVerification.UpdateDate = CoreHelper.SystemTimeNow;
            propertyVerification.VerificationStatus = Domain.Enums.VerificationStatus.Pending;

            //Updaload file or Image document
            string LegalDocumentsPath = await _firebaseConfig.UploadImage(request.LegalDocumentsURL);
            propertyVerification.LegalDocumentsURL = LegalDocumentsPath;

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
            // Kiểm tra xem xác minh có tồn tại không
            var propertyVerification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (propertyVerification == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy xác nhận ký gửi.");
            }

            

            // Tìm căn hộ liên quan
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(propertyVerification.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ.");
            }

            // Cập nhật trạng thái xác minh thành Accepted
            propertyVerification.VerificationStatus = Domain.Enums.VerificationStatus.Accepted;
            propertyVerification.UpdateDate = CoreHelper.SystemTimeNow;

            // Cập nhật trạng thái căn hộ thành Available
            apartment.ApartmentStatus = Domain.Enums.ApartmentStatus.Available;
            apartment.UpdatedDate = CoreHelper.SystemTimeNow;

            // Lưu thay đổi vào cơ sở dữ liệu
            _unitOfWork.PropertyVerificationRepository.Update(propertyVerification);
            _unitOfWork.ApartmentRepository.Update(apartment);
            await _unitOfWork.SaveAsync();

            // Tạo phản hồi
            var response = _mapper.Map<CreatePropertyVerificationResponse>(propertyVerification);
            return response;
        }


        // Reject a property verification
        public async Task<CreatePropertyVerificationResponse> RejectPropertyVerification(Guid verificationId, string rejectionReason)
        {
            // Kiểm tra xem xác minh có tồn tại không
            var propertyVerification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (propertyVerification == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy xác nhận ký gửi.");
            }

            // Tìm căn hộ liên quan
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(propertyVerification.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ.");
            }

            // Cập nhật trạng thái xác minh thành Rejected và thêm lý do
            propertyVerification.VerificationStatus = Domain.Enums.VerificationStatus.Rejected;
            propertyVerification.Comments = rejectionReason;
            propertyVerification.UpdateDate = CoreHelper.SystemTimeNow;

            // Cập nhật trạng thái căn hộ thành Unavailable
            apartment.ApartmentStatus = Domain.Enums.ApartmentStatus.Unavailable;
            apartment.UpdatedDate = CoreHelper.SystemTimeNow;

            // Lưu thay đổi vào cơ sở dữ liệu
            _unitOfWork.PropertyVerificationRepository.Update(propertyVerification);
            _unitOfWork.ApartmentRepository.Update(apartment);
            await _unitOfWork.SaveAsync();

            // Tạo phản hồi
            var response = _mapper.Map<CreatePropertyVerificationResponse>(propertyVerification);
            return response;
        }


    }
}
