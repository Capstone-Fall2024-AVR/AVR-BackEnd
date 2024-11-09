using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Transaction.TransactionDisbursementResponse
{
    public class TransactionDisbursementResponse
    {
        public Guid TransactionId { get; set; }
        public double AmountPaid { get; set; }
        public DateTimeOffset DisbursementDate { get; set; }
        public TransactionStatus Status { get; set; }
    }
}
