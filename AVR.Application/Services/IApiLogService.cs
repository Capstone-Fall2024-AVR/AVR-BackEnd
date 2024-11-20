using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IApiLogService
    {
        Task LogApiUsageAsync(string userId, string path, string method, DateTime timestamp);
    }

}
