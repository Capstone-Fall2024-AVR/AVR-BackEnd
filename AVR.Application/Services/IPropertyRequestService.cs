using AVR.Application.ViewModels.Request.PropertyRequests;
using AVR.Application.ViewModels.Response.PropertyRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IPropertyRequestService
    {
        Task<CreatePropertyRequestResponse> CreatePropertyRequest(CreatePropertyRequestRequest request);
        Task<IEnumerable<CreatePropertyRequestResponse>> GetPropertyRequests();
        Task<CreatePropertyRequestResponse> GetPropertyRequestById(Guid requestId);
    }
}
