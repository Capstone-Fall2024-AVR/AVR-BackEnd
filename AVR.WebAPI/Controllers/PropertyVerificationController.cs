using AVR.Application.ServiceImplements;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.PropertyVerifications;
using AVR.Domain.Enums;
using CoreApiResponse;
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

        // Lấy thông tin PropertyVerification theo ID
        [HttpGet("{verificationId}")]
        public async Task<IActionResult> GetVerificationById(Guid verificationId)
        {
            var verification = await _propertyVerificationService.GetByIdAsync(verificationId);
            return CustomResult("Tải dữ liệu xác minh thành công.", verification);
        }

        // Lấy tất cả PropertyVerifications
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllVerifications()
        {
            var verifications = await _propertyVerificationService.GetAllAsync();
            return CustomResult("Tải tất cả dữ liệu xác minh thành công.", verifications);
        }

        // Tạo mới một PropertyVerification
        [HttpPost("create")]
        public async Task<IActionResult> CreateVerification([FromForm] PropertyVerificationRequest request)
        {
            var verification = await _propertyVerificationService.CreateAsync(request);
            return CustomResult("Tạo phiên xác minh thành công.", verification);
        }

        // Cập nhật một PropertyVerification
        [HttpPatch("update/{verificationId}")]
        public async Task<IActionResult> UpdateVerification(Guid verificationId, [FromForm] UpdatePropertyVerificationRequest request)
        {
            var updatedVerification = await _propertyVerificationService.UpdateAsync(verificationId, request);
            return CustomResult("Cập nhật phiên xác minh thành công.", updatedVerification);
        }

        // Xóa một PropertyVerification
        [HttpDelete("delete/{verificationId}")]
        public async Task<IActionResult> DeleteVerification(Guid verificationId)
        {
            var result = await _propertyVerificationService.DeleteAsync(verificationId);
            return CustomResult("Xóa phiên xác minh thành công.", result);
        }

        // Chấp nhận một PropertyVerification
        [HttpPost("accept/{verificationId}")]
        public async Task<IActionResult> AcceptVerification(Guid verificationId)
        {
            var acceptedVerification = await _propertyVerificationService.AcceptAsync(verificationId);
            return CustomResult("Phiên xác minh đã được chấp nhận.", acceptedVerification);
        }

        // Từ chối một PropertyVerification
        [HttpPost("reject/{verificationId}")]
        public async Task<IActionResult> RejectVerification(Guid verificationId)
        {
            var rejectedVerification = await _propertyVerificationService.RejectAsync(verificationId);
            return CustomResult("Phiên xác minh đã bị từ chối.", rejectedVerification);
        }

        // Tìm kiếm PropertyVerifications
        [HttpGet("search")]
        public async Task<IActionResult> SearchVerifications(
            [FromQuery] string? name,
            [FromQuery] VerificationStatus? status,
            [FromQuery] DateTimeOffset? startDate,
            [FromQuery] DateTimeOffset? endDate,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 10)
        {
            var (verifications, totalItem, totalPage) = await _propertyVerificationService.SearchAsync(
                name, status, startDate, endDate, pageIndex, pageSize);

            var result = new
            {
                TotalItems = totalItem,
                TotalPages = totalPage,
                Verifications = verifications,
                CurrentPage = pageIndex,
                PageSize = pageSize
            };

            return CustomResult("Tìm kiếm phiên xác minh thành công.", result);
        }

        // Gia hạn hợp đồng cho căn hộ
        [HttpPost("renew-contract")]
        public async Task<IActionResult> RenewContract([FromForm] RenewContractRequest request)
        {
            var response = await _propertyVerificationService.RenewContractAsync(request);
            return CustomResult("Gia hạn hợp đồng thành công.", response);
        }

        [HttpGet("contracts")]
        public async Task<IActionResult> GetContractSummaries(
            [FromQuery] string? ownerName = null,
            [FromQuery] string? contractCode = null,
            [FromQuery] VerificationStatus? status = null,
            [FromQuery] DateTimeOffset? startDate = null,
            [FromQuery] DateTimeOffset? endDate = null,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 10)
        {
            // Gọi service để lấy danh sách hợp đồng dựa trên điều kiện tìm kiếm
            var (results, totalItems, totalPages) = await _propertyVerificationService.SearchContractsAsync(
                ownerName, contractCode, status, startDate, endDate, pageIndex, pageSize);

            // Đóng gói dữ liệu trả về
            var response = new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                Contracts = results,
                CurrentPage = pageIndex,
                PageSize = pageSize
            };

            // Trả về kết quả
            return CustomResult("Tải danh sách hợp đồng thành công.", response);
        }

        [HttpGet("near-expiry")]
        public async Task<IActionResult> GetNearExpiryVerifications([FromQuery] int days = 7)
        {
            var verifications = await _propertyVerificationService.GetNearExpiryVerificationsAsync(days);
            return CustomResult("Lấy danh sách xác minh gần ngày hết hạn thành công.", verifications);
        }


    }
}
