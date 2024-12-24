using AVR.Application.Services;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.Quartz
{
    public class DepositScheduler : IDepositScheduler
    {
        private readonly IScheduler _scheduler;
        private readonly ISettingsService _settingsService;

        public DepositScheduler(IScheduler scheduler, ISettingsService settingsService)
        {
            _scheduler = scheduler;
            _settingsService = settingsService;
        }

        public async Task ScheduleDepositExpiryJob(Deposit deposit)
        {
            // Tạo JobKey dựa trên DepositID
            var jobKey = new JobKey($"DisableDepositJob-{deposit.DepositID}");

            // Kiểm tra nếu job với JobKey này đã tồn tại
            if (await _scheduler.CheckExists(jobKey))
            {
                // Nếu đã tồn tại, xóa job cũ trước khi tạo lại
                await _scheduler.DeleteJob(jobKey);
            }

            // Tạo job mới với JobKey duy nhất
            var job = JobBuilder.Create<DisableDepositJob>()
                .WithIdentity(jobKey)
                .UsingJobData("depositId", deposit.DepositID)
                .UsingJobData("apartmentID", deposit.ApartmentID)
                .UsingJobData("accountID", deposit.AccountID)
                .Build();

            // Tạo trigger cho job, bắt đầu tại thời điểm expiryDate của deposit
            var trigger = TriggerBuilder.Create()
                .WithIdentity($"DisableDepositTrigger-{deposit.DepositID}")
                .StartAt(deposit.expiryDate)
                .Build();

            // Lên lịch job với trigger
            await _scheduler.ScheduleJob(job, trigger);
        }

        public async Task ScheduleAcceptDepositExpiryJob(Deposit deposit)
        {
            // Tạo JobKey dựa trên DepositID
            var jobKey = new JobKey($"DisableAcceptDepositJob-{deposit.DepositID}");

            // Kiểm tra nếu job với JobKey này đã tồn tại
            if (await _scheduler.CheckExists(jobKey))
            {
                // Nếu đã tồn tại, xóa job cũ trước khi tạo lại
                await _scheduler.DeleteJob(jobKey);
            }

            // Tạo job mới với JobKey duy nhất
            var job = JobBuilder.Create<DisableDepositJob>()
                .WithIdentity(jobKey)
                .UsingJobData("depositId", deposit.DepositID)
                .UsingJobData("apartmentID", deposit.ApartmentID)
                .UsingJobData("accountID", deposit.AccountID)
                .Build();

            // Tạo trigger cho job, bắt đầu tại thời điểm expiryDate của deposit
            var trigger = TriggerBuilder.Create()
                .WithIdentity($"DisableAcceptDepositJob-{deposit.DepositID}")
                .StartAt(deposit.expiryDate)
                .Build();

            // Lên lịch job với trigger
            await _scheduler.ScheduleJob(job, trigger);
        }

        public async Task ScheduleDisbursementDepositJob(Transaction transaction)
        {
            // Tạo JobKey dựa trên DepositID
            var jobKey = new JobKey($"DisbursementDepositJob-{transaction.TransactionID}");

            // Kiểm tra nếu job với JobKey này đã tồn tại
            if (await _scheduler.CheckExists(jobKey))
            {
                // Nếu đã tồn tại, xóa job cũ trước khi tạo lại
                await _scheduler.DeleteJob(jobKey);
            }

            // Tạo job mới với JobKey duy nhất
            var job = JobBuilder.Create<DisbursementDepositJob>()
                .WithIdentity(jobKey)
                .UsingJobData("transactionId", transaction.TransactionID)
                .UsingJobData("depositId", transaction.DepositID)
                .Build();

            // Tạo trigger cho job, bắt đầu tại thời điểm expiryDate của deposit
            var trigger = TriggerBuilder.Create()
                .WithIdentity($"DisbursementDepositJob-{transaction.TransactionID}")
                .StartAt(transaction.UpdateDate.AddMinutes(await _settingsService.GetDisbursementDurationAsync()))
                .Build();

            // Lên lịch job với trigger
            await _scheduler.ScheduleJob(job, trigger);
        }
    }
}
