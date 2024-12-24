using AVR.Application.ViewModels.Request.Owners;
using AVR.Application.ViewModels.Response.Owners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IApartmentOwnerService
    {
        Task<ApartmentOwnerResponse> CreateApartmentOwnerAsync(CreateApartmentOwnerRequest request);

        Task<IEnumerable<ApartmentOwnerResponse>> GetAllApartmentOwnersAsync();

        Task<ApartmentOwnerResponse> GetApartmentOwnerByIdAsync(Guid apartmentOwnerId);

        Task<ApartmentOwnerResponse> UpdateApartmentOwnerAsync(Guid apartmentOwnerId, UpdateApartmentOwnerRequest request);

        Task<(IEnumerable<ApartmentOwnerResponse> Owners, int TotalItems, int TotalPages)> SearchApartmentOwnersAsync(
            string? name,
            string? email,
            string? phoneNumber,
            Guid? accountId,
            int pageIndex = 1,
            int pageSize = 10);

        Task<ApartmentOwnerWithPropertiesResponse> SearchApartmentOwnerWithPropertiesAsync(Guid? apartmentId, Guid? ownerId);
    }
}
