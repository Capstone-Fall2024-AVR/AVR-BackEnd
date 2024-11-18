using AVR.Application.Services;
using Microsoft.AspNetCore.Mvc;
using CoreApiResponse;
using AVR.Domain.Enums;
using AVR.Application.ServiceImplements;

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
        public async Task<IActionResult> RequestDeposit([FromForm] CreateDepositRequest request)
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

        [HttpGet("search")]
        public async Task<IActionResult> SearchDeposits(
            [FromQuery] Guid? depositId,
            [FromQuery] Guid? apartmentId,
            [FromQuery] Guid? accountId,
            [FromQuery] Guid? ownerId,
            [FromQuery] DepositStatus? depositStatus,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 5)
        {
            var deposits = await _depositService.SearchDeposits(
                depositId,
                apartmentId,
                accountId,
                ownerId,
                depositStatus,
                pageIndex,
                pageSize);

            return CustomResult("Tìm kiếm deposit thành công.", deposits);
        }


        [HttpGet("{depositId}")]
        public async Task<IActionResult> GetDepositById(Guid depositId)
        {
            var deposit = await _depositService.GetDepositByIdAsync(depositId);
            return CustomResult("Lấy thông tin deposit thành công.", deposit);
        }


        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllDeposits([FromQuery] DepositStatus? depositStatus = null)
        {
            var deposits = await _depositService.GetAllDepositsAsync(depositStatus);
            return CustomResult("Lấy danh sách deposit thành công.", deposits);
        }


        [HttpGet("by-apartment/{apartmentId}")]
        public async Task<IActionResult> GetDepositsByApartmentId(Guid apartmentId, [FromQuery] DepositStatus? depositStatus = null)
        {
            var deposits = await _depositService.GetDepositsByApartmentIdAsync(apartmentId, depositStatus);
            return CustomResult("Lấy danh sách deposit theo Apartment ID thành công.", deposits);
        }


        [HttpGet("by-account/{accountId}")]
        public async Task<IActionResult> GetDepositsByAccountId(Guid accountId, [FromQuery] DepositStatus? depositStatus = null)
        {
            var deposits = await _depositService.GetDepositsByAccountIdAsync(accountId, depositStatus);
            return CustomResult("Lấy danh sách deposit theo Account ID thành công.", deposits);
        }

        [HttpPost("trade-request/{currentDepositId}")]
        public async Task<IActionResult> RequestTradeDeposit(Guid currentDepositId, [FromForm] string newApartmentCode)
        {
            var result = await _depositService.RequestTradeDepositAsync(currentDepositId, newApartmentCode);
            return CustomResult("Trade deposit request created successfully.", result);
        }

        [HttpPost("trade-accept/{tradeDepositId}")]
        public async Task<IActionResult> AcceptTradeDeposit(Guid tradeDepositId)
        {
            var result = await _depositService.AcceptTradeDepositAsync(tradeDepositId);
            return CustomResult("Trade deposit accepted successfully.", result);
        }

        [HttpPost("trade-reject/{tradeDepositId}")]
        public async Task<IActionResult> RejectTradeDeposit(Guid tradeDepositId)
        {
            var result = await _depositService.RejectTradeDepositAsync(tradeDepositId);
            return CustomResult("Trade deposit rejected successfully.", result);
        }

        [HttpGet("total")]
        public async Task<IActionResult> GetTotalDeposits([FromQuery] DepositStatus? depositStatus = null)
        {
            var totalDeposits = await _depositService.GetTotalDepositsAsync(depositStatus);
            var message = depositStatus.HasValue
                ? $"Tổng số lượng deposit với trạng thái {depositStatus}: {totalDeposits}"
                : $"Tổng số lượng tất cả các deposit: {totalDeposits}";

            return CustomResult(message, totalDeposits);
        }

        [HttpGet("export-detailed-financial-data/{projectId}")]
        public async Task<IActionResult> ExportDetailedFinancialData(Guid projectId)
        {
            try
            {
                var filePath = await _depositService.ExportDetailedFinancialDataAsync(projectId);

                // Return the file as a download
                var fileBytes = System.IO.File.ReadAllBytes(filePath);
                var fileName = Path.GetFileName(filePath);
                return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

    }
}
