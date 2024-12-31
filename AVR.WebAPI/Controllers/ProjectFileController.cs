using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ProjectFile.CreateProjectFileRequest;
using AVR.Application.ViewModels.Request.ProjectFile.UpdateProjectFileRequest;
using AVR.Application.ViewModels.Response.ProjectFile.ProjectFileResponse;
using AVR.Application.ViewModels.Response.Projects;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
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

        [HttpGet("close-to-expiry")]
        public async Task<IActionResult> GetProjectFilesCloseToExpiry([FromQuery] int daysBeforeExpiry = 7)
        {
            var projectFiles = await _projectFileService.GetProjectFilesCloseToExpiryAsync(daysBeforeExpiry);
            return Ok(new { message = "Danh sách ProjectFile gần tới ExpiryDate.", data = projectFiles });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjectFile(Guid id)
        {
            await _projectFileService.DeleteProjectFileAsync(id);
            return NoContent();
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchProjectsFiles(
            [FromQuery] Guid? projectId,
            [FromQuery] ProjectFileType? fileType,
            [FromQuery] string? keyword,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 5)
        {
            var (projectFiles, totalItem, totalPage) = await _projectFileService.SearchProjectsFiles(projectId, fileType, keyword, pageIndex, pageSize);
            return CustomResult("Kết quả tìm kiếm tệp dự án đã được tải thành công.", new
            {
                TotalItem = totalItem,
                TotalPage = totalPage,
                CurrentPage = pageIndex,
                PageSize = pageSize,
                Results = projectFiles
            });
        }

    }
}
