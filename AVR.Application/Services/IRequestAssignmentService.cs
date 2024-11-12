using AVR.Application.ViewModels.Response.RequestAssignments;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{

    public interface IRequestAssignmentService
    {
        Task<IEnumerable<RequestAssignmentResponse>> GetAllAsync();
        Task<RequestAssignmentResponse> GetByIdAsync(Guid assignmentId);
        Task<RequestAssignmentResponse> AssignRequestAsync(Guid requestId, Guid staffId, RequestType requestType);
        Task<RequestAssignmentResponse> UpdateAssignRequestAsync(Guid assignmentId, RequestAssignmentStatus newStatus, DateTimeOffset? completeDate = null);
        Task<bool> UnassignRequestAsync(Guid assignmentId);
        Task<IEnumerable<RequestAssignmentResponse>> SearchAsync(Guid? teamId, Guid? assignedTeamMemberID, RequestType? requestType, Guid? requestId, DateTimeOffset? assignedDate, DateTimeOffset? completeDate);
    }
}
