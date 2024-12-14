using AutoMapper;
using AVR.Application.Services;
using AVR.Application.Utils.GenerateCode;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Response.DepositResponse;
using AVR.Application.ViewModels.Response.Deposits;
using AVR.Application.ViewModels.Response.Projects;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using System.Linq.Expressions;

namespace AVR.Application.ServiceImplements
{
    public class DepositService : IDepositService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ISendMail _sendMail;
        private readonly IFirebaseConfig _firebaseConfig;
        private readonly IDepositScheduler _depositScheduler;
        private readonly ISettingsService _settingsService;
        private readonly IGenerateCode _generateCode;
        private readonly INotificationService _notificationService;

        public DepositService(IGenerateCode generateCode, ISettingsService settingsService, IDepositScheduler depositScheduler, IFirebaseConfig firebaseConfig, IUnitOfWork unitOfWork, IMapper mapper, ISendMail sendMail, INotificationService notificationService)
        {
            _settingsService = settingsService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _sendMail = sendMail;
            _firebaseConfig = firebaseConfig;
            _depositScheduler = depositScheduler;
            _generateCode = generateCode;
            _notificationService = notificationService;
        }

        public async Task<CreateDepositResponse> RequestDepositAsync(CreateDepositRequest request)
        {
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin căn hộ!");
            }

            if (apartment.ApartmentStatus != ApartmentStatus.Available)
            {
                throw new CustomException.InvalidDataException("Căn hộ không sẵn sàng để deposit!");
            }

            var depositAmount = 0.00;
            var BrokerageFee = 0.00;
            var CommissionFee = 0.00;
            var SecurityDeposit = 0.00;

            //find deposit value from Project Financial Contract
            var projectfee = _unitOfWork.ProjectFinancialContractRepository
                .Get(pf => pf.ProjectApartmentID == apartment.ProjectApartmentID &&
                    pf.LowestPrice <= apartment.Price &&
                    pf.HighestPrice > apartment.Price
                ).FirstOrDefault();

            if (projectfee != null)
            {
                depositAmount = (double)projectfee.DepositAmount;
                BrokerageFee = (double)projectfee.BrokerageFee;
                CommissionFee = (double)projectfee.CommissionFee;
            }

            //find deposit value from Property Verification
            var property = _unitOfWork.PropertyVerificationRepository
                .Get(pr => pr.ApartmentOwnerApartmentID == apartment.ApartmentID
                ).FirstOrDefault();

            if (property != null)
            {
                depositAmount = (double)property.DepositValue;
                BrokerageFee = (double)property.BrokerageFee;
                CommissionFee = (double)property.CommissionRate;
            }

            SecurityDeposit = depositAmount - (BrokerageFee + depositAmount * CommissionFee / 100);
            apartment.ApartmentStatus = ApartmentStatus.Pending;

            // Lấy depositPercentage và expiryDuration từ cấu hình
            var depositPercentage = await _settingsService.GetDepositPercentageAsync();
            var expiryDuration = await _settingsService.GetExpiryDurationAsync();

            //depositAmount = (double)apartment.Price * (depositPercentage / 100.0);

            var deposit = _mapper.Map<Deposit>(request);
            deposit.depositPercentage = depositPercentage;
            deposit.DepositCode = "";
            deposit.DisbursementStatus = DisbursementStatus.PendingDisbursement;
            deposit.depositAmount = depositAmount;
            deposit.paymentAmount = depositAmount;
            deposit.BrokerageFee = BrokerageFee;
            deposit.CommissionFee = CommissionFee;
            deposit.DepositStatus = DepositStatus.Pending;
            deposit.DepositType = DepositType.Deposit;
            deposit.description = $"Đặt cọc cho căn hộ {apartment.ApartmentName}";
            deposit.expiryDate = deposit.CreateDate.AddMinutes(expiryDuration);
            deposit.CreateDate = CoreHelper.SystemTimeNow;
            deposit.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.DepositRepository.Insert(deposit);

            var frontImageUrl = await _firebaseConfig.UploadImage(request.DepositProfile.IdentityCardFrontImage);
            var backImageUrl = await _firebaseConfig.UploadImage(request.DepositProfile.IdentityCardBackImage);

            var depositProfile = new DepositProfile
            {
                FullName = request.DepositProfile.FullName,
                IdentityCardNumber = request.DepositProfile.IdentityCardNumber,
                DateOfIssue = request.DepositProfile.DateOfIssue,
                DateOfBirth = request.DepositProfile.DateOfBirth,
                Nationality = request.DepositProfile.Nationality,
                Address = request.DepositProfile.Address,
                Email = request.DepositProfile.Email,
                PhoneNumber = request.DepositProfile.PhoneNumber,
                IdentityCardFrontImage = frontImageUrl,
                IdentityCardBackImage = backImageUrl,
                DepositID = deposit.DepositID
            };

            _unitOfWork.DepositProfileRepository.Insert(depositProfile);
            await _unitOfWork.SaveAsync();

            deposit.DepositCode = await _generateCode.GenerateDepositCode(deposit.DepositID);
            _unitOfWork.DepositRepository.Update(deposit);
            await _unitOfWork.SaveAsync();

            // Lên lịch job với scheduler
            await _depositScheduler.ScheduleDepositExpiryJob(deposit);

