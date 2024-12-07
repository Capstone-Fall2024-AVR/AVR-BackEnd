using AVR.Application.Services;
using AVR.Application.ViewModels.Request.AppointmentRequests;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/appointmentrequests")]
    [ApiController]
    public class AppointmentRequestController : BaseController
    {
        private readonly IAppointmentRequestService _appointmentRequestService;
        public AppointmentRequestController (IAppointmentRequestService appointmentRequestService)
        {
            _appointmentRequestService = appointmentRequestService;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllRequests()
        {
            var requests = await _appointmentRequestService.GetAllRequestsAsync();
            return CustomResult("Danh sách yêu cầu được tải thành công.", requests);
        }

        // Lấy yêu cầu theo ID
        [HttpGet("{requestId}")]
        public async Task<IActionResult> GetRequestById(Guid requestId)
        {
            var request = await _appointmentRequestService.GetRequestByIdAsync(requestId);
            return CustomResult("Yêu cầu được tải thành công.", request);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateRequest(CreateAppointmentReqRequest createRequest)
        {
            var newRequest = await _appointmentRequestService.CreateRequestAsync(createRequest);
            return CustomResult("Yêu cầu cuộc hẹn được tạo thành công.", newRequest);
        }

        [HttpPut("assign-staff/{requestId}")]
        public async Task<IActionResult> AssignStaff(Guid requestId, [FromForm] Guid staffId)
        {
            var updatedRequest = await _appointmentRequestService.AssignStaffAsync(requestId, staffId);
            return CustomResult("Nhân viên được gán thành công vào yêu cầu.", updatedRequest);
        }

        [HttpPut("update-status/{requestId}")]
        public async Task<IActionResult> UpdateStatus(Guid requestId, [FromBody] RequestStatus newStatus)
        {
            var updatedRequest = await _appointmentRequestService.UpdateRequestStatusAsync(requestId, newStatus);
            return CustomResult("Trạng thái yêu cầu được cập nhật thành công.", updatedRequest);
        }

        // Chấp nhận yêu cầu
        [HttpPut("accept/{requestId}")]
        public async Task<IActionResult> AcceptRequest(Guid requestId)
        {
            var acceptedRequest = await _appointmentRequestService.AcceptRequestAsync(requestId);
            return CustomResult("Yêu cầu đã được chấp nhận thành công.", acceptedRequest);
        }

        // Từ chối yêu cầu
        [HttpPut("reject/{requestId}")]
        public async Task<IActionResult> RejectRequest(Guid requestId)
        {
            var rejectedRequest = await _appointmentRequestService.RejectRequestAsync(requestId);
            return CustomResult("Yêu cầu đã được từ chối thành công.", rejectedRequest);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchAppointmentRequests(
            [FromQuery] Guid? customerId,
            [FromQuery] Guid? apartmentId,
            [FromQuery] RequestStatus? status,
            [FromQuery] AppointmentTypes? requestType,
            [FromQuery] Guid? assignedTeamMemberID,
            [FromQuery] DateTimeOffset? preferredDate,
            [FromQuery] DateTimeOffset? startDate,
            [FromQuery] DateTimeOffset? endDate,
            [FromQuery] Guid? teamId,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 10
)
        {
            var (results, totalItems, totalPages) = await _appointmentRequestService.SearchAppointmentRequestsAsync(
                customerId, apartmentId, status, requestType, assignedTeamMemberID, preferredDate, startDate, endDate, teamId, pageIndex, pageSize
            );

            return CustomResult("Kết quả tìm kiếm yêu cầu cuộc hẹn.", new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                Results = results,
                CurrentPage = pageIndex,
                PageSize = pageSize
            });
        }

    }
}
