using AVR.Application.ViewModels.Request.PropertyRequests;
using AVR.Application.ViewModels.Response.PropertyRequests;
using AVR.Domain.Enums;
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

        Task<AcceptPropertyRequestResponse> AssignPropertyRequest(Guid requestId, Guid staffId);
        Task<CreatePropertyRequestResponse> RejectPropertyRequest(Guid requestId);
        Task<CreatePropertyRequestResponse> AcceptPropertyRequest(Guid requestId);
        Task<IEnumerable<CreatePropertyRequestResponse>> SearchPropertyRequests(
                Guid? ownerId = null,
                Guid? staffId = null,
                string? propertyName = null,
                decimal? minExpectedPrice = null,
                decimal? maxExpectedPrice = null,
                string? address = null,
                List<RequestStatus>? requestStatuses = null,
                string? userName = null,
                string? email = null,
                string? phoneNumber = null);
    }
}
