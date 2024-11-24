using AVR.Domain.Enums;
using AVR.Domain.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AVR.Domain.Entities
{
    public class Disbursement
    {
        [Key]
        public Guid DisbursementID { get; set; } = Guid.NewGuid();

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; } // Amount disbursed

        [Required]
        public Guid ProjectApartmentID { get; set; } // Link to ProjectApartment
        public virtual ProjectApartment ProjectApartment { get; set; }

        [Required]
        public string TransactionCode { get; set; } // Unique code for this disbursement

        [Required]
        public PaymentMethod PaymentMethod { get; set; }  // Payment method used

        [Required]
        public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.UtcNow;

        [Required]
        public DateTimeOffset UpdateDate { get; set; } = DateTimeOffset.UtcNow;

        [Required]
        public DisbursementTransaction Status { get; set; }  // Status of the disbursement
    }
}
