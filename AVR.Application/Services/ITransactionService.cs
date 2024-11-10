using AVR.Application.ViewModels.Request.Transaction.TransactionDisbursementRequest;
using AVR.Application.ViewModels.Response.Transaction.TransactionDisbursementResponse;
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
        Task<IEnumerable<TransactionDisbursementResponse>> DisburseTransactionsAsync(TransactionDisbursementRequest request);
        Task UpdateTransactionStatusAsync();
        Task<FileContentResult> ExportDisbursedApartmentsToExcelAsync(Guid projectId);
    }
}
