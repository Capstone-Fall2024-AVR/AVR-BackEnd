using AVR.Application.Services;
using AVR.Application.ViewModels.Request.VRExperiences;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/vrexperiences")]
    [ApiController]
    public class VRExperienceController : BaseController
    {
        private readonly IVRExperienceService _vrExperienceService;

        public VRExperienceController(IVRExperienceService vrExperienceService)
        {
            _vrExperienceService = vrExperienceService;
        }

        // Get all VR Experiences
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllVRExperiences()
        {
            var experiences = await _vrExperienceService.GetAllVRExperiencesAsync();
            return CustomResult("Danh sách trải nghiệm VR được tải thành công.", experiences);
        }

        // Get VR Experience by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVRExperienceById(Guid id)
        {
            var experience = await _vrExperienceService.GetVRExperienceByIdAsync(id);
            return CustomResult("Thông tin trải nghiệm VR được tải thành công.", experience);
        }

        // Create a new VR Experience
        [HttpPost("create")]
        public async Task<IActionResult> CreateVRExperience([FromBody] CreateVRExperienceRequest request)
        {
            var newExperience = await _vrExperienceService.CreateVRExperienceAsync(request);
            return CustomResult("Trải nghiệm VR được tạo thành công.", newExperience);
        }

        // Search VR Experiences
        [HttpGet("search")]
        public async Task<IActionResult> SearchVRExperiences(
             [FromQuery] Guid? apartmentId,
             [FromQuery] Guid? accountId,
             [FromQuery] DateTimeOffset? startDate,
             [FromQuery] DateTimeOffset? endDate,
             [FromQuery] int pageIndex = 1,
             [FromQuery] int pageSize = 10)
        {
            var (experiences, totalItem) = await _vrExperienceService.SearchVRExperiencesAsync(
                apartmentId, accountId, startDate, endDate, pageIndex, pageSize);

            var result = new
            {
                TotalItem = totalItem,
                Experiences = experiences
            };

            return CustomResult("Kết quả tìm kiếm trải nghiệm VR.", result);
        }


        // Update an existing VR Experience
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateVRExperience(Guid id, [FromBody] UpdateVRExperienceRequest request)
        {
            var updatedExperience = await _vrExperienceService.UpdateVRExperienceAsync(id, request);
            return CustomResult("Trải nghiệm VR được cập nhật thành công.", updatedExperience);
        }
    }
}
