using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ApartmentDocument
    {
        [Key]
        public Guid DocumentID { get; set; } = Guid.NewGuid();

        [Required]
        public string DocumentType { get; set; } // Loại giấy tờ (ví dụ: sổ hồng, giấy phép xây dựng, v.v.)

        [Required]
        public string DocumentUrl { get; set; } // URL hoặc đường dẫn tới file giấy tờ

        [Required]
        public Guid ApartmentID { get; set; } // Khóa ngoại, liên kết với căn hộ

        [Required]
        public Guid AccountID { get; set; } // Khóa ngoại, liên kết với tài khoản người sở hữu

        // Navigation properties
        public virtual Apartment Apartment { get; set; }
        public virtual Account Account { get; set; }
    }
}
