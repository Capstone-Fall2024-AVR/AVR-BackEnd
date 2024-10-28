using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.FacilitiesReq
{
    public class FacilityRequest : IMapFrom<Facilities>
    {
        public string FacilitiesName { get; set; }
        public string FacilitiesDescription { get; set; }
    }
}
