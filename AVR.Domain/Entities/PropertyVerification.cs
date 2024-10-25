using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class PropertyVerification
    {
        [Key]
        public Guid VerificationID { get; set; } = Guid.NewGuid();

        [Required]
        public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.Now;

        [Required]
        public DateTimeOffset UpdateDate { get; set; } = DateTimeOffset.Now;

        [Required]
        public VerificationStatus VerificationStatus { get; set; } = VerificationStatus.Pending; // Trạng thái xác nhận

        public string LegalDocumentsURL { get; set; } // URL đến tài liệu pháp lý của hợp đồng
        public string Comments { get; set; } // Ghi chú từ nhân viên xác nhận

        // Foreign key to Apartment (1-1 relationship)
        [Required]
        public Guid ApartmentID { get; set; }
        public virtual Apartment Apartment { get; set; }
    }
}
