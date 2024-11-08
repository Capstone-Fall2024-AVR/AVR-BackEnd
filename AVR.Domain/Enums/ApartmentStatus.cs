using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Enums
{
    public enum ApartmentStatus
    {
        PendingApproval = 0,
        Available = 1,
        Pending = 2,
        Sold = 3,
        Unavailable= 4,
    }
}
