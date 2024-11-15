using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Owners;
using AVR.Domain.Enums;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/apartment-owners")]
    [ApiController]
    public class ApartmentOwnerController : BaseController
    {
        private readonly IApartmentOwnerService _apartmentOwnerService;

        public ApartmentOwnerController(IApartmentOwnerService apartmentOwnerService)
        {
            _apartmentOwnerService = apartmentOwnerService;
        }

        // Lấy thông tin chi tiết của một ApartmentOwner theo ID
        [HttpGet("{apartmentOwnerId}")]
        public async Task<IActionResult> GetOwnerInfo(Guid apartmentOwnerId)
        {
            var owner = await _apartmentOwnerService.GetApartmentOwnerByIdAsync(apartmentOwnerId);
            return CustomResult("Lấy thông tin chi tiết thành công.", owner);
        }

        // Lấy danh sách tất cả ApartmentOwners
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllOwners()
        {
            var owners = await _apartmentOwnerService.GetAllApartmentOwnersAsync();
            return CustomResult("Tải dữ liệu thành công.", owners);
        }

        // Tìm kiếm ApartmentOwners
        [HttpGet("search")]
        public async Task<IActionResult> SearchOwners(
            [FromQuery] string? name,
            [FromQuery] string? email,
            [FromQuery] string? phoneNumber,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 5)
        {
            var (owners, totalItems, totalPages) = await _apartmentOwnerService.SearchApartmentOwnersAsync(
                name, email, phoneNumber, pageIndex, pageSize
            );

            var result = new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                Owners = owners,
                CurrentPage = pageIndex,
                PageSize = pageSize
            };

            return CustomResult("Tìm kiếm thành công.", result);
        }

        // Tạo mới một ApartmentOwner
        [HttpPost("create-owner")]
        public async Task<IActionResult> CreateApartmentOwner(CreateApartmentOwnerRequest request)
        {
            var owner = await _apartmentOwnerService.CreateApartmentOwnerAsync(request);
            return CustomResult("Tạo chủ sở hữu căn hộ thành công.", owner);
        }

        // Cập nhật thông tin của một ApartmentOwner
        [HttpPut("update-owner/{apartmentOwnerId}")]
        public async Task<IActionResult> UpdateApartmentOwner(Guid apartmentOwnerId, [FromForm] UpdateApartmentOwnerRequest request)
        {
            var result = await _apartmentOwnerService.UpdateApartmentOwnerAsync(apartmentOwnerId, request);
            return CustomResult("Cập nhật thông tin chủ sở hữu thành công.", result);
        }


        [HttpGet("search-with-properties")]
        public async Task<IActionResult> SearchApartmentOwnerWithProperties([FromQuery] Guid? apartmentId, [FromQuery] Guid? ownerId)
        {
            var response = await _apartmentOwnerService.SearchApartmentOwnerWithPropertiesAsync(apartmentId, ownerId);
            return CustomResult("Tìm kiếm chủ sở hữu căn hộ và thông tin hợp đồng thành công.", response);
        }


    }
}
