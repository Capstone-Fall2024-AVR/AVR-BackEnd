using AVR.Application.ViewModels.Request.Transaction.TransactionDisbursementRequest;
using AVR.Application.ViewModels.Response.Transaction.TransactionDisbursementResponse;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface ITransactionService
    {
        /*Task<IEnumerable<TransactionDisbursementResponse>> DisburseTransactionsAsync(TransactionDisbursementRequest request);
        Task UpdateTransactionStatusAsync();
        Task<FileContentResult> ExportDisbursedApartmentsToExcelAsync(Guid projectId);*/

        Task<(IEnumerable<TransactionDisbursementResponse> Transactions, int TotalItems, int TotalPages)> SearchTransactionsAsync(
         Guid? transactionId,
         Guid? depositId,
         Guid? accountId,
         TransactionStatus? transactionStatus,
         string? keyword, // Tìm kiếm theo từ khóa
         int pageIndex = 1,
         int pageSize = 10);

        Task<int> GetTransactionCountAsync(TransactionStatus? transactionStatus = null);

    }
}
