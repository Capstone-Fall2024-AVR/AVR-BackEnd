using AVR.Application.ServiceImplements;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Apartments;
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

        public async Task<IActionResult> GetApartmentInfo(Guid apartmentId)
        {
            var apartment = await _apartmentService.GetApartmentById(apartmentId);
            return CustomResult("Tải dữ liệu thành công.", apartment);
        }

        [HttpGet("get-all")]

        public async Task<IActionResult> GetAllApartments()
        {
            var apartments = await _apartmentService.GetApartments();
            return CustomResult("Tải dữ liệu thành công.", apartments);
        }

        [HttpPost("create-apartment-for-project")]
        public async Task<IActionResult> CreateApartmentForProject(CreateApartmentRequest request)
        {
            var apartment = await _apartmentService.CreateApartment(request);
            return CustomResult("Tạo căn hộ thành công.", apartment);
        }



        [HttpPost("create-apartment-for-owner")]
        public async Task<IActionResult> CreateApartmentForOwner(CreateApartmentRequest request)
        {
            var apartment = await _apartmentService.CreateApartment(request);
            return CustomResult("Tạo căn hộ thành công.", apartment);
        }

        [HttpPost("create-apartment-list-for-project")]
        public async Task<IActionResult> CreateApartmentList([FromBody] CreateApartmentListRequest request)
        {
            var apartments = await _apartmentService.CreateApartmentList(request);
            return CustomResult("Tạo danh sách căn hộ thành công.", apartments);
        }

    }
}
