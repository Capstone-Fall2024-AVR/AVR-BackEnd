using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AVR.Domain.Entities
{
    [Table("ApartmentOwnerApartment")]
    public class ApartmentOwnerApartment
    {
        [Key]
        public Guid ApartmentOwnerApartmentID { get; set; } = Guid.NewGuid();

        [Required]
        public Guid ApartmentOwnerID { get; set; } // Liên kết đến ApartmentOwner
        public virtual ApartmentOwner ApartmentOwner { get; set; }

        [Required]
        public Guid AssignedTeamMemberID { get; set; }
        public virtual TeamMember AssignedTeamMember { get; set; }

        public Guid? ApartmentID { get; set; } // Liên kết đến Apartment
        public virtual Apartment Apartment { get; set; }

        [Required]
        public OwnershipStatus OwnershipStatus { get; set; } // Trạng thái sở hữu

        // Navigation property
        public virtual ICollection<PropertyVerification> PropertyVerifications { get; set; } // Các phiên xác minh liên quan đến sở hữu này
    }
}
