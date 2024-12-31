using AVR.Application.ViewModels.Request.ProjectFile.CreateProjectFileRequest;
using AVR.Application.ViewModels.Request.ProjectFile.UpdateProjectFileRequest;
using AVR.Application.ViewModels.Response.ProjectFile.ProjectFileResponse;
using AVR.Application.ViewModels.Response.Projects;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IProjectFileService
    {
        Task<ProjectFileResponse> CreateProjectFileAsync(CreateProjectFileRequest request);
        Task<ProjectFileResponse> GetProjectFileByIdAsync(Guid id);
        Task<IEnumerable<ProjectFileResponse>> GetAllProjectFilesAsync();
        Task<ProjectFileResponse> UpdateProjectFileAsync(Guid id, UpdateProjectFileRequest request);
        Task<IEnumerable<ProjectFileResponse>> GetProjectFilesCloseToExpiryAsync(int daysBeforeExpiry = 7);
        Task<bool> DeleteProjectFileAsync(Guid id);
        Task<(IEnumerable<ProjectFileResponse> ProjectFiles, int TotalItem, int TotalPage)> SearchProjectsFiles(
             Guid? projectId,
             ProjectFileType? fileType,
             string? keyword,
             int pageIndex = 1,
             int pageSize = 5);

    }
}
