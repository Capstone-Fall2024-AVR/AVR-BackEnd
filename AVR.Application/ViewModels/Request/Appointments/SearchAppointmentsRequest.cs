using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Appointments
{
    public class SearchAppointmentsRequest
    {
        public Guid? CustomerID { get; set; }
        public Guid? ApartmentID { get; set; }
        public Guid? SellerId { get; set; }
        public AppointmentStatus? Status { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public string? Title { get; set; }
        public string? keyword { get; set; }
        public Guid? TeamID { get; set; }
        public string? ReferenceCode { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

}
