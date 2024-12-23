using AVR.Application.Services;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StatisticsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<object> GetStatisticsAsync()
        {
            // Doanh thu (Tổng depositAmount từ Deposit)
            var totalRevenue = _unitOfWork.DepositRepository.Get()
                .Where(d => d.DepositStatus == DepositStatus.Paid)
                .Sum(d => d.depositAmount);

            // Số căn hộ hiện hữu (ApartmentStatus là Available)
            var totalAvailableApartments = _unitOfWork.ApartmentRepository.Get()
                .Count(a => a.ApartmentStatus == ApartmentStatus.Available);

            // Tiền môi giới (Tổng BrokerageFee từ Deposit)
            var totalBrokerageFee = _unitOfWork.DepositRepository.Get()
                .Where(d => d.BrokerageFee.HasValue && d.DepositStatus == DepositStatus.Paid)
                .Sum(d => d.BrokerageFee.Value);

            // Tổng lịch hẹn (Appointment)
            var totalAppointments = _unitOfWork.AppointmentRepository.Get().Count();

            // Tổng người dùng (AccountStatus là Active)
            var totalUsers = _unitOfWork.AccountRepository.Get()
                .Count(a => a.AccountStatus == AccountStatus.Active);

            // Tổng giao dịch (Transaction)
            var totalTransactions = _unitOfWork.TransactionRepository.Get().Count();

            return new
            {
                TotalRevenue = totalRevenue,
                TotalAvailableApartments = totalAvailableApartments,
                TotalBrokerageFee = totalBrokerageFee,
                TotalAppointments = totalAppointments,
                TotalUsers = totalUsers,
                TotalTransactions = totalTransactions
            };
        }

        public async Task<Dictionary<AppointmentTypes, int>> GetAppointmentCountByTypeAsync()
        {
            var appointmentCounts = _unitOfWork.AppointmentRepository.Get()
                .GroupBy(a => a.AppointmentTypes)
                .ToDictionary(g => g.Key, g => g.Count());

            return appointmentCounts;
        }

        public async Task<int> GetActiveOwnershipCountAsync()
        {
            var count = _unitOfWork.ApartmentOwnerApartmentRepository
                .Get()
                .Count(a => a.OwnershipStatus == OwnershipStatus.Active);
            return count;
        }

        public async Task<int> GetProjectProviderCountAsync()
        {
            var count = _unitOfWork.ApartmentProjectProviderRepository
                .Get()
                .Count();
            return count;
        }

        public async Task<int> GetCombinedCountAsync()
        {
            var activeOwnershipCount = await GetActiveOwnershipCountAsync();
            var projectProviderCount = await GetProjectProviderCountAsync();
            return activeOwnershipCount + projectProviderCount;
        }
    }

}
