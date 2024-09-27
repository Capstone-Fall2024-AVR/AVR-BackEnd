using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    [Table("ApartmentOwnerApartment")]
    public class ApartmentOwnerApartment
    {
        [Key]
        public Guid DocumentID { get; set; } = Guid.NewGuid();

        [Required]
        public Guid ApartmentID { get; set; } // Khóa ngoại, liên kết với căn hộ

        [Required]
        public Guid AccountID { get; set; } // Khóa ngoại, liên kết với tài khoản người sở hữu

        // Navigation properties
        public virtual Apartment Apartment { get; set; }
        public virtual Account Account { get; set; }
    }
}
