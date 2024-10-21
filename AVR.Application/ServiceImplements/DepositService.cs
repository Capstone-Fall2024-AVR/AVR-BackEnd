using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Response.DepositResponse;
using AVR.Application.ViewModels.Response.Deposits;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;

namespace AVR.Application.ServiceImplements
{
    public class DepositService : IDepositService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ISendMail _sendMail;
        private readonly IFirebaseConfig _firebaseConfig;

        public DepositService(IFirebaseConfig firebaseConfig, IUnitOfWork unitOfWork, IMapper mapper, ISendMail sendMail)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _sendMail = sendMail;
            _firebaseConfig = firebaseConfig;
        }

        public async Task<CreateDepositResponse> RequestDepositAsync(CreateDepositRequest request)
        {
            /*if (request.depositPercentage < 10 || request.depositPercentage > 100)
            {
                throw new CustomException.InvalidDataException("Phần trăm deposit phải nằm trong khoảng từ 10% đến 100%.");
            }*/

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
            var depositAmount = (double)apartment.RecommendedPrice * 0.1;

            var deposit = _mapper.Map<Deposit>(request);
            deposit.depositPercentage = 10;
            deposit.depositAmount = depositAmount;
            deposit.DepositStatus = DepositStatus.Request;
            deposit.description = $"Đặt cọc cho căn hộ {apartment.ApartmentName}";
            deposit.expiryDate = DateTimeOffset.Now.AddDays(3);
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

            var depositResponse = _mapper.Map<CreateDepositResponse>(deposit);
            depositResponse.DepositProfile = _mapper.Map<DepositProfileResponse>(depositProfile);

            return depositResponse;
        }




        public async Task<DepositResponse> AcceptDepositAsync(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin deposit!");
            }
            if (deposit.DepositStatus != DepositStatus.Request)
            {
                throw new CustomException.InvalidDataException("Status deposit không hợp lệ!");
            }
            deposit.DepositStatus = DepositStatus.Accept;
            deposit.UpdateDate = DateTimeOffset.Now;

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

            return _mapper.Map<DepositResponse>(deposit);
        }

        public async Task<DepositResponse> RejectDepositAsync(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin deposit!");
            }
            if (deposit.DepositStatus != DepositStatus.Request)
            {
                throw new CustomException.InvalidDataException("Status deposit không hợp lệ!");
            }
            deposit.DepositStatus = DepositStatus.Reject;
            deposit.UpdateDate = DateTimeOffset.Now;

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


        public async Task DisableDepositAsync(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null || deposit.DepositStatus != DepositStatus.Accept || deposit.DepositStatus != DepositStatus.Request)
            {
                throw new CustomException.DataNotFoundException("Không thể vô hiệu hóa deposit này!");
            }

            deposit.DepositStatus = DepositStatus.Disable;
            deposit.UpdateDate = DateTimeOffset.Now;

            _unitOfWork.DepositRepository.Update(deposit);
            await _unitOfWork.SaveAsync();
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




    }
}
