using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.ApplicationSettings
{
    public class ApplicationSettingsRequest
    {
        public double DepositPercentage { get; set; }
        public int ExpiryDurationInMinutes { get; set; }
    }

}
