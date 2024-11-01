using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ProjectProviders;
using AVR.Domain.Enums;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/agreements")]
    [ApiController]
    public class AgreementUpdateRequestController : BaseController
    {
        private readonly IAgreementUpdateRequestService _agreementService;

        public AgreementUpdateRequestController(IAgreementUpdateRequestService agreementService)
        {
            _agreementService = agreementService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAgreementUpdateRequest([FromBody] CreateAgreementUpdateRequest request)
        {
            var result = await _agreementService.CreateAsync(request);
            return CustomResult("Yêu cầu cập nhật thỏa thuận đã được tạo thành công.", result);
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllAgreementUpdateRequests()
        {
            var results = await _agreementService.GetAllAsync();
            return CustomResult("Danh sách yêu cầu cập nhật thỏa thuận.", results);
        }

        [HttpGet("{requestId}")]
        public async Task<IActionResult> GetAgreementUpdateRequestById(Guid requestId)
        {
            var result = await _agreementService.GetByIdAsync(requestId);
            return CustomResult("Chi tiết yêu cầu cập nhật thỏa thuận.", result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchAgreementUpdateRequests(
            [FromQuery] AgreementUpdateType? updateType,
            [FromQuery] AgreementUpdateStatus? updateStatus,
            [FromQuery] Guid? accountId,
            [FromQuery] string? title,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 10)
        {
            var results = await _agreementService.SearchAsync(updateType, updateStatus, accountId, title, pageIndex, pageSize);
            return CustomResult("Kết quả tìm kiếm yêu cầu cập nhật thỏa thuận.", results);
        }

        [HttpPut("{requestId}/accept")]
        public async Task<IActionResult> AcceptAgreementUpdateRequest(Guid requestId)
        {
            var result = await _agreementService.AcceptRequestAsync(requestId);
            return CustomResult("Yêu cầu cập nhật thỏa thuận đã được chấp nhận.", result);
        }

        [HttpPut("{requestId}/reject")]
        public async Task<IActionResult> RejectAgreementUpdateRequest(Guid requestId)
        {
            var result = await _agreementService.RejectRequestAsync(requestId);
            return CustomResult("Yêu cầu cập nhật thỏa thuận đã bị từ chối.", result);
        }
    }
}
