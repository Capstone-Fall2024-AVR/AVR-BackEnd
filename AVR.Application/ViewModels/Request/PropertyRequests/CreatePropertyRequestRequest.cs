using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.PropertyRequests
{
    public class CreatePropertyRequestRequest : IMapFrom<PropertyRequest>
    {
        [Required]
        public Guid OwnerID { get; set; }  // ID của owner

        [Required(ErrorMessage = "Vui lòng nhập tên căn hộ.")]
        public string PropertyName { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá mong muốn.")]
        public decimal ExpectedPrice { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ căn hộ.")]
        public string Address { get; set; }
        // New fields for owner contact information
        [Required(ErrorMessage = "Vui lòng nhập tên người dùng.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại.")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string PhoneNumber { get; set; }

        public string? Note { get; set; }
    }
}
