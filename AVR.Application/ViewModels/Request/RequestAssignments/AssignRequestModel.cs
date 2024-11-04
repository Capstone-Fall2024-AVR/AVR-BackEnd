using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.RequestAssignments
{
    public class AssignRequestModel
    {
        public Guid RequestId { get; set; }
        public Guid StaffId { get; set; }
        public RequestType RequestType { get; set; }
    }
}
