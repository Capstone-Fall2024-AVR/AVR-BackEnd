using AVR.Application.ViewModels.Request.AppointmentRequests;
using AVR.Application.ViewModels.Request.Appointments;
using AVR.Application.ViewModels.Response.AppointmentRequests;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IAppointmentRequestService
    {
        Task<IEnumerable<AppointmentRequestResponse>> GetAllRequestsAsync();
        Task<AppointmentRequestResponse> GetRequestByIdAsync(Guid requestId);
        Task<AppointmentRequestResponse> CreateRequestAsync(CreateAppointmentReqRequest request);
        Task<AppointmentRequestResponse> AssignStaffAsync(Guid requestId, Guid accountId);
        Task<AppointmentRequestResponse> UpdateRequestStatusAsync(Guid requestId, RequestStatus newStatus);

        Task<AppointmentRequestResponse> AcceptRequestAsync(Guid requestId, Guid sellerId);
        Task<AppointmentRequestResponse> RejectRequestAsync(Guid requestId, Guid sellerID, string? note);

        Task<(IEnumerable<AppointmentRequestResponse> Results, int TotalItems, int TotalPages)> SearchAppointmentRequestsAsync(
                Guid? customerId = null,
                Guid? apartmentId = null,
                RequestStatus? status = null,
                AppointmentTypes? requestType = null,
                Guid? assignedTeamMemberID = null,
                DateTimeOffset? preferredDate = null,
                DateTimeOffset? startDate = null,
                DateTimeOffset? endDate = null,
                Guid? teamId = null,
                string? keyword = null,
                int pageIndex = 1,
                int pageSize = 10);

    }
}
