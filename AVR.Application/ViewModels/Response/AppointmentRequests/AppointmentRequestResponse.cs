using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.AppointmentRequests
{
    public class AppointmentRequestResponse : IMapFrom<AppointmentRequest>
    {
        public Guid RequestID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid ApartmentID { get; set; }
        public string RequestType { get; set; }
        public DateTimeOffset? PreferredDate { get; set; }
        public TimeSpan? PreferredTime { get; set; }
        public DateTimeOffset? AssignedDate { get; set; }
        public string Status { get; set; }
        public Guid? AssignedTeamMemberID { get; set; }
        public Guid AssigndAccountID { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
    }
}
