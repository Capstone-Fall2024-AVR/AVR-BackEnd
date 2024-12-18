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

        Task<AcceptPropertyRequestResponse> AssignPropertyRequest(Guid requestId, Guid assignedStaffAccountID);
        Task<CreatePropertyRequestResponse> RejectPropertyRequest(Guid requestId, Guid sellerId, string? note);
        Task<CreatePropertyRequestResponse> AcceptPropertyRequest(Guid requestId, Guid sellerId);
        Task<(IEnumerable<CreatePropertyRequestResponse> Results, int TotalItems, int TotalPages)> SearchPropertyRequests(
                  Guid? ownerId,
                  Guid? staffId,
                  string? propertyName,
                  decimal? minExpectedPrice,
                  decimal? maxExpectedPrice,
                  string? address,
                  List<RequestStatus>? requestStatuses,
                  string? userName,
                  string? email,
                  string? phoneNumber,
                  string? keyword,
                  int pageIndex = 1,
                  int pageSize = 5);
    }
}
