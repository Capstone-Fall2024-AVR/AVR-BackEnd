using AVR.Application.Services;
using AVR.Domain.CustomException;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using Quartz;


namespace AVR.Infrastructure.Integrations.Quartz
{
    public class DisableDepositJob : IJob
    {
        private readonly IDepositService _depositService;
        private readonly ISendMail _sendMail;
        private readonly IUnitOfWork _unitOfWork;

        public DisableDepositJob(IDepositService depositService, ISendMail sendMail, IUnitOfWork unitOfWork)
        {
            _depositService = depositService;
            _sendMail = sendMail;
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            var depositId = context.JobDetail.JobDataMap.GetGuid("depositId");
            var accountID = context.JobDetail.JobDataMap.GetGuid("accountID");
            var apartmentID = context.JobDetail.JobDataMap.GetGuid("apartmentID");
            // Cập nhật trạng thái Deposit và Apartment
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit != null && deposit.DepositStatus == DepositStatus.Request)
            {
                var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(apartmentID);
                if (apartment == null)
                {
                    throw new CustomException.DataNotFoundException("Không tìm thấy thông tin căn hộ!");
                }
                var account = await _unitOfWork.AccountRepository.GetByIdAsync(accountID);
                if (account == null)
                {
                    throw new CustomException.DataNotFoundException("Không tìm thấy thông tin tài khoản!");
                }
                
                deposit.DepositStatus = DepositStatus.Disable;
                apartment.ApartmentStatus = ApartmentStatus.Available;
                deposit.UpdateDate = CoreHelper.SystemTimeNow;

                await _unitOfWork.SaveAsync();

                // Gửi email xin lỗi khách hàng
                
                if (account != null)
                {
                    await _sendMail.SendDepositDisableEmailAsync(account.Email, account.Name);
                }
            }
        }
    }
}
