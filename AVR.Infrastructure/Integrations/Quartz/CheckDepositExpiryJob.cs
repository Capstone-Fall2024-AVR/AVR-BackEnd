using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.Quartz
{
    public class CheckDepositExpiryJob : IJob
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISendMail _sendMail;

        public CheckDepositExpiryJob(IUnitOfWork unitOfWork, ISendMail sendMail)
        {
            _unitOfWork = unitOfWork;
            _sendMail = sendMail;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            var expiredDeposits = _unitOfWork.DepositRepository
                .Get(d => d.expiryDate <= DateTimeOffset.Now && d.DepositStatus != DepositStatus.Disable)
                .ToList();

            foreach (var deposit in expiredDeposits)
            {
                deposit.DepositStatus = DepositStatus.Disable;
                deposit.UpdateDate = DateTimeOffset.Now;

                var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(deposit.ApartmentID);
                if (apartment != null)
                {
                    apartment.ApartmentStatus = ApartmentStatus.Available;
                }

                if (deposit.Transactions != null)
                {
                    deposit.Transactions.TransactionStatus = TransactionStatus.Failed;
                }

                // Gửi email thông báo
                var account = await _unitOfWork.AccountRepository.GetByIdAsync(deposit.AccountID);
                if (account != null)
                {
                    await _sendMail.SendDepositRejectedEmailAsync(account.Email, account.Name);
                }

                _unitOfWork.DepositRepository.Update(deposit);
            }

            await _unitOfWork.SaveAsync();
        }
    }
}
