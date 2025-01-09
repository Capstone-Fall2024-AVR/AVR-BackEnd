using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.ProjectProviders
{
    public class ProviderStatisticsResponse
    {
        public Guid ProviderId { get; set; }
        public string ProviderName { get; set; }
        public int NumberOfProjects { get; set; }
        public int TotalApartments { get; set; }
        public int AvailableApartments { get; set; }
        public double TotalDepositMoney { get; set; }
    }

}
