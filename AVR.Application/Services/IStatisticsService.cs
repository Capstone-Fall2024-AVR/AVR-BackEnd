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
        Task<object> GetStatisticsAsync();
        Task<Dictionary<AppointmentTypes, int>> GetAppointmentCountByTypeAsync();
        Task<int> GetActiveOwnershipCountAsync();
        Task<int> GetProjectProviderCountAsync();
        Task<int> GetCombinedCountAsync();

    }

}
