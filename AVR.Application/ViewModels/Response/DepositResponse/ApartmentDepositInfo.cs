using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.DepositResponse
{
    public class ApartmentDepositInfo
    {
        public Guid ApartmentId { get; set; }
        public string ApartmentCode { get; set; }
        public string ApartmentName { get; set; }
        public double TotalDepositAmount { get; set; }
        public string DepositCode { get; set; }
        public string TransactionNo { get; set; }
        public DateTimeOffset? DepositDate { get; set; }

        // Fields from DepositProfile
        public string FullName { get; set; }  // Họ và tên
        public string IdentityCardNumber { get; set; }  // Số CCCD
        public DateTime DateOfIssue { get; set; }  // Ngày cấp
        public DateTime DateOfBirth { get; set; }  // Ngày sinh
        public string Nationality { get; set; }  // Quốc tịch
        public string Address { get; set; }  // Địa chỉ
        public string Email { get; set; }  // Email
        public string PhoneNumber { get; set; }  // Số điện thoại
        public string IdentityCardFrontImage { get; set; }  // Ảnh CCCD mặt trước
        public string IdentityCardBackImage { get; set; }  // Ảnh CCCD mặt sau
    }

}
