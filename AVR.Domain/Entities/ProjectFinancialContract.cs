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

        //mức tiền thấp nhất
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal LowestPrice { get; set; }

        //mức tiền cao nhất
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal HighestPrice { get; set; }

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
        

        // Foreign Key tới ProjectApartment
        public Guid ProjectApartmentID { get; set; }
        public virtual ProjectApartment ProjectApartment { get; set; }
    }
}
