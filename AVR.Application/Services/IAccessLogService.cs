using AVR.Application.ViewModels.Request.AccessLogs;
using AVR.Application.ViewModels.Response.AccessLogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IAccessLogService
    {
        Task<ProjectAccessLogResponse> CreateProjectAccessLogAsync(CreateProjectAccessLogRequest request);
        Task<VRAccessLogResponse> CreateVRAccessLogAsync(CreateVRAccessLogRequest request);
        Task<IEnumerable<ProjectAccessLogResponse>> GetProjectAccessLogsAsync(Guid projectId);
        Task<IEnumerable<VRAccessLogResponse>> GetVRAccessLogsAsync(Guid vrExperienceId);
        Task<(IEnumerable<VRAccessLogResponse> Logs, int TotalItems, int TotalPages)> SearchVRAccessLogsAsync(
            Guid? vrExperienceId,
            DateTimeOffset? fromDate,
            DateTimeOffset? toDate,
            int pageIndex = 1,
            int pageSize = 5);
        Task<(IEnumerable<ProjectAccessLogResponse> Logs, int TotalItems, int TotalPages)> SearchProjectAccessLogsAsync(
            Guid? projectApartmentId,
            DateTimeOffset? fromDate,
            DateTimeOffset? toDate,
            int pageIndex = 1,
            int pageSize = 5);
        Task DeleteProjectAccessLogAsync(Guid logId);
        Task DeleteVRAccessLogAsync(Guid logId);
    }
}
