using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Appointments
{
    public class CreateAppointmentResponse : IMapFrom<Appointment>
    {
        public Guid AppointmentID { get; set; }
        public string AppointmentCode { get; set; }
        public string ApartmentCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }


        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public DateTimeOffset AssignedDate { get; set; }
        public DateTimeOffset AppointmentDate { get; set; }
        public string AppointmentStatus { get; set; }
        public string AppointmentTypes { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        // Staff
        public Guid? AssignedTeamMemberID { get; set; }

        public Guid? AssigndAccountID { get; set; }
        public string? SellerName { get; set; }
        public string? SellerPhone { get; set; }
        // Customer
        public Guid? CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }

        // Apartment
        public Guid ApartmentID { get; set; }

        public string ReferenceCode { get; set; }
    }
}
