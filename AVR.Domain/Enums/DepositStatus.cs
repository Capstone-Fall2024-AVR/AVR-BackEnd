using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Enums
{
    public enum DepositStatus
    {
        Pending = 1,
        Accept = 2,
        Reject = 3,
        Disable = 4,
        PaymentFailed = 5,
        Paid = 6,
        TradeRequested = 7,
        Complete = 8
    }
}
