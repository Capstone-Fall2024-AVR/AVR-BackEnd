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
        Task<IEnumerable<Apartment>> GetApartments();
        Task<Apartment> GetApartmentById (Guid id);

    }
}
