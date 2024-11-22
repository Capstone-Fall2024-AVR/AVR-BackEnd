using AutoMapper;
using AVR.Application.Services;
using AVR.Application.Utils.GenerateCode;
using AVR.Application.ViewModels.Request.Apartments;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Response.Apartments;
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
    public class ApartmentService : IApartmentService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFirebaseConfig _firebaseConfig;
        private readonly UserManager<Account> _userManager;
        private readonly IApartmentScheduler _apartmentscheduler;
        private readonly IGenerateCode _generateCode;
        private readonly INotificationService _notificationService;

        public ApartmentService(IGenerateCode generateCode, IApartmentScheduler apartmentscheduler, IMapper mapper, IUnitOfWork unitOfWork, IFirebaseConfig firebaseConfig, UserManager<Account> userManager, INotificationService notificationService)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _firebaseConfig = firebaseConfig;
            _userManager = userManager;
            _apartmentscheduler = apartmentscheduler;
            _generateCode = generateCode;
            _notificationService = notificationService;
        }

        public async Task<CreateApartmentForOwnerResponse> CreateApartmentForOwnerAsync(CreateApartmentForOwnerRequest request)
        {
            // Lấy PropertyVerification bằng PropertyVerificationID
            var propertyVerification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(request.PropertyVerificationID);
            if (propertyVerification == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin xác minh tài sản.");
            }

            // Lấy ApartmentOwnerApartment từ PropertyVerification
            var apartmentOwnerApartment = await _unitOfWork.ApartmentOwnerApartmentRepository.GetByIdAsync(propertyVerification.ApartmentOwnerApartmentID);
            if (apartmentOwnerApartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy ApartmentOwnerApartment liên kết với xác minh tài sản.");
            }

            // Lấy thông tin dự án
            var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(request.ProjectApartmentID);
            if (projectApartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin dự án căn hộ.");
            }

            var projectApartmentName = projectApartment.ProjectApartmentName;

            // Lấy tên chủ sở hữu từ ApartmentOwner
            var owner = await _unitOfWork.ApartmentOwnerRepository.GetByIdAsync(apartmentOwnerApartment.ApartmentOwnerID);
            if (owner == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy chủ sở hữu.");
            }
            var ownerName = owner.Name;

            Guid apartmentId = Guid.NewGuid();
            var apartment = _mapper.Map<Apartment>(request);
            apartment.ApartmentID = apartmentId;
            apartment.ApartmentCode = "string";
            apartment.ApartmentStatus = ApartmentStatus.PendingApproval;
            apartment.PossessionType = PossessionType.Owner;
            apartment.CreatedDate = CoreHelper.SystemTimeNow;
            apartment.UpdatedDate = CoreHelper.SystemTimeNow;
            apartment.Price = propertyVerification.PropertyValue;
            apartment.PricePerSquareMeter = apartment.Area > 0 ? apartment.Price / apartment.Area : 0;
            apartment.EffectiveStartDate = propertyVerification.EffectiveDate;
            apartment.ExpiryDate = propertyVerification.ExpiryDate;
            apartment.AssignedTeamMemberID = apartmentOwnerApartment.AssignedTeamMemberID;

            apartmentOwnerApartment.ApartmentID = apartment.ApartmentID;
            apartmentOwnerApartment.OwnershipStatus = OwnershipStatus.Active;

            _unitOfWork.ApartmentRepository.Insert(apartment);
            _unitOfWork.ApartmentOwnerApartmentRepository.Update(apartmentOwnerApartment);
            await _unitOfWork.SaveAsync();

            apartment.ApartmentCode = await _generateCode.GenerateApartmentCode(apartmentId);
            _unitOfWork.ApartmentRepository.Update(apartment);
            await _unitOfWork.SaveAsync();

            var imageResponses = new List<ApartmentImageResponse>();
            if (request.Images != null && request.Images.Count > 0)
            {
                foreach (var file in request.Images)
                {
                    var imageUrl = await _firebaseConfig.UploadImage(file);

                    var apartmentImage = new ApartmentImage
                    {
                        ApartmentImageID = Guid.NewGuid(),
                        Description = file.FileName,
                        ImageUrl = imageUrl,
                        CreateDate = CoreHelper.SystemTimeNow,
                        UpdateDate = CoreHelper.SystemTimeNow,
                        ApartmentID = apartment.ApartmentID
                    };

                    _unitOfWork.ApartmentImageRepository.Insert(apartmentImage);
                    imageResponses.Add(new ApartmentImageResponse
                    {
                        ApartmentImageID = apartmentImage.ApartmentImageID,
                        Description = apartmentImage.Description,
                        ImageUrl = apartmentImage.ImageUrl
                    });
                }

                await _unitOfWork.SaveAsync();
            }

            string videoUrl = null;
            if (request.VRVideoFile != null)
            {
                videoUrl = await _firebaseConfig.UploadImage(request.VRVideoFile);
                var vrExperience = new VRExperience
                {
                    VRExperienceID = Guid.NewGuid(),
                    video_url_file = videoUrl,
                    CreateDate = CoreHelper.SystemTimeNow,
                    UpdateDate = CoreHelper.SystemTimeNow,
                    ApartmentID = apartment.ApartmentID,
                    AssignedTeamMemberID = apartmentOwnerApartment.AssignedTeamMemberID
                };
                _unitOfWork.VRExperienceRepository.Insert(vrExperience);
            }
            await _unitOfWork.SaveAsync();

            var notificationRequest = new NotificationRequest
            {
                AccountID = owner.AccountID,
                Title = "Tạo căn hộ thành công",
                Description = $"Căn hộ {apartment.ApartmentCode} đã được tạo thành công và đang chờ phê duyệt.",
                NotificationTypes = NotificationType.Apartment,
                ReferenceId = apartment.ApartmentID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);




            await _apartmentscheduler.ScheduleApartmentExpiryJob(apartment);

            var response = _mapper.Map<CreateApartmentForOwnerResponse>(apartment);
            response.ProjectApartmentName = projectApartmentName;
            response.Images = imageResponses;
            response.VRVideoUrl = videoUrl;
            response.OwnerName = ownerName;
            return response;
        }



        public async Task<CreateApartmentResponse> CreateApartment(CreateApartmentRequest request)
        {
            // Kiểm tra xem dự án căn hộ có tồn tại không
            var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(request.ProjectApartmentID);
            if (projectApartment == null)
            {
                throw new CustomException.InvalidDataException("Dự án căn hộ không tồn tại.");
            }

            // Kiểm tra AccountID và lấy TeamMemberID tương ứng 
            var teamMember = _unitOfWork.TeamMemberRepository.Get(tm =>
                tm.AccountID == request.AssignedAccountID && tm.TeamID == projectApartment.TeamID && tm.IsManager == true)
                .FirstOrDefault();

            if (teamMember == null)
            {
                throw new CustomException.InvalidDataException("Nhân viên được chỉ định không thuộc team quản lý dự án hoặc không phải là staff.");
            }



            // Tạo đối tượng Apartment từ request
            Guid apartmentid = Guid.NewGuid();
            var apartment = _mapper.Map<Apartment>(request);
            apartment.ApartmentID = apartmentid;
            apartment.ApartmentCode = "string";
            apartment.ApartmentStatus = ApartmentStatus.PendingApproval;
            apartment.PossessionType = PossessionType.Provider;
            apartment.CreatedDate = CoreHelper.SystemTimeNow;
            apartment.PricePerSquareMeter = apartment.Area > 0 ? apartment.Price / apartment.Area : 0;
            apartment.UpdatedDate = CoreHelper.SystemTimeNow;


            apartment.ProjectApartmentID = projectApartment.ProjectApartmentID;
            apartment.AssignedTeamMemberID = teamMember.TeamMemberID;

            // Lưu căn hộ vào cơ sở dữ liệu
            _unitOfWork.ApartmentRepository.Insert(apartment);
            await _unitOfWork.SaveAsync();

            apartment.ApartmentCode = await _generateCode.GenerateApartmentCode(apartmentid);
            _unitOfWork.ApartmentRepository.Update(apartment);
            await _unitOfWork.SaveAsync();

            // Xử lý hình ảnh nếu có
            var imageResponses = new List<ApartmentImageResponse>();
            if (request.Images != null && request.Images.Count > 0)
            {
                foreach (var file in request.Images)
                {
                    var imageUrl = await _firebaseConfig.UploadImage(file); // Upload hình lên Firebase

                    var apartmentImage = new ApartmentImage
                    {
                        ApartmentImageID = Guid.NewGuid(),
                        Description = file.FileName,
                        ImageUrl = imageUrl,
                        CreateDate = CoreHelper.SystemTimeNow,
                        UpdateDate = CoreHelper.SystemTimeNow,
                        ApartmentID = apartment.ApartmentID
                    };

                    _unitOfWork.ApartmentImageRepository.Insert(apartmentImage);
                    imageResponses.Add(new ApartmentImageResponse
                    {
                        ApartmentImageID = apartmentImage.ApartmentImageID,
                        Description = apartmentImage.Description,
                        ImageUrl = apartmentImage.ImageUrl
                    });
                }

                await _unitOfWork.SaveAsync();
            }

            // Upload video VR và tạo VRExperience nếu có
            string videoUrl = null;
            if (request.VRVideoFile != null)
            {
                videoUrl = await _firebaseConfig.UploadImage(request.VRVideoFile);
                var vrExperience = new VRExperience
                {
                    VRExperienceID = Guid.NewGuid(),
                    video_url_file = videoUrl,
                    CreateDate = CoreHelper.SystemTimeNow,
                    UpdateDate = CoreHelper.SystemTimeNow,
                    ApartmentID = apartment.ApartmentID,
                    AssignedTeamMemberID = teamMember.TeamMemberID,
                };
                _unitOfWork.VRExperienceRepository.Insert(vrExperience);
            }
            await _unitOfWork.SaveAsync();


            //Quartz
            await _apartmentscheduler.ScheduleApartmentExpiryJob(apartment);

            // Trả về response
            var response = _mapper.Map<CreateApartmentResponse>(apartment);
            response.Images = imageResponses; // Trả về danh sách hình ảnh
            response.ProjectApartmentName = projectApartment.ProjectApartmentName; // Trả thêm tên dự án
            response.VRVideoUrl = videoUrl;
            return response;
        }


        //Add 1 list căn hộ cho project

        public Task<IEnumerable<CreateApartmentResponse>> CreateApartmentList(CreateApartmentListRequest request)
        {
            throw new NotImplementedException();
        }


        //Get By id

        public async Task<CreateApartmentResponse> GetApartmentById(Guid id, Guid? accountId)
        {
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(id);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy apartment này.");
            }

            // Lấy tên dự án liên quan
            var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);

            if (projectApartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy dự án căn hộ liên quan.");
            }

            // Lấy danh sách hình ảnh liên quan đến căn hộ
            var apartmentImages = _unitOfWork.ApartmentImageRepository.Get(img => img.ApartmentID == id);
            var vrExperience = _unitOfWork.VRExperienceRepository.Get(vr => vr.ApartmentID == id).FirstOrDefault();

            bool userLiked = false;
            if (accountId.HasValue)
            {
                userLiked = _unitOfWork.ApartmentInteractionRepository
                    .Get(i => i.AccountID == accountId.Value && i.ApartmentID == id && i.InteractionTypes == InteractionType.Liked)
                    .Any();
            }
            // Ánh xạ kết quả trả về thành response
            var response = _mapper.Map<CreateApartmentResponse>(apartment);
            response.ProjectApartmentName = projectApartment.ProjectApartmentName; // Thêm tên dự án
            response.Images = apartmentImages.Select(img => new ApartmentImageResponse
            {
                ApartmentImageID = img.ApartmentImageID,
                Description = img.Description,
                ImageUrl = img.ImageUrl
            }).ToList();
            response.VRVideoUrl = vrExperience?.video_url_file ?? string.Empty;


            response.UserLiked = userLiked;
            return response;
        }

        //Get list apartment
        public async Task<IEnumerable<CreateApartmentResponse>> GetApartments()
        {
            var apartments = await _unitOfWork.ApartmentRepository.GetAllAsync();
            if (apartments == null || !apartments.Any())
            {
                throw new CustomException.DataNotFoundException("List apartment này trống.");
            }

            var responseList = new List<CreateApartmentResponse>();

            foreach (var apartment in apartments)
            {
                // Lấy tên dự án liên quan
                var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);
                if (projectApartment == null)
                {
                    throw new CustomException.DataNotFoundException($"Không tìm thấy dự án cho căn hộ: {apartment.ApartmentName}");
                }

                // Lấy danh sách hình ảnh liên quan đến căn hộ
                var apartmentImages = _unitOfWork.ApartmentImageRepository.Get(img => img.ApartmentID == apartment.ApartmentID);
                var vrExperience = _unitOfWork.VRExperienceRepository.Get(vr => vr.ApartmentID == apartment.ApartmentID).FirstOrDefault();

                // Ánh xạ kết quả trả về thành response
                var response = _mapper.Map<CreateApartmentResponse>(apartment);
                response.ProjectApartmentName = projectApartment.ProjectApartmentName; // Thêm tên dự án
                response.Images = apartmentImages.Select(img => new ApartmentImageResponse
                {
                    ApartmentImageID = img.ApartmentImageID,
                    Description = img.Description,
                    ImageUrl = img.ImageUrl
                }).ToList();
                response.VRVideoUrl = vrExperience?.video_url_file ?? string.Empty;



                responseList.Add(response);
            }

            return responseList;
        }


        public async Task<(IEnumerable<CreateApartmentResponse> Apartments, int TotalItem, int TotalPage)> SearchApartments(
            string? apartmentName,
            string? address,
            string? district,
            string? ward,
            List<ApartmentType>? apartmentTypes,
            List<ApartmentStatus>? apartmentStatuses,
            List<PossessionType>? possessionTypes,
            decimal? minPrice,
            decimal? maxPrice,
            decimal? minArea,
            decimal? maxArea,
            int? numberOfRooms,
            int? numberOfBathrooms,
            List<Direction>? directions,
            List<BalconyDirection>? balconyDirections,
            Guid? accountId,
            Guid? projectId,
            bool? userLiked = null,
            int pageIndex = 1,
            int pageSize = 5)
        {
            // Lấy tất cả các ApartmentInteraction của người dùng hiện tại có InteractionType là Liked
            var likedApartmentIds = _unitOfWork.ApartmentInteractionRepository
                .Get(i => i.AccountID == accountId && i.InteractionTypes == InteractionType.Liked)
                .Select(i => i.ApartmentID)
                .ToHashSet();

            // Tạo filter expression dựa trên các tham số tìm kiếm
            Expression<Func<Apartment, bool>> filter = a =>
                 (string.IsNullOrEmpty(apartmentName) || a.ApartmentName.Contains(apartmentName)) &&
                 (string.IsNullOrEmpty(address) || a.Address.Contains(address)) &&
                 (string.IsNullOrEmpty(district) || a.District.Contains(district)) &&
                 (string.IsNullOrEmpty(ward) || a.Ward.Contains(ward)) &&
                 (!projectId.HasValue || a.ProjectApartmentID == projectId) &&
                 (apartmentTypes == null || apartmentTypes.Count == 0 || apartmentTypes.Contains(a.ApartmentType)) &&
                 (apartmentStatuses == null || apartmentStatuses.Count == 0 || apartmentStatuses.Contains(a.ApartmentStatus)) &&
                 (possessionTypes == null || possessionTypes.Count == 0 || possessionTypes.Contains(a.PossessionType)) &&
                 (!minPrice.HasValue || a.Price >= minPrice) &&
                 (!maxPrice.HasValue || a.Price <= maxPrice) &&
                 (!minArea.HasValue || a.Area >= minArea) &&
                 (!maxArea.HasValue || a.Area <= maxArea) &&
                 (!numberOfRooms.HasValue || a.NumberOfRooms == numberOfRooms) &&
                 (!numberOfBathrooms.HasValue || a.NumberOfBathrooms == numberOfBathrooms) &&
                 (directions == null || directions.Count == 0 || directions.Contains(a.Direction)) &&
                 (balconyDirections == null || balconyDirections.Count == 0 || balconyDirections.Contains(a.BalconyDirection)) &&
                 (!userLiked.HasValue || (userLiked.Value == likedApartmentIds.Contains(a.ApartmentID)));

            // Tính tổng số lượng căn hộ phù hợp với bộ lọc
            var totalItem = await _unitOfWork.ApartmentRepository.CountAsync(filter);

            // Truy vấn từ repository với filter, sắp xếp và phân trang
            var apartments = _unitOfWork.ApartmentRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(a => a.CreatedDate),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Ánh xạ kết quả trả về thành response
            var responseList = new List<CreateApartmentResponse>();

            foreach (var apartment in apartments)
            {
                // Lấy danh sách hình ảnh cho từng căn hộ
                var apartmentImages = _unitOfWork.ApartmentImageRepository.Get(img => img.ApartmentID == apartment.ApartmentID);

                var imageResponses = apartmentImages.Select(img => new ApartmentImageResponse
                {
                    ApartmentImageID = img.ApartmentImageID,
                    Description = img.Description,
                    ImageUrl = img.ImageUrl
                }).ToList();

                // Lấy tên dự án từ ProjectApartment
                var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);
                var projectApartmentName = projectApartment?.ProjectApartmentName ?? "Không rõ dự án";
                var vrExperience = _unitOfWork.VRExperienceRepository.Get(vr => vr.ApartmentID == apartment.ApartmentID).FirstOrDefault();

                // Map response từ apartment và thêm danh sách hình ảnh và tên dự án
                var response = _mapper.Map<CreateApartmentResponse>(apartment);
                response.Images = imageResponses; // Trả về danh sách hình ảnh
                response.ProjectApartmentName = projectApartmentName; // Trả thêm tên dự án

                // Xác định trạng thái UserLiked cho từng căn hộ dựa trên likedApartmentIds
                response.UserLiked = likedApartmentIds.Contains(apartment.ApartmentID);
                response.VRVideoUrl = vrExperience?.video_url_file ?? string.Empty;

                responseList.Add(response);
            }

            int totalPages = (int)Math.Ceiling((double)totalItem / pageSize);

            return (responseList, totalItem, totalPages);
        }



        public async Task<CreateApartmentResponse> ApproveApartment(Guid apartmentId)
        {
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(apartmentId);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ.");
            }

            if (apartment.ApartmentStatus != ApartmentStatus.PendingApproval)
            {
                throw new CustomException.InvalidDataException("Căn hộ không trong trạng thái chờ duyệt.");
            }

            apartment.ApartmentStatus = ApartmentStatus.Available;
            apartment.UpdatedDate = CoreHelper.SystemTimeNow;

            _unitOfWork.ApartmentRepository.Update(apartment);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<CreateApartmentResponse>(apartment);
        }

        public async Task<CreateApartmentResponse> RejectApartment(Guid apartmentId)
        {
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(apartmentId);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ.");
            }

            if (apartment.ApartmentStatus != ApartmentStatus.PendingApproval)
            {
                throw new CustomException.InvalidDataException("Căn hộ không trong trạng thái chờ duyệt.");
            }

            apartment.ApartmentStatus = ApartmentStatus.Unavailable;
            apartment.UpdatedDate = CoreHelper.SystemTimeNow;

            _unitOfWork.ApartmentRepository.Update(apartment);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<CreateApartmentResponse>(apartment);
        }

        public async Task<CreateApartmentResponse> UpdateApartment(Guid apartmentId, UpdateApartmentRequest request)
        {
            // Lấy căn hộ từ cơ sở dữ liệu
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(apartmentId);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ.");
            }

            // Cập nhật các thông tin nếu có trong request, giữ nguyên giá trị cũ nếu không được cung cấp
            apartment.ApartmentName = request.ApartmentName ?? apartment.ApartmentName;
            apartment.Description = request.Description ?? apartment.Description;
            apartment.Address = request.Address ?? apartment.Address;
            apartment.Area = request.Area ?? apartment.Area;
            apartment.District = request.District ?? apartment.District;
            apartment.Ward = request.Ward ?? apartment.Ward;
            apartment.NumberOfRooms = request.NumberOfRooms ?? apartment.NumberOfRooms;
            apartment.NumberOfBathrooms = request.NumberOfBathrooms ?? apartment.NumberOfBathrooms;
            apartment.Location = request.Location ?? apartment.Location;
            apartment.Direction = request.Direction ?? apartment.Direction;
            apartment.Price = request.Price ?? apartment.Price;
            apartment.PricePerSquareMeter = request.PricePerSquareMeter ?? apartment.PricePerSquareMeter;
            apartment.EffectiveStartDate = request.EffectiveStartDate ?? apartment.EffectiveStartDate;
            apartment.ExpiryDate = request.ExpiryDate ?? apartment.ExpiryDate;
            apartment.ApartmentStatus = request.ApartmentStatus ?? apartment.ApartmentStatus;
            apartment.ApartmentType = request.ApartmentType ?? apartment.ApartmentType;
            apartment.PossessionType = request.PossessionType ?? apartment.PossessionType;
            apartment.BalconyDirection = request.BalconyDirection ?? apartment.BalconyDirection;
            apartment.Building = request.Building ?? apartment.Building;
            apartment.Floor = request.Floor ?? apartment.Floor;
            apartment.RoomNumber = request.RoomNumber ?? apartment.RoomNumber;
            apartment.ProjectApartmentID = request.ProjectApartmentID ?? apartment.ProjectApartmentID;

            // Kiểm tra AssignedAccountID
            if (request.AssignedAccountID.HasValue)
            {
                var teamMember = _unitOfWork.TeamMemberRepository.Get(tm =>
                    tm.AccountID == request.AssignedAccountID.Value &&
                    tm.TeamID == apartment.ProjectApartmentID &&
                    tm.IsManager == true).FirstOrDefault();

                if (teamMember == null)
                {
                    throw new CustomException.InvalidDataException("Nhân viên được chỉ định không thuộc team quản lý dự án hoặc không phải là staff.");
                }

                apartment.AssignedTeamMemberID = teamMember.TeamMemberID;
            }

            // Cập nhật hình ảnh mới (nếu có)
            if (request.Images != null && request.Images.Any())
            {
                var imageResponses = new List<ApartmentImageResponse>();

                foreach (var file in request.Images)
                {
                    var imageUrl = await _firebaseConfig.UploadImage(file);

                    var apartmentImage = new ApartmentImage
                    {
                        ApartmentImageID = Guid.NewGuid(),
                        Description = file.FileName,
                        ImageUrl = imageUrl,
                        CreateDate = CoreHelper.SystemTimeNow,
                        UpdateDate = CoreHelper.SystemTimeNow,
                        ApartmentID = apartment.ApartmentID
                    };

                    _unitOfWork.ApartmentImageRepository.Insert(apartmentImage);
                    imageResponses.Add(new ApartmentImageResponse
                    {
                        ApartmentImageID = apartmentImage.ApartmentImageID,
                        Description = apartmentImage.Description,
                        ImageUrl = apartmentImage.ImageUrl
                    });
                }
            }

            if (!apartment.AssignedTeamMemberID.HasValue)
            {
                throw new CustomException.InvalidDataException("AssignedTeamMemberID không thể là null.");
            }

            // Upload video VR mới nếu có
            if (request.VRVideoFile != null)
            {
                var videoUrl = await _firebaseConfig.UploadImage(request.VRVideoFile);

                var vrExperience = new VRExperience
                {
                    VRExperienceID = Guid.NewGuid(),
                    video_url_file = videoUrl,
                    CreateDate = CoreHelper.SystemTimeNow,
                    UpdateDate = CoreHelper.SystemTimeNow,
                    ApartmentID = apartment.ApartmentID,
                    AssignedTeamMemberID = apartment.AssignedTeamMemberID.Value
                };

                _unitOfWork.VRExperienceRepository.Insert(vrExperience);
            }

            apartment.UpdatedDate = CoreHelper.SystemTimeNow;

            // Lưu các thay đổi
            _unitOfWork.ApartmentRepository.Update(apartment);
            await _unitOfWork.SaveAsync();

            // Trả về response
            return _mapper.Map<CreateApartmentResponse>(apartment);
        }

    }
}
