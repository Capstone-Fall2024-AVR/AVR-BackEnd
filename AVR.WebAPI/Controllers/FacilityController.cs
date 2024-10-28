using AVR.Application.Services;
using AVR.Application.ViewModels.Request.FacilitiesReq;
using AVR.Domain.Entities;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/facilities")]
    [ApiController]
    public class FacilityController : BaseController
    {
        private readonly IFacilityService _facilityService;

        public FacilityController(IFacilityService facilityService)
        {
            _facilityService = facilityService;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllFacilities()
        {
            var facilities = await _facilityService.GetAllFacilitiesAsync();
            return CustomResult("Tải dữ liệu thành công.", facilities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFacilityById(Guid id)
        {
            var facility = await _facilityService.GetFacilityByIdAsync(id);
            return CustomResult("Tải dữ liệu thành công.", facility);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateFacility(FacilityRequest request)
        {
            var facility = await _facilityService.CreateFacilityAsync(request);
            return CustomResult("Tạo tiện ích thành công.", facility);
        }
    }
}
