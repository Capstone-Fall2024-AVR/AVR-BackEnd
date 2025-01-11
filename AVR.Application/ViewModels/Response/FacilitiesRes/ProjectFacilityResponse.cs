using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.FacilitiesRes
{
    public class ProjectFacilityResponse
    {
        public Guid ProjectFacilityID { get; set; }
        public Guid FacilityID { get; set; }
        public string FacilitiesName { get; set; }
    }

}
