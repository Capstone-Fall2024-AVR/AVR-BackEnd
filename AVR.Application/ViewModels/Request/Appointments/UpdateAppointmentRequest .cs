using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Appointments
{
    public class UpdateAppointmentRequest : IMapFrom<Appointment>
    {
        [Required]
        public Guid AppointmentID { get; set; }  // ID của cuộc hẹn cần cập nhật

        [Required]
        public DateTimeOffset NewAppointmentDate { get; set; }  // Ngày mới của cuộc hẹn

        [Required]
        public TimeSpan NewStartTime { get; set; }  // Giờ bắt đầu mới

        [Required]
        public TimeSpan NewEndTime { get; set; }  // Giờ kết thúc mới

        [Required]
        public AppointmentStatus NewStatus { get; set; }  // Trạng thái mới của cuộc hẹn, ví dụ: Confirmed, InProcessing, Done, Canceled, Updated

        public string UpdatedDescription { get; set; }  // Mô tả thêm nếu cần (không bắt buộc)
    }
}
