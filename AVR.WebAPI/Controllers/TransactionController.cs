using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Transaction.TransactionDisbursementRequest;
using Microsoft.AspNetCore.Mvc;
using CoreApiResponse;

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
                return StatusCode(500, $"An error occurred while exporting the data: {ex.Message}");
            }
        }
    }
}
