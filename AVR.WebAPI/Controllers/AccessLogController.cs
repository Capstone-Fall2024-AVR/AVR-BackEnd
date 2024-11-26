using AVR.Application.Services;
using AVR.Application.ViewModels.Request.AccessLogs;
using AVR.Application.ViewModels.Response.AccessLogs;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/access-logs")]
    [ApiController]
    public class AccessLogController : BaseController
    {
        private readonly IAccessLogService _accessLogService;

        public AccessLogController(IAccessLogService accessLogService)
        {
            _accessLogService = accessLogService;
        }

        // Tạo log truy cập dự án
        [HttpPost("project")]
        public async Task<IActionResult> CreateProjectAccessLog([FromBody] CreateProjectAccessLogRequest request)
        {
            var result = await _accessLogService.CreateProjectAccessLogAsync(request);
            return CustomResult("Tạo log truy cập dự án thành công.", result);
        }

        // Tạo log truy cập VR
        [HttpPost("vr")]
        public async Task<IActionResult> CreateVRAccessLog([FromBody] CreateVRAccessLogRequest request)
        {
            var result = await _accessLogService.CreateVRAccessLogAsync(request);
            return CustomResult("Tạo log truy cập VR thành công.", result);
        }

        // Lấy danh sách log truy cập dự án theo projectId
        [HttpGet("project/{projectId}")]
        public async Task<IActionResult> GetProjectAccessLogs(Guid projectId)
        {
            var result = await _accessLogService.GetProjectAccessLogsAsync(projectId);
            return CustomResult("Lấy danh sách log truy cập dự án thành công.", result);
        }

        // Lấy danh sách log truy cập VR theo VRExperienceID
        [HttpGet("vr/{vrExperienceId}")]
        public async Task<IActionResult> GetVRAccessLogs(Guid vrExperienceId)
        {
            var result = await _accessLogService.GetVRAccessLogsAsync(vrExperienceId);
            return CustomResult("Lấy danh sách log truy cập VR thành công.", result);
        }

        // Tìm kiếm log truy cập dự án
        [HttpGet("project/search")]
        public async Task<IActionResult> SearchProjectAccessLogs(
            [FromQuery] Guid? projectApartmentId,
            [FromQuery] DateTimeOffset? fromDate,
            [FromQuery] DateTimeOffset? toDate,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 5)
        {
            var (logs, totalItems, totalPages) = await _accessLogService.SearchProjectAccessLogsAsync(projectApartmentId, fromDate, toDate, pageIndex, pageSize);
            var result = new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                Logs = logs,
                CurrentPage = pageIndex,
                PageSize = pageSize
            };
            return CustomResult("Tìm kiếm log truy cập dự án thành công.", result);
        }

        // Tìm kiếm log truy cập VR
        [HttpGet("vr/search")]
        public async Task<IActionResult> SearchVRAccessLogs(
            [FromQuery] Guid? vrExperienceId,
            [FromQuery] DateTimeOffset? fromDate,
            [FromQuery] DateTimeOffset? toDate,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 5)
        {
            var (logs, totalItems, totalPages) = await _accessLogService.SearchVRAccessLogsAsync(vrExperienceId, fromDate, toDate, pageIndex, pageSize);
            var result = new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                Logs = logs,
                CurrentPage = pageIndex,
                PageSize = pageSize
            };
            return CustomResult("Tìm kiếm log truy cập VR thành công.", result);
        }

        // Xóa log truy cập dự án
        [HttpDelete("project/{logId}")]
        public async Task<IActionResult> DeleteProjectAccessLog(Guid logId)
        {
            await _accessLogService.DeleteProjectAccessLogAsync(logId);
            return CustomResult("Xóa log truy cập dự án thành công.");
        }

        // Xóa log truy cập VR
        [HttpDelete("vr/{logId}")]
        public async Task<IActionResult> DeleteVRAccessLog(Guid logId)
        {
            await _accessLogService.DeleteVRAccessLogAsync(logId);
            return CustomResult("Xóa log truy cập VR thành công.");
        }
    }
}
