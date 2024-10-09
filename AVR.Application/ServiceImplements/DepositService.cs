using AutoMapper;
using AVR.Application.Services;
using AVR.Application.Utils.Pagination;
using AVR.Application.ViewModels.Request.Deposits;
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

        public DepositService(IUnitOfWork unitOfWork, IMapper mapper, ISendMail sendMail)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _sendMail = sendMail;
        }

        public async Task<DepositResponse> RequestDepositAsync(CreateDepositRequest request)
        {
            if (request.depositPercentage <= 10 || request.depositPercentage > 100)
            {
                throw new CustomException.InvalidDataException("Phần trăm deposit phải nằm trong khoảng từ 10% đến 100%.");
            }

            // Lấy thông tin Apartment để tính depositAmount
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin căn hộ!");
            }

            // Loại bỏ ký tự không phải số và dấu phẩy từ chuỗi recommendedPrice
            var cleanedPrice = new string(apartment.recommendedPrice.Where(c => char.IsDigit(c) || c == '.').ToArray());

            // Chuyển đổi chuỗi thành số thực
            if (!double.TryParse(cleanedPrice, out var recommendedPrice))
            {
                throw new CustomException.InvalidDataException("Định dạng giá không hợp lệ.");
            }

            var depositAmount = recommendedPrice * (request.depositPercentage / 100);

            // Tạo deposit mới từ request
            var deposit = _mapper.Map<Deposit>(request);
            deposit.depositAmount = depositAmount;
            deposit.DepositStatus = DepositStatus.Request;
            deposit.CreateDate = DateTimeOffset.Now;
            deposit.UpdateDate = DateTimeOffset.Now;

            // Lưu deposit vào cơ sở dữ liệu
            _unitOfWork.DepositRepository.Insert(deposit);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<DepositResponse>(deposit);
        }


        public async Task<DepositResponse> AcceptDepositAsync(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin deposit!");
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
            var emailMessage = $"Deposit của bạn đã được chấp nhận. Số tiền: {deposit.depositAmount}";
            await _sendMail.SendEmailAsync(account.Email, "Deposit Accepted", emailMessage);

            return _mapper.Map<DepositResponse>(deposit);
        }

        public async Task<DepositResponse> RejectDepositAsync(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin deposit!");
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
            var emailMessage = "Deposit của bạn đã bị từ chối.";
            await _sendMail.SendEmailAsync(account.Email, "Deposit Rejected", emailMessage);

            return _mapper.Map<DepositResponse>(deposit);
        }

        public async Task DisableDepositAsync(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null || deposit.DepositStatus != DepositStatus.Accept)
            {
                throw new CustomException.DataNotFoundException("Không thể vô hiệu hóa deposit này!");
            }

            deposit.DepositStatus = DepositStatus.Disable;
            deposit.UpdateDate = DateTimeOffset.Now;

            _unitOfWork.DepositRepository.Update(deposit);
            await _unitOfWork.SaveAsync();
        }

        //Get Deposit by ID
        public async Task<DepositResponse> GetDepositByIdAsync(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy deposit này.");
            }

            return _mapper.Map<DepositResponse>(deposit);
        }

        //Get all deposits
        public async Task<IEnumerable<DepositResponse>> GetAllDepositsAsync()
        {
            var deposits = await _unitOfWork.DepositRepository.GetAllAsync();
            if (deposits == null || !deposits.Any())
            {
                throw new CustomException.DataNotFoundException("Không có deposit nào.");
            }

            return _mapper.Map<IEnumerable<DepositResponse>>(deposits);
        }


        //Get Deposits by Apartment ID
        public async Task<IEnumerable<DepositResponse>> GetDepositsByApartmentIdAsync(Guid apartmentId)
        {
            var deposits = await _unitOfWork.DepositRepository.GetAllAsync();
            var filteredDeposits = deposits.Where(d => d.ApartmentID == apartmentId);

            if (!filteredDeposits.Any())
            {
                throw new CustomException.DataNotFoundException("Không có deposit nào cho căn hộ này.");
            }

            return _mapper.Map<IEnumerable<DepositResponse>>(filteredDeposits);
        }


        //Get Deposits by Account ID
        public async Task<IEnumerable<DepositResponse>> GetDepositsByAccountIdAsync(Guid accountId)
        {
            var deposits = await _unitOfWork.DepositRepository.GetAllAsync();
            var filteredDeposits = deposits.Where(d => d.AccountID == accountId);

            if (!filteredDeposits.Any())
            {
                throw new CustomException.DataNotFoundException("Không có deposit nào cho tài khoản này.");
            }

            return _mapper.Map<IEnumerable<DepositResponse>>(filteredDeposits);
        }


    }
}
