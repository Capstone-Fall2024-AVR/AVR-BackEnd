using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class AppointmentRequest
    {
        [Key]
        public Guid RequestID { get; set; } = Guid.NewGuid();

        [Required]
        public Guid CustomerID { get; set; }  // Khách hàng gửi yêu cầu
        public virtual Account Customer { get; set; }

        [Required]
        public Guid ApartmentID { get; set; }  // Căn hộ được yêu cầu
        public virtual Apartment Apartment { get; set; }

        [Required]
        public AppointmentTypes RequestType { get; set; }  

        public DateTimeOffset? PreferredDate { get; set; }  // Thời gian mong muốn của khách hàng
        public TimeSpan? PreferredTime { get; set; }
        public DateTimeOffset? AssignedDate { get; set; } //Ngày assign nhân viên vào
        public RequestStatus Status { get; set; } = RequestStatus.Pending;  

        public Guid? StaffID { get; set; } 
        public virtual Account Staff { get; set; }

        [Required]
        public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.Now;  
        [Required]
        public DateTimeOffset UpdateDate { get; set; } = DateTimeOffset.Now;
    }
}
