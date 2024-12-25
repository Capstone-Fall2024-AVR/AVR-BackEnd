using AutoMapper;
using AVR.Application.Services;
using AVR.Application.Utils.GenerateCode;
using AVR.Application.ViewModels.Request.PropertyVerifications;
using AVR.Application.ViewModels.Response.PropertyVerifications;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using iTextSharp.text.pdf.security;
using Newtonsoft.Json;
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
        private readonly IGenerateCode _generateCode;
        private readonly IPropertyScheduler _propertyScheduler;

        public PropertyVerificationService(IUnitOfWork unitOfWork, IMapper mapper, IFirebaseConfig firebaseConfig, IGenerateCode generateCode, IPropertyScheduler propertyScheduler)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _firebaseConfig = firebaseConfig;
            _generateCode = generateCode;
            _propertyScheduler = propertyScheduler;
        }



        // Create PropertyVerification and ApartmentOwnerApartment if necessary
        public async Task<PropertyVerificationResponse> CreateAsync(PropertyVerificationRequest request)
        {
            var apartmentOwner = await _unitOfWork.ApartmentOwnerRepository.GetByIdAsync(request.ApartmentOwnerID);
            if (apartmentOwner == null)
                throw new Exception("Không tìm thấy ApartmentOwner với ID đã cung cấp.");

            var account = await _unitOfWork.AccountRepository.GetByIdAsync(request.AssignedAccountID);
            if (account == null)
                throw new Exception("Không tìm thấy tài khoản với ID đã cung cấp.");

            var teamMember = _unitOfWork.TeamMemberRepository.Get(tm => tm.AccountID == account.Id).FirstOrDefault();
            if (teamMember == null)
                throw new Exception("Không tìm thấy TeamMember liên kết với tài khoản đã cung cấp.");

            var team = await _unitOfWork.TeamRepository.GetByIdAsync(teamMember.TeamID);
            if (team == null || team.TeamType != TeamType.IndividualProjectManagement)
                throw new Exception("Nhân viên được chỉ định không thuộc đội có TeamType là IndividualProjectManagement.");

            var apartmentOwnerApartment = await _unitOfWork.ApartmentOwnerApartmentRepository.GetByIdAsync(request.ApartmentOwnerApartmentID);

            if (apartmentOwnerApartment == null)
            {
                apartmentOwnerApartment = new ApartmentOwnerApartment
                {
                    ApartmentOwnerApartmentID = Guid.NewGuid(),
                    ApartmentOwnerID = request.ApartmentOwnerID,
                    OwnershipStatus = OwnershipStatus.Pending,
                    AssignedTeamMemberID = teamMember.TeamMemberID
                };

                _unitOfWork.ApartmentOwnerApartmentRepository.Insert(apartmentOwnerApartment);
                await _unitOfWork.SaveAsync();
            }

            var propertyVerification = _mapper.Map<PropertyVerification>(request);
            propertyVerification.ApartmentOwnerApartmentID = apartmentOwnerApartment.ApartmentOwnerApartmentID;
            propertyVerification.VerificationStatus = VerificationStatus.Pending;
            propertyVerification.ContractCode = "TEMP"; // Giá trị tạm thời

            // Lưu PropertyVerification
            _unitOfWork.PropertyVerificationRepository.Insert(propertyVerification);
            await _unitOfWork.SaveAsync();

            // Tạo các LegalDocument
            if (request.LegalDocumentFiles != null && request.LegalDocumentFiles.Count > 0)
            {
                foreach (var file in request.LegalDocumentFiles)
                {
                    var url = await _firebaseConfig.UploadImage(file);
                    var legalDocument = new LegalDocument
                    {
                        VerificationID = propertyVerification.VerificationID,
                        FileName = file.FileName,
                        FileUrl = url,
                        CreateDate = CoreHelper.SystemTimeNow,
                        UpdateDate = CoreHelper.SystemTimeNow,
                    };

                    _unitOfWork.LegalDocumentRepository.Insert(legalDocument);
                }
                await _unitOfWork.SaveAsync();
            }

            // Cập nhật ContractCode chính thức
            propertyVerification.ContractCode = await _generateCode.GenerateContractCode(propertyVerification.VerificationID);
            _unitOfWork.PropertyVerificationRepository.Update(propertyVerification);
            await _unitOfWork.SaveAsync();

            await _propertyScheduler.SchedulePropertyExpiryJob(propertyVerification);

            var response = _mapper.Map<PropertyVerificationResponse>(propertyVerification);
            response.LegalDocuments = propertyVerification.LegalDocuments
                .Select(ld => new LegalDocumentResponse
                {
                    FileName = ld.FileName,
                    FileUrl = ld.FileUrl,
                    CreateDate = ld.CreateDate,
                    UpdateDate = ld.UpdateDate,
                })
                .ToList();

            return response;
        }





        // Get all PropertyVerifications
        public async Task<IEnumerable<PropertyVerificationResponse>> GetAllAsync()
        {
            var verifications = _unitOfWork.PropertyVerificationRepository.Get(
                includeProperties: "LegalDocuments,ApartmentOwnerApartment.ApartmentOwner"
            );

            return verifications.Select(v =>
            {
                var response = _mapper.Map<PropertyVerificationResponse>(v);
                response.LegalDocuments = v.LegalDocuments.Select(ld => new LegalDocumentResponse
                {
                    FileName = ld.FileName,
                    FileUrl = ld.FileUrl,
                    CreateDate = ld.CreateDate,
                    UpdateDate = ld.UpdateDate
                }).ToList();

                response.OwnerName = v.ApartmentOwnerApartment?.ApartmentOwner?.Name ?? "Chưa xác định";

                return response;
            });
        }




        // Get a PropertyVerification by ID
        public async Task<PropertyVerificationResponse> GetByIdAsync(Guid verificationId)
        {
            var verification = _unitOfWork.PropertyVerificationRepository.Get(
                filter: v => v.VerificationID == verificationId,
                includeProperties: "LegalDocuments,ApartmentOwnerApartment.ApartmentOwner"
            ).FirstOrDefault();

            if (verification == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy phiên xác minh.");

            var response = _mapper.Map<PropertyVerificationResponse>(verification);
            response.LegalDocuments = verification.LegalDocuments.Select(ld => new LegalDocumentResponse
            {
                FileName = ld.FileName,
                FileUrl = ld.FileUrl,
                CreateDate = ld.CreateDate,
                UpdateDate = ld.UpdateDate
            }).ToList();

            // Gắn thêm tên chủ ký gửi
            response.OwnerName = verification.ApartmentOwnerApartment?.ApartmentOwner?.Name ?? "Chưa xác định";

            return response;
        }





        // Update a PropertyVerification
        public async Task<PropertyVerificationResponse> UpdateAsync(Guid verificationId, UpdatePropertyVerificationRequest request)
        {
            var verification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (verification == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy phiên xác minh.");

            if (request.LegalDocumentFiles != null && request.LegalDocumentFiles.Count > 0)
            {
                foreach (var file in request.LegalDocumentFiles)
                {
                    var url = await _firebaseConfig.UploadImage(file);
                    var legalDocument = new LegalDocument
                    {
                        VerificationID = verification.VerificationID,
                        FileName = file.FileName,
                        FileUrl = url,
                        CreateDate = CoreHelper.SystemTimeNow,
                        UpdateDate = CoreHelper.SystemTimeNow,
                    };

                    _unitOfWork.LegalDocumentRepository.Insert(legalDocument);
                }
                await _unitOfWork.SaveAsync();
            }

            _mapper.Map(request, verification);
            verification.UpdateDate = DateTimeOffset.UtcNow;

            _unitOfWork.PropertyVerificationRepository.Update(verification);
            await _unitOfWork.SaveAsync();

            await _propertyScheduler.SchedulePropertyExpiryJob(verification);

            return _mapper.Map<PropertyVerificationResponse>(verification);
        }




        // Delete a PropertyVerification
        public async Task<bool> DeleteAsync(Guid verificationId)
        {
            var verification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (verification == null)
                throw new Exception("Không tìm thấy phiên xác minh.");

            _unitOfWork.PropertyVerificationRepository.Delete(verification);
            await _unitOfWork.SaveAsync();
            return true;
        }


        // Accept PropertyVerification
        public async Task<PropertyVerificationResponse> AcceptAsync(Guid verificationId)
        {
            var verification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (verification == null)
                throw new Exception("Không tìm thấy phiên xác minh.");

            verification.VerificationStatus = VerificationStatus.Accepted;

            _unitOfWork.PropertyVerificationRepository.Update(verification);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<PropertyVerificationResponse>(verification);
        }


        // Reject PropertyVerification
        public async Task<PropertyVerificationResponse> RejectAsync(Guid verificationId)
        {
            var verification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationId);
            if (verification == null)
                throw new Exception("Không tìm thấy phiên xác minh.");

            verification.VerificationStatus = VerificationStatus.Expirated;

            _unitOfWork.PropertyVerificationRepository.Update(verification);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<PropertyVerificationResponse>(verification);
        }


        // Search PropertyVerifications
        public async Task<(IEnumerable<PropertyVerificationResponse> Results, int TotalItems, int TotalPages)> SearchAsync(
        string? keyword = null,
        VerificationStatus? status = null,
        DateTimeOffset? startDate = null,
        DateTimeOffset? endDate = null,
        int pageIndex = 1,
        int pageSize = 10)
        {
            // Bộ lọc tìm kiếm
            Expression<Func<PropertyVerification, bool>> filter = pv =>
                (string.IsNullOrEmpty(keyword) ||
                 pv.VerificationName.Contains(keyword) ||
                 pv.ContractCode.Contains(keyword) ||
                 pv.ApartmentOwnerApartment.ApartmentOwner.Name.Contains(keyword)) &&
                (!status.HasValue || pv.VerificationStatus == status) &&
                (!startDate.HasValue || pv.CreateDate >= startDate) &&
                (!endDate.HasValue || pv.CreateDate <= endDate);

            // Đếm tổng số bản ghi phù hợp
            int totalItems = await _unitOfWork.PropertyVerificationRepository.CountAsync(filter);

            // Lấy danh sách bản ghi phân trang và sắp xếp
            var verifications = _unitOfWork.PropertyVerificationRepository.Get(
                filter: filter,
                includeProperties: "LegalDocuments,ApartmentOwnerApartment.ApartmentOwner",
                orderBy: o => o.OrderBy(v => v.HasApartment == true ? 0 : 1) // Sắp xếp ưu tiên có căn hộ
                               .ThenByDescending(v => v.UpdateDate),         // Sau đó theo ngày cập nhật
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Tính tổng số trang
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Ánh xạ kết quả trả về
            var results = verifications.Select(v =>
            {
                var response = _mapper.Map<PropertyVerificationResponse>(v);
                response.LegalDocuments = v.LegalDocuments.Select(ld => new LegalDocumentResponse
                {
                    FileName = ld.FileName,
                    FileUrl = ld.FileUrl,
                    CreateDate = ld.CreateDate,
                    UpdateDate = ld.UpdateDate
                }).ToList();

                response.OwnerName = v.ApartmentOwnerApartment?.ApartmentOwner?.Name ?? "Chưa xác định";
                return response;
            });

            return (results, totalItems, totalPages);
        }





        public async Task<PropertyVerificationResponse> RenewContractAsync(RenewContractRequest request)
        {
            // Kiểm tra căn hộ có tồn tại không
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (apartment == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ với ID đã cung cấp.");

            // Lấy thông tin ApartmentOwnerApartment liên quan đến căn hộ
            var apartmentOwnerApartment = _unitOfWork.ApartmentOwnerApartmentRepository
                .Get(a => a.ApartmentID == request.ApartmentID, includeProperties: "ApartmentOwner")
                .FirstOrDefault();

            if (apartmentOwnerApartment == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin sở hữu căn hộ.");

            // Tạo hợp đồng mới (PropertyVerification) để gia hạn
            var newContract = _mapper.Map<PropertyVerification>(request);
            newContract.ContractCode = "string";
            newContract.ApartmentOwnerApartmentID = apartmentOwnerApartment.ApartmentOwnerApartmentID;
            newContract.VerificationStatus = VerificationStatus.Accepted;

            // Tải lên tài liệu pháp lý mới nếu có
            if (request.LegalDocumentFiles != null && request.LegalDocumentFiles.Count > 0)
            {
                foreach (var file in request.LegalDocumentFiles)
                {
                    var url = await _firebaseConfig.UploadImage(file);
                    var legalDocument = new LegalDocument
                    {
                        VerificationID = newContract.VerificationID,
                        FileName = file.FileName,
                        FileUrl = url,
                        CreateDate = CoreHelper.SystemTimeNow,
                        UpdateDate = CoreHelper.SystemTimeNow,
                    };
                    _unitOfWork.LegalDocumentRepository.Insert(legalDocument);
                }
                await _unitOfWork.SaveAsync();
            }

            // Cập nhật ngày hiệu lực của căn hộ dựa trên hợp đồng mới
            apartment.EffectiveStartDate = request.EffectiveDate;
            apartment.ExpiryDate = request.ExpiryDate;
            apartment.ApartmentStatus = ApartmentStatus.Available; // Đặt lại trạng thái căn hộ

            // Lưu hợp đồng mới và cập nhật căn hộ
            _unitOfWork.PropertyVerificationRepository.Insert(newContract);
            _unitOfWork.ApartmentRepository.Update(apartment);
            await _unitOfWork.SaveAsync();

            newContract.ContractCode = await _generateCode.GenerateContractCode(newContract.VerificationID);
            _unitOfWork.PropertyVerificationRepository.Update(newContract);
            await _unitOfWork.SaveAsync();

            // Lên lịch job với scheduler
            await _propertyScheduler.SchedulePropertyExpiryJob(newContract);

            return _mapper.Map<PropertyVerificationResponse>(newContract);
        }



        public async Task<(IEnumerable<ContractSummaryResponse> Results, int TotalItems, int TotalPages)> SearchContractsAsync(
        string? ownerName = null,
        string? contractCode = null,
        VerificationStatus? status = null,
        DateTimeOffset? startDate = null,
        DateTimeOffset? endDate = null,
        int pageIndex = 1,
        int pageSize = 10)
        {
            // Lấy danh sách PropertyVerification có đầy đủ liên kết
            var verifications = _unitOfWork.PropertyVerificationRepository.Get(
                includeProperties: "ApartmentOwnerApartment.ApartmentOwner,ApartmentOwnerApartment.Apartment,LegalDocuments");

            // Lọc danh sách theo điều kiện
            var filteredVerifications = verifications.Where(pv =>
                (string.IsNullOrEmpty(ownerName) || pv.ApartmentOwnerApartment.ApartmentOwner.Name.Contains(ownerName, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(contractCode) || pv.ContractCode.Contains(contractCode, StringComparison.OrdinalIgnoreCase)) &&
                (!status.HasValue || pv.VerificationStatus == status) &&
                (!startDate.HasValue || pv.EffectiveDate >= startDate) &&
                (!endDate.HasValue || pv.ExpiryDate <= endDate));

            // Tính tổng số bản ghi và số trang
            int totalItems = filteredVerifications.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Phân trang dữ liệu
            var pagedVerifications = filteredVerifications
                .OrderBy(pv => pv.CreateDate)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // Ánh xạ dữ liệu trả về
            var results = pagedVerifications.Select(pv => new ContractSummaryResponse
            {
                ContractCode = pv.ContractCode ?? "Chưa xác định",
                ApartmentCode = pv.ApartmentOwnerApartment?.Apartment?.ApartmentCode ?? "Chưa xác định",
                OwnerName = pv.ApartmentOwnerApartment?.ApartmentOwner?.Name ?? "Chưa xác định",
                EffectiveDate = pv.EffectiveDate,
                ExpiryDate = pv.ExpiryDate,
                VerificationStatus = pv.VerificationStatus,
                LegalDocumentsURL = pv.LegalDocuments?.Select(ld => ld.FileUrl).ToList() ?? new List<string>()
            });

            return (results, totalItems, totalPages);
        }


        public async Task<IEnumerable<PropertyVerificationResponse>> GetNearExpiryVerificationsAsync(int days)
        {
            var currentDate = CoreHelper.SystemTimeNow;
            var nearExpiryDate = currentDate.AddDays(days);

            var verifications = _unitOfWork.PropertyVerificationRepository.Get(
                filter: v => v.ExpiryDate <= nearExpiryDate && v.ExpiryDate >= currentDate,
                includeProperties: "LegalDocuments",
                orderBy: q => q.OrderBy(v => v.ExpiryDate)
            );

            if (!verifications.Any())
                throw new CustomException.DataNotFoundException("Không có xác minh nào gần ngày hết hạn.");

            return verifications.Select(v =>
            {
                var response = _mapper.Map<PropertyVerificationResponse>(v);
                response.LegalDocuments = v.LegalDocuments.Select(ld => new LegalDocumentResponse
                {
                    FileName = ld.FileName,
                    FileUrl = ld.FileUrl,
                    CreateDate = ld.CreateDate,
                    UpdateDate = ld.UpdateDate
                }).ToList();

                return response;
            });
        }




    }

}
