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

        //Get deposit by ID
        [HttpGet("{depositId}")]
        public async Task<IActionResult> GetDepositById(Guid depositId)
        {
            var deposit = await _depositService.GetDepositByIdAsync(depositId);
            return CustomResult("Lấy thông tin deposit thành công.", deposit);
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllDeposits()
        {
            var deposits = await _depositService.GetAllDepositsAsync();
            return CustomResult("Lấy danh sách deposit thành công.", deposits);
        }

        //Get deposits by Apartment ID
        [HttpGet("by-apartment/{apartmentId}")]
        public async Task<IActionResult> GetDepositsByApartmentId(Guid apartmentId)
        {
            var deposits = await _depositService.GetDepositsByApartmentIdAsync(apartmentId);
            return CustomResult("Lấy danh sách deposit theo Apartment ID thành công.", deposits);
        }

        //Get deposits by Account ID
        [HttpGet("by-account/{accountId}")]
        public async Task<IActionResult> GetDepositsByAccountId(Guid accountId)
        {
            var deposits = await _depositService.GetDepositsByAccountIdAsync(accountId);
            return CustomResult("Lấy danh sách deposit theo Account ID thành công.", deposits);
        }
    }
}
