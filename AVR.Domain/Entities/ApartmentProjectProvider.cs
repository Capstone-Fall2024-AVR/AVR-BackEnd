using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ApartmentProjectProvider
    {
        [Key]
        public Guid ApartmentProjectProviderID { get; set; } = Guid.NewGuid();
        [Required]
        public string ApartmentProjectProviderName { get; set; }
        [Required]  
        public string ApartmentProjectDescription { get; set; }
        [Required]
        public string LegallInfor { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string DiagramUrl { get; set; }
        [Required]
        public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.Now;
        [Required]
        public DateTimeOffset UpdateDate { get; set; } = DateTimeOffset.Now;
        public Guid AccountID { get; set; }
        // Navigation properties
        public virtual Account Accounts { get; set; }
        public virtual ICollection<ProjectApartment> ProjectApartments { get; set; }
        public virtual ICollection<AgreementUpdateRequest> AgreementUpdateRequests { get; set; }

    }
}
