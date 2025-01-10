using AVR.Domain.Enums;
using AVR.Domain.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class Appointment
    {
        [Key]
        public Guid AppointmentID { get; set; } = Guid.NewGuid();
        public string AppointmentCode { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Location { get; set; }
        [Required]
        public DateTimeOffset CreateDate { get; set; } = CoreHelper.SystemTimeNow;
        public DateTimeOffset UpdatedDate { get; set; } = CoreHelper.SystemTimeNow;
        
        public DateTimeOffset? AssignedDate { get; set; } //Ngày assign nhân viên vào
        [Required]
        public DateTimeOffset AppointmentDate { get; set; }
        [Required]
        public AppointmentStatus AppointmentStatus { get; set; }
        [Required]
        public AppointmentTypes AppointmentTypes { get; set; }


         // Thời gian bắt đầu và kết thúc của cuộc hẹn
    
        public TimeSpan? StartTime { get; set; }
        
        
        public TimeSpan? EndTime { get; set; }

        //Slot
        public Guid? SlotID { get; set; }
        public virtual Slot Slots { get; set; }

        public Guid? AssignedTeamMemberID { get; set; }
        public virtual TeamMember AssignedTeamMember { get; set; }

        // Customer
        public Guid CustomerID { get; set; }
        public virtual Account Customer { get; set; }

        //Apartment
        public Guid? ApartmentID { get; set; }
        public virtual Apartment Apartments { get; set; }

        public string ReferenceCode { get; set; }

        public string Username { get; set; }
        public string Phone {  get; set; }
    }

}
