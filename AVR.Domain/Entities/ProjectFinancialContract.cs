using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ProjectFinancialContract
    {
        [Key]
        public Guid FinancialContractID { get; set; } = Guid.NewGuid();

        // Tiền cọc
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DepositAmount { get; set; }

        // Tiền môi giới
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BrokerageFee { get; set; }

        // Tiền hoa hồng
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CommissionFee_1 { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CommissionFee_2 { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CommissionFee_3 { get; set; }

        // Ngày có hiệu lực
        [Required]
        public DateTimeOffset EffectiveDate { get; set; }

        // Ngày kết thúc
        [Required]
        public DateTimeOffset EndDate { get; set; }

        // Lưu URL của file hợp đồng
        [Required]
        public string ContractFileUrl { get; set; }

        // Foreign Key tới ProjectApartment
        public Guid ProjectApartmentID { get; set; }
        public virtual ProjectApartment ProjectApartment { get; set; }
    }
}
