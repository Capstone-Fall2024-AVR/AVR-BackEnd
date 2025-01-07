using AutoMapper;
using AVR.Application.Services;
using AVR.Application.Utils.GenerateCode;
using AVR.Application.ViewModels.Request.Apartments;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Request.ProjectFinancialContract.CreateProjectFinancialContractRequest;
using AVR.Application.ViewModels.Response.Apartments;
using AVR.Application.ViewModels.Response.VRExperiences;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using DocumentFormat.OpenXml.Office2016.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static PdfSharp.Capabilities.Features;

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
        private readonly IFileService _fileService;

        public ApartmentService(IGenerateCode generateCode, IApartmentScheduler apartmentscheduler, IMapper mapper, IUnitOfWork unitOfWork, IFirebaseConfig firebaseConfig, UserManager<Account> userManager, INotificationService notificationService, IFileService fileService)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _firebaseConfig = firebaseConfig;
            _userManager = userManager;
            _apartmentscheduler = apartmentscheduler;
            _generateCode = generateCode;
            _notificationService = notificationService;
            _fileService = fileService;
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

            var temmember = _unitOfWork.TeamMemberRepository.Get(t => t.TeamID == projectApartment.TeamID && t.IsManager == true).FirstOrDefault();

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

            propertyVerification.HasApartment = true;
            _unitOfWork.PropertyVerificationRepository.Update(propertyVerification);

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

            var vrExperienceResponses = new List<VRResponse>();
            if (request.VRVideoFiles != null && request.VRVideoFiles.Count > 0)
            {
                foreach (var vrFile in request.VRVideoFiles)
                {
                    var videoUrl = await _firebaseConfig.UploadImage(vrFile);

                    var vrExperience = new VRExperience
                    {
                        VRExperienceID = Guid.NewGuid(),
                        video_url_file = videoUrl,
                        description = vrFile.FileName,
                        CreateDate = CoreHelper.SystemTimeNow,
                        UpdateDate = CoreHelper.SystemTimeNow,
                        ApartmentID = apartment.ApartmentID,
                        AssignedTeamMemberID = apartmentOwnerApartment.AssignedTeamMemberID,
                    };

                    _unitOfWork.VRExperienceRepository.Insert(vrExperience);
                    vrExperienceResponses.Add(new VRResponse
                    {
                        VideoUrl = vrExperience.video_url_file,
                        Description = vrExperience.description,
                    });
                }
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

            var notificationStaff = new NotificationRequest
            {
                AccountID = temmember.AccountID,
                Title = "Tạo căn hộ thành công",
                Description = $"Căn hộ {apartment.ApartmentCode} đã được tạo thành công và đang chờ phê duyệt. Vui lòng mau chóng kiểm duyệt!",
                NotificationTypes = NotificationType.Apartment,
                ReferenceId = apartment.ApartmentID
            };

            await _notificationService.CreateNotificationAsync(notificationStaff);


            await _apartmentscheduler.ScheduleApartmentExpiryJob(apartment);

            var response = _mapper.Map<CreateApartmentForOwnerResponse>(apartment);
            response.ProjectApartmentName = projectApartmentName;
            response.Images = imageResponses;
            response.VRVideoUrls = vrExperienceResponses;
            response.OwnerName = ownerName;
            return response;
        }

        public async Task<IEnumerable<CreateApartmentResponse>> BulkUploadApartmentsAsync(IFormFile file, string description, DateTimeOffset expiryDay, Guid projectApartmentId, List<IFormFile>? images = null, List<IFormFile>? vrFiles = null)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException("File không hợp lệ.");
            }

            var project = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(projectApartmentId);
            if (project == null)
            {
                throw new CustomException.DataNotFoundException("Not found project!");
            }

            var apartments = new List<CreateApartmentRequest>();
            var financialContracts = new List<CreateProjectFinancialContractRequest>();
            var imgCodeMap = new Dictionary<string, List<IFormFile>>();
            var vrCodeMap = new Dictionary<string, List<IFormFile>>();

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    // Sheet 1: Apartments
                    var apartmentSheet = package.Workbook.Worksheets[0];
                    var apartmentRowCount = apartmentSheet.Dimension.Rows;

                    for (int row = 2; row <= apartmentRowCount; row++)
                    {
                        try
                        {
                            var apartment = new CreateApartmentRequest
                            {
                                ApartmentName = apartmentSheet.Cells[row, 1].Text ?? "None",
                                Description = apartmentSheet.Cells[row, 2].Text ?? "None",
                                Address = apartmentSheet.Cells[row, 3].Text ?? "None",
                                Area = decimal.TryParse(apartmentSheet.Cells[row, 4].Text, out var area) ? area : 0,
                                District = apartmentSheet.Cells[row, 5].Text ?? "None",
                                Ward = apartmentSheet.Cells[row, 6].Text ?? "None",
                                NumberOfRooms = int.TryParse(apartmentSheet.Cells[row, 7].Text, out var numRooms) ? numRooms : 0,
                                NumberOfBathrooms = int.TryParse(apartmentSheet.Cells[row, 8].Text, out var numBathrooms) ? numBathrooms : 0,
                                Location = apartmentSheet.Cells[row, 9].Text ?? "None",
                                Direction = Enum.TryParse<Direction>(apartmentSheet.Cells[row, 10].Text, true, out var direction) ? direction : Direction.Dong,
                                Price = decimal.TryParse(apartmentSheet.Cells[row, 11].Text, out var price) ? price : 0,
                                EffectiveDate = DateTimeOffset.TryParse(apartmentSheet.Cells[row, 12].Text, out var startDate) ? startDate : CoreHelper.SystemTimeNow,
                                ExpiryDate = DateTimeOffset.TryParse(apartmentSheet.Cells[row, 13].Text, out var expiryDate) ? expiryDate : CoreHelper.SystemTimeNow.AddMonths(6),
                                ApartmentType = Enum.TryParse<ApartmentType>(apartmentSheet.Cells[row, 14].Text, true, out var type) ? type : ApartmentType.CanHoTruyenThong,
                                BalconyDirection = Enum.TryParse<BalconyDirection>(apartmentSheet.Cells[row, 15].Text, true, out var balconyDirection) ? balconyDirection : BalconyDirection.Dong,
                                Building = apartmentSheet.Cells[row, 16].Text ?? "None",
                                Floor = int.TryParse(apartmentSheet.Cells[row, 17].Text, out var floor) ? floor : 0,
                                RoomNumber = int.TryParse(apartmentSheet.Cells[row, 18].Text, out var roomNumber) ? roomNumber : 0,
                                ImgCode = apartmentSheet.Cells[row, 19].Text, // Cột ImgCode
                                VRCode = apartmentSheet.Cells[row, 20].Text, // Cột VRCode
                                ProjectApartmentID = projectApartmentId
                            };

                            apartments.Add(apartment);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception($"Lỗi tại hàng {row} của sheet Apartment: {ex.Message}");
                        }
                    }

                    // Sheet 2: ProjectFinancialContracts
                    var financialContractSheet = package.Workbook.Worksheets[1];
                    var financialRowCount = financialContractSheet.Dimension.Rows;

                    for (int row = 2; row <= financialRowCount; row++)
                    {
                        try
                        {
                            var financialContract = new CreateProjectFinancialContractRequest
                            {
                                LowestPrice = decimal.TryParse(financialContractSheet.Cells[row, 1].Text, out var lowestPrice) ? lowestPrice : 0,
                                HighestPrice = decimal.TryParse(financialContractSheet.Cells[row, 2].Text, out var highestPrice) ? highestPrice : 0,
                                DepositAmount = decimal.TryParse(financialContractSheet.Cells[row, 3].Text, out var depositAmount) ? depositAmount : 0,
                                BrokerageFee = decimal.TryParse(financialContractSheet.Cells[row, 4].Text, out var brokerageFee) ? brokerageFee : 0,
                                CommissionFee = decimal.TryParse(financialContractSheet.Cells[row, 5].Text, out var commissionFee) ? commissionFee : 0,
                                ProjectApartmentID = projectApartmentId
                            };

                            financialContracts.Add(financialContract);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception($"Lỗi tại hàng {row} của sheet FinancialContract: {ex.Message}");
                        }
                    }
                }
            }

            // Tạo bản đồ từ ImgCode và VRCode đến danh sách file
            if (images != null)
            {
                foreach (var image in images)
                {
                    var code = Path.GetFileNameWithoutExtension(image.FileName).Split('_')[0]; // Lấy ImgCode từ tên file
                    if (!imgCodeMap.ContainsKey(code))
                    {
                        imgCodeMap[code] = new List<IFormFile>();
                    }
                    imgCodeMap[code].Add(image);
                }
            }

            if (vrFiles != null)
            {
                foreach (var vrFile in vrFiles)
                {
                    var code = Path.GetFileNameWithoutExtension(vrFile.FileName).Split('_')[0]; // Lấy VRCode từ tên file
                    if (!vrCodeMap.ContainsKey(code))
                    {
                        vrCodeMap[code] = new List<IFormFile>();
                    }
                    vrCodeMap[code].Add(vrFile);
                }
            }

            // Tạo các ProjectFinancialContract
            foreach (var contractRequest in financialContracts)
            {
                var financialContract = _mapper.Map<ProjectFinancialContract>(contractRequest);
                financialContract.FinancialContractID = Guid.NewGuid();

                _unitOfWork.ProjectFinancialContractRepository.Insert(financialContract);
            }
            await _unitOfWork.SaveAsync();

            // Upload Excel file vào bảng ProjectFile
            string fileUrl = await _firebaseConfig.UploadImage(file); 

            var projectFile = new ProjectFile
            {
                ProjectFileID = Guid.NewGuid(),
                ProjectFileUrl = fileUrl,
                Description = description,
                CreateDate = CoreHelper.SystemTimeNow,
                UpdateDate = CoreHelper.SystemTimeNow,
                ExpiryDate = expiryDay,
                ProjectApartmentID = projectApartmentId,
                ProjectFileTypes = ProjectFileType.File 
            };

            _unitOfWork.ProjectFileRepository.Insert(projectFile); 
            await _unitOfWork.SaveAsync();

            var createdApartments = new List<CreateApartmentResponse>();

            foreach (var apartmentRequest in apartments)
            {
                var aptId = Guid.NewGuid();
                var apartment = _mapper.Map<Apartment>(apartmentRequest);
                apartment.ApartmentID = aptId;
                apartment.ApartmentCode = await _generateCode.GenerateApartmentCode(aptId);
                apartment.ApartmentStatus = ApartmentStatus.PendingApproval;
                apartment.ProjectApartmentID = projectApartmentId;
                apartment.CreatedDate = CoreHelper.SystemTimeNow;
                apartment.UpdatedDate = CoreHelper.SystemTimeNow;

                _unitOfWork.ApartmentRepository.Insert(apartment);
                await _unitOfWork.SaveAsync();

                // ✅ Upload hình ảnh cho mỗi căn hộ
                var imageResponses = new List<ApartmentImageResponse>();
                if (apartmentRequest.ImgCode != null && imgCodeMap.ContainsKey(apartmentRequest.ImgCode))
                {
                    foreach (var imageFile in imgCodeMap[apartmentRequest.ImgCode])
                    {
                        var imageUrl = await _firebaseConfig.UploadImage(imageFile);
                        var apartmentImage = new ApartmentImage
                        {
                            ApartmentImageID = Guid.NewGuid(),
                            Description = imageFile.FileName,
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
                // ✅ Upload video VR cho mỗi căn hộ
                var vrExperienceResponses = new List<VRResponse>();
                if (apartmentRequest.VRCode != null && vrCodeMap.ContainsKey(apartmentRequest.VRCode))
                {
                    foreach (var vrFile in vrCodeMap[apartmentRequest.VRCode])
                    {
                        var videoUrl = await _firebaseConfig.UploadImage(vrFile);
                        var vrExperience = new VRExperience
                        {
                            VRExperienceID = Guid.NewGuid(),
                            video_url_file = videoUrl,
                            description = vrFile.FileName,
                            CreateDate = CoreHelper.SystemTimeNow,
                            UpdateDate = CoreHelper.SystemTimeNow,
                            ApartmentID = apartment.ApartmentID
                        };
                        _unitOfWork.VRExperienceRepository.Insert(vrExperience);
                        vrExperienceResponses.Add(new VRResponse
                        {
                            VideoUrl = vrExperience.video_url_file,
                            Description = vrExperience.description,
                        });
                    }
                }

                await _unitOfWork.SaveAsync();

                var response = _mapper.Map<CreateApartmentResponse>(apartment);
                response.Images = imageResponses;
                response.VRVideoUrls = vrExperienceResponses;
                response.ProjectApartmentName = project.ProjectApartmentName;
                //find deposit value from Project Financial Contract
                var projectfee = _unitOfWork.ProjectFinancialContractRepository
                    .Get(pf => pf.ProjectApartmentID == apartment.ProjectApartmentID &&
                        pf.LowestPrice <= apartment.Price &&
                        pf.HighestPrice > apartment.Price
                    ).FirstOrDefault();
                if (projectfee != null)
                {
                    response.DepositAmount = projectfee.DepositAmount;
                }

                createdApartments.Add(response);
            }

            return createdApartments;
        }


        public async Task<CreateApartmentResponse> CreateApartment(CreateApartmentRequest request)
        {
            // Kiểm tra xem dự án căn hộ có tồn tại không
            var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(request.ProjectApartmentID);
            if (projectApartment == null)
            {
                throw new CustomException.InvalidDataException("Dự án căn hộ không tồn tại.");
            }

            // Lấy thông tin Provider từ dự án
            var provider = await _unitOfWork.ApartmentProjectProviderRepository.GetByIdAsync(projectApartment.ApartmentProjectProviderID);
            if (provider == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin Provider của dự án.");
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
            var vrExperienceResponses = new List<VRResponse>();
            if (request.VRVideoFiles != null && request.VRVideoFiles.Count > 0)
            {
                foreach (var vrFile in request.VRVideoFiles)
                {
                    var videoUrl = await _firebaseConfig.UploadImage(vrFile);

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
                    vrExperienceResponses.Add(new VRResponse
                    {
                        VideoUrl = vrExperience.video_url_file,
                        Description = vrExperience.description
                    });
                }
            }
            await _unitOfWork.SaveAsync();


            //Quartz
            await _apartmentscheduler.ScheduleApartmentExpiryJob(apartment);

            // Trả về response
            var response = _mapper.Map<CreateApartmentResponse>(apartment);
            response.Images = imageResponses; // Trả về danh sách hình ảnh
            response.ProjectApartmentName = projectApartment.ProjectApartmentName; // Trả thêm tên dự án
            response.VRVideoUrls = vrExperienceResponses; // Danh sách các URL video VR

            // Gửi thông báo đến Provider
            var notificationRequest = new NotificationRequest
            {
                AccountID = provider.AccountID,
                Title = "Căn hộ mới được tạo",
                Description = $"Căn hộ {apartment.ApartmentCode} trong dự án {projectApartment.ProjectApartmentName} đã được tạo thành công.",
                NotificationTypes = NotificationType.Apartment,
                ReferenceId = apartment.ApartmentID
            };
            await _notificationService.CreateNotificationAsync(notificationRequest);

            // Gửi thông báo đến Staff
            var notificationStaff = new NotificationRequest
            {
                AccountID = (Guid)request.AssignedAccountID,
                Title = "Căn hộ mới được tạo",
                Description = $"Căn hộ {apartment.ApartmentCode} trong dự án {projectApartment.ProjectApartmentName} đã được tạo. Vui lòng nhanh chóng kiểm duyệt!",
                NotificationTypes = NotificationType.Apartment,
                ReferenceId = apartment.ApartmentID
            };
            await _notificationService.CreateNotificationAsync(notificationStaff);

            return response;
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
            var vrExperiences = _unitOfWork.VRExperienceRepository.Get(vr => vr.ApartmentID == id);
            var vrExperienceUrls = vrExperiences.Select(vr => vr.video_url_file).ToList();


            bool userLiked = false;
            if (accountId.HasValue)
            {
                userLiked = _unitOfWork.ApartmentInteractionRepository
                    .Get(i => i.AccountID == accountId.Value && i.ApartmentID == id && i.InteractionTypes == InteractionType.Liked)
                    .Any();
            }
            // Ánh xạ kết quả trả về thành response
            var response = _mapper.Map<CreateApartmentResponse>(apartment);
            
            //find deposit value from Project Financial Contract
            var projectfee = _unitOfWork.ProjectFinancialContractRepository
                .Get(pf => pf.ProjectApartmentID == apartment.ProjectApartmentID &&
                    pf.LowestPrice <= apartment.Price &&
                    pf.HighestPrice > apartment.Price
                ).FirstOrDefault();
            if(projectfee != null )
            {
                response.DepositAmount = projectfee.DepositAmount;
            }
            
            //find deposit value from Property Verification
            var property = _unitOfWork.PropertyVerificationRepository
                .Get(pr => pr.ApartmentOwnerApartmentID == apartment.ApartmentID
                ).FirstOrDefault();
            if (property != null )
            {
                response.DepositAmount = property.DepositValue;
            }
            response.ProjectApartmentName = projectApartment.ProjectApartmentName; // Thêm tên dự án
            response.Images = apartmentImages.Select(img => new ApartmentImageResponse
            {
                ApartmentImageID = img.ApartmentImageID,
                Description = img.Description,
                ImageUrl = img.ImageUrl
            }).ToList();
            response.VRVideoUrls = vrExperiences.Select(vr => new VRResponse
            {
                VideoUrl= vr.video_url_file,
                Description = vr.description
            }).ToList();


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
                var vrExperiences = _unitOfWork.VRExperienceRepository.Get(vr => vr.ApartmentID == apartment.ApartmentID);
                var vrExperienceUrls = vrExperiences.Select(vr => vr.video_url_file).ToList();

                // Ánh xạ kết quả trả về thành response
                var response = _mapper.Map<CreateApartmentResponse>(apartment);
                response.ProjectApartmentName = projectApartment.ProjectApartmentName; // Thêm tên dự án
                response.Images = apartmentImages.Select(img => new ApartmentImageResponse
                {
                    ApartmentImageID = img.ApartmentImageID,
                    Description = img.Description,
                    ImageUrl = img.ImageUrl
                }).ToList();
                response.VRVideoUrls = vrExperiences.Select(vr => new VRResponse
                {
                    VideoUrl = vr.video_url_file,
                    Description = vr.description
                }).ToList();



                responseList.Add(response);
            }

            return responseList;
        }


        public async Task<(IEnumerable<CreateApartmentResponse> Apartments, int TotalItem, int TotalPage)> SearchApartments(
            string? apartmentName,
            string? apartmentCode,
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
            Guid? accountOwnerID,
            Guid? accountId,
            Guid? projectId,
            Guid? teamId,
            bool? userLiked = null,
            int pageIndex = 1,
            int pageSize = 5)
        {
            // Nếu có accountOwnerID, lọc danh sách ApartmentID thuộc chủ sở hữu đó
            HashSet<Guid> ownerApartmentIds = new();
            if (accountOwnerID.HasValue)
            {
                ownerApartmentIds = _unitOfWork.ApartmentOwnerApartmentRepository
                    .Get(aoa => aoa.ApartmentOwner.AccountID == accountOwnerID.Value && aoa.ApartmentID.HasValue)
                    .Select(aoa => aoa.ApartmentID.Value)
                    .ToHashSet();

                // Nếu không có căn hộ thuộc sở hữu, trả về danh sách rỗng
                if (!ownerApartmentIds.Any())
                {
                    return (new List<CreateApartmentResponse>(), 0, 0);
                }
            }

            // Lấy tất cả các ApartmentInteraction của người dùng hiện tại có InteractionType là Liked
            var likedApartmentIds = _unitOfWork.ApartmentInteractionRepository
                .Get(i => i.AccountID == accountId && i.InteractionTypes == InteractionType.Liked)
                .Select(i => i.ApartmentID)
                .ToHashSet();

            // Tạo filter expression dựa trên các tham số tìm kiếm
            Expression<Func<Apartment, bool>> filter = a =>
                 (!accountOwnerID.HasValue || ownerApartmentIds.Contains(a.ApartmentID)) &&
                 (string.IsNullOrEmpty(apartmentName) || a.ApartmentName.Contains(apartmentName)) &&
                 (string.IsNullOrEmpty(apartmentCode) || a.ApartmentCode.Contains(apartmentCode)) &&
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
                 (!userLiked.HasValue || (userLiked.Value == likedApartmentIds.Contains(a.ApartmentID))) &&
                 (!teamId.HasValue || (a.ProjectApartment.TeamID == teamId));

            // Tính tổng số lượng căn hộ phù hợp với bộ lọc
            var totalItem = await _unitOfWork.ApartmentRepository.CountAsync(filter);


            // Điều chỉnh cách sắp xếp dựa trên giá trị của minPrice và maxPrice
            Func<IQueryable<Apartment>, IOrderedQueryable<Apartment>>? orderBy = null;
            if (minPrice.HasValue && maxPrice.HasValue)
            {
                orderBy = q => q.OrderBy(a => a.Price); // Sắp xếp tăng dần trong khoảng giá
            }
            else if (minPrice.HasValue)
            {
                orderBy = q => q.OrderBy(a => a.Price); // Sắp xếp tăng dần
            }
            else if (maxPrice.HasValue)
            {
                orderBy = q => q.OrderByDescending(a => a.Price); // Sắp xếp giảm dần
            }
            else
            {
                orderBy = q => q.OrderByDescending(a => a.CreatedDate); // Sắp xếp mặc định
            }

            // Truy vấn từ repository với filter, sắp xếp và phân trang
            var apartments = _unitOfWork.ApartmentRepository.Get(
                filter: filter,
                orderBy: orderBy,
                includeProperties: "ProjectApartment",
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
                var vrExperiences = _unitOfWork.VRExperienceRepository.Get(vr => vr.ApartmentID == apartment.ApartmentID);
                var vrExperienceUrls = vrExperiences.Select(vr => vr.video_url_file).ToList();

                // Map response từ apartment và thêm danh sách hình ảnh và tên dự án
                var response = _mapper.Map<CreateApartmentResponse>(apartment);

                //find deposit value from Project Financial Contract
                var projectfee = _unitOfWork.ProjectFinancialContractRepository
                    .Get(pf => pf.ProjectApartmentID == apartment.ProjectApartmentID &&
                        pf.LowestPrice <= apartment.Price &&
                        pf.HighestPrice > apartment.Price
                    ).FirstOrDefault();
                if (projectfee != null)
                {
                    response.DepositAmount = projectfee.DepositAmount;
                }

                //find deposit value from Property Verification
                var property = _unitOfWork.PropertyVerificationRepository
                    .Get(pr => pr.ApartmentOwnerApartmentID == apartment.ApartmentID
                    ).FirstOrDefault();
                if (property != null)
                {
                    response.DepositAmount = property.DepositValue;
                }

                response.Images = imageResponses; // Trả về danh sách hình ảnh
                response.ProjectApartmentName = projectApartmentName; // Trả thêm tên dự án

                // Xác định trạng thái UserLiked cho từng căn hộ dựa trên likedApartmentIds
                response.UserLiked = likedApartmentIds.Contains(apartment.ApartmentID);
                response.VRVideoUrls = vrExperiences.Select(vr => new VRResponse
                {
                    VideoUrl = vr.video_url_file,
                    Description = vr.description
                }).ToList();
                response.TeamId = projectApartment?.TeamID;

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
                }
            }

            // Upload danh sách video VR mới nếu có
            if (request.VRVideoFiles != null && request.VRVideoFiles.Any())
            {
                foreach (var vrFile in request.VRVideoFiles)
                {
                    var videoUrl = await _firebaseConfig.UploadImage(vrFile);

                    var vrExperience = new VRExperience
                    {
                        VRExperienceID = Guid.NewGuid(),
                        video_url_file = videoUrl,
                        description = vrFile.FileName,
                        CreateDate = CoreHelper.SystemTimeNow,
                        UpdateDate = CoreHelper.SystemTimeNow,
                        ApartmentID = apartment.ApartmentID,
                        AssignedTeamMemberID = apartment.AssignedTeamMemberID.Value
                    };

                    _unitOfWork.VRExperienceRepository.Insert(vrExperience);
                }
            }

            apartment.UpdatedDate = CoreHelper.SystemTimeNow;

            // Lưu các thay đổi
            _unitOfWork.ApartmentRepository.Update(apartment);
            await _unitOfWork.SaveAsync();

            // Gửi thông báo dựa trên PossessionType
            if (apartment.PossessionType == PossessionType.Owner)
            {
                var ownerApartment = _unitOfWork.ApartmentOwnerApartmentRepository.Get(a => a.ApartmentID == apartment.ApartmentID).FirstOrDefault();
                if (ownerApartment != null)
                {
                    var owner = await _unitOfWork.ApartmentOwnerRepository.GetByIdAsync(ownerApartment.ApartmentOwnerID);
                    if (owner != null)
                    {
                        var notificationRequest = new NotificationRequest
                        {
                            AccountID = owner.AccountID,
                            Title = "Cập nhật căn hộ",
                            Description = $"Căn hộ {apartment.ApartmentCode} của bạn đã được cập nhật thành công.",
                            NotificationTypes = NotificationType.Apartment,
                            ReferenceId = apartment.ApartmentID
                        };
                        await _notificationService.CreateNotificationAsync(notificationRequest);
                    }
                }
            }
            else if (apartment.PossessionType == PossessionType.Provider)
            {
                var project = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);
                if (project?.ApartmentProjectProvider != null)
                {
                    var notificationRequest = new NotificationRequest
                    {
                        AccountID = project.ApartmentProjectProvider.AccountID,
                        Title = "Cập nhật căn hộ",
                        Description = $"Căn hộ {apartment.ApartmentCode} thuộc dự án {project.ProjectApartmentName} đã được cập nhật thành công.",
                        NotificationTypes = NotificationType.Apartment,
                        ReferenceId = apartment.ApartmentID
                    };
                    await _notificationService.CreateNotificationAsync(notificationRequest);
                }
            }

            // Trả về response
            return _mapper.Map<CreateApartmentResponse>(apartment);
        }


        //Tạo list căn hộ cùng 1 lúc
        public async Task<IEnumerable<CreateApartmentResponse>> CreateMultipleApartments(CreateMultipleApartmentsRequest request)
        {
            // Kiểm tra dự án căn hộ tồn tại
            var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(request.ProjectApartmentID);
            if (projectApartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy dự án căn hộ.");
            }

            // Lấy thông tin Provider từ dự án
            var provider = await _unitOfWork.ApartmentProjectProviderRepository.GetByIdAsync(projectApartment.ApartmentProjectProviderID);
            if (provider == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin Provider của dự án.");
            }

            // Kiểm tra AccountID và lấy TeamMemberID tương ứng
            var teamMember = _unitOfWork.TeamMemberRepository.Get(tm =>
                tm.AccountID == request.SampleApartment.AssignedAccountID &&
                tm.TeamID == projectApartment.TeamID &&
                tm.IsManager == true
            ).FirstOrDefault();

            if (teamMember == null)
            {
                throw new CustomException.InvalidDataException("Nhân viên được chỉ định không thuộc team quản lý dự án hoặc không phải là staff.");
            }

            var responses = new List<CreateApartmentResponse>();

            for (int i = 0; i < request.Quantity; i++)
            {
                // Tạo đối tượng Apartment từ thông tin mẫu
                Guid apartmentId = Guid.NewGuid();
                var apartment = _mapper.Map<Apartment>(request.SampleApartment);
                apartment.ApartmentID = apartmentId;
                apartment.ApartmentCode = "string";
                apartment.ApartmentStatus = ApartmentStatus.PendingApproval;
                apartment.PossessionType = PossessionType.Provider;
                apartment.CreatedDate = CoreHelper.SystemTimeNow;
                apartment.UpdatedDate = CoreHelper.SystemTimeNow;
                apartment.ProjectApartmentID = request.ProjectApartmentID;
                apartment.AssignedTeamMemberID = teamMember.TeamMemberID;
                apartment.ProjectApartmentID = projectApartment.ProjectApartmentID;

                // Tính giá/m2
                apartment.PricePerSquareMeter = apartment.Area > 0 ? apartment.Price / apartment.Area : 0;

                _unitOfWork.ApartmentRepository.Insert(apartment);
                await _unitOfWork.SaveAsync();

                // Generate mã căn hộ
                apartment.ApartmentCode = await _generateCode.GenerateApartmentCode(apartmentId);
                _unitOfWork.ApartmentRepository.Update(apartment);
                await _unitOfWork.SaveAsync();

                // Upload hình ảnh (nếu có)
                var imageResponses = new List<ApartmentImageResponse>();
                if (request.SampleApartment.Images != null && request.SampleApartment.Images.Count > 0)
                {
                    foreach (var file in request.SampleApartment.Images)
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

                // Upload video VR nếu có
                var vrExperienceResponses = new List<VRResponse>();
                if (request.SampleApartment.VRVideoFiles != null && request.SampleApartment.VRVideoFiles.Count > 0)
                {
                    foreach (var vrFile in request.SampleApartment.VRVideoFiles)
                    {
                        var videoUrl = await _firebaseConfig.UploadImage(vrFile);

                        var vrExperience = new VRExperience
                        {
                            VRExperienceID = Guid.NewGuid(),
                            video_url_file = videoUrl,
                            description = vrFile.FileName,
                            CreateDate = CoreHelper.SystemTimeNow,
                            UpdateDate = CoreHelper.SystemTimeNow,
                            ApartmentID = apartment.ApartmentID,
                            AssignedTeamMemberID = teamMember.TeamMemberID,
                        };

                        _unitOfWork.VRExperienceRepository.Insert(vrExperience);
                        vrExperienceResponses.Add(new VRResponse
                        {
                            VideoUrl = vrExperience.video_url_file,
                            Description = vrExperience.description,
                        });
                    }
                }

                await _unitOfWork.SaveAsync();

                // Map response
                var response = _mapper.Map<CreateApartmentResponse>(apartment);
                response.Images = imageResponses;
                response.ProjectApartmentName = projectApartment.ProjectApartmentName;
                response.VRVideoUrls = vrExperienceResponses;

                responses.Add(response);
            }

            // Gửi thông báo đến Provider
            var notificationRequest = new NotificationRequest
            {
                AccountID = provider.AccountID,
                Title = "Danh sách căn hộ mới được tạo",
                Description = $"{request.Quantity} căn hộ trong dự án {projectApartment.ProjectApartmentName} đã được tạo thành công.",
                NotificationTypes = NotificationType.Apartment,
                ReferenceId = projectApartment.ProjectApartmentID
            };
            await _notificationService.CreateNotificationAsync(notificationRequest);

            return responses;
        }

        public async Task<IEnumerable<CreateApartmentResponse>> PatchApartmentsAsync(List<PatchApartmentRequest> requests)
        {
            if (requests == null || !requests.Any())
            {
                throw new CustomException.InvalidDataException("Danh sách yêu cầu cập nhật không được để trống.");
            }

            var updatedApartments = new List<CreateApartmentResponse>();

            foreach (var request in requests)
            {
                // Lấy căn hộ từ cơ sở dữ liệu
                var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
                if (apartment == null)
                {
                    throw new CustomException.DataNotFoundException($"Không tìm thấy căn hộ với ID: {request.ApartmentID}");
                }

                // Truy vấn ProjectApartment và Provider từ cơ sở dữ liệu
                var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);
                if (projectApartment == null)
                {
                    throw new CustomException.DataNotFoundException("Không tìm thấy dự án căn hộ liên quan.");
                }

                var provider = await _unitOfWork.ApartmentProjectProviderRepository.GetByIdAsync(projectApartment.ApartmentProjectProviderID);
                if (provider == null)
                {
                    throw new CustomException.DataNotFoundException("Không tìm thấy thông tin Provider của dự án.");
                }

                // Cập nhật các thuộc tính nếu có giá trị
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
                apartment.PricePerSquareMeter = request.PricePerSquareMeter ?? (apartment.Area > 0 ? apartment.Price / apartment.Area : apartment.PricePerSquareMeter);
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

                // Kiểm tra AssignedAccountID (nếu có)
                if (request.AssignedAccountID.HasValue)
                {
                    var teamMember = _unitOfWork.TeamMemberRepository.Get(tm =>
                        tm.AccountID == request.AssignedAccountID.Value &&
                        tm.TeamID == apartment.ProjectApartmentID).FirstOrDefault();

                    if (teamMember == null)
                    {
                        throw new CustomException.InvalidDataException($"Nhân viên được chỉ định không hợp lệ cho căn hộ: {apartment.ApartmentName}");
                    }

                    apartment.AssignedTeamMemberID = teamMember.TeamMemberID;
                }

                // Cập nhật hình ảnh mới (nếu có)
                if (request.Images != null && request.Images.Any())
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
                    }
                }

                // Cập nhật video VR mới (nếu có)
                if (request.VRVideoFiles != null && request.VRVideoFiles.Any())
                {
                    foreach (var vrFile in request.VRVideoFiles)
                    {
                        var videoUrl = await _firebaseConfig.UploadImage(vrFile);

                        var vrExperience = new VRExperience
                        {
                            VRExperienceID = Guid.NewGuid(),
                            video_url_file = videoUrl,
                            description = vrFile.FileName,
                            CreateDate = CoreHelper.SystemTimeNow,
                            UpdateDate = CoreHelper.SystemTimeNow,
                            ApartmentID = apartment.ApartmentID,
                            AssignedTeamMemberID = apartment.AssignedTeamMemberID.Value
                        };

                        _unitOfWork.VRExperienceRepository.Insert(vrExperience);
                    }
                }

                apartment.UpdatedDate = CoreHelper.SystemTimeNow;

                // Lưu thay đổi vào cơ sở dữ liệu
                _unitOfWork.ApartmentRepository.Update(apartment);

                if (provider != null)
                {
                    var notificationRequest = new NotificationRequest
                    {
                        AccountID = provider.AccountID,
                        Title = "Cập nhật căn hộ thành công",
                        Description = $"Căn hộ {apartment.ApartmentName} đã được cập nhật thành công.",
                        NotificationTypes = NotificationType.Apartment,
                        ReferenceId = apartment.ApartmentID
                    };
                    await _notificationService.CreateNotificationAsync(notificationRequest);
                }

                // Ánh xạ và thêm vào danh sách phản hồi
                var response = _mapper.Map<CreateApartmentResponse>(apartment);
                updatedApartments.Add(response);
            }

            // Lưu tất cả thay đổi sau khi xử lý xong danh sách
            await _unitOfWork.SaveAsync();

            return updatedApartments;
        }




    }
}
