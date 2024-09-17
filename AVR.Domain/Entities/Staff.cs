using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class Staff
    {
        [Key]
        public Guid StaffID { get; set; } = Guid.NewGuid();
        [Required]
        public string StaffName { get; set; }
        [Required]
        public string StaffPhone { get; set; }
        [Required]
        public string StaffEmail { get; set; }
        [Required]
        public string imageUrl { get; set; }
        [Required]
        public DateTimeOffset CreateAt { get; set; } = DateTimeOffset.Now;
        [Required]
        public DateTimeOffset UpdateAt { get; set;}
        public Guid AccountID { get; set; }

        // Navigation properties
        public virtual Account Accounts { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }  // Change from single to collection

        public virtual ICollection<VRExperience> VRExperiences { get; set; }

    }
}
