using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.RequestAssignments
{
    public class UpdateRequestAssignmentModel
    {
        public RequestAssignmentStatus Status { get; set; }
        public DateTimeOffset? CompleteDate { get; set; }
    }
}
