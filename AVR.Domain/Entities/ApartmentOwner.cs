using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AVR.Domain.Entities
{
    [Table("ApartmentOwner")]
    public class ApartmentOwner
    {
        [Key]
        public Guid ApartmentOwnerID { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; } // Tên người dùng

        [Required]
        public string Email { get; set; } // Email

        [Required]
        public string PhoneNumber { get; set; } // Số điện thoại

        [Required]
        public string NationalID { get; set; } // Giấy tờ tùy thân

        [Required]
        public DateTimeOffset IssueDate { get; set; } // Ngày cấp giấy tờ tùy thân

        [Required]
        public DateTimeOffset BirthDate { get; set; } // Ngày sinh

        [Required]
        public string Nationality { get; set; } // Quốc tịch

        [Required]
        public Gender Gender { get; set; } // Giới tính

        [Required]
        public string Address { get; set; } // Địa chỉ

        [Required]
        public Guid AccountID { get; set; } // Khóa ngoại đến Account
        public virtual Account Account { get; set; } // Navigation property đến Account

        // Navigation properties
        public virtual ICollection<ApartmentOwnerApartment> ApartmentOwnerApartments { get; set; } // Danh sách căn hộ sở hữu
    }
}
