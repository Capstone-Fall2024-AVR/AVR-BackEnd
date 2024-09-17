using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class Facilities
    {
        [Key]
        public Guid FacilitiesID { get; set; } = Guid.NewGuid();
        [Required]
        public string FacilitiesName { get; set; }
        [Required]
        public string FacilitiesDescription { get; set; }
        //Apartment_Facilities
        public virtual ApartmentFacility ApartmentFacilities { get; set; }

    }
}
