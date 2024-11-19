using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class TeamMember
    {
        [Key]
        public Guid TeamMemberID { get; set; } = Guid.NewGuid();

        // Foreign Key tới Account (nhân viên)
        [Required]
        public Guid AccountID { get; set; }
        public virtual Account Account { get; set; }

        public bool IsManager { get; set; } = false;

        // Foreign Key tới Team
        [Required]
        public Guid TeamID { get; set; }
        public virtual Team Team { get; set; }

        // Quan hệ với Apartment (các căn hộ mà TeamMember phụ trách)
        public virtual ICollection<Apartment> Apartments { get; set; }


        public virtual ICollection<VRExperience> VRExperiences { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<AppointmentRequest> AppointmentRequests { get; set; }
        public virtual ICollection<RequestAssignment> RequestAssignments { get; set; }

        public virtual ICollection<ApartmentOwnerApartment> ApartmentOwnerApartments { get; set; }

    }
}
