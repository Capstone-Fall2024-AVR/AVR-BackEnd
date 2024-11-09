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
    }
}
