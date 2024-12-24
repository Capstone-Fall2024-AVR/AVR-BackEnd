using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.DepositRequest
{
    public class RevenueSummaryResponse
    {
        public DateTimeOffset StartDate { get; set; } // Thời gian bắt đầu
        public DateTimeOffset EndDate { get; set; } // Thời gian kết thúc
        public double TotalRevenue { get; set; } // Tổng doanh thu (depositAmount)
        public double TotalBrokerageFee { get; set; } // Tổng tiền môi giới (BrokerageFee)
        public double TotalSecurityDeposit { get; set; } // Tổng tiền ký quỹ (TotalRevenue - TotalBrokerageFee)
    }


}
