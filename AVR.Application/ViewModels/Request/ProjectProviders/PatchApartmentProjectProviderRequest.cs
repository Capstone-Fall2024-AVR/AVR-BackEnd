using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.ProjectProviders
{
    public class PatchApartmentProjectProviderRequest
    {
        public string? ApartmentProjectProviderName { get; set; }
        public string? ApartmentProjectDescription { get; set; }
        public string? LegallInfor { get; set; }
        public string? Location { get; set; }
        public string? DiagramUrl { get; set; }
    }

}
