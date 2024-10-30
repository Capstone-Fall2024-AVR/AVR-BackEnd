using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ApplicationSettings;
using AVR.Application.ViewModels.Response.ApplicationSettings;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingsService _settingsService;

        public SettingsController(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        // API để cập nhật cấu hình
        [HttpPut("update")]
        public async Task<IActionResult> UpdateSettings([FromBody] ApplicationSettingsRequest request)
        {
            await _settingsService.UpdateSettingsAsync(request.DepositPercentage, request.ExpiryDurationInMinutes);

            var updatedSettings = new ApplicationSettingsResponse
            {
                DepositPercentage = request.DepositPercentage,
                ExpiryDurationInMinutes = request.ExpiryDurationInMinutes
            };

            return Ok(updatedSettings);
        }

        // API để lấy cấu hình hiện tại
        [HttpGet("current")]
        public async Task<ActionResult<ApplicationSettingsResponse>> GetCurrentSettings()
        {
            var depositPercentage = await _settingsService.GetDepositPercentageAsync();
            var expiryDuration = await _settingsService.GetExpiryDurationAsync();

            var response = new ApplicationSettingsResponse
            {
                DepositPercentage = depositPercentage,
                ExpiryDurationInMinutes = expiryDuration
            };

            return Ok(response);
        }
    }

}
