using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Owners
{
    public class UpdateApartmentOwnerRequest : IMapFrom<ApartmentOwner>
    {
        [Required(ErrorMessage = "Tên không được để trống.")]
        [MaxLength(100, ErrorMessage = "Tên không được vượt quá 100 ký tự.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email không được để trống.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống.")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Giấy tờ tùy thân không được để trống.")]
        [MaxLength(20, ErrorMessage = "Giấy tờ tùy thân không được vượt quá 20 ký tự.")]
        public string NationalID { get; set; }

        [Required(ErrorMessage = "Ngày cấp giấy tờ tùy thân không được để trống.")]
        public DateTimeOffset IssueDate { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống.")]
        public DateTimeOffset BirthDate { get; set; }

        [Required(ErrorMessage = "Quốc tịch không được để trống.")]
        [MaxLength(50, ErrorMessage = "Quốc tịch không được vượt quá 50 ký tự.")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Giới tính không được để trống.")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống.")]
        [MaxLength(255, ErrorMessage = "Địa chỉ không được vượt quá 255 ký tự.")]
        public string Address { get; set; }
    }
}
