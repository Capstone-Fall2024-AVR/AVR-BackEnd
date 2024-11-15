using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SettingsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<double> GetDepositPercentageAsync()
        {
            var settings = await _unitOfWork.SettingsRepository.GetAllAsync();
            return settings.FirstOrDefault()?.DepositPercentage ?? 10; // Default 10%
        }

        public async Task<int> GetExpiryDurationAsync()
        {
            var settings = await _unitOfWork.SettingsRepository.GetAllAsync();
            return settings.FirstOrDefault()?.ExpiryDurationInMinutes ?? 2; // Default 2 minutes
        }

        public async Task<double> GetProcedureFeeAsync()
        {
            var settings = await _unitOfWork.SettingsRepository.GetAllAsync();
            return settings.FirstOrDefault()?.ProcedureFee ?? 20000000.0;
        }

        public async Task UpdateSettingsAsync(double depositPercentage, double procedureFee, int expiryDurationInMinutes)
        {
            var settings = await _unitOfWork.SettingsRepository.GetAllAsync();
            var setting = settings.FirstOrDefault();
            if (setting != null)
            {
                setting.DepositPercentage = depositPercentage;
                setting.ProcedureFee = procedureFee;
                setting.ExpiryDurationInMinutes = expiryDurationInMinutes;
                _unitOfWork.SettingsRepository.Update(setting);
            }
            else
            {
                setting = new ApplicationSettings
                {
                    DepositPercentage = depositPercentage,
                    ProcedureFee = procedureFee,
                    ExpiryDurationInMinutes = expiryDurationInMinutes
                };
                _unitOfWork.SettingsRepository.Insert(setting);
            }
            await _unitOfWork.SaveAsync();
        }
    }
}
