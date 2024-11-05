using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVR.Domain.Enums;
using AVR.Domain.Utils;

namespace AVR.Domain.Entities
{
    public class PropertyRequest
    {
        [Key]
        public Guid RequestID { get; set; } = Guid.NewGuid();

        [Required]
        public Guid OwnerID { get; set; }  // ID của owner
        public virtual Account Owner { get; set; }

        public Guid? StaffID { get; set; }  // ID của staff
        public virtual Account Staff { get; set; }


        [Required]
        public string PropertyName { get; set; } // Tên căn hộ dự kiến ký gửi

        public string Description { get; set; } // Mô tả về căn hộ

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ExpectedPrice { get; set; } // Giá bán mong muốn

        [Required]
        public string Address { get; set; } // Địa chỉ của căn hộ

        [Required]
        public string UserName { get; set; } // Tên người dùng

        [Required]
        public string Email { get; set; } // Email người dùng

        [Required]
        public string PhoneNumber { get; set; } // Số điện thoại người dùng

        [Required]
        public DateTimeOffset RequestDate { get; set; } = CoreHelper.SystemTimeNow;
        [Required]
        public DateTimeOffset UpdateDate { get; set; } = CoreHelper.SystemTimeNow;


        // Foreign key relation to Account

        public RequestStatus RequestStatus { get; set; } = RequestStatus.Pending; // Trạng thái yêu cầu ký gửi

        
    }
}
