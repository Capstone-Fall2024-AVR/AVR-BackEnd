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
    public class ApartmentScheduler : IApartmentScheduler
    {
        private readonly IScheduler _scheduler;

        public ApartmentScheduler(IScheduler scheduler)
        {
            _scheduler = scheduler;
        }

        public async Task ScheduleApartmentExpiryJob(Apartment apartment)
        {
            var job = JobBuilder.Create<DisableApartmentJob>()
                .WithIdentity($"DisableApartmentJob-{apartment.ApartmentID}")
                .UsingJobData("apartmentID", apartment.ApartmentID)
                .Build();

            var trigger = TriggerBuilder.Create()
                .WithIdentity($"DisableApartmentTrigger-{apartment.ApartmentID}")
                .StartAt(apartment.ExpiryDate)
                .Build();

            await _scheduler.ScheduleJob(job, trigger);
        }
    }
}
