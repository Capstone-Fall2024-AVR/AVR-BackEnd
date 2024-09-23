using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ProjectImage
    {
        [Key] 
        public Guid ProjectImageID { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.Now;
        [Required]
        public DateTimeOffset UpdateDate { get; set; }
        public Guid ProjectApartmentID { get; set; }
        
        public virtual ProjectApartment ProjectApartments { get; set; }
    }
}
