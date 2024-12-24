using AVR.Application.Mapper;
using AVR.Application.ViewModels.Request.ApplicationSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.ApplicationSettings
{
    public class ApplicationSettingsResponse : IMapFrom<ApplicationSettingsRequest>
    {
        public double DepositPercentage { get; set; }
        public double ProcedureFee { get; set; }
        public int ExpiryDurationInMinutes { get; set; }
        public int DisbursementDurationInMinutes { get; set; }
    }

}
