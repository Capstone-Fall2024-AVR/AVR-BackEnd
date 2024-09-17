using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ApartmentOwner
    {
        [Key]
        public Guid ApartmentOwnerID { get; set; } = Guid.NewGuid();
        [Required]
        public string OwnerShipCertificate { get; set; }
        [Required]
        public string LandUserRightCertificate { get; set; }
        [Required]
        public string ConstructionPermit { get; set; }
        [Required]
        public string OtherDocuments { get; set; }
        public Guid AccountID { get; set; }

        // Navigation properties
        public virtual Account Accounts { get; set; }
        public virtual ProjectApartment ProjectApartment { get; set; }


    }
}
