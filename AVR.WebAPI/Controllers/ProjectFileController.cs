using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ProjectFile.CreateProjectFileRequest;
using AVR.Application.ViewModels.Request.ProjectFile.UpdateProjectFileRequest;
using AVR.Application.ViewModels.Response.ProjectFile.ProjectFileResponse;
using AVR.Application.ViewModels.Response.Projects;
using AVR.Domain.Entities;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/project-files")]
    [ApiController]
    public class ProjectFileController : BaseController
    {
        private readonly IProjectFileService _projectFileService;

        public ProjectFileController(IProjectFileService projectFileService)
        {
            _projectFileService = projectFileService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateProjectFile([FromForm] CreateProjectFileRequest request)
        {
            var projectFile = await _projectFileService.CreateProjectFileAsync(request);
            return CustomResult("Project File đã được upload thành công.", projectFile);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjectFileById(Guid id)
        {
            var projectFile = await _projectFileService.GetProjectFileByIdAsync(id);
            return CustomResult("Project File đã lấy tạo thành công.", projectFile);
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllProjectFiles()
        {
            var projectFiles = await _projectFileService.GetAllProjectFilesAsync();
            return CustomResult("Project File đã lấy tạo thành công.", projectFiles);
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateProjectFile(Guid id, [FromBody] UpdateProjectFileRequest request)
        {
            var updatedProjectFile = await _projectFileService.UpdateProjectFileAsync(id, request);
            return CustomResult("Project File đã update tạo thành công.", updatedProjectFile);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjectFile(Guid id)
        {
            await _projectFileService.DeleteProjectFileAsync(id);
            return NoContent();
        }
    }
}
