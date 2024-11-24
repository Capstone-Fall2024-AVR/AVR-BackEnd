using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class Transaction
    {
        [Key] 
        public Guid TransactionID { get; set; } = Guid.NewGuid();
        [Required]
        public double ammount { get; set; }
        [Required]
        public string TransactionNo { get; set; }
        [Required]
        public string note { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public DateTimeOffset CreateDate { get; set; }
        [Required]
        public DateTimeOffset UpdateDate { get; set; }
        [Required]
        public DateTimeOffset TransactionDate { get; set; }
        [Required]
        public TransactionStatus TransactionStatus { get; set;}

        public PaymentMethod PaymentMethods { get; set;}
        //Deposit
        public Guid DepositID { get; set; }
        public virtual Deposit Deposits { get; set;}

    }
}
