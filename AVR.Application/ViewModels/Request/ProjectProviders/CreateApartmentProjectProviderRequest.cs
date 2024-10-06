using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.ProjectProviders
{
    public class CreateApartmentProjectProviderRequest : IMapFrom<ApartmentProjectProvider>
    {
        // Thông tin tài khoản
        [Required(ErrorMessage = "Vui lòng nhập tên.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email.")]
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập xác nhận mật khẩu.")]
        public string ConfirmPassword { get; set; }

        // Thông tin nhà cung cấp dự án
        [Required]
        public string ApartmentProjectProviderName { get; set; }

        [Required]
        public string ApartmentProjectDescription { get; set; }

        [Required]
        public string LegallInfor { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string DiagramUrl { get; set; }
    }


}
