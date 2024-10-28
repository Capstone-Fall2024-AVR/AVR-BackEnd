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

        Task<IEnumerable<ProjectApartmentResponse>> SearchProjects(
         string? projectName,
         List<ProjectApartmentStatus>? statuses,
         decimal? minPrice,
         decimal? maxPrice,
         int pageIndex = 1,
         int pageSize = 5);

    }
}
