using AVR.Application.Services;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/project-facilities")]
    [ApiController]
    public class ProjectFacilityController : BaseController
    {
        private readonly IProjectFacilityService _projectFacilityService;

        public ProjectFacilityController(IProjectFacilityService projectFacilityService)
        {
            _projectFacilityService = projectFacilityService;
        }

        // DELETE api/v1/project-facilities/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjectFacility(Guid id)
        {
            await _projectFacilityService.DeleteProjectFacilityAsync(id);
            return CustomResult("Xóa Project Facility thành công.");
        }
    }
}
