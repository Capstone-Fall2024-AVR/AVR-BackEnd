using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.AppointmentRequests
{
    public class CreateAppointmentReqRequest : IMapFrom<AppointmentRequest>
    {
        [Required]
        public Guid CustomerID { get; set; }
        [Required]
        public Guid ApartmentID { get; set; }
        public DateTimeOffset? PreferredDate { get; set; }
        public TimeSpan? PreferredTime { get; set; }

        [Required(ErrorMessage = "Tên người dùng là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Tên người dùng không được vượt quá 100 ký tự.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string PhoneNumber { get; set; }

    }
}
