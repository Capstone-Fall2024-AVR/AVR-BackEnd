using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IVNPayService
    {
        Task<string> CreateVNPayUrl(Guid depositId);
        Task<string> CreateDisbursementVNPayUrl(Guid depositId);
        Task<string> CreateRefundVNPayUrl(Guid depositId);
        bool ValidateVNPaySignature(string queryString, string signature);
        Task ProcessPaymentResultAsync(Guid depositId, string transactionStatus, string TransactionNo);
        Task RetryPaymentAsync(Guid depositId);
    }
}
