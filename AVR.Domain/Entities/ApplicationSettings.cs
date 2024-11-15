using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ApplicationSettings
    {
        public int Id { get; set; }
        public double DepositPercentage { get; set; }
        public double ProcedureFee { get; set; }
        public int ExpiryDurationInMinutes { get; set; } // Số phút trước khi hết hạn
    }
}
