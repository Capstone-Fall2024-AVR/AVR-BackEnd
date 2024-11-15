using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.PropertyVerifications;
using AVR.Application.ViewModels.Response.PropertyVerifications;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        // Create PropertyVerification and ApartmentOwnerApartment if necessary
        public async Task<PropertyVerificationResponse> CreateAsync(PropertyVerificationRequest request)
        {

            var apartmentOwner = await _unitOfWork.ApartmentOwnerRepository.GetByIdAsync(request.ApartmentOwnerID);
            if (apartmentOwner == null)
            {
                throw new Exception("Không tìm thấy ApartmentOwner với ID đã cung cấp.");
            }

            // Kiểm tra AssignedTeamMemberID
            var teamMember = await _unitOfWork.TeamMemberRepository.GetByIdAsync(request.AssignedTeamMemberID);
            if (teamMember == null)
            {
                throw new CustomException.InvalidDataException("Không tìm thấy TeamMember với ID đã cung cấp.");
            }

            // Kiểm tra TeamType của TeamMember
            var team = await _unitOfWork.TeamRepository.GetByIdAsync(teamMember.TeamID);
            if (team == null || team.TeamType != TeamType.IndividualProjectManagement)
            {
                throw new CustomException.InvalidDataException("Nhân viên được chỉ định không thuộc đội có TeamType là IndividualProjectManagement.");
            }

            // Kiểm tra ApartmentOwnerApartmentID đã tồn tại hay chưa
            var apartmentOwnerApartment = await _unitOfWork.ApartmentOwnerApartmentRepository.GetByIdAsync(request.ApartmentOwnerApartmentID);

            if (apartmentOwnerApartment == null)
            {
                // Tạo mới ApartmentOwnerApartment nếu không tìm thấy
                apartmentOwnerApartment = new ApartmentOwnerApartment
                {
                    ApartmentOwnerApartmentID = Guid.NewGuid(),
                    ApartmentOwnerID = request.ApartmentOwnerID, // Thêm ID chủ sở hữu
                    OwnershipStatus = OwnershipStatus.Pending, // Trạng thái ban đầu là Pending
                    AssignedTeamMemberID = request.AssignedTeamMemberID // Gắn nhân viên phụ trách
                };

                _unitOfWork.ApartmentOwnerApartmentRepository.Insert(apartmentOwnerApartment);
                await _unitOfWork.SaveAsync();
            }

            // Tải lên tài liệu pháp lý nếu có
            string legalDocumentsURL = null;
            if (request.LegalDocumentFile != null)
            {
                legalDocumentsURL = await _firebaseConfig.UploadImage(request.LegalDocumentFile);
            }

            // Tạo PropertyVerification mới
            var propertyVerification = _mapper.Map<PropertyVerification>(request);
            propertyVerification.ApartmentOwnerApartmentID = apartmentOwnerApartment.ApartmentOwnerApartmentID; // Liên kết với ApartmentOwnerApartment
            propertyVerification.LegalDocumentsURL = legalDocumentsURL;
            propertyVerification.VerificationStatus = VerificationStatus.Pending; // Trạng thái mặc định là Pending

            // Lưu vào cơ sở dữ liệu
            _unitOfWork.PropertyVerificationRepository.Insert(propertyVerification);
            await _unitOfWork.SaveAsync();

            // Trả về PropertyVerificationResponse
            return _mapper.Map<PropertyVerificationResponse>(propertyVerification);
        }


        // Get all PropertyVerifications
        public async Task<IEnumerable<PropertyVerificationResponse>> GetAllAsync()
        {
            var verifications = await _unitOfWork.PropertyVerificationRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<PropertyVerificationResponse>>(verifications);
        }

        // Get a PropertyVerification by ID
        public async Task<PropertyVerificationResponse> GetByIdAsync(Guid verificationId)
        {
            var verification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (verification == null) throw new Exception("Không tìm thấy phiên xác minh.");
            return _mapper.Map<PropertyVerificationResponse>(verification);
        }

        // Update a PropertyVerification
        public async Task<PropertyVerificationResponse> UpdateAsync(Guid verificationId, UpdatePropertyVerificationRequest request)
        {
            var verification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (verification == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy phiên xác minh.");

            // Cập nhật file tài liệu pháp lý nếu có
            if (request.LegalDocumentFile != null)
            {
                // Tải file mới lên Firebase và lấy URL
                var legalDocumentsURL = await _firebaseConfig.UploadImage(request.LegalDocumentFile);
                verification.LegalDocumentsURL = legalDocumentsURL;
            }

            // Cập nhật các trường khác từ request
            _mapper.Map(request, verification);
            verification.UpdateDate = DateTimeOffset.UtcNow;

            // Lưu vào cơ sở dữ liệu
            _unitOfWork.PropertyVerificationRepository.Update(verification);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<PropertyVerificationResponse>(verification);
        }


        // Delete a PropertyVerification
        public async Task<bool> DeleteAsync(Guid verificationId)
        {
            var verification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (verification == null) throw new Exception("Không tìm thấy phiên xác minh.");

            _unitOfWork.PropertyVerificationRepository.Delete(verification);
            await _unitOfWork.SaveAsync();
            return true;
        }

        // Accept PropertyVerification
        public async Task<PropertyVerificationResponse> AcceptAsync(Guid verificationId)
        {
            var verification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (verification == null) throw new Exception("Không tìm thấy phiên xác minh.");
            verification.VerificationStatus = VerificationStatus.Accepted;

            _unitOfWork.PropertyVerificationRepository.Update(verification);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<PropertyVerificationResponse>(verification);
        }

        // Reject PropertyVerification
        public async Task<PropertyVerificationResponse> RejectAsync(Guid verificationId)
        {
            var verification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (verification == null) throw new Exception("Không tìm thấy phiên xác minh.");
            verification.VerificationStatus = VerificationStatus.Rejected;

            _unitOfWork.PropertyVerificationRepository.Update(verification);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<PropertyVerificationResponse>(verification);
        }

        // Search PropertyVerifications
        public async Task<(IEnumerable<PropertyVerificationResponse> Results, int TotalItems, int TotalPages)> SearchAsync(
            string? name = null,
            VerificationStatus? status = null,
            DateTimeOffset? startDate = null,
            DateTimeOffset? endDate = null,
            int pageIndex = 1,
            int pageSize = 10)
        {
            Expression<Func<PropertyVerification, bool>> filter = pv =>
                (string.IsNullOrEmpty(name) || pv.VerificationName.Contains(name)) &&
                (!status.HasValue || pv.VerificationStatus == status) &&
                (!startDate.HasValue || pv.CreateDate >= startDate) &&
                (!endDate.HasValue || pv.CreateDate <= endDate);

            int totalItems = await _unitOfWork.PropertyVerificationRepository.CountAsync(filter);
            var verifications = _unitOfWork.PropertyVerificationRepository.Get(
                filter: filter,
                orderBy: q => q.OrderBy(pv => pv.CreateDate),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            var results = _mapper.Map<IEnumerable<PropertyVerificationResponse>>(verifications);

            return (results, totalItems, totalPages);
        }
    }

}
