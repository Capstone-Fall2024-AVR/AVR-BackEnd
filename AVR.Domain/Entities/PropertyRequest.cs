using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVR.Domain.Enums;

namespace AVR.Domain.Entities
{
    public class PropertyRequest
    {
        [Key]
        public Guid RequestID { get; set; } = Guid.NewGuid();

        [Required]
        public Guid AccountID { get; set; }  // ID của owner

        [Required]
        public string PropertyName { get; set; } // Tên căn hộ dự kiến ký gửi

        public string Description { get; set; } // Mô tả về căn hộ

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ExpectedPrice { get; set; } // Giá bán mong muốn

        [Required]
        public string Address { get; set; } // Địa chỉ của căn hộ

        public DateTimeOffset RequestDate { get; set; } = DateTimeOffset.Now;

        // Foreign key relation to Account
        public virtual Account Account { get; set; }
        public RequestStatus RequestStatus { get; set; } = RequestStatus.Pending; // Trạng thái yêu cầu ký gửi

        // One-to-Many relationship with PropertyVerification
        public virtual ICollection<PropertyVerification> PropertyVerifications { get; set; } = new List<PropertyVerification>();
    }
}
