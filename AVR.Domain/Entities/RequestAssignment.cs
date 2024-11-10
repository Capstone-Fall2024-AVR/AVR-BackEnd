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

    public class RequestAssignment
    {
        [Key]
        public Guid AssignmentId { get; set; } = Guid.NewGuid();

        [Required]
        public Guid RequestId { get; set; }
        [Required]
        public RequestType RequestType { get; set; }  // Loại yêu cầu (Appointment, Property, ...)

        [Required]
        public Guid AssignedTeamMemberID { get; set; }
        public virtual TeamMember AssignedTeamMember { get; set; }

        [Required]
        public DateTimeOffset AssignedDate { get; set; } = CoreHelper.SystemTimeNow;

        public DateTimeOffset? CompleteDate { get; set; } // Ngày hoàn thành yêu cầu

        [Required]
        public RequestAssignmentStatus Status { get; set; } = RequestAssignmentStatus.Pending;
    }


}
