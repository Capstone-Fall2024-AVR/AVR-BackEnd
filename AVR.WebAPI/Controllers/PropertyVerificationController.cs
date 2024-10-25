using AVR.Application.Services;
using AVR.Application.ViewModels.Request.PropertyVerifications;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/property-verifications")]
    [ApiController]
    public class PropertyVerificationController : BaseController
    {
        private readonly IPropertyVerificationService _propertyVerificationService;

        public PropertyVerificationController(IPropertyVerificationService propertyVerificationService)
        {
            _propertyVerificationService = propertyVerificationService;
        }

        [HttpPost("create-property-verification")]
        public async Task<IActionResult> CreatePropertyVerification([FromForm] CreatePropertyVerificationRequest request)
        {
            var response = await _propertyVerificationService.CreatePropertyVerification(request);
            return CustomResult("Tải dữ liệu thành công.", response);
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetPropertyVerifications()
        {
            var response = await _propertyVerificationService.GetPropertyVerifications();
            return CustomResult("Tải dữ liệu thành công.", response);
        }

        [HttpGet("{verificationId}")]
        public async Task<IActionResult> GetPropertyVerificationById(Guid verificationId)
        {
            var response = await _propertyVerificationService.GetPropertyVerificationById(verificationId);
            return CustomResult("Tải dữ liệu thành công.", response);
        }

        [HttpPut("accept/{verificationId}")]
        public async Task<IActionResult> AcceptPropertyVerification(Guid verificationId)
        {
            var response = await _propertyVerificationService.AcceptPropertyVerification(verificationId);
            return CustomResult("Xác nhận ký gửi đã được chấp nhận.", response);
        }

        [HttpPut("reject/{verificationId}")]
        public async Task<IActionResult> RejectPropertyVerification(Guid verificationId, [FromBody] string rejectionReason)
        {
            var response = await _propertyVerificationService.RejectPropertyVerification(verificationId, rejectionReason);
            return CustomResult("Xác nhận ký gửi đã bị từ chối.", response);
        }
    }
}
