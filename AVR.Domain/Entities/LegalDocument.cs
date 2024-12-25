using AVR.Domain.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class LegalDocument 
    {
        [Key]
        public Guid LegalDocumentID { get; set; } = Guid.NewGuid();

        [Required]
        public string FileName { get; set; } // Tên file

        [Required]
        public string FileUrl { get; set; } // URL của file

        [Required]
        public DateTimeOffset CreateDate { get; set; } = CoreHelper.SystemTimeNow;

        [Required]
        public DateTimeOffset UpdateDate { get; set; } = CoreHelper.SystemTimeNow;

        [Required]
        public Guid VerificationID { get; set; } // Khóa ngoại liên kết với PropertyVerification

        [ForeignKey(nameof(VerificationID))]
        public virtual PropertyVerification PropertyVerification { get; set; } // Điều hướng ngược
    }
}
