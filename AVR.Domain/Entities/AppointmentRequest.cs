using AVR.Domain.Enums;
using AVR.Domain.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class AppointmentRequest
    {
        [Key]
        public Guid RequestID { get; set; } = Guid.NewGuid();

        public string AppointmentRequestCode { get; set; }

        [AllowNull]
        public string? Note { get; set; }

        [Required]
        public Guid CustomerID { get; set; }  // Khách hàng gửi yêu cầu
        public virtual Account Customer { get; set; }

        [AllowNull]
        public Guid? SellerID { get; set; }  
        public virtual Account Seller { get; set; }

        [Required]
        public Guid ApartmentID { get; set; }  // Căn hộ được yêu cầu
        public virtual Apartment Apartment { get; set; }

        [Required]
        public AppointmentTypes RequestType { get; set; }  

        public DateTimeOffset? PreferredDate { get; set; }  // Thời gian mong muốn của khách hàng
        public TimeSpan? PreferredTime { get; set; }
        public DateTimeOffset? AssignedDate { get; set; } //Ngày assign nhân viên vào
        public RequestStatus Status { get; set; } = RequestStatus.Pending;

        public Guid? AssignedTeamMemberID { get; set; }
        public virtual TeamMember AssignedTeamMember { get; set; }

        // New Fields
        [Required]
        [StringLength(100, ErrorMessage = "Tên người dùng không được vượt quá 100 ký tự.")]
        public string Username { get; set; }  // Tên người dùng của khách hàng

        [Required]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string PhoneNumber { get; set; }  // Số điện thoại của khách hàng

        [Required]
        public DateTimeOffset CreateDate { get; set; } = CoreHelper.SystemTimeNow;  
        [Required]
        public DateTimeOffset UpdateDate { get; set; } = CoreHelper.SystemTimeNow;

    }
}
