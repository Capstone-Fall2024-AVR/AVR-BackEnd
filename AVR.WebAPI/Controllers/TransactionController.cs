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



        [HttpGet("search")]
        public async Task<IActionResult> SearchTransactions(
            [FromQuery] Guid? transactionId,
            [FromQuery] Guid? depositId,
            [FromQuery] Guid? accountId,
            [FromQuery] Guid? providerId,
            [FromQuery] string? transactionNo,
            [FromQuery] TransactionTypes? transactionTypes,
            [FromQuery] TransactionStatus? transactionStatus,
            [FromQuery] string? keyword,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 10)
        {
            var (transactions, totalItems, totalPages) = await _transactionService.SearchTransactionsAsync(
                transactionId,
                depositId,
                accountId,
                providerId,
                transactionNo,
                transactionTypes,
                transactionStatus,
                keyword,
                pageIndex,
                pageSize);

            var response = new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                Transactions = transactions,
                CurrentPage = pageIndex,
                PageSize = pageSize
            };

            return CustomResult("Kết quả tìm kiếm các giao dịch.", response);
        }



        [HttpGet("count")]
        public async Task<IActionResult> GetTransactionCount([FromQuery] TransactionStatus? transactionStatus = null)
        {
            var count = await _transactionService.GetTransactionCountAsync(transactionStatus);
            return CustomResult("Transaction count retrieved successfully", count);
        }

    }
}
