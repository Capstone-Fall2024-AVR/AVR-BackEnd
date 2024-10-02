using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Projects
{
    public class CreateProjectRequest : IMapFrom<ProjectApartment>
    {
        [Required]
        public string ProjectApartmentName { get; set; }

        [Required]
        public string ProjectApartmentDescription { get; set; }

        [Required]
        public string Price_range { get; set; }

        [Required]
        public ProjectApartmentStatus ProjectApartmentStatus { get; set; }

        [Required]
        public Guid ApartmentProjectProviderID { get; set; }
    }
}
