using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class DepositProfile
    {
        [Key]
        public Guid ProfileID { get; set; } = Guid.NewGuid();

        [Required]
        public string FullName { get; set; }  // Họ và tên

        [Required]
        public string Gender { get; set; }  // giới tính

        [Required]
        public string IdentityCardNumber { get; set; }  // Số CCCD

        [Required]
        public DateTime DateOfIssue { get; set; }  // Ngày cấp

        [Required]
        public DateTime DateOfBirth { get; set; }  // Ngày sinh

        [Required]
        public string Nationality { get; set; }  // Quốc tịch

        [Required]
        public string Address { get; set; }  // Địa chỉ

        [Required]
        public string Email { get; set; }  // Email

        [Required]
        public string PhoneNumber { get; set; }  // Số điện thoại

        [Required]
        public string IdentityCardFrontImage { get; set; }  // Ảnh CCCD mặt trước (URL hoặc Path)

        [Required]
        public string IdentityCardBackImage { get; set; }  // Ảnh CCCD mặt sau (URL hoặc Path)

        // 1-1 Relationship with Deposit
        [Required]
        public Guid DepositID { get; set; }
        public virtual Deposit Deposit { get; set; }
    }
}
