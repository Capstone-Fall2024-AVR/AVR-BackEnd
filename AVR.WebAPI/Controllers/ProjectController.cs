using AVR.Application.ServiceImplements;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Request.Projects;
using AVR.Domain.Enums;
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
        public async Task<IActionResult> CreateProject([FromForm]CreateProjectApartmentRequest request)
        {
            var project = await _projectService.CreateProjectApartmentAsync(request);
            return CustomResult("Tạo Project thành công.", project);
        }
        [HttpGet("search")]
        public async Task<IActionResult> SearchProjects(
            [FromQuery] string? projectName,
            [FromQuery] Guid? ApartmentProjectProviderID,
            [FromQuery] List<ProjectApartmentStatus>? statuses,
            [FromQuery] decimal? minPrice,
            [FromQuery] decimal? maxPrice,
            [FromQuery] Guid? teamId,
            int pageIndex = 1,
            int pageSize = 5)
        {
            var (projects, totalItem, totalPage) = await _projectService.SearchProjects(
                projectName, ApartmentProjectProviderID, statuses, minPrice, maxPrice, teamId, pageIndex, pageSize);

            var result = new
            {
                TotalItem = totalItem,
                TotalPage = totalPage,
                Projects = projects,
                CurrentPage = pageIndex,
                PageSize = pageSize
            };

            return CustomResult("Tìm kiếm dự án thành công.", result);
        }

        // Update an existing Project Apartment
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateProjectApartment(Guid id, [FromBody] UpdateProjectApartmentRequest request)
        {
            var updatedProject = await _projectService.UpdateProjectApartmentAsync(id, request);
            return CustomResult("Dự án đã được cập nhật thành công.", updatedProject);
        }

        [HttpGet("projects/summary")]
        public async Task<IActionResult> GetProjectSummary(DepositStatus? depositStatus = null, DisbursementStatus? disbursementStatus = null, int pageIndex = 1, int pageSize = 10)
        {
            var (projects, totalItems, totalPages) = await _projectService.GetProjectSummaryAsync(depositStatus, disbursementStatus, pageIndex, pageSize);
            
            var result = new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                CurrentPage = pageIndex,
                PageSize = pageSize,
                Projects = projects
            };

            return CustomResult("Tải dữ liệu thành công!", result);
        }

        [HttpGet("managed-by/{managerId}")]
        public async Task<IActionResult> GetProjectsByManager(Guid managerId, int pageIndex = 1, int pageSize = 10)
        {
            var (projects, totalItems, totalPages) = await _projectService.GetProjectsByManagerAsync(managerId, pageIndex, pageSize);

            var result = new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                CurrentPage = pageIndex,
                PageSize = pageSize,
                Projects = projects
            };

            return CustomResult("Tải dữ liệu thành công.", result);
        }
    }
}
