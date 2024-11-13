using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Response.DepositResponse;
using AVR.Application.ViewModels.Response.Deposits;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
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

        public DepositService(ISettingsService settingsService, IDepositScheduler depositScheduler, IFirebaseConfig firebaseConfig, IUnitOfWork unitOfWork, IMapper mapper, ISendMail sendMail)
        {
            _settingsService = settingsService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _sendMail = sendMail;
            _firebaseConfig = firebaseConfig;
            _depositScheduler = depositScheduler;
        }


        /*public async Task<CreateDepositResponse> RequestDepositAsync(CreateDepositRequest request)
        {
            //if (request.depositPercentage < 10 || request.depositPercentage > 100)
            //{
            //    throw new CustomException.InvalidDataException("Phần trăm deposit phải nằm trong khoảng từ 10% đến 100%.");
            //}

            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin căn hộ!");
            }

            if (apartment.ApartmentStatus != ApartmentStatus.Available)
            {
                throw new CustomException.InvalidDataException("Căn hộ không sẵn sàng để deposit!");
            }

            apartment.ApartmentStatus = ApartmentStatus.Request;




            //var depositPercentageDecimal = (decimal)request.depositPercentage;
            var depositAmount = (double)apartment.Price * 0.1;


            var deposit = _mapper.Map<Deposit>(request);
            deposit.depositPercentage = 10;
            deposit.depositAmount = depositAmount;
            deposit.DepositStatus = DepositStatus.Request;
            deposit.description = $"Đặt cọc cho căn hộ {apartment.ApartmentName}";
            deposit.expiryDate = deposit.CreateDate.AddMinutes(2);
            deposit.CreateDate = DateTimeOffset.Now;
            deposit.UpdateDate = DateTimeOffset.Now;

            _unitOfWork.DepositRepository.Insert(deposit);

            // Upload ảnh CCCD lên Firebase
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
                IdentityCardFrontImage = frontImageUrl,  // Lưu URL ảnh
                IdentityCardBackImage = backImageUrl,    // Lưu URL ảnh
                DepositID = deposit.DepositID
            };

            _unitOfWork.DepositProfileRepository.Insert(depositProfile);
            await _unitOfWork.SaveAsync();
            // Lên lịch job với scheduler
            await _depositScheduler.ScheduleDepositExpiryJob(deposit);

            var depositResponse = _mapper.Map<CreateDepositResponse>(deposit);
            depositResponse.DepositProfile = _mapper.Map<DepositProfileResponse>(depositProfile);

            return depositResponse;
        }*/

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

            apartment.ApartmentStatus = ApartmentStatus.Pending;

            // Lấy depositPercentage và expiryDuration từ cấu hình
            var depositPercentage = await _settingsService.GetDepositPercentageAsync();
            var expiryDuration = await _settingsService.GetExpiryDurationAsync();

            var depositAmount = (double)apartment.Price * (depositPercentage / 100.0);

            var deposit = _mapper.Map<Deposit>(request);
            deposit.depositPercentage = depositPercentage;
            deposit.depositAmount = depositAmount;
            deposit.paymentAmount = depositAmount;
            deposit.DepositStatus = DepositStatus.Pending;
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

            // Lên lịch job với scheduler
            await _depositScheduler.ScheduleDepositExpiryJob(deposit);

            var depositResponse = _mapper.Map<CreateDepositResponse>(deposit);
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

            double percentage = await _settingsService.GetDepositPercentageAsync();
            var newDepositAmount = (double)newApartment.Price * percentage / 100;
            if (newDepositAmount < currentDeposit.depositAmount)
            {
                throw new CustomException.InvalidDataException("The requested apartment is lower in price.");
            }

            // Create a new deposit for the traded apartment
            var tradeDeposit = new Deposit
            {
                DepositID = Guid.NewGuid(),
                AccountID = currentDeposit.AccountID,
                ApartmentID = newApartment.ApartmentID,
                depositPercentage = currentDeposit.depositPercentage,
                depositAmount = newDepositAmount,
                paymentAmount = newDepositAmount - currentDeposit.depositAmount,
                note = $"Trade request from Apartment {currentApartment.ApartmentName} to {newApartment.ApartmentName}",
                DepositStatus = DepositStatus.TradeRequested,
                description = $"Đặt cọc cho căn hộ {newApartment.ApartmentName}",
                CreateDate = CoreHelper.SystemTimeNow,
                UpdateDate = CoreHelper.SystemTimeNow,
                expiryDate = CoreHelper.SystemTimeNow.AddMinutes(await _settingsService.GetExpiryDurationAsync()),
            };

            // Insert the new trade deposit and save to ensure it has a valid DepositID
            _unitOfWork.DepositRepository.Insert(tradeDeposit);
            await _unitOfWork.SaveAsync(); // Save tradeDeposit to generate its DepositID in the database

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
            //await _depositScheduler.ScheduleDepositExpiryJob(tradeDeposit);

            var depositResponse = _mapper.Map<CreateDepositResponse>(tradeDeposit);
            depositResponse.DepositProfile = _mapper.Map<DepositProfileResponse>(newDepositProfile);

            return depositResponse;
        }



        //Accept Trade Deposit
        public async Task<DepositResponse> AcceptTradeDepositAsync(Guid tradeDepositId)
        {
            var tradeDeposit = await _unitOfWork.DepositRepository.GetByIdAsync(tradeDepositId);
            if (tradeDeposit == null || tradeDeposit.DepositStatus != DepositStatus.TradeRequested)
            {
                throw new CustomException.InvalidDataException("Trade deposit request not found or invalid.");
            }

            var currentDeposit = _unitOfWork.DepositRepository.Get(d => d.AccountID == tradeDeposit.AccountID && d.DepositStatus == DepositStatus.TradeRequested).FirstOrDefault();
            if (currentDeposit == null)
            {
                throw new CustomException.DataNotFoundException("Current deposit not found or invalid.");
            }

            // Disable current deposit and mark new one as accepted
            currentDeposit.DepositStatus = DepositStatus.Disable;
            tradeDeposit.DepositStatus = DepositStatus.Accept;
            tradeDeposit.UpdateDate = CoreHelper.SystemTimeNow;
            tradeDeposit.expiryDate = tradeDeposit.UpdateDate.AddMinutes(await _settingsService.GetExpiryDurationAsync());

            // Update apartment statuses
            var oldApartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(currentDeposit.ApartmentID);
            var newApartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(tradeDeposit.ApartmentID);
            if (oldApartment != null) oldApartment.ApartmentStatus = ApartmentStatus.Available;
            if (newApartment != null) newApartment.ApartmentStatus = ApartmentStatus.Pending;

            _unitOfWork.DepositRepository.Update(currentDeposit);
            _unitOfWork.DepositRepository.Update(tradeDeposit);
            _unitOfWork.ApartmentRepository.Update(oldApartment);
            _unitOfWork.ApartmentRepository.Update(newApartment);

            await _unitOfWork.SaveAsync();

            // Lên lịch job với scheduler
            //await _depositScheduler.ScheduleAcceptDepositExpiryJob(tradeDeposit);

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
            return _mapper.Map<DepositResponse>(tradeDeposit);
        }


        //Accept Deposit
        public async Task<DepositResponse> AcceptDepositAsync(Guid depositId)
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
        }

        public async Task<IEnumerable<DepositResponse>> SearchDeposits(
            Guid? depositId,
            Guid? apartmentId,
            Guid? accountId,
            Guid? ownerId,
            DepositStatus? depositStatus,
            int pageIndex = 1,
            int pageSize = 5)
        {
            // Construct filter expression
            Expression<Func<Deposit, bool>> filter = d =>
                (!depositId.HasValue || d.DepositID == depositId) &&
                (!apartmentId.HasValue || d.ApartmentID == apartmentId) &&
                (!accountId.HasValue || d.AccountID == accountId) &&
                (!ownerId.HasValue || d.Apartments.ApartmentOwnerApartment.AccountID == ownerId) &&
                (!depositStatus.HasValue || d.DepositStatus == depositStatus);

            // Retrieve deposits with filter, order by date, and apply pagination
            var deposits = _unitOfWork.DepositRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(d => d.CreateDate),
                pageIndex: pageIndex,
                pageSize: pageSize);

            /*if (!deposits.Any())
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy deposit nào phù hợp với tiêu chí tìm kiếm.");
            }*/

            var depositResponses = _mapper.Map<IEnumerable<DepositResponse>>(deposits).ToList();

            // Map DepositProfile for each deposit
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

        public async Task<int> GetTotalDepositsAsync(DepositStatus? depositStatus = null)
        {
            // Calculate the total count of deposits based on the given status
            var totalDeposits = depositStatus.HasValue
                ? _unitOfWork.DepositRepository.Get(d => d.DepositStatus == depositStatus).Count()
                : _unitOfWork.DepositRepository.GetAll().Count();

            return totalDeposits;
        }
    }
}
