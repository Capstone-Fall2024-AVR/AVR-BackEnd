using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ApplicationSettings;
using AVR.Application.ViewModels.Response.ApplicationSettings;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/settings")]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingsService _settingsService;

        public SettingsController(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        // API để cập nhật cấu hình
        [HttpPut("update")]
        public async Task<IActionResult> UpdateSettings([FromForm] ApplicationSettingsRequest request)
        {
            await _settingsService.UpdateSettingsAsync(
                request.DepositPercentage,
                request.ProcedureFee,
                request.ExpiryDurationInMinutes,
                request.DisbursementDurationInMinutes
            );

            // Lấy thông tin mới nhất để trả về
            var updatedSettings = new ApplicationSettingsResponse
            {
                DepositPercentage = await _settingsService.GetDepositPercentageAsync(),
                ProcedureFee = await _settingsService.GetProcedureFeeAsync(),
                ExpiryDurationInMinutes = await _settingsService.GetExpiryDurationAsync(),
                DisbursementDurationInMinutes = await _settingsService.GetDisbursementDurationAsync()
            };

            return Ok(updatedSettings);
        }


        // API để lấy cấu hình hiện tại
        [HttpGet("current")]
        public async Task<ActionResult<ApplicationSettingsResponse>> GetCurrentSettings()
        {
            var depositPercentage = await _settingsService.GetDepositPercentageAsync();
            var procedureFee = await _settingsService.GetProcedureFeeAsync();
            var expiryDuration = await _settingsService.GetExpiryDurationAsync();
            var disbursementDuration = await _settingsService.GetDisbursementDurationAsync();

            var response = new ApplicationSettingsResponse
            {
                DepositPercentage = depositPercentage,
                ProcedureFee = procedureFee,
                ExpiryDurationInMinutes = expiryDuration,
                DisbursementDurationInMinutes = disbursementDuration
            };

            return Ok(response);
        }
    }

}
