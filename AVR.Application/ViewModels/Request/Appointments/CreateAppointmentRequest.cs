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
    public class CreateAppointmentRequest : IMapFrom<Appointment>
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string AssignedBy { get; set; }

        [Required]
        public DateTimeOffset CreateDate { get; set; }

        [Required]
        public DateTimeOffset UpdateDate { get; set; }

        [Required]
        public DateTimeOffset AssignedDate { get; set; }

        [Required]
        public DateTimeOffset AppointmentDate { get; set; }

        [Required]
        public AppointmentStatus AppointmentStatus { get; set; }

        [Required]
        public AppointmentTypes AppointmentTypes { get; set; }

        // Slot
        [Required]
        public Guid SlotID { get; set; }

        // Staff
        public Guid? StaffID { get; set; }

       
        // Customer
        public Guid? CustomerID { get; set; }

        // Apartment
        [Required]
        public Guid ApartmentID { get; set; }
    }
}
