using AVR.Application.Services;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/statistics")]
    [ApiController]
    public class StatisticsController : BaseController
    {
        private readonly IStatisticsService _statisticsService;

        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStatistics()
        {
            var statistics = await _statisticsService.GetStatisticsAsync();
            return CustomResult("Thống kê thành công.", statistics);
        }

        [HttpGet("appointment-count-by-type")]
        public async Task<IActionResult> GetAppointmentCountByType()
        {
            var appointmentCounts = await _statisticsService.GetAppointmentCountByTypeAsync();
            return CustomResult("Thống kê số lượng cuộc hẹn theo loại thành công.", appointmentCounts);
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

    }
}
