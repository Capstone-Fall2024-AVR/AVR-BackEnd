using AVR.Application.Services;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/disbursement")]
    public class DisbursementController : ControllerBase
    {
        private readonly IDisbursementService _disbursementService;

        public DisbursementController(IDisbursementService disbursementService)
        {
            _disbursementService = disbursementService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateDisbursementUrl(Guid projectId, decimal totalAmount)
        {
            var paymentUrl = await _disbursementService.CreateDisbursementVNPayUrl(projectId, totalAmount);
            return Ok(new { url = paymentUrl });
        }

        [HttpGet("callback")]
        public async Task<IActionResult> DisbursementCallback([FromQuery] string vnp_OrderInfo, [FromQuery] string vnp_TransactionStatus, [FromQuery] string vnp_TransactionNo)
        {
            var disbursementId = Guid.Parse(vnp_OrderInfo);

            await _disbursementService.ProcessDisbursementResultAsync(disbursementId, vnp_TransactionStatus, vnp_TransactionNo);
            return Ok("Disbursement processed.");
        }
    }


}
