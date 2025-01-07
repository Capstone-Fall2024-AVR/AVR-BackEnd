using AVR.Application.Services;
using AVR.Domain.Enums;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/statistics")]
    [ApiController]
    public class StatisticsController : BaseController
    {
        private readonly IStatisticsService _statisticsService;
        private readonly IProjectFileService _projectFileService;
        private readonly IDepositService _depositService;
        private readonly IPropertyVerificationService _propertyVerificationService;

        public StatisticsController(IStatisticsService statisticsService, IProjectFileService projectFileService, IDepositService depositService, IPropertyVerificationService propertyVerificationService)
        {
            _statisticsService = statisticsService;
            _projectFileService = projectFileService;
            _depositService = depositService;
            _propertyVerificationService = propertyVerificationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStatistics([FromQuery] string timePeriod = "all")
        {
            var statistics = await _statisticsService.GetStatisticsAsync(timePeriod);
            return CustomResult($"Thống kê thành công cho khoảng thời gian: {timePeriod}.", statistics);
        }


        [HttpGet("appointment-count-by-type")]
        public async Task<IActionResult> GetAppointmentCountByType([FromQuery] string timePeriod = "all")
        {
            var appointmentCounts = await _statisticsService.GetAppointmentCountByTypeAsync(timePeriod);
            return CustomResult("Thống kê số lượng cuộc hẹn theo loại thành công.", appointmentCounts);
        }

        [HttpGet("apartment-count-by-possession-type")]
        public async Task<IActionResult> GetApartmentCountByPossessionType()
        {
            var apartmentCounts = await _statisticsService.GetApartmentCountByPossessionTypeAsync();
            return CustomResult("Thống kê số lượng căn hộ theo loại sở hữu thành công.", apartmentCounts);
        }


        [HttpGet("ownership-and-provider-counts")]
        public async Task<IActionResult> GetOwnershipAndProviderCounts()
        {
            var activeOwnershipCount = await _statisticsService.GetActiveOwnershipCountAsync();
            var projectProviderCount = await _statisticsService.GetProjectProviderCountAsync();
            var combinedCount = await _statisticsService.GetCombinedCountAsync();

            var result = new
            {
                ActiveOwnershipCount = activeOwnershipCount,
                ProjectProviderCount = projectProviderCount,
                CombinedCount = combinedCount
            };

            return CustomResult("Thống kê số lượng thành công.", result);
        }

        [HttpGet("revenue-summary")]
        public async Task<IActionResult> GetRevenueSummary([FromQuery] string period = "month", [FromQuery] int year = 2024)
        {
            var revenueSummary = await _depositService.GetRevenueSummaryAsync(period, year);
            return CustomResult($"Tính toán doanh thu chi tiết theo {period} thành công.", revenueSummary);
        }

        [HttpGet("expiry-project-files")]
        public async Task<IActionResult> GetProjectFilesCloseToExpiry([FromQuery] int daysBeforeExpiry = 7)
        {
            var projectFiles = await _projectFileService.GetProjectFilesCloseToExpiryAsync(daysBeforeExpiry);
            return Ok(new { message = "Danh sách ProjectFile gần tới ExpiryDate.", data = projectFiles });
        }

        [HttpGet("near-verifications")]
        public async Task<IActionResult> GetNearExpiryVerifications([FromQuery] int days = 7)
        {
            var verifications = await _propertyVerificationService.GetNearExpiryVerificationsAsync(days);
            return CustomResult("Lấy danh sách xác minh gần ngày hết hạn thành công.", verifications);
        }
    }
}
