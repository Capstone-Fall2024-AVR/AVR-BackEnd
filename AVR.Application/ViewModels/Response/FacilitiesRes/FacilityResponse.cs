using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.FacilitiesRes
{
    public class FacilityResponse : IMapFrom<Facilities>
    {
        public Guid FacilitiesID { get; set; }
        public string FacilitiesName { get; set; }
        public string FacilitiesDescription { get; set; }
    }
}
