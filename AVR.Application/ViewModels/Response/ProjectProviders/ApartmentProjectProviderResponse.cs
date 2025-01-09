using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.ProjectProviders
{
    public class ApartmentProjectProviderResponse : IMapFrom<ApartmentProjectProvider>
    {
        public Guid ApartmentProjectProviderID { get; set; }
        public string ApartmentProjectProviderName { get; set; }
        public string ApartmentProjectDescription { get; set; }
        public string Location { get; set; }
        public string DiagramUrl { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public Guid? AccountID { get; set; }
    }


}
