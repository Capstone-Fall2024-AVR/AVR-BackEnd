using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ProjectFacility
    {
        [Key] 
        public Guid ProjectFacilityID { get; set; }
        public Guid FacilityID { get; set; }
        public Guid ProjectApartmentId { get; set; }

        // Navigation properties
        public virtual Facilities Facility { get; set; } // Single reference to Facilities
        public virtual ProjectApartment ProjectApartment { get; set; } // Single reference to Project Apartment

    }
}
