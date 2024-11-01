using AVR.Application.ViewModels.Request.ProjectProviders;
using AVR.Application.ViewModels.Response.ProjectProviders;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IAgreementUpdateRequestService
    {
        Task<AgreementUpdateRequestResponse> CreateAsync(CreateAgreementUpdateRequest request);
        Task<IEnumerable<AgreementUpdateRequestResponse>> GetAllAsync();
        Task<AgreementUpdateRequestResponse> GetByIdAsync(Guid requestId);
        Task<IEnumerable<AgreementUpdateRequestResponse>> SearchAsync(
            AgreementUpdateType? updateType,
            AgreementUpdateStatus? updateStatus,
            Guid? accountId,
            string? title,
            int pageIndex = 1,
            int pageSize = 10);
        Task<AgreementUpdateRequestResponse> AcceptRequestAsync(Guid requestId);
        Task<AgreementUpdateRequestResponse> RejectRequestAsync(Guid requestId);
    }
}
