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
        public string DepositCode { get; set; }
        public string TransactionNo { get; set; }
        public string CustomerName { get; set; }
        public string ApartmentCode { get; set; }
        public double AmountPaid { get; set; }
        public DateTimeOffset TransactionDate { get; set; }
        public string description { get; set; }
        public string Status { get; set; }
        public string PaymentMethods { get; set; }
    }
}