            // Gửi thông báo cho StaffId
            var project = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);
            var team = _unitOfWork.TeamMemberRepository.Get(
                t => t.TeamID == project.TeamID && t.IsManager == true
                ).FirstOrDefault();

            var notificationRequest = new NotificationRequest
            {
                AccountID = team.AccountID,
                Title = "Có một đặt cọc mới!",
                Description = $"Căn hộ {apartment.ApartmentCode} đã được đặt cọc từ khách hàng {deposit.Accounts.Name}.",
                NotificationTypes = NotificationType.Deposit,
                ReferenceId = deposit.DepositID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            var depositResponse = _mapper.Map<CreateDepositResponse>(deposit);
            depositResponse.SecurityDeposit = SecurityDeposit;
            depositResponse.ApartmentCode = apartment.ApartmentCode;
            depositResponse.DepositProfile = _mapper.Map<DepositProfileResponse>(depositProfile);

            return depositResponse;
        }

        public async Task<CreateDepositResponse> RequestDepositV2Async(CreateDepositRequest request)
        {
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin căn hộ!");
            }

            if (apartment.ApartmentStatus != ApartmentStatus.Available)
            {
                throw new CustomException.InvalidDataException("Căn hộ không sẵn sàng để deposit!");
            }

            var depositAmount = 0.00;

            //find deposit value from Project Financial Contract
            var projectfee = _unitOfWork.ProjectFinancialContractRepository
                .Get(pf => pf.ProjectApartmentID == apartment.ProjectApartmentID &&
                    pf.LowestPrice <= apartment.Price &&
                    pf.HighestPrice > apartment.Price
                ).FirstOrDefault();

            if (projectfee != null)
            {
                depositAmount = (double)projectfee.DepositAmount;
            }

            //find deposit value from Property Verification
            var property = _unitOfWork.PropertyVerificationRepository
                .Get(pr => pr.ApartmentOwnerApartmentID == apartment.ApartmentID
                ).FirstOrDefault();

            if (property != null)
            {
                depositAmount = (double)property.DepositValue;
                
            }

            apartment.ApartmentStatus = ApartmentStatus.Pending;

            // Lấy depositPercentage và expiryDuration từ cấu hình
            var depositPercentage = await _settingsService.GetDepositPercentageAsync();
            var expiryDuration = await _settingsService.GetExpiryDurationAsync();


            var deposit = _mapper.Map<Deposit>(request);
            deposit.depositPercentage = depositPercentage;
            deposit.DepositCode = "";
            deposit.DisbursementStatus = DisbursementStatus.PendingDisbursement;
            deposit.depositAmount = depositAmount;
            deposit.paymentAmount = depositAmount;
            deposit.DepositStatus = DepositStatus.Pending;
            deposit.DepositType = DepositType.Deposit;
            deposit.description = $"Đặt cọc cho căn hộ {apartment.ApartmentName}";
            deposit.expiryDate = deposit.CreateDate.AddMinutes(expiryDuration);
            deposit.CreateDate = CoreHelper.SystemTimeNow;
            deposit.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.DepositRepository.Insert(deposit);

            var frontImageUrl = await _firebaseConfig.UploadImage(request.DepositProfile.IdentityCardFrontImage);
            var backImageUrl = await _firebaseConfig.UploadImage(request.DepositProfile.IdentityCardBackImage);

            var depositProfile = new DepositProfile
            {
                FullName = request.DepositProfile.FullName,
                IdentityCardNumber = request.DepositProfile.IdentityCardNumber,
                DateOfIssue = request.DepositProfile.DateOfIssue,
                DateOfBirth = request.DepositProfile.DateOfBirth,
                Nationality = request.DepositProfile.Nationality,
                Address = request.DepositProfile.Address,
                Email = request.DepositProfile.Email,
                PhoneNumber = request.DepositProfile.PhoneNumber,
                IdentityCardFrontImage = frontImageUrl,
                IdentityCardBackImage = backImageUrl,
                DepositID = deposit.DepositID
            };

            _unitOfWork.DepositProfileRepository.Insert(depositProfile);
            await _unitOfWork.SaveAsync();

            deposit.DepositCode = await _generateCode.GenerateDepositCode(deposit.DepositID);
            _unitOfWork.DepositRepository.Update(deposit);
            await _unitOfWork.SaveAsync();

            // Lên lịch job với scheduler
            await _depositScheduler.ScheduleDepositExpiryJob(deposit);

            // Gửi thông báo cho StaffId
            var project = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);
            var team = _unitOfWork.TeamMemberRepository.Get(
                t => t.TeamID == project.TeamID && t.IsManager == true
                ).FirstOrDefault();

            var notificationRequest = new NotificationRequest
            {
                AccountID = team.AccountID,
                Title = "Có một yêu cầu đặt chỗ mới!",
                Description = $"Căn hộ {apartment.ApartmentCode} đã được đặt cọc từ khách hàng {deposit.Accounts.Name}.",
                NotificationTypes = NotificationType.Deposit,
                ReferenceId = deposit.DepositID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            var depositResponse = _mapper.Map<CreateDepositResponse>(deposit);
            depositResponse.ApartmentCode = apartment.ApartmentCode;
            depositResponse.DepositProfile = _mapper.Map<DepositProfileResponse>(depositProfile);

            return depositResponse;
        }

        public async Task<CreateDepositResponse> RequestTradeDepositAsync(Guid currentDepositId, string newApartmentCode)
        {
            // Fetch the current deposit
            var currentDeposit = await _unitOfWork.DepositRepository.GetByIdAsync(currentDepositId);

            if (currentDeposit == null || currentDeposit.DepositStatus != DepositStatus.Paid)
            {
                throw new CustomException.DataNotFoundException("Invalid or non-active deposit for trading.");
            }

            var currentApartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(currentDeposit.ApartmentID);
            if (currentApartment == null)
            {
                throw new CustomException.DataNotFoundException("The apartment not found");
            }

            // Fetch the new apartment to trade into
            var newApartment = _unitOfWork.ApartmentRepository.Get(a => a.ApartmentCode == newApartmentCode).FirstOrDefault();
            if (newApartment == null || newApartment.ApartmentStatus != ApartmentStatus.Available)
            {
                throw new CustomException.InvalidDataException("The requested apartment is not available.");
            }

            if (currentApartment.ProjectApartmentID != newApartment.ProjectApartmentID)
            {
                throw new CustomException.InvalidDataException("Hai căn hộ không cùng một dự án!");
            }

            var newDepositAmount = 0.00;
            var depositAmount = 0.00;
            var BrokerageFee = 0.00;
            var CommissionFee = 0.00;
            var SecurityDeposit = 0.00;
            var procedureFee = await _settingsService.GetProcedureFeeAsync();

            //find deposit value from Project Financial Contract
            var projectfee = _unitOfWork.ProjectFinancialContractRepository
                .Get(pf => pf.ProjectApartmentID == newApartment.ProjectApartmentID &&
                pf.LowestPrice <= newApartment.Price &&
                    pf.HighestPrice > newApartment.Price
                ).FirstOrDefault();

            if (projectfee != null)
            {
                newDepositAmount = (double)projectfee.DepositAmount;
                BrokerageFee = (double)projectfee.BrokerageFee;
                CommissionFee = (double)projectfee.CommissionFee;

                if (newDepositAmount == currentDeposit.depositAmount)
                {
                    depositAmount = procedureFee;
                }
                else if (newDepositAmount < currentDeposit.depositAmount)
                {
                    throw new CustomException.InvalidDataException("The requested apartment is lower in price.");
                }
                else
                {
                    depositAmount = newDepositAmount - currentDeposit.depositAmount + procedureFee;
                }
            }

            //find deposit value from Property Verification
            var property = _unitOfWork.PropertyVerificationRepository
                .Get(pr => pr.ApartmentOwnerApartmentID == newApartment.ApartmentID
                ).FirstOrDefault();

            if (property != null)
            {
                newDepositAmount = (double)property.DepositValue;
                BrokerageFee = (double)property.BrokerageFee;
                CommissionFee = (double)property.CommissionRate;

                if (newDepositAmount == currentDeposit.depositAmount)
                {
                    //depositAmount = (double)projectfee.BrokerageFee + (newDepositAmount * ((double)projectfee.CommissionFee_1/100));
                    depositAmount = procedureFee;
                }
                else if (newDepositAmount < currentDeposit.depositAmount)
                {
                    throw new CustomException.InvalidDataException("The requested apartment is lower in price.");
                }
                else
                {
                    depositAmount = newDepositAmount - currentDeposit.depositAmount + procedureFee;
                }
            }

            SecurityDeposit = newDepositAmount - (BrokerageFee + newDepositAmount * CommissionFee / 100);

            // Create a new deposit for the traded apartment
            var tradeDeposit = new Deposit
            {
                DepositID = Guid.NewGuid(),
                DepositCode = "",
                OldDepositCode = currentDeposit.DepositCode,
                AccountID = currentDeposit.AccountID,
                ApartmentID = newApartment.ApartmentID,
                depositPercentage = currentDeposit.depositPercentage,
                depositAmount = newDepositAmount,
                paymentAmount = depositAmount,
                BrokerageFee = BrokerageFee,
                CommissionFee = CommissionFee,
                TradeFee = procedureFee,
                note = $"Trade request from Apartment {currentApartment.ApartmentName} to {newApartment.ApartmentName}",
                DepositStatus = DepositStatus.TradeRequested,
                DepositType = DepositType.Trade,
                DisbursementStatus = DisbursementStatus.PendingDisbursement,
                description = $"Trade request from Apartment {currentApartment.ApartmentName} to {newApartment.ApartmentName}",
                CreateDate = CoreHelper.SystemTimeNow,
                UpdateDate = CoreHelper.SystemTimeNow,
                expiryDate = CoreHelper.SystemTimeNow.AddMinutes(await _settingsService.GetExpiryDurationAsync()),
            };

            // Insert the new trade deposit and save to ensure it has a valid DepositID
            _unitOfWork.DepositRepository.Insert(tradeDeposit);
            await _unitOfWork.SaveAsync(); // Save tradeDeposit to generate its DepositID in the database
            tradeDeposit.DepositCode = await _generateCode.GenerateDepositCode(tradeDeposit.DepositID);
            _unitOfWork.DepositRepository.Update(tradeDeposit);
            await _unitOfWork.SaveAsync();

            // Copy the deposit profile from the existing deposit and create a new one
            var depositProfile = _unitOfWork.DepositProfileRepository.Get(d => d.DepositID == currentDeposit.DepositID).FirstOrDefault();

            if (depositProfile == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy Deposit Profile");
            }
            var newDepositProfile = new DepositProfile
            {
                DepositID = tradeDeposit.DepositID,
                FullName = depositProfile.FullName,
                IdentityCardNumber = depositProfile.IdentityCardNumber,
                DateOfIssue = depositProfile.DateOfIssue,
                DateOfBirth = depositProfile.DateOfBirth,
                Nationality = depositProfile.Nationality,
                Address = depositProfile.Address,
                Email = depositProfile.Email,
                PhoneNumber = depositProfile.PhoneNumber,
                IdentityCardFrontImage = depositProfile.IdentityCardFrontImage,
                IdentityCardBackImage = depositProfile.IdentityCardBackImage
            };

            _unitOfWork.DepositProfileRepository.Insert(newDepositProfile);

            // Update the current deposit to indicate it is in a trade request
            currentDeposit.DepositStatus = DepositStatus.TradeRequested;
            _unitOfWork.DepositRepository.Update(currentDeposit);

            await _unitOfWork.SaveAsync();
            // Lên lịch job với scheduler
            await _depositScheduler.ScheduleDepositExpiryJob(tradeDeposit);

            // Gửi thông báo cho StaffId
            var project = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(newApartment.ProjectApartmentID);
            var team = _unitOfWork.TeamMemberRepository.Get(
                t => t.TeamID == project.TeamID && t.IsManager == true
                ).FirstOrDefault();

            var notificationRequest = new NotificationRequest
            {
                AccountID = team.AccountID,
                Title = "Có một yêu cầu trao đổi căn hộ!",
                Description = $"Yêu cầu chuyển đổi từ căn hộ {currentApartment.ApartmentCode} sang căn hộ {newApartment.ApartmentCode} từ khách hàng {tradeDeposit.Accounts.Name}",
                NotificationTypes = NotificationType.Deposit,
                ReferenceId = tradeDeposit.DepositID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            var depositResponse = _mapper.Map<CreateDepositResponse>(tradeDeposit);
            depositResponse.SecurityDeposit = SecurityDeposit;
            depositResponse.ApartmentCode = newApartment.ApartmentCode;
            depositResponse.DepositProfile = _mapper.Map<DepositProfileResponse>(newDepositProfile);

            return depositResponse;
        }

        public async Task<CreateDepositResponse> RequestTradeDepositV2Async(Guid currentDepositId, string newApartmentCode)
        {
            // Fetch the current deposit
            var currentDeposit = await _unitOfWork.DepositRepository.GetByIdAsync(currentDepositId);

            if (currentDeposit == null || currentDeposit.DepositStatus != DepositStatus.Paid)
            {
                throw new CustomException.DataNotFoundException("Invalid or non-active deposit for trading.");
            }

            var currentApartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(currentDeposit.ApartmentID);
            if (currentApartment == null)
            {
                throw new CustomException.DataNotFoundException("The apartment not found");
            }

            // Fetch the new apartment to trade into
            var newApartment = _unitOfWork.ApartmentRepository.Get(a => a.ApartmentCode == newApartmentCode).FirstOrDefault();
            if (newApartment == null || newApartment.ApartmentStatus != ApartmentStatus.Available)
            {
                throw new CustomException.InvalidDataException("The requested apartment is not available.");
            }

            if (currentApartment.ProjectApartmentID != newApartment.ProjectApartmentID)
            {
                throw new CustomException.InvalidDataException("Hai căn hộ không cùng một dự án!");
            }

            var newDepositAmount = 0.00;
            var depositAmount = 0.00;
            
            var procedureFee = await _settingsService.GetProcedureFeeAsync();

            //find deposit value from Project Financial Contract
            var projectfee = _unitOfWork.ProjectFinancialContractRepository
                .Get(pf => pf.ProjectApartmentID == newApartment.ProjectApartmentID &&
                pf.LowestPrice <= newApartment.Price &&
                    pf.HighestPrice > newApartment.Price
                ).FirstOrDefault();

            if (projectfee != null)
            {
                newDepositAmount = (double)projectfee.BrokerageFee;

                if (newDepositAmount == currentDeposit.depositAmount)
                {
                    depositAmount = procedureFee;
                }
                else if (newDepositAmount < currentDeposit.depositAmount)
                {
                    throw new CustomException.InvalidDataException("The requested apartment is lower in price.");
                }
                else
                {
                    depositAmount = newDepositAmount - currentDeposit.depositAmount + procedureFee;
                }
            }

            //find deposit value from Property Verification
            var property = _unitOfWork.PropertyVerificationRepository
                .Get(pr => pr.ApartmentOwnerApartmentID == newApartment.ApartmentID
                ).FirstOrDefault();

            if (property != null)
            {
                newDepositAmount = (double)property.BrokerageFee;
                
                if (newDepositAmount == currentDeposit.depositAmount)
                {
                    depositAmount = procedureFee;
                }
                else if (newDepositAmount < currentDeposit.depositAmount)
                {
                    throw new CustomException.InvalidDataException("The requested apartment is lower in price.");
                }
                else
                {
                    depositAmount = newDepositAmount - currentDeposit.depositAmount + procedureFee;
                }
            }


            // Create a new deposit for the traded apartment
            var tradeDeposit = new Deposit
            {
                DepositID = Guid.NewGuid(),
                DepositCode = "",
                OldDepositCode = currentDeposit.DepositCode,
                AccountID = currentDeposit.AccountID,
                ApartmentID = newApartment.ApartmentID,
                depositPercentage = currentDeposit.depositPercentage,
                depositAmount = newDepositAmount,
                paymentAmount = depositAmount,
                TradeFee = procedureFee,
                note = $"Trade request from Apartment {currentApartment.ApartmentName} to {newApartment.ApartmentName}",
                DepositStatus = DepositStatus.TradeRequested,
                DepositType = DepositType.Trade,
                DisbursementStatus = DisbursementStatus.PendingDisbursement,
                description = $"Trade request from Apartment {currentApartment.ApartmentName} to {newApartment.ApartmentName}",
                CreateDate = CoreHelper.SystemTimeNow,
                UpdateDate = CoreHelper.SystemTimeNow,
                expiryDate = CoreHelper.SystemTimeNow.AddMinutes(await _settingsService.GetExpiryDurationAsync()),
            };

            // Insert the new trade deposit and save to ensure it has a valid DepositID
            _unitOfWork.DepositRepository.Insert(tradeDeposit);
            await _unitOfWork.SaveAsync(); // Save tradeDeposit to generate its DepositID in the database
            tradeDeposit.DepositCode = await _generateCode.GenerateDepositCode(tradeDeposit.DepositID);
            _unitOfWork.DepositRepository.Update(tradeDeposit);
            await _unitOfWork.SaveAsync();

            // Copy the deposit profile from the existing deposit and create a new one
            var depositProfile = _unitOfWork.DepositProfileRepository.Get(d => d.DepositID == currentDeposit.DepositID).FirstOrDefault();

            if (depositProfile == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy Deposit Profile");
            }
            var newDepositProfile = new DepositProfile
            {
                DepositID = tradeDeposit.DepositID,
                FullName = depositProfile.FullName,
                IdentityCardNumber = depositProfile.IdentityCardNumber,
                DateOfIssue = depositProfile.DateOfIssue,
                DateOfBirth = depositProfile.DateOfBirth,
                Nationality = depositProfile.Nationality,
                Address = depositProfile.Address,
                Email = depositProfile.Email,
                PhoneNumber = depositProfile.PhoneNumber,
                IdentityCardFrontImage = depositProfile.IdentityCardFrontImage,
                IdentityCardBackImage = depositProfile.IdentityCardBackImage
            };

            _unitOfWork.DepositProfileRepository.Insert(newDepositProfile);

            // Update the current deposit to indicate it is in a trade request
            currentDeposit.DepositStatus = DepositStatus.TradeRequested;
            _unitOfWork.DepositRepository.Update(currentDeposit);

            await _unitOfWork.SaveAsync();
            // Lên lịch job với scheduler
            await _depositScheduler.ScheduleDepositExpiryJob(tradeDeposit);

            // Gửi thông báo cho StaffId
            var project = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(newApartment.ProjectApartmentID);
            var team = _unitOfWork.TeamMemberRepository.Get(
                t => t.TeamID == project.TeamID && t.IsManager == true
                ).FirstOrDefault();

            var notificationRequest = new NotificationRequest
            {
                AccountID = team.AccountID,
                Title = "Có một yêu cầu trao đổi căn hộ!",
                Description = $"Yêu cầu chuyển đổi từ căn hộ {currentApartment.ApartmentCode} sang căn hộ {newApartment.ApartmentCode} từ khách hàng {tradeDeposit.Accounts.Name}",
                NotificationTypes = NotificationType.Deposit,
                ReferenceId = tradeDeposit.DepositID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            var depositResponse = _mapper.Map<CreateDepositResponse>(tradeDeposit);
            depositResponse.ApartmentCode = newApartment.ApartmentCode;
            depositResponse.DepositProfile = _mapper.Map<DepositProfileResponse>(newDepositProfile);

            return depositResponse;
        }

        //Accept Trade Deposit
        public async Task<DepositResponse> AcceptTradeDepositAsync(Guid tradeDepositId, Guid StaffID)
        {
            var tradeDeposit = await _unitOfWork.DepositRepository.GetByIdAsync(tradeDepositId);
            if (tradeDeposit == null || tradeDeposit.DepositStatus != DepositStatus.TradeRequested)
            {
                throw new CustomException.InvalidDataException("Trade deposit request not found or invalid.");
            }

            var currentDeposit = _unitOfWork.DepositRepository.Get(d => d.DepositCode == tradeDeposit.OldDepositCode && d.AccountID == tradeDeposit.AccountID && d.DepositStatus == DepositStatus.TradeRequested).FirstOrDefault();
            if (currentDeposit == null)
            {
                throw new CustomException.DataNotFoundException("Current deposit not found or invalid.");
            }

            // Disable current deposit and mark new one as accepted
            currentDeposit.DepositStatus = DepositStatus.Disable;
            _unitOfWork.DepositRepository.Update(currentDeposit);
            await _unitOfWork.SaveAsync();

            tradeDeposit.DepositStatus = DepositStatus.Accept;
            tradeDeposit.UpdateDate = CoreHelper.SystemTimeNow;
            tradeDeposit.StaffID = StaffID;
            tradeDeposit.expiryDate = tradeDeposit.UpdateDate.AddMinutes(await _settingsService.GetExpiryDurationAsync());
            _unitOfWork.DepositRepository.Update(tradeDeposit);
            await _unitOfWork.SaveAsync();

            // Update apartment statuses
            var oldApartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(currentDeposit.ApartmentID);
            if (oldApartment != null)
            {
                oldApartment.ApartmentStatus = ApartmentStatus.Available;
                _unitOfWork.ApartmentRepository.Update(oldApartment);
            }

            var newApartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(tradeDeposit.ApartmentID);
            if (newApartment != null)
            {
                newApartment.ApartmentStatus = ApartmentStatus.Pending;
                _unitOfWork.ApartmentRepository.Update(newApartment);
            }

            await _unitOfWork.SaveAsync();

            // Lên lịch job với scheduler
            await _depositScheduler.ScheduleAcceptDepositExpiryJob(tradeDeposit);

            // Gửi thông báo cho CustomerId
            var notificationRequest = new NotificationRequest
            {
                AccountID = tradeDeposit.AccountID,
                Title = "Yêu cầu trao đổi đã được chấp nhận!",
                Description = $"Yêu cầu chuyển đổi căn hộ {newApartment.ApartmentCode} đã được chấp nhận!",
                NotificationTypes = NotificationType.Deposit,
                ReferenceId = tradeDeposit.DepositID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            return _mapper.Map<DepositResponse>(tradeDeposit);
        }

        //Reject Trade Deposit
        public async Task<DepositResponse> RejectTradeDepositAsync(Guid tradeDepositId)
        {
            var tradeDeposit = await _unitOfWork.DepositRepository.GetByIdAsync(tradeDepositId);
            if (tradeDeposit == null || tradeDeposit.DepositStatus != DepositStatus.TradeRequested)
            {
                throw new CustomException.InvalidDataException("Trade deposit request not found or invalid.");
            }

            // Reject the trade request and revert the original deposit status
            tradeDeposit.DepositStatus = DepositStatus.Reject;
            var originalDeposit = _unitOfWork.DepositRepository.Get(d => d.AccountID == tradeDeposit.AccountID && d.DepositStatus == DepositStatus.TradeRequested).FirstOrDefault();
            if (originalDeposit != null)
            {
                originalDeposit.DepositStatus = DepositStatus.Accept;
                _unitOfWork.DepositRepository.Update(originalDeposit);
            }

            _unitOfWork.DepositRepository.Update(tradeDeposit);
            await _unitOfWork.SaveAsync();

            // Gửi thông báo cho CustomerId
            var notificationRequest = new NotificationRequest
            {
                AccountID = tradeDeposit.AccountID,
                Title = "Yêu cầu đặt chỗ đã bị từ chối!",
                Description = $"Yêu cầu chuyển đổi căn hộ {tradeDeposit.Apartments.ApartmentCode} đã bị từ chối!",
                NotificationTypes = NotificationType.Deposit,
                ReferenceId = tradeDeposit.DepositID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            return _mapper.Map<DepositResponse>(tradeDeposit);
        }


        //Accept Deposit
        public async Task<DepositResponse> AcceptDepositAsync(Guid depositId, Guid StaffID)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin deposit!");
            }
            if (deposit.DepositStatus != DepositStatus.Pending)
            {
                throw new CustomException.InvalidDataException("Status deposit không hợp lệ!");
            }
            deposit.DepositStatus = DepositStatus.Accept;
            deposit.UpdateDate = CoreHelper.SystemTimeNow;
            deposit.expiryDate = deposit.UpdateDate.AddMinutes(await _settingsService.GetExpiryDurationAsync());
            deposit.StaffID = StaffID;

            _unitOfWork.DepositRepository.Update(deposit);
            await _unitOfWork.SaveAsync();

            // Lấy email của người yêu cầu deposit
            var account = await _unitOfWork.AccountRepository.GetByIdAsync(deposit.AccountID);
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy tài khoản người dùng!");
            }

            // Gửi email thông báo chấp nhận deposit
            await _sendMail.SendDepositAcceptedEmailAsync(account.Email, account.Name, deposit.depositAmount);

            // Lên lịch job với scheduler
            await _depositScheduler.ScheduleAcceptDepositExpiryJob(deposit);

            // Gửi thông báo cho CustomerId
            var notificationRequest = new NotificationRequest
            {
                AccountID = deposit.AccountID,
                Title = "Yêu cầu đặt chỗ đã được chấp nhận!",
                Description = $"Yêu cầu đatẹ chỗ căn hộ {deposit.Apartments.ApartmentCode} đã được chấp nhận!",
                NotificationTypes = NotificationType.Deposit,
                ReferenceId = deposit.DepositID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            return _mapper.Map<DepositResponse>(deposit);
        }

        //Reject Deposit
        public async Task<DepositResponse> RejectDepositAsync(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin deposit!");
            }
            if (deposit.DepositStatus != DepositStatus.Pending)
            {
                throw new CustomException.InvalidDataException("Status deposit không hợp lệ!");
            }
            deposit.DepositStatus = DepositStatus.Reject;
            deposit.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.DepositRepository.Update(deposit);
            await _unitOfWork.SaveAsync();

            // Lấy email của người yêu cầu deposit
            var account = await _unitOfWork.AccountRepository.GetByIdAsync(deposit.AccountID);
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy tài khoản người dùng!");
            }

            // Gửi email thông báo từ chối deposit
            await _sendMail.SendDepositRejectedEmailAsync(account.Email, account.Name);

            // Gửi thông báo cho CustomerId
            var notificationRequest = new NotificationRequest
            {
                AccountID = deposit.AccountID,
                Title = "Yêu cầu đặt chỗ đã bị từ chối!",
                Description = $"Yêu cầu đặt cọc căn hộ {deposit.Apartments.ApartmentCode} đã được chấp nhận!",
                NotificationTypes = NotificationType.Deposit,
                ReferenceId = deposit.DepositID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);

            return _mapper.Map<DepositResponse>(deposit);
        }

        //Disable Deposit
        public async Task DisableDepositAsync(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null || deposit.DepositStatus != DepositStatus.Accept || deposit.DepositStatus != DepositStatus.Pending)
            {
                throw new CustomException.DataNotFoundException("Không thể vô hiệu hóa deposit này!");
            }

            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(deposit.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin căn hộ!");
            }

            deposit.DepositStatus = DepositStatus.Disable;
            deposit.UpdateDate = CoreHelper.SystemTimeNow;

            apartment.ApartmentStatus = ApartmentStatus.Available;
            apartment.UpdatedDate = CoreHelper.SystemTimeNow;

            _unitOfWork.DepositRepository.Update(deposit);
            _unitOfWork.ApartmentRepository.Update(apartment);
            await _unitOfWork.SaveAsync();

            // Gửi thông báo cho StaffId
            var project = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);
            var team = _unitOfWork.TeamMemberRepository.Get(
                t => t.TeamID == project.TeamID && t.IsManager == true
                ).FirstOrDefault();

            var notificationRequest = new NotificationRequest
            {
                AccountID = team.AccountID,
                Title = "Có một yêu cầu đặt cọc căn hộ bị vô hiệu hóa!",
                Description = $"Yêu cầu đặt cọc căn hộ {apartment.ApartmentCode} từ {deposit.Accounts.Name} bị vô hiệu hóa",
                NotificationTypes = NotificationType.Deposit,
                ReferenceId = deposit.DepositID
            };

            await _notificationService.CreateNotificationAsync(notificationRequest);
        }

        public async Task<(IEnumerable<DepositResponse> Deposits, int TotalItems, int TotalPages)> SearchDeposits(
            Guid? depositId,
            string? depositCode,
            string? apartmentCode,
            Guid? apartmentId,
            Guid? accountId,
            Guid? ownerId,
            Guid? teamId,
            Guid? projectApartmentId, // Added parameter
            DepositStatus? depositStatus,
            int pageIndex = 1,
            int pageSize = 5)
        {
            // Construct filter expression
            Expression<Func<Deposit, bool>> filter = d =>
                (!depositId.HasValue || d.DepositID == depositId) &&
                (string.IsNullOrEmpty(depositCode) || d.DepositCode == depositCode)&&
                (string.IsNullOrEmpty(apartmentCode) || d.Apartments.ApartmentCode.Contains(apartmentCode)) &&
                (!apartmentId.HasValue || d.ApartmentID == apartmentId) &&
                (!accountId.HasValue || d.AccountID == accountId) &&
                (!depositStatus.HasValue || d.DepositStatus == depositStatus) &&
                (!teamId.HasValue || d.Apartments.ProjectApartment.TeamID == teamId) &&
                (!projectApartmentId.HasValue || d.Apartments.ProjectApartmentID == projectApartmentId); // New filter condition

            // Get total item count
            int totalItems = await _unitOfWork.DepositRepository.CountAsync(filter);

            // Calculate total pages
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Retrieve deposits with filter, order by date, and apply pagination
            var deposits = _unitOfWork.DepositRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(d => d.CreateDate),
                pageIndex: pageIndex,
                pageSize: pageSize,
                includeProperties: "Apartments"); // Ensure Apartments are included for filtering by ProjectApartmentID

            var depositResponses = _mapper.Map<IEnumerable<DepositResponse>>(deposits).ToList();

            // Map additional details for each deposit
            foreach (var depositResponse in depositResponses)
            {
                var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositResponse.DepositID);
                if (deposit != null)
                {
                    var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(deposit.ApartmentID);
                    if (apartment != null)
                    {
                        depositResponse.ApartmentCode = apartment.ApartmentCode;
                    }
                    depositResponse.SecurityDeposit = (double)(deposit.depositAmount - (deposit?.BrokerageFee + deposit.depositAmount * deposit?.CommissionFee / 100));
                }
                var depositProfile = _unitOfWork.DepositProfileRepository.Get(d => d.DepositID == depositResponse.DepositID);
                if (depositProfile != null)
                {
                    depositResponse.DepositProfile = _mapper.Map<List<DepositProfileResponse>>(depositProfile);
                }
            }

            return (depositResponses, totalItems, totalPages);
        }

        // Hàm: Get Deposit by ID
        public async Task<DepositResponse> GetDepositByIdAsync(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy deposit này.");
            }

            var depositResponse = _mapper.Map<DepositResponse>(deposit);

            var depositProfile = _unitOfWork.DepositProfileRepository.Get(d => d.DepositID == depositId);
            if (depositProfile != null)
            {
                depositResponse.DepositProfile = _mapper.Map<List<DepositProfileResponse>>(depositProfile);
            }

            return depositResponse;
        }

        // Hàm: Get all deposits có lọc theo DepositStatus
        public async Task<IEnumerable<DepositResponse>> GetAllDepositsAsync(DepositStatus? depositStatus = null)
        {
            // Lấy danh sách deposit, có lọc theo status nếu có
            var deposits = depositStatus.HasValue
                ? _unitOfWork.DepositRepository.Get(d => d.DepositStatus == depositStatus)
                : await _unitOfWork.DepositRepository.GetAllAsync();

            if (deposits == null || !deposits.Any())
            {
                throw new CustomException.DataNotFoundException("Không có deposit nào.");
            }

            // Ánh xạ danh sách deposit sang DepositResponse
            var depositResponses = _mapper.Map<IEnumerable<DepositResponse>>(deposits).ToList();

            // Lấy thông tin DepositProfile cho từng deposit
            foreach (var depositResponse in depositResponses)
            {
                var depositProfile = _unitOfWork.DepositProfileRepository.Get(d => d.DepositID == depositResponse.DepositID);
                if (depositProfile != null)
                {
                    depositResponse.DepositProfile = _mapper.Map<List<DepositProfileResponse>>(depositProfile);
                }
            }

            return depositResponses;
        }

        // Hàm: Get Deposits by Apartment ID có lọc theo DepositStatus
        public async Task<IEnumerable<DepositResponse>> GetDepositsByApartmentIdAsync(Guid apartmentId, DepositStatus? depositStatus = null)
        {
            var deposits = depositStatus.HasValue
                ? _unitOfWork.DepositRepository.Get(d => d.ApartmentID == apartmentId && d.DepositStatus == depositStatus)
                : _unitOfWork.DepositRepository.Get(d => d.ApartmentID == apartmentId);

            if (deposits == null || !deposits.Any())
            {
                throw new CustomException.DataNotFoundException("Không có deposit nào cho căn hộ này.");
            }

            // Ánh xạ danh sách deposit sang DepositResponse
            var depositResponses = _mapper.Map<IEnumerable<DepositResponse>>(deposits).ToList();

            // Lấy thông tin DepositProfile cho từng deposit
            foreach (var depositResponse in depositResponses)
            {
                var depositProfile = _unitOfWork.DepositProfileRepository.Get(d => d.DepositID == depositResponse.DepositID);
                if (depositProfile != null)
                {
                    depositResponse.DepositProfile = _mapper.Map<List<DepositProfileResponse>>(depositProfile);
                }
            }

            return depositResponses;
        }

        // Hàm: Get Deposits by Account ID có lọc theo DepositStatus
        public async Task<IEnumerable<DepositResponse>> GetDepositsByAccountIdAsync(Guid accountId, DepositStatus? depositStatus = null)
        {
            var deposits = depositStatus.HasValue
                ? _unitOfWork.DepositRepository.Get(d => d.AccountID == accountId && d.DepositStatus == depositStatus)
                : _unitOfWork.DepositRepository.Get(d => d.AccountID == accountId);

            if (deposits == null || !deposits.Any())
            {
                throw new CustomException.DataNotFoundException("Không có deposit nào cho tài khoản này.");
            }

            // Ánh xạ danh sách deposit sang DepositResponse
            var depositResponses = _mapper.Map<IEnumerable<DepositResponse>>(deposits).ToList();

            // Lấy thông tin DepositProfile cho từng deposit
            foreach (var depositResponse in depositResponses)
            {
                var depositProfile = _unitOfWork.DepositProfileRepository.Get(d => d.DepositID == depositResponse.DepositID);
                if (depositProfile != null)
                {
                    depositResponse.DepositProfile = _mapper.Map<List<DepositProfileResponse>>(depositProfile);
                }
            }

            return depositResponses;
        }

        public async Task<DepositResponse> DisburseDepositAsync(Guid depositId, Guid StaffID)
        {
            // Retrieve the deposit by ID
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new CustomException.DataNotFoundException("Deposit not found.");
            }

            // Check if the deposit is eligible for disbursement
            if (deposit.DisbursementStatus != DisbursementStatus.PendingDisbursement)
            {
                throw new CustomException.InvalidDataException("The deposit is not in a state for disbursement.");
            }

            // Update the disbursement status and assign the team member
            deposit.DisbursementStatus = DisbursementStatus.DisbursementCompleted;
            deposit.StaffID = StaffID;
            deposit.UpdateDate = CoreHelper.SystemTimeNow;

            // Save changes to the database
            _unitOfWork.DepositRepository.Update(deposit);
            await _unitOfWork.SaveAsync();

            // Map the updated deposit to the response object
            var depositResponse = _mapper.Map<DepositResponse>(deposit);

            return depositResponse;
        }


        public async Task<int> GetTotalDepositsAsync(DepositStatus? depositStatus = null)
        {
            // Calculate the total count of deposits based on the given status
            var totalDeposits = depositStatus.HasValue
                ? _unitOfWork.DepositRepository.Get(d => d.DepositStatus == depositStatus).Count()
                : _unitOfWork.DepositRepository.GetAll().Count();

            return totalDeposits;
        }

        public async Task<string> ExportDetailedFinancialDataAsync(Guid projectId)
        {
            // Retrieve the project with related data
            var project = _unitOfWork.ProjectApartmentRepository
                .Get(p => p.ProjectApartmentID == projectId, includeProperties: "Apartments.Deposits")
                .FirstOrDefault();

            if (project == null)
            {
                throw new CustomException.DataNotFoundException("Project not found.");
            }

            // Generate the Excel file
            using (var workbook = new XLWorkbook())
            {
                // **Worksheet 1: Project Overview**
                var projectWorksheet = workbook.Worksheets.Add("Project Overview");

                // Add project metadata
                projectWorksheet.Cell(1, 1).Value = "Project Name:";
                projectWorksheet.Cell(1, 2).Value = project.ProjectApartmentName;
                projectWorksheet.Cell(2, 1).Value = "Project Code:";
                projectWorksheet.Cell(2, 2).Value = project.ProjectCode;
                projectWorksheet.Cell(3, 1).Value = "Location:";
                projectWorksheet.Cell(3, 2).Value = project.Address;
                projectWorksheet.Cell(4, 1).Value = "Total Apartments:";
                projectWorksheet.Cell(4, 2).Value = project.Apartments.Count;

                // **Worksheet 2: Financial Details**
                var detailsWorksheet = workbook.Worksheets.Add("Financial Details");

                // Add headers for apartment and deposit data
                detailsWorksheet.Cell(1, 1).Value = "Apartment Code";
                detailsWorksheet.Cell(1, 2).Value = "Apartment Name";
                detailsWorksheet.Cell(1, 3).Value = "Apartment Area (m²)";
                detailsWorksheet.Cell(1, 4).Value = "Apartment Price";
                detailsWorksheet.Cell(1, 5).Value = "Deposit Code";
                detailsWorksheet.Cell(1, 6).Value = "Deposit Amount";
                detailsWorksheet.Cell(1, 7).Value = "Brokerage Fee";
                detailsWorksheet.Cell(1, 8).Value = "Commission Fee (%)";
                detailsWorksheet.Cell(1, 9).Value = "Security Deposit";
                detailsWorksheet.Cell(1, 10).Value = "Trade Fee";
                detailsWorksheet.Cell(1, 11).Value = "Payment Amount";
                detailsWorksheet.Cell(1, 12).Value = "Deposit Status";
                detailsWorksheet.Cell(1, 13).Value = "Last Updated Date";
                //detailsWorksheet.Cell(1, 14).Value = "Expiry Date";

                // Populate apartment and deposit data
                int currentRow = 2;
                foreach (var apartment in project.Apartments)
                {
                    foreach (var deposit in apartment.Deposits.Where(d => d.UpdateDate.AddMinutes(3) <= CoreHelper.SystemTimeNow && d.DepositStatus == DepositStatus.Paid))
                    {
                        var commissionFeePercentage = deposit.CommissionFee / 100;
                        var securityDeposit = deposit.depositAmount - (deposit.BrokerageFee + deposit.depositAmount * commissionFeePercentage);

                        detailsWorksheet.Cell(currentRow, 1).Value = apartment.ApartmentCode;
                        detailsWorksheet.Cell(currentRow, 2).Value = apartment.ApartmentName;
                        detailsWorksheet.Cell(currentRow, 3).Value = apartment.Area;
                        detailsWorksheet.Cell(currentRow, 4).Value = apartment.Price;
                        detailsWorksheet.Cell(currentRow, 5).Value = deposit.DepositCode;
                        detailsWorksheet.Cell(currentRow, 6).Value = deposit.depositAmount;
                        detailsWorksheet.Cell(currentRow, 7).Value = deposit.BrokerageFee;
                        detailsWorksheet.Cell(currentRow, 8).Value = deposit.CommissionFee;
                        detailsWorksheet.Cell(currentRow, 9).Value = securityDeposit; // Calculated Security Deposit
                        detailsWorksheet.Cell(currentRow, 10).Value = deposit.TradeFee ?? 0; // Trade Fee, default to 0 if null
                        detailsWorksheet.Cell(currentRow, 11).Value = deposit.paymentAmount;
                        detailsWorksheet.Cell(currentRow, 12).Value = deposit.DepositStatus.ToString();
                        detailsWorksheet.Cell(currentRow, 13).Value = deposit.UpdateDate.ToString();
                        //detailsWorksheet.Cell(currentRow, 14).Value = deposit.expiryDate.ToString();

                        currentRow++;
                    }
                }

                // **Worksheet 3: Financial Summary**
                var summaryWorksheet = workbook.Worksheets.Add("Financial Summary");

                // Add summary headers
                summaryWorksheet.Cell(1, 1).Value = "Metric";
                summaryWorksheet.Cell(1, 2).Value = "Value";

                // Calculate financial metrics
                var eligibleDeposits = project.Apartments
                    .SelectMany(a => a.Deposits)
                    .Where(d => d.UpdateDate.AddMinutes(3) <= CoreHelper.SystemTimeNow);

                var totalDepositAmount = eligibleDeposits.Sum(d => d.depositAmount);
                var totalBrokerageFee = eligibleDeposits.Sum(d => d.BrokerageFee);
                var totalTradeFee = eligibleDeposits.Sum(d => d.TradeFee ?? 0);
                //var totalPayment = eligibleDeposits.Sum(d => d.paymentAmount);
                //var totalCommissionFee = eligibleDeposits.Sum(d => d.CommissionFee);
                var totalSecurityDeposit = eligibleDeposits
                    .Sum(d => d.depositAmount - (d.BrokerageFee + d.depositAmount * (d.CommissionFee / 100)));

                // Populate financial summary
                summaryWorksheet.Cell(2, 1).Value = "Total Deposit Amount";
                summaryWorksheet.Cell(2, 2).Value = totalDepositAmount;
                summaryWorksheet.Cell(3, 1).Value = "Total Brokerage Fee";
                summaryWorksheet.Cell(3, 2).Value = totalBrokerageFee;
                summaryWorksheet.Cell(4, 1).Value = "Total Trade Fee";
                summaryWorksheet.Cell(4, 2).Value = totalTradeFee;
                summaryWorksheet.Cell(5, 1).Value = "Total Security Deposit";
                summaryWorksheet.Cell(5, 2).Value = totalSecurityDeposit;
                summaryWorksheet.Cell(5, 1).Value = "Total Payment";
                summaryWorksheet.Cell(5, 2).Value = totalDepositAmount + totalTradeFee;


                // Save the file
                var filePath = $"FinancialData_{project.ProjectApartmentName}_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
                var tempPath = Path.Combine(Path.GetTempPath(), filePath);
                workbook.SaveAs(tempPath);

                // **Update deposits meeting criteria**
                foreach (var deposit in eligibleDeposits)
                {
                    deposit.DepositStatus = DepositStatus.Exported; // Update status to Exported
                    _unitOfWork.DepositRepository.Update(deposit);
                }

                await _unitOfWork.SaveAsync();

                return tempPath; // Return file path for download
            }
        }

        public async Task<ProjectDisbursementResponse> GetProjectDisbursementDetailsAsync(Guid projectId)
        {
            // Fetch the project with related apartments and deposits
            var project = _unitOfWork.ProjectApartmentRepository
                .Get(p => p.ProjectApartmentID == projectId, includeProperties: "Apartments.Deposits.Transactions,Apartments.Deposits.DepositProfile")
                .FirstOrDefault();

            if (project == null)
            {
                throw new CustomException.DataNotFoundException("Project not found.");
            }

            // Separate apartments into those with deposits and those without
            var apartmentsWithDeposits = project.Apartments
                .Where(a => a.Deposits.Any(d => d.DepositStatus == DepositStatus.Paid))
                .Select(a => new ApartmentDepositInfo
                {
                    ApartmentId = a.ApartmentID,
                    ApartmentCode = a.ApartmentCode,
                    ApartmentName = a.ApartmentName,
                    TotalDepositAmount = a.Deposits.Where(d => d.DepositStatus == DepositStatus.Paid).Sum(d => d.depositAmount),
                    DepositCode = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.DepositCode,
                    TransactionNo = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.Transactions?.TransactionNo,
                    DepositDate = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.CreateDate,

                    // Map fields from DepositProfile
                    FullName = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.DepositProfile?.FullName,
                    IdentityCardNumber = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.DepositProfile?.IdentityCardNumber,
                    DateOfIssue = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.DepositProfile?.DateOfIssue ?? DateTime.MinValue,
                    DateOfBirth = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.DepositProfile?.DateOfBirth ?? DateTime.MinValue,
                    Nationality = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.DepositProfile?.Nationality,
                    Address = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.DepositProfile?.Address,
                    Email = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.DepositProfile?.Email,
                    PhoneNumber = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.DepositProfile?.PhoneNumber,
                    IdentityCardFrontImage = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.DepositProfile?.IdentityCardFrontImage,
                    IdentityCardBackImage = a.Deposits.FirstOrDefault(d => d.DepositStatus == DepositStatus.Paid)?.DepositProfile?.IdentityCardBackImage
                })
                .ToList();

            var apartmentsWithoutDeposits = project.Apartments
                .Where(a => !a.Deposits.Any(d => d.DepositStatus == DepositStatus.Paid))
                .Select(a => new ApartmentInfo
                {
                    ApartmentId = a.ApartmentID,
                    ApartmentCode = a.ApartmentCode,
                    ApartmentName = a.ApartmentName
                })
                .ToList();

            // Calculate total deposit amount for apartments with deposits
            var totalDepositAmount = apartmentsWithDeposits.Sum(a => a.TotalDepositAmount);

            // Map to response
            var response = new ProjectDisbursementResponse
            {
                ProjectId = project.ProjectApartmentID,
                ProjectName = project.ProjectApartmentName,
                ProjectCode = project.ProjectCode,
                ApartmentsWithDeposits = apartmentsWithDeposits,
                ApartmentsWithoutDeposits = apartmentsWithoutDeposits,
                TotalDepositAmount = totalDepositAmount
            };

            return response;
        }




    }

}

