using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.RequestAssignments
{
    public class RequestAssignmentResponse : IMapFrom<RequestAssignment>
    {
        public Guid AssignmentId { get; set; }
        public Guid RequestId { get; set; }
        public string RequestType { get; set; }
        public Guid StaffId { get; set; }
        public DateTimeOffset AssignedDate { get; set; }
        public DateTimeOffset? CompleteDate { get; set; }
        public string Status { get; set; }
    }
}
