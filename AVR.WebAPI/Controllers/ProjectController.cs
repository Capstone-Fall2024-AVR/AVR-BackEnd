using AVR.Application.ServiceImplements;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Request.Projects;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/projects")]
    [ApiController]
    public class ProjectController : BaseController
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("{projectId}")]

        public async Task<IActionResult> GetProjectInfo(Guid projectId)
        {
            var project = await _projectService.GetProjectById(projectId);
            return CustomResult("Tải dữ liệu thành công.", project);
        }
        [HttpGet("get-all")]

        public async Task<IActionResult> GetAllNotis()
        {
            var projects = await _projectService.GetAllProject();
            return CustomResult("Tải dữ liệu thành công.", projects);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateProject(CreateProjectRequest request)
        {
            var project = await _projectService.CreateProject(request);
            return CustomResult("Tạo Project thành công.", project);
        }
    }
}
