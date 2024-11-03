using AVR.Application.ViewModels.Request.ApartmentInteractions;
using AVR.Application.ViewModels.Response.ApartmentInteractions;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IApartmentInteractionService
    {
        Task<IEnumerable<ApartmentInteractionResponse>> GetAllAsync();
        Task<ApartmentInteractionResponse> GetByIdAsync(Guid interactionId);
        Task<ApartmentInteractionResponse> CreateAsync(CreateApartmentInteractionRequest request);
        Task<IEnumerable<ApartmentInteractionResponse>> SearchAsync(
            Guid? accountId,
            InteractionType? interactionType,
            Guid? apartmentId,
            DateTimeOffset? date,
            int pageIndex = 1,
            int pageSize = 10);
    }
}
