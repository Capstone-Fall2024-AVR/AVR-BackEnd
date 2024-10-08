using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Deposits;
using Microsoft.AspNetCore.Mvc;
using CoreApiResponse;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/deposits")]
    [ApiController]
    public class DepositController : BaseController
    {
        private readonly IDepositService _depositService;

        public DepositController(IDepositService depositService)
        {
            _depositService = depositService;
        }

        [HttpPost("request")]
        public async Task<IActionResult> RequestDeposit(CreateDepositRequest request)
        {
            var deposit = await _depositService.RequestDepositAsync(request);
            return CustomResult("Deposit request đã được tạo thành công.", deposit);
        }

        [HttpPost("accept/{depositId}")]
        public async Task<IActionResult> AcceptDeposit(Guid depositId)
        {
            var deposit = await _depositService.AcceptDepositAsync(depositId);
            return CustomResult("Deposit đã được chấp nhận.", deposit);
        }

        [HttpPost("reject/{depositId}")]
        public async Task<IActionResult> RejectDeposit(Guid depositId)
        {
            var deposit = await _depositService.RejectDepositAsync(depositId);
            return CustomResult("Deposit đã bị từ chối.", deposit);
        }

        [HttpPost("disable/{depositId}")]
        public async Task<IActionResult> DisableDeposit(Guid depositId)
        {
            await _depositService.DisableDepositAsync(depositId);
            return CustomResult("Deposit đã bị vô hiệu hóa.");
        }
    }
}
