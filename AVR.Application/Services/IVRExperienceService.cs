using AVR.Application.ViewModels.Request.VRExperiences;
using AVR.Application.ViewModels.Response.VRExperiences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IVRExperienceService
    {
        Task<IEnumerable<VRExperienceResponse>> GetAllVRExperiencesAsync();
        Task<VRExperienceResponse> GetVRExperienceByIdAsync(Guid id);
        Task<VRExperienceResponse> CreateVRExperienceAsync(CreateVRExperienceRequest request);
        Task<(IEnumerable<VRExperienceResponse> Experiences, int TotalItem)> SearchVRExperiencesAsync(
             Guid? apartmentId = null,
             Guid? assignedTeamMemberID = null,
             DateTimeOffset? startDate = null,
             DateTimeOffset? endDate = null,
             int pageIndex = 1,
             int pageSize = 10);
        Task<VRExperienceResponse> UpdateVRExperienceAsync(Guid id, UpdateVRExperienceRequest request);
    }
}
