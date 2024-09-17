using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ApartmentImage
    {
        [Key] 
        public Guid ApartmentImageID { get; set; } = Guid.NewGuid();
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public DateTimeOffset CreateDate { get; set; }
        [Required]
        public DateTimeOffset UpdateDate { get; set; }
        public Guid ApartmentID { get; set; }

        // Navigation properties
        public virtual Apartment Apartments { get; set; }

    }
}
