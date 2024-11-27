using AVR.Application.Services;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v2/deposits")]
    [ApiController]
    public class DepositControllerV2 : BaseController
    {
        private readonly IDepositService _depositService;

        public DepositControllerV2(IDepositService depositService)
        {
            _depositService = depositService;
        }

        [HttpPost("request")]
        public async Task<IActionResult> RequestDeposit([FromForm] CreateDepositRequest request)
        {
            var deposit = await _depositService.RequestDepositV2Async(request);
            return CustomResult("Deposit request đã được tạo thành công.", deposit);
        }

        [HttpPost("trade-request/{currentDepositId}")]
        public async Task<IActionResult> RequestTradeDeposit(Guid currentDepositId, [FromForm] string newApartmentCode)
        {
            var result = await _depositService.RequestTradeDepositV2Async(currentDepositId, newApartmentCode);
            return CustomResult("Trade deposit request created successfully.", result);
        }

    }
}
