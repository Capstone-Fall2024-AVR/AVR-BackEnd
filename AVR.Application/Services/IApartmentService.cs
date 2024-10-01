using AVR.Application.ViewModels.Request.Apartments;
using AVR.Application.ViewModels.Response.Apartments;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IApartmentService
    {
        Task<IEnumerable<CreateApartmentResponse>> GetApartments();
        Task<CreateApartmentResponse> GetApartmentById (Guid id);

        Task<CreateApartmentResponse> CreateApartment(CreateApartmentRequest request);
    }
}
