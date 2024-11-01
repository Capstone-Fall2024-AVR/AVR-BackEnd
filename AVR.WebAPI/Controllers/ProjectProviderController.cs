using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ProjectProviders;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/projectproviders")]
    [ApiController]
    public class ProjectProviderController : BaseController
    {
        private readonly IProjectProviderService _projectProviderService;
        public ProjectProviderController(IProjectProviderService projectProviderService)
        {
            _projectProviderService = projectProviderService;
        }
        
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllProjectProvider()
        {
            var projectProviders = await _projectProviderService.GetProjectProviders();
            return CustomResult("Tải dữ liệu thành công.", projectProviders);
        }

        [HttpGet("{projectProviderId}")]
        public async Task<IActionResult> GetProjectProviderById(Guid projectProviderId)
        {
            var projectProvider = await _projectProviderService.GetProjectProviderById(projectProviderId);
            return CustomResult("Tải dữ liệu thành công.", projectProvider);
        }
        // Tạo mới một nhà cung cấp dự án
        [HttpPost("create")]
        public async Task<IActionResult> CreateProjectProvider([FromBody] CreateApartmentProjectProviderRequest request)
        {
            var projectProvider = await _projectProviderService.CreateProjectProvider(request);
            return CustomResult("Tạo nhà cung cấp dự án thành công.", projectProvider);
        }



    }
}
