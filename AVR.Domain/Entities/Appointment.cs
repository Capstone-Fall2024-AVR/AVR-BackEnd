using AVR.Domain.Enums;
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
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string AssignedBy { get; set; }
        [Required]
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        [Required]
        public DateTimeOffset AssignedDate { get; set; }
        [Required]
        public DateTimeOffset AppointmentDate { get; set; }
        [Required]
        public AppointmentStatus AppointmentStatus { get; set; }
        [Required]
        public AppointmentTypes AppointmentTypes { get; set; }

        /*//Customer
        public Guid CustomerID { get; set; }
        public virtual Customer Customers { get; set; }*/

        //Slot
        public Guid SlotID { get; set; }
        public virtual Slot Slots { get; set; }

        // Thay thế Staff bằng Account
        public Guid AccountID { get; set; }
        public virtual Account Accounts { get; set; }

        //Apartment
        public Guid ApartmentID { get; set; }
        public virtual Apartment Apartments { get; set; }
    }

}
