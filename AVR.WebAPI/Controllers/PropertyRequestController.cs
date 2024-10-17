using AVR.Application.Services;
using AVR.Application.ViewModels.Request.PropertyRequests;
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
    }
}
