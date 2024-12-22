using AVR.Domain.Enums;
using AVR.Domain.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    [Table("DepositRequest")]
    public class Deposit
    {
        [Key]
        public Guid DepositID { get; set; } = Guid.NewGuid();
        [Required]
        public string DepositCode { get; set;}
        [AllowNull]
        public string? TransactionNo { get; set; }
        [AllowNull]
        public string? OldDepositCode { get; set; }
        [Required]
        public double depositPercentage { get; set; }
        [Required]
        public double depositAmount { get; set; }
        [Required]
        public double paymentAmount { get; set; }

        // Tiền môi giới
        [AllowNull]
        public double? BrokerageFee { get; set; }

        // Tiền hoa hồng
        [AllowNull]
        public double? CommissionFee { get; set; }

        //Tiền Trao đổi
        [AllowNull]
        public double? TradeFee { get; set; }

        [AllowNull]
        public string? note { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public DateTimeOffset CreateDate { get; set; } = CoreHelper.SystemTimeNow;
        [Required]
        public DateTimeOffset UpdateDate { get; set; }
        [Required]
        public DateTimeOffset expiryDate { get; set; }
        [Required]
        public DepositStatus DepositStatus { get; set; }
        [Required]
        public DepositType DepositType { get; set; }
        [Required]
        public DisbursementStatus DisbursementStatus { get; set; }

        // Replace Customer with Account
        public Guid AccountID { get; set; }
        public virtual Account Accounts { get; set; }

        public Guid? StaffID { get; set; }

        // Apartment
        public Guid ApartmentID { get; set; }
        public virtual Apartment Apartments { get; set; }

        // 1-1 Relationship with DepositProfile
        public virtual DepositProfile DepositProfile { get; set; }

        // Transaction
        public virtual Transaction Transactions { get; set; }
    }

}
