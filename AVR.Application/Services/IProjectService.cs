using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Request.Projects;
using AVR.Application.ViewModels.Response.Notifications;
using AVR.Application.ViewModels.Response.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IProjectService
    {
        Task<CreateProjectResponse> GetProjectById(Guid id);
        Task<IEnumerable<CreateProjectResponse>> GetAllProject();

        Task<CreateProjectResponse> CreateProject(CreateProjectRequest request);
    }
}
