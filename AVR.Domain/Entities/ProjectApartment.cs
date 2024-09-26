using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ProjectApartment
    {
        [Key] 
        public Guid ProjectApartmentID { get; set; } = Guid.NewGuid();
        [Required] 
        public string ProjectApartmentName { get; set; }
        [Required]
        public string ProjectApartmentDescription { get; set; }
        [Required]
        public string Price_range { get; set; }
        [Required]
        public DateTimeOffset UpdateDate { get; set; }
        [Required]
        public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.Now;
        [Required]
        public ProjectApartmentStatus ProjectApartmentStatus { get; set; }

        //ProjectImage
        public virtual ICollection<ProjectImage> ProjectImages { get; set; }
        // Thay thế Management bằng Account
        public Guid AccountID { get; set; }
        public virtual Account Accounts { get; set; }

        /*//Apartment
        public virtual ICollection<Apartment> Apartments { get; set; }*/
        //Project_Access_Log
        public virtual ICollection<ProjectAccessLog> ProjectAccessLogs { get; set; }
        public virtual ICollection<ProjectApartmentApartment> ProjectApartmentApartments { get; set; } = new List<ProjectApartmentApartment>();

    }
}
