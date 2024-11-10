using AVR.Application.ServiceImplements;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Apartments;
using AVR.Domain.Enums;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/apartments")]
    [ApiController]
    public class ApartmentController : BaseController
    {
        private readonly IApartmentService _apartmentService;
        public ApartmentController (IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }

        [HttpGet("{apartmentId}")]

        public async Task<IActionResult> GetApartmentInfo(Guid apartmentId, [FromQuery] Guid? accountId)
        {
            var apartment = await _apartmentService.GetApartmentById(apartmentId, accountId);
            return CustomResult("Tải dữ liệu thành công.", apartment);
        }

        [HttpGet("get-all")]

        public async Task<IActionResult> GetAllApartments()
        {
            var apartments = await _apartmentService.GetApartments();
            return CustomResult("Tải dữ liệu thành công.", apartments);
        }

        [HttpPost("create-apartment-for-project")]
        public async Task<IActionResult> CreateApartmentForProject([FromForm] CreateApartmentRequest request)
        {
            var apartment = await _apartmentService.CreateApartment(request);
            return CustomResult("Tạo căn hộ thành công cho dự án.", apartment);
        }




        [HttpPost("create-apartment-for-owner")]
        public async Task<IActionResult> CreateApartmentForOwner([FromForm] CreateApartmentForOwnerRequest request)
        {
            var apartment = await _apartmentService.CreateApartmentForOwnerAsync(request);
            return CustomResult("Tạo căn hộ thành công cho chủ sở hữu.", apartment);
        }


        [HttpPost("create-apartment-list-for-project")]
        public async Task<IActionResult> CreateApartmentList([FromBody] CreateApartmentListRequest request)
        {
            var apartments = await _apartmentService.CreateApartmentList(request);
            return CustomResult("Tạo danh sách căn hộ thành công.", apartments);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchApartments(
            [FromQuery] string? apartmentName,
            [FromQuery] string? address,
            [FromQuery] string? district,
            [FromQuery] string? ward,
            [FromQuery] List<ApartmentType>? apartmentTypes,
            [FromQuery] decimal? minPrice,
            [FromQuery] decimal? maxPrice,
            [FromQuery] decimal? minArea,
            [FromQuery] decimal? maxArea,
            [FromQuery] int? numberOfRooms,
            [FromQuery] int? numberOfBathrooms,
            [FromQuery] List<Direction>? directions,
            [FromQuery] List<BalconyDirection>? balconyDirections,
            [FromQuery] Guid? accountId,
            [FromQuery] bool? userLiked = null,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 5)
        {
            // Call the service to search for apartments
            var (apartments, totalItem) = await _apartmentService.SearchApartments(
                apartmentName,
                address,
                district,
                ward,
                apartmentTypes,
                minPrice,
                maxPrice,
                minArea,
                maxArea,
                numberOfRooms,
                numberOfBathrooms,
                directions,
                balconyDirections,
                accountId,
                userLiked,
                pageIndex,
                pageSize
            );

            // Create a response object containing both the apartments list and total item count
            var result = new
            {
                TotalItem = totalItem,
                Apartments = apartments
            };

            // Return the custom result with the total item count and paginated apartments
            return CustomResult("Tìm kiếm căn hộ thành công.", result);
        }



        [HttpPut("approve/{id}")]
        public async Task<IActionResult> ApproveApartment(Guid id)
        {
            var result = await _apartmentService.ApproveApartment(id);
            return CustomResult("Căn hộ đã được duyệt thành công.", result);
        }

        [HttpPut("reject/{id}")]
        public async Task<IActionResult> RejectApartment(Guid id)
        {
            var result = await _apartmentService.RejectApartment(id);
            return CustomResult("Căn hộ đã bị từ chối.", result);
        }

    }
}
