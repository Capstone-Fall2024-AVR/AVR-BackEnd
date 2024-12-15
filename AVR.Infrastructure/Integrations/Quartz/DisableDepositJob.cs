using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Notifications;
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
        private readonly INotificationService _notificationService;

        public DisableDepositJob(IDepositService depositService, ISendMail sendMail, IUnitOfWork unitOfWork, INotificationService notificationService)
        {
            _depositService = depositService;
            _sendMail = sendMail;
            _unitOfWork = unitOfWork;
            _notificationService = notificationService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            var depositId = context.JobDetail.JobDataMap.GetGuid("depositId");
            var accountID = context.JobDetail.JobDataMap.GetGuid("accountID");
            var apartmentID = context.JobDetail.JobDataMap.GetGuid("apartmentID");
            // Cập nhật trạng thái Deposit và Apartment
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
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
            if (deposit != null && (deposit.DepositStatus == DepositStatus.Pending || deposit.DepositStatus == DepositStatus.Accept))
            {
                deposit.DepositStatus = DepositStatus.Disable;
                apartment.ApartmentStatus = ApartmentStatus.Available;
                deposit.UpdateDate = CoreHelper.SystemTimeNow;

                _unitOfWork.DepositRepository.Update(deposit);
                _unitOfWork.ApartmentRepository.Update(apartment);

                await _unitOfWork.SaveAsync();

                // Gửi thông báo cho CustomerId
                var notificationRequest = new NotificationRequest
                {
                    AccountID = deposit.AccountID,
                    Title = "Yêu cầu thanh toán bị quá hạn!",
                    Description = $"Yêu cầu đặt chỗ căn hộ {deposit.Apartments.ApartmentCode} đã quá thời gian thanh toán!",
                    NotificationTypes = NotificationType.Deposit,
                    ReferenceId = deposit.DepositID
                };

                await _notificationService.CreateNotificationAsync(notificationRequest);

                // Gửi email xin lỗi khách hàng

                if (account != null)
                {
                    await _sendMail.SendDepositDisableEmailAsync(account.Email, account.Name);
                }
            }
        }
    }
}
