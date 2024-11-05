using AVR.Application.Services;
using AVR.Application.ViewModels.Request.PropertyRequests;
using AVR.Domain.Enums;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/property-requests")]
    [ApiController]
    public class PropertyRequestController : BaseController
    {
        private readonly IPropertyRequestService _propertyRequestService;

        public PropertyRequestController(IPropertyRequestService propertyRequestService)
        {
            _propertyRequestService = propertyRequestService;
        }

        [HttpPost("create-property-request")]
        public async Task<IActionResult> CreatePropertyRequest([FromBody] CreatePropertyRequestRequest request)
        {
            var response = await _propertyRequestService.CreatePropertyRequest(request);
            return CustomResult("Tải dữ liệu thành công.", response);
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetPropertyRequests()
        {
            var proPertyRequests = await _propertyRequestService.GetPropertyRequests();
            return CustomResult("Tải dữ liệu thành công.", proPertyRequests);
        }

        [HttpGet("{requestId}")]
        public async Task<IActionResult> GetPropertyRequestById(Guid requestId)
        {
            var proPertyRequest = await _propertyRequestService.GetPropertyRequestById(requestId);
            return CustomResult("Tải dữ liệu thành công.", proPertyRequest);
        }

        [HttpPut("assign/{requestId}/{staffId}")]
        public async Task<IActionResult> AcceptPropertyRequest(Guid requestId, Guid staffId)
        {
            var response = await _propertyRequestService.AcceptPropertyRequest(requestId, staffId);
            return CustomResult("Assign staff received Property request!", response);

        }

        [HttpPut("reject/{requestId}")]
        public async Task<IActionResult> RejectPropertyRequest(Guid requestId)
        {
            var response = await _propertyRequestService.RejectPropertyRequest(requestId);
            return CustomResult("Property request is rejected !", response);
        }

        [HttpPut("accept/{requestId}")]
        public async Task<IActionResult> AcceptPropertyRequest(Guid requestId)
        {
            var response = await _propertyRequestService.AcceptPropertyRequest(requestId);
            return CustomResult("Property request is accepted !", response);
        }
        [HttpGet("search")]
        public async Task<IActionResult> SearchPropertyRequests(
           [FromQuery] Guid? ownerId,
           [FromQuery] Guid? staffId,
           [FromQuery] string? propertyName,
           [FromQuery] decimal? minExpectedPrice,
           [FromQuery] decimal? maxExpectedPrice,
           [FromQuery] string? address,
           [FromQuery] List<RequestStatus>? requestStatuses,
           [FromQuery] string? userName,
           [FromQuery] string? email,
           [FromQuery] string? phoneNumber)
        {
            var results = await _propertyRequestService.SearchPropertyRequests(
                ownerId,
                staffId,
                propertyName,
                minExpectedPrice,
                maxExpectedPrice,
                address,
                requestStatuses,
                userName,
                email,
                phoneNumber
            );

            return CustomResult("Kết quả tìm kiếm đã được tải thành công.", results);
        }
    }

}
