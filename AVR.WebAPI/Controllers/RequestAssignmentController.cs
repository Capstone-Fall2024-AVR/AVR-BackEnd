using AVR.Application.Services;
using AVR.Application.ViewModels.Request.RequestAssignments;
using AVR.Domain.Enums;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/request-assignments")]
    [ApiController]
    public class RequestAssignmentController : BaseController
    {
        private readonly IRequestAssignmentService _requestAssignmentService;

        public RequestAssignmentController(IRequestAssignmentService requestAssignmentService)
        {
            _requestAssignmentService = requestAssignmentService;
        }

        [HttpGet("{assignmentId}")]
        public async Task<IActionResult> GetRequestAssignment(Guid assignmentId)
        {
            var assignment = await _requestAssignmentService.GetByIdAsync(assignmentId);
            return CustomResult("Tải dữ liệu thành công.", assignment);
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllRequestAssignments()
        {
            var assignments = await _requestAssignmentService.GetAllAsync();
            return CustomResult("Tải dữ liệu thành công.", assignments);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchRequestAssignments([FromQuery] Guid? teamId, [FromQuery] Guid? staffId, [FromQuery] RequestType? requestType, [FromQuery] Guid? requestId, [FromQuery] DateTimeOffset? assignedDate, [FromQuery] DateTimeOffset? completeDate)
        {
            var assignments = await _requestAssignmentService.SearchAsync(teamId, staffId, requestType, requestId, assignedDate, completeDate);
            return CustomResult("Kết quả tìm kiếm được tải thành công.", assignments);
        }

        [HttpPost("assign")]
        public async Task<IActionResult> AssignRequest([FromBody] AssignRequestModel model)
        {
            var assignment = await _requestAssignmentService.AssignRequestAsync(model.RequestId, model.StaffId, model.RequestType);
            return CustomResult("Phân công yêu cầu thành công.", assignment);
        }
        [HttpPut("update-assignment/{assignmentId}")]
        public async Task<IActionResult> UpdateRequestAssignment(Guid assignmentId, [FromBody] UpdateRequestAssignmentModel model)
        {
            var updatedAssignment = await _requestAssignmentService.UpdateAssignRequestAsync(assignmentId, model.Status, model.CompleteDate);
            return CustomResult("Cập nhật yêu cầu phân công thành công.", updatedAssignment);
        }

        [HttpDelete("unassign/{assignmentId}")]
        public async Task<IActionResult> UnassignRequest(Guid assignmentId)
        {
            var result = await _requestAssignmentService.UnassignRequestAsync(assignmentId);
            return CustomResult("Hủy phân công yêu cầu thành công.", result);
        }

    }
}
