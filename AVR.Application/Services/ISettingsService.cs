using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface ISettingsService
    {
        Task<double> GetDepositPercentageAsync();
        Task<double> GetProcedureFeeAsync();
        Task<int> GetExpiryDurationAsync();
        Task UpdateSettingsAsync(double depositPercentage, double procedureFee, int expiryDurationInMinutes);
    }
}
