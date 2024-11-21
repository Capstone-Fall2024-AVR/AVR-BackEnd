using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Request.Projects;
using AVR.Application.ViewModels.Response.Notifications;
using AVR.Application.ViewModels.Response.Projects;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IProjectService
    {
        Task<ProjectApartmentResponse> GetProjectById(Guid id);
        Task<IEnumerable<ProjectApartmentResponse>> GetAllProject();

        Task<ProjectApartmentResponse> CreateProjectApartmentAsync(CreateProjectApartmentRequest request);

        Task<(IEnumerable<ProjectApartmentResponse> Projects, int TotalItem, int TotalPage)> SearchProjects(
                string? projectName,
                Guid? ApartmentProjectProviderID,
                List<ProjectApartmentStatus>? statuses,
                decimal? minPrice,
                decimal? maxPrice,
                Guid? teamId,
                int pageIndex = 1,
                int pageSize = 5);


        Task<ProjectApartmentResponse> UpdateProjectApartmentAsync(Guid projectId, UpdateProjectApartmentRequest request);
        Task<IEnumerable<ProjectSummaryResponse>> GetProjectSummaryAsync(DepositStatus? depositStatus = null);

        Task<(IEnumerable<ProjectApartmentResponse> Projects, int TotalItems, int TotalPages)> GetProjectsByManagerAsync(
            Guid staffId,
            int pageIndex = 1,
            int pageSize = 10);


        Task<(IEnumerable<ProjectApartmentResponse> Projects, int TotalItem, int TotalPage)> SearchOrGetProjectsByManagerAsync(
            Guid? staffId = null,
            string? projectName = null,
            Guid? ApartmentProjectProviderID = null,
            List<ProjectApartmentStatus>? statuses = null,
            decimal? minPrice = null,
            decimal? maxPrice = null,
            Guid? teamId = null,
            int pageIndex = 1,
            int pageSize = 10);
    }
}
