using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ApartmentFacility
    {
        [Key] 
        public Guid ApartmentFacilityID { get; set; }
        public Guid FacilityID { get; set; }
        public Guid ApartmentID { get; set; }

        // Navigation properties
        public virtual Facilities Facility { get; set; } // Single reference to Facilities
        public virtual Apartment Apartment { get; set; } // Single reference to Apartment

    }
}
