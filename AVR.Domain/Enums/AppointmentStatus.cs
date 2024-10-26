using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Enums
{
    public enum AppointmentStatus
    {
        Confirmed = 1,
        InProcessing = 2,
        Done = 3,
        Canceled = 4,
        Updated = 5,
    }
}
