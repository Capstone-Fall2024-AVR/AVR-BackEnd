using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.DepositRequest
{
    public class RevenueSummaryResponse
    {
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string? Month { get; set; } // Thêm thuộc tính Month
        public double TotalRevenue { get; set; }
        public double TotalBrokerageFee { get; set; }
        public double TotalTradeFee { get; set; }
        public double TotalSecurityDeposit { get; set; }
    }



}
