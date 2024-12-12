using AVR.Domain.Enums;
using AVR.Domain.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AVR.Domain.Entities
{
    public class PropertyVerification
    {
        [Key]
        public Guid VerificationID { get; set; } = Guid.NewGuid();

        [Required]
        public DateTimeOffset CreateDate { get; set; } = CoreHelper.SystemTimeNow;

        [Required]
        public DateTimeOffset UpdateDate { get; set; } = CoreHelper.SystemTimeNow;

        [Required]
        public VerificationStatus VerificationStatus { get; set; } = VerificationStatus.Pending;

        public string LegalDocumentsURL { get; set; } // URL đến tài liệu pháp lý
        public string? Comments { get; set; } // Ghi chú từ nhân viên xác nhận

        [Required]
        public Guid ApartmentOwnerApartmentID { get; set; }
        public virtual ApartmentOwnerApartment ApartmentOwnerApartment { get; set; }

        [Required]
        [MaxLength(100)]
        public string VerificationName { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PropertyValue { get; set; } // Giá trị căn hộ

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DepositValue { get; set; } // Giá trị đặt cọc

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BrokerageFee { get; set; } // Số tiền môi giới

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SecurityDeposit { get; set; } // Tiền ký quỹ

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CommissionRate { get; set; } // Tỷ lệ hoa hồng

        [Required]
        public DateTimeOffset EffectiveDate { get; set; } // Ngày bắt đầu hiệu lực

        [Required]
        public DateTimeOffset ExpiryDate { get; set; } // Ngày kết thúc hiệu lực

        [Required]
        [MaxLength(50)]
        public string ContractCode { get; set; } // Mã hợp đồng

        [Required]
        public bool HasApartment { get; set; } = false;

    }
}
