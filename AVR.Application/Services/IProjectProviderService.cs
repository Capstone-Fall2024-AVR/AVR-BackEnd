using AVR.Application.ViewModels.Request.ProjectProviders;
using AVR.Application.ViewModels.Response.ProjectProviders;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IProjectProviderService
    {
        Task<ApartmentProjectProvider> GetProjectProviderById (Guid id);
        Task<IEnumerable<ApartmentProjectProvider>> GetProjectProviders();
        
        Task<ApartmentProjectProviderResponse> CreateProjectProvider(CreateApartmentProjectProviderRequest request);
        Task<(IEnumerable<ApartmentProjectProviderResponse> Providers, int TotalItem)> SearchProjectProviders(
             string? providerName,
             string? location,
             Guid? accountId = null,
             DateTimeOffset? createdAfter = null,
             DateTimeOffset? createdBefore = null,
             int pageIndex = 1,
             int pageSize = 5);
    }
}
