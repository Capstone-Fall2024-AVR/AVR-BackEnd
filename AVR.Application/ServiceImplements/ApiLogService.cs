using AVR.Application.Services;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class ApiLogService : IApiLogService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApiLogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task LogApiUsageAsync(string userId, string path, string method, DateTime timestamp)
        {
            var logEntry = new ApiLog
            {
                UserId = userId,
                Path = path,
                Method = method,
                Timestamp = timestamp
            };

            _unitOfWork.ApiLogRepository.Insert(logEntry);
            await _unitOfWork.SaveAsync();
        }
    }

}
