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
            return settings.FirstOrDefault()?.ExpiryDurationInMinutes ?? 30; // Default 30 minutes
        }

        public async Task<double> GetProcedureFeeAsync()
        {
            var settings = await _unitOfWork.SettingsRepository.GetAllAsync();
            return settings.FirstOrDefault()?.ProcedureFee ?? 20000000.0;
        }

        public async Task<int> GetDisbursementDurationAsync()
        {
            var settings = await _unitOfWork.SettingsRepository.GetAllAsync();
            return settings.FirstOrDefault()?.DisbursementDurationInMinutes ?? 30; // Default 30 minutes
        }

        public async Task UpdateSettingsAsync(double? depositPercentage, double? procedureFee, int? expiryDurationInMinutes, int? disbursementDuration)
        {
            var settings = await _unitOfWork.SettingsRepository.GetAllAsync();
            var setting = settings.FirstOrDefault();

            if (setting != null)
            {
                // Chỉ cập nhật các trường được thay đổi
                setting.DepositPercentage = depositPercentage ?? setting.DepositPercentage;
                setting.ProcedureFee = procedureFee ?? setting.ProcedureFee;
                setting.ExpiryDurationInMinutes = expiryDurationInMinutes ?? setting.ExpiryDurationInMinutes;
                setting.DisbursementDurationInMinutes = disbursementDuration ?? setting.DisbursementDurationInMinutes;

                _unitOfWork.SettingsRepository.Update(setting);
            }
            else
            {
                // Nếu chưa có, tạo mới với các giá trị mặc định nếu cần
                setting = new ApplicationSettings
                {
                    DepositPercentage = depositPercentage ?? 10.0, // Default value
                    ProcedureFee = procedureFee ?? 20000000.0,    // Default value
                    ExpiryDurationInMinutes = expiryDurationInMinutes ?? 30, // Default value
                    DisbursementDurationInMinutes = disbursementDuration ?? 30 // Default value
                };
                _unitOfWork.SettingsRepository.Insert(setting);
            }

            await _unitOfWork.SaveAsync();
        }

    }
}
