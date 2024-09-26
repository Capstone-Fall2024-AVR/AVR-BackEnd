using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class Apartment
    {
        [Key]
        public Guid ApartmentID { get; set; } = Guid.NewGuid();
        [Required]
        public string ApartmentName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTimeOffset CreatedDate { get; set; } = DateTime.Now;
        [Required]
        public DateTimeOffset UpdatedDate { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string area { get; set; }
        [Required]
        public string numberOfRooms { get; set; }
        [Required]
        public string location { get; set; }
        [Required]
        public string direction { get; set; }
        [Required]
        public string pricePerSquareMeter { get; set; }
        [Required]
        public string recommendedPrice { get; set; }
        [Required]
        public DateTimeOffset expiryDate { get; set; }
        [Required]
        public ApartmentStatus ApartmentStatus { get; set; }
        [Required]
        public ApartmentType ApartmentType { get; set; }

        /*public Guid ProjectID { get; set; }*/
        /*public Guid ApartmentOwnerID { get; set; }*/


        // Navigation properties
        public virtual ICollection<ProjectApartmentApartment> ProjectApartmentApartments { get; set; } = new List<ProjectApartmentApartment>();
        public virtual ICollection<ApartmentFacility> ApartmentFacilities { get; set; }
        /*public virtual ProjectApartment ProjectApartments { get; set; }*/
        public virtual ICollection<VRExperience> VRExperiences { get; set; }
        public virtual ICollection<ApartmentImage> ApartmentImages { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
        public virtual ICollection<ApartmentInteraction> ApartmentInteractions { get; set; }
        public virtual ICollection<RequestApartment> RequestApartments { get; set; }
        /*public virtual ApartmentOwner ApartmentOwners { get; set; }*/
        public virtual ICollection<ApartmentDocument> ApartmentDocuments { get; set; }



    }
}
