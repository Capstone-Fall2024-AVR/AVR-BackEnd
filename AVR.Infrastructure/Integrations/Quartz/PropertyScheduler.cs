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
            // Tạo JobKey để xác định job chính và job cảnh báo
            var expiryJobKey = new JobKey($"DisablePropertyVerificationDepositJob-{propertyVerification.VerificationID}");
            var warningJobKey = new JobKey($"WarningPropertyVerificationDepositJob-{propertyVerification.VerificationID}");

            // Kiểm tra nếu job chính đã tồn tại, xóa đi và tạo lại
            if (await _scheduler.CheckExists(expiryJobKey))
            {
                await _scheduler.DeleteJob(expiryJobKey);
            }

            // Kiểm tra nếu job cảnh báo đã tồn tại, xóa đi và tạo lại
            if (await _scheduler.CheckExists(warningJobKey))
            {
                await _scheduler.DeleteJob(warningJobKey);
            }

            // Tạo job chính để hết hạn Property Verification
            var expiryJob = JobBuilder.Create<DisablePropertyJob>()
                .WithIdentity(expiryJobKey)
                .UsingJobData("verificationID", propertyVerification.VerificationID)
                .Build();

            var expiryTrigger = TriggerBuilder.Create()
                .WithIdentity($"DisablePropertyVerificationDepositTrigger-{propertyVerification.VerificationID}")
                .StartAt(propertyVerification.ExpiryDate)
                .Build();

            // Lên lịch job hết hạn
            await _scheduler.ScheduleJob(expiryJob, expiryTrigger);

            // Tạo job cảnh báo trước 7 ngày hết hạn
            var warningJob = JobBuilder.Create<WarningPropertyJob>()
                .WithIdentity(warningJobKey)
                .UsingJobData("verificationID", propertyVerification.VerificationID)
                .Build();

            // Tính toán thời điểm cảnh báo (7 ngày trước ngày hết hạn)
            var warningDate = propertyVerification.ExpiryDate.AddDays(-7);

            var warningTrigger = TriggerBuilder.Create()
                .WithIdentity($"WarningPropertyVerificationDepositTrigger-{propertyVerification.VerificationID}")
                .StartAt(warningDate)
                .Build();

            // Lên lịch job cảnh báo trước 7 ngày
            await _scheduler.ScheduleJob(warningJob, warningTrigger);
        }

    }
}
