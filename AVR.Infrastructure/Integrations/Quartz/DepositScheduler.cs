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

        public DepositScheduler(IScheduler scheduler)
        {
            _scheduler = scheduler;
        }

        public async Task ScheduleDepositExpiryJob(Deposit deposit)
        {
            var job = JobBuilder.Create<DisableDepositJob>()
                .WithIdentity($"DisableDepositJob-{deposit.DepositID}")
                .UsingJobData("depositId", deposit.DepositID)
                .UsingJobData("apartmentID", deposit.ApartmentID)
                .UsingJobData("accountID", deposit.AccountID)
                .Build();

            var trigger = TriggerBuilder.Create()
                .WithIdentity($"DisableDepositTrigger-{deposit.DepositID}")
                .StartAt(deposit.expiryDate)
                .Build();

            await _scheduler.ScheduleJob(job, trigger);
        }
    }
}
