using AVR.Application.Services;
using Microsoft.AspNetCore.Mvc;
using CoreApiResponse;
using AVR.Domain.Enums;
using AVR.Application.ServiceImplements;
using AVR.Domain.CustomException;

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
            var deposit = await _depositService.RequestDepositV2Async(request);
            return CustomResult("Deposit request đã được tạo thành công.", deposit);
        }


        [HttpPost("accept/{depositId}")]
        public async Task<IActionResult> AcceptDeposit(Guid depositId, Guid StaffID)
        {
            var deposit = await _depositService.AcceptDepositAsync(depositId, StaffID);
            return CustomResult("Deposit đã được chấp nhận.", deposit);
        }

        [HttpPost("reject/{depositId}")]
        public async Task<IActionResult> RejectDeposit(Guid depositId, Guid staffID, string? note)
        {
            var deposit = await _depositService.RejectDepositAsync(depositId, staffID, note);
            return CustomResult("Deposit đã bị từ chối.", deposit);
        }

        [HttpPost("disable/{depositId}")]
        public async Task<IActionResult> DisableDeposit(Guid depositId, string note)
        {
            await _depositService.DisableDepositAsync(depositId, note);
            return CustomResult("Deposit đã bị vô hiệu hóa.");
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchDeposits(
            [FromQuery] Guid? depositId,
            [FromQuery] string? depositCode,
            [FromQuery] string? apartmentCode,
            [FromQuery] string? keyword,
            [FromQuery] Guid? apartmentId,
            [FromQuery] Guid? accountId,
            [FromQuery] Guid? ownerId,
            [FromQuery] Guid? teamId,
            [FromQuery] Guid? projectApartmentId,
            [FromQuery] DepositStatus? depositStatus,
            [FromQuery] DepositType? depositType,
            [FromQuery] DisbursementStatus? disbursementStatus,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 5)
        {
            // Call the service to search for deposits and return pagination metadata
            var (deposits, totalItems, totalPages) = await _depositService.SearchDeposits(
                depositId,
                depositCode,
                apartmentCode,
                keyword,
                apartmentId,
                accountId,
                ownerId,
                teamId,
                projectApartmentId,
                depositStatus,
                depositType, 
                disbursementStatus,
                pageIndex,
                pageSize);

            // Create response object
            var response = new
            {
                Deposits = deposits,
                TotalItems = totalItems,
                TotalPages = totalPages,
                CurrentPage = pageIndex,
                PageSize = pageSize
            };

            return CustomResult("Tìm kiếm deposit thành công.", response);
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

        [HttpPost("disburse/{depositId}")]
        public async Task<IActionResult> DisburseDeposit(Guid depositId, [FromQuery] Guid ManagerId, [FromQuery] DisbursementStatus? disbursementStatus = null)
        {
            var deposit = await _depositService.DisburseDepositAsync(depositId, ManagerId, disbursementStatus);
            return CustomResult("Disbursement completed successfully.", deposit);
        }


        [HttpPost("trade-request/{currentDepositId}")]
        public async Task<IActionResult> RequestTradeDeposit(Guid currentDepositId, [FromForm] string newApartmentCode)
        {
            var result = await _depositService.RequestTradeDepositV2Async(currentDepositId, newApartmentCode);
            return CustomResult("Trade deposit request created successfully.", result);
        }

        [HttpPost("trade-accept/{tradeDepositId}")]
        public async Task<IActionResult> AcceptTradeDeposit(Guid tradeDepositId, Guid staffId)
        {
            var result = await _depositService.AcceptTradeDepositAsync(tradeDepositId, staffId);
            return CustomResult("Trade deposit accepted successfully.", result);
        }

        [HttpPost("trade-reject/{tradeDepositId}")]
        public async Task<IActionResult> RejectTradeDeposit(Guid tradeDepositId, Guid staffId, string? note)
        {
            var result = await _depositService.RejectTradeDepositAsync(tradeDepositId, staffId, note);
            return CustomResult("Trade deposit rejected successfully.", result);
        }

        /*[HttpGet("total")]
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
        }*/

        /*[HttpGet("project-disbursement/{projectId}")]
        public async Task<IActionResult> GetProjectDisbursementDetails(Guid projectId)
        {
            var response = await _depositService.GetProjectDisbursementDetailsAsync(projectId);
            return CustomResult("Project disbursement details retrieved successfully.", response);
        }*/


    }
}
