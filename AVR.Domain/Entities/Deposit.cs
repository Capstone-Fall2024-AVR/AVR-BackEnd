using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class Deposit
    {
        [Key] 
        public Guid DepositID { get; set; } = Guid.NewGuid();
        [Required]
        public double depositPercentage { get; set; }
        [Required]
        public double constractNumber { get; set; }
        [Required]
        public double depositAmount { get; set; }
        [Required]
        public string note { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.Now;
        [Required]
        public DateTimeOffset UpdateDate { get; set;}
        [Required]
        public DateTimeOffset expiryDate { get; set; }
        [Required]
        public DepositStatus DepositStatus { get; set;}

        //Customer
        public Guid CustomerID { get; set; }
        public virtual Customer Customers { get; set; }
        //Apartment
        public Guid ApartmentID { get; set; }
        public virtual Apartment Apartments { get; set; }
        //DepositCancel
        public virtual ICollection<DepositCancel> DepositCancels { get; set; }
        //Transaction
        public virtual Transaction Transactions { get; set; }

    }
}
