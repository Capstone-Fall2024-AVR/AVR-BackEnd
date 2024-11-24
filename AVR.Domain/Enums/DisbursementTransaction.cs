using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Enums
{
    public enum DisbursementTransaction
    {
        Pending = 0,       // Disbursement is initiated but not completed
        Completed = 1,     // Disbursement is successfully completed
        Failed = 2         // Disbursement failed
    }
}
