using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Projects
{
    public class ProjectSummaryResponse
    {
        public Guid ProjectID { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int TransactionCount { get; set; }
        public double? TotalDepositAmount { get; set; }
        public string DisbursementStatus { get; set; }
    }

}
