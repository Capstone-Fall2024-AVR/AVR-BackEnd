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
        [HttpGet("search")]
        public async Task<IActionResult> SearchProjectProviders(
            [FromQuery] string? providerName,
            [FromQuery] string? location,
            [FromQuery] Guid? accountId = null,
            [FromQuery] DateTimeOffset? createdAfter = null,
            [FromQuery] DateTimeOffset? createdBefore = null,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 5)
        {
            var (providers, totalItem, totalPage) = await _projectProviderService.SearchProjectProviders(
                providerName,
                location,
                accountId,
                createdAfter,
                createdBefore,
                pageIndex,
                pageSize
            );

            var result = new
            {
                TotalItem = totalItem,
                TotalPage = totalPage,
                Providers = providers,
                CurrentPage = pageIndex,
                PageSize = pageSize
            };

            return CustomResult("Tìm kiếm nhà cung cấp dự án thành công.", result);
        }

        [HttpPatch("{providerId}")]
        public async Task<IActionResult> PatchProjectProvider(Guid providerId, [FromBody] PatchApartmentProjectProviderRequest request)
        {
            var updatedProvider = await _projectProviderService.PatchProjectProvider(providerId, request);
            return CustomResult("Cập nhật thông tin nhà cung cấp dự án thành công.", updatedProvider);
        }






    }
}
