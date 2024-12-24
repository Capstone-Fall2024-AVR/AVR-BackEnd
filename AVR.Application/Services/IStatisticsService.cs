using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IStatisticsService
    {
        Task<object> GetStatisticsAsync(string timePeriod);

        Task<object> GetAppointmentCountByTypeAsync();
        Task<object> GetApartmentCountByPossessionTypeAsync();
        Task<int> GetActiveOwnershipCountAsync();
        Task<int> GetProjectProviderCountAsync();
        Task<int> GetCombinedCountAsync();

    }

}
