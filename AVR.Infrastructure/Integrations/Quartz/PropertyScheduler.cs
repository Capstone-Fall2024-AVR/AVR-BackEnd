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
    public class PropertyScheduler : IPropertyScheduler
    {
        private readonly IScheduler _scheduler;

        public PropertyScheduler(IScheduler scheduler)
        {
            _scheduler = scheduler;
        }

        public async Task SchedulePropertyExpiryJob(PropertyVerification propertyVerification)
        {
            // Tạo JobKey dựa trên PropertyVerificationID
            var jobKey = new JobKey($"DisablePropertyVerificationDepositJob-{propertyVerification.VerificationID}");

            // Kiểm tra nếu job với JobKey này đã tồn tại
            if (await _scheduler.CheckExists(jobKey))
            {
                // Nếu đã tồn tại, xóa job cũ trước khi tạo lại
                await _scheduler.DeleteJob(jobKey);
            }

            // Tạo job mới với JobKey duy nhất
            var job = JobBuilder.Create<DisablePropertyJob>()
                .WithIdentity(jobKey)
                .UsingJobData("verificationID", propertyVerification.VerificationID)
                .Build();

            // Tạo trigger cho job, bắt đầu tại thời điểm expiryDate của deposit
            var trigger = TriggerBuilder.Create()
                .WithIdentity($"DisablePropertyVerificationDepositJob-{propertyVerification.VerificationID}")
                .StartAt(propertyVerification.ExpiryDate)
                .Build();

            // Lên lịch job với trigger
            await _scheduler.ScheduleJob(job, trigger);
        }
    }
}
