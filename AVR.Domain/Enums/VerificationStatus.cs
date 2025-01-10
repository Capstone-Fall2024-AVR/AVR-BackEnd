using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Enums
{
    public enum VerificationStatus
    {
        Pending = 1,
        Accepted = 2,
        Expirated = 3,
        Rejected = 4,
        Canceled = 5,
    }
}
