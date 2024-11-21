using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Interfaces
{
    public interface IPropertyScheduler
    {
        Task SchedulePropertyExpiryJob(PropertyVerification propertyVerification);
    }
}
