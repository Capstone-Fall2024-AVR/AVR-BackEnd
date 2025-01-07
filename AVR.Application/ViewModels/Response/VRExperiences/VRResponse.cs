using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.VRExperiences
{
    public class VRResponse : IMapFrom<VRExperience>
    {
        public Guid VRExperienceID { get; set; }
        public string VideoUrl { get; set; }
        public string Description { get; set; }
    }
}
