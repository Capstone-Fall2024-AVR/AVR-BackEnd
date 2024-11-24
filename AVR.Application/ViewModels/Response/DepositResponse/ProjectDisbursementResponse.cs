using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.DepositResponse
{
    public class ProjectDisbursementResponse
    {
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public List<ApartmentDepositInfo> ApartmentsWithDeposits { get; set; }
        public List<ApartmentInfo> ApartmentsWithoutDeposits { get; set; }
        public double TotalDepositAmount { get; set; }
    }
}
