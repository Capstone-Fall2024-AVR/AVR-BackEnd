using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Transaction.TransactionDisbursementRequest;
using Microsoft.AspNetCore.Mvc;
using CoreApiResponse;
using AVR.Domain.Enums;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/transactions")]
    [ApiController]
    public class TransactionController : BaseController
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost("disburse")]
        public async Task<IActionResult> DisburseTransactions([FromBody] TransactionDisbursementRequest request)
        {
            var result = await _transactionService.DisburseTransactionsAsync(request);
            return CustomResult("Tạo giải ngân thành công!", result);
        }

        [HttpPost("update-status")]
        public async Task<IActionResult> UpdateTransactionStatus()
        {
            await _transactionService.UpdateTransactionStatusAsync();
            return CustomResult("Transaction statuses updated successfully.");
        }

        /// <summary>
        /// Exports disbursed apartments to an Excel file for a specific project.
        /// </summary>
        /// <param name="projectId">The ID of the project to filter apartments.</param>
        /// <returns>An Excel file containing disbursed apartments.</returns>
        [HttpGet("export-disbursed-apartments")]
        public async Task<IActionResult> ExportDisbursedApartmentsToExcel(Guid projectId)
        {
            try
            {
                var fileContentResult = await _transactionService.ExportDisbursedApartmentsToExcelAsync(projectId);
                return fileContentResult;
            }
            catch (Exception ex)
            {
                return CustomResult($"An error occurred while exporting the data: {ex.Message}");
            }
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchTransactions(
            [FromQuery] Guid? transactionId,
            [FromQuery] Guid? depositId,
            [FromQuery] TransactionStatus? transactionStatus,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 10)
        {
            var transactions = await _transactionService.SearchTransactionsAsync(
                transactionId,
                depositId,
                transactionStatus,
                pageIndex,
                pageSize);

            return CustomResult("Search results for transactions", transactions);
        }

        [HttpGet("count")]
        public async Task<IActionResult> GetTransactionCount([FromQuery] TransactionStatus? transactionStatus = null)
        {
            var count = await _transactionService.GetTransactionCountAsync(transactionStatus);
            return CustomResult("Transaction count retrieved successfully", count);
        }

    }
}
