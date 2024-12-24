using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ProjectFile
    {
        [Required]
        public Guid ProjectFileID { get; set; }

        public string ProjectFileUrl { get; set; }
        public string Description { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set;}
        public DateTimeOffset ExpiryDate { get; set; }

        // Foreign Key tới ProjectApartment
        public Guid ProjectApartmentID { get; set; }
        public virtual ProjectApartment ProjectApartment { get; set; }

    }
}
