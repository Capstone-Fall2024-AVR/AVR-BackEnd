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
        [Required]
        public string Location { get; set; }

        [Required]
        public DateTimeOffset AppointmentDate { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        // Staff
        public Guid AssignedStaffAccountID { get; set; }



        // Customer
        public Guid CustomerID { get; set; }

        // Apartment
        public Guid? ApartmentID { get; set; }

        [Required]
        public string ReferenceCode { get; set; }
    }
}
