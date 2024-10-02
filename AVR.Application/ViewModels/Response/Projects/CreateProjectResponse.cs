using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Projects
{
    public class CreateProjectResponse : IMapFrom<ProjectApartment>
    {
        public Guid ProjectApartmentID { get; set; }

        public string ProjectApartmentName { get; set; }

        public string ProjectApartmentDescription { get; set; }

        public string Price_range { get; set; }

        public DateTimeOffset UpdateDate { get; set; }

        public DateTimeOffset CreateDate { get; set; }

        public ProjectApartmentStatus ProjectApartmentStatus { get; set; }

        public Guid ApartmentProjectProviderID { get; set; }
    }
}
