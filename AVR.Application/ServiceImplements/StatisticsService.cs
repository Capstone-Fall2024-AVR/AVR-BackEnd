using AVR.Application.Services;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
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

        public async Task<object> GetStatisticsAsync(string timePeriod)
        {
            // Xác định khoảng thời gian
            DateTimeOffset startDate, endDate;
            var now = CoreHelper.SystemTimeNow;

            switch (timePeriod.ToLower())
            {
                case "week":
                    startDate = now.AddDays(-(int)now.DayOfWeek + 1); // Thứ 2 đầu tuần
                    endDate = startDate.AddDays(6).AddDays(1).AddTicks(-1); // Chủ nhật cuối tuần
                    break;
                case "month":
                    startDate = new DateTimeOffset(now.Year, now.Month, 1, 0, 0, 0, TimeSpan.Zero);
                    endDate = startDate.AddMonths(1).AddTicks(-1); // Cuối tháng
                    break;
                case "year":
                    startDate = new DateTimeOffset(now.Year, 1, 1, 0, 0, 0, TimeSpan.Zero);
                    endDate = new DateTimeOffset(now.Year, 12, 31, 23, 59, 59, TimeSpan.Zero);
                    break;
                default: // "all"
                    startDate = DateTimeOffset.MinValue;
                    endDate = DateTimeOffset.MaxValue;
                    break;
            }

            // Lấy thống kê
            var deposits = _unitOfWork.DepositRepository.Get()
                .Where(d => d.DepositStatus == DepositStatus.Paid && d.CreateDate >= startDate && d.CreateDate <= endDate);

            var apartments = _unitOfWork.ApartmentRepository.Get()
                .Where(a => a.CreatedDate >= startDate && a.CreatedDate <= endDate);

            var appointments = _unitOfWork.AppointmentRepository.Get()
                .Where(a => a.CreateDate >= startDate && a.CreateDate <= endDate);

            var totalRevenue = deposits.Sum(d => d.depositAmount);
            var totalBrokerageFee = deposits.Sum(d => d.BrokerageFee ?? 0);
            var totalSecurityDeposit = totalRevenue - totalBrokerageFee;
            var totalAvailableApartments = apartments.Count(a => a.ApartmentStatus == ApartmentStatus.Available);
            var totalAppointments = appointments.Count();
            var totalUsers = _unitOfWork.AccountRepository.Get()
                .Count(a => a.AccountStatus == AccountStatus.Active);
            var totalTransactions = _unitOfWork.TransactionRepository.Get()
                .Count();

            return new
            {
                TimePeriod = timePeriod,
                StartDate = startDate,
                EndDate = endDate,
                TotalRevenue = totalRevenue,
                TotalAppointments = totalAppointments,
                TotalAvailableApartments = totalAvailableApartments,
                TotalBrokerageFee = totalBrokerageFee,
                TotalSecurityDeposit = totalSecurityDeposit,
                TotalUsers = totalUsers,
                TotalTransactions = totalTransactions
            };
        }


        public async Task<object> GetAppointmentCountByTypeAsync()
        {
            // Lấy tất cả giá trị của AppointmentTypes
            var allAppointmentTypes = Enum.GetValues(typeof(AppointmentTypes))
                .Cast<AppointmentTypes>();

            // Đếm số lượng theo loại từ cơ sở dữ liệu
            var appointmentCounts = _unitOfWork.AppointmentRepository.Get()
                .GroupBy(a => a.AppointmentTypes)
                .ToDictionary(g => g.Key, g => g.Count());

            // Đảm bảo các loại không xuất hiện được set giá trị bằng 0
            var fullAppointmentCounts = allAppointmentTypes.ToDictionary(
                type => type,
                type => appointmentCounts.ContainsKey(type) ? appointmentCounts[type] : 0
            );

            // Tính tổng tất cả các lịch hẹn
            var totalAppointments = fullAppointmentCounts.Values.Sum();

            // Trả về object chứa chi tiết và tổng
            return new
            {
                Details = fullAppointmentCounts.Select(ac => new
                {
                    AppointmentType = ac.Key.ToString(),
                    Count = ac.Value
                }),
                Total = totalAppointments
            };
        }

        public async Task<object> GetApartmentCountByPossessionTypeAsync()
        {
            // Lấy tất cả giá trị của PossessionType enum
            var allPossessionTypes = Enum.GetValues(typeof(PossessionType))
                .Cast<PossessionType>();

            // Đếm số lượng theo PossessionType từ cơ sở dữ liệu
            var apartmentCounts = _unitOfWork.ApartmentRepository.Get()
                .GroupBy(a => a.PossessionType)
                .ToDictionary(g => g.Key, g => g.Count());

            // Đảm bảo các loại không xuất hiện được set giá trị bằng 0
            var fullApartmentCounts = allPossessionTypes.ToDictionary(
                type => type,
                type => apartmentCounts.ContainsKey(type) ? apartmentCounts[type] : 0
            );

            // Tính tổng số lượng căn hộ
            var totalApartments = fullApartmentCounts.Values.Sum();

            // Trả về object chứa chi tiết và tổng
            return new
            {
                Details = fullApartmentCounts.Select(ac => new
                {
                    PossessionType = ac.Key.ToString(),
                    Count = ac.Value
                }),
                TotalApartments = totalApartments
            };
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
