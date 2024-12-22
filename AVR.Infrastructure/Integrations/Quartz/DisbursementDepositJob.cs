using AVR.Application.Services;
using AVR.Domain.CustomException;
using AVR.Domain.Interfaces;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.Quartz
{
    public class DisbursementDepositJob : IJob
    {
        private readonly IDepositService _depositService;
        private readonly IUnitOfWork _unitOfWork;

        public DisbursementDepositJob(IDepositService depositService, IUnitOfWork unitOfWork)
        {
            _depositService = depositService;
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            var transactionId = context.JobDetail.JobDataMap.GetGuid("transactionId");
            var depositId = context.JobDetail.JobDataMap.GetGuid("depositId");

            var transaction = await _unitOfWork.TransactionRepository.GetByIdAsync(transactionId);
            if (transaction == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin hóa đơn!");
            }

            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin đặt cọc!");
            }
            var staffID = deposit.StaffID;
            if(transaction.TransactionStatus == Domain.Enums.TransactionStatus.Completed)
            {
                await _depositService.DisburseDepositAsync(depositId, (Guid)staffID, Domain.Enums.DisbursementStatus.ProcessingDisbursement);
            }
        }
    }
}
