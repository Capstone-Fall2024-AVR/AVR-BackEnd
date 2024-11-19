using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class Team
    {
        [Key]
        public Guid TeamID { get; set; } = Guid.NewGuid();

        [Required]
        public string TeamName { get; set; }
        [Required]
        public string TeamDescription { get; set; }
        [Required]
        public TeamType TeamType { get; set; }


        // Quan hệ với TeamMember
        public virtual ICollection<TeamMember> TeamMembers { get; set; }

        // Quan hệ với ProjectApartment
        public virtual ICollection<ProjectApartment> ProjectApartments { get; set; }

    }
}
