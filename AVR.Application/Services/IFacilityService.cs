using AVR.Application.ViewModels.Request.FacilitiesReq;
using AVR.Application.ViewModels.Response.FacilitiesRes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IFacilityService
    {
        Task<IEnumerable<FacilityResponse>> GetAllFacilitiesAsync();
        Task<FacilityResponse> GetFacilityByIdAsync(Guid id);
        Task<FacilityResponse> CreateFacilityAsync(FacilityRequest request);
    }
}
