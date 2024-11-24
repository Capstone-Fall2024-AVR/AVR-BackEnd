using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IDisbursementService
    {
        Task<string> CreateDisbursementVNPayUrl(Guid projectId, decimal totalAmount);
        Task ProcessDisbursementResultAsync(Guid disbursementId, string transactionStatus, string transactionNo);
    }
}
