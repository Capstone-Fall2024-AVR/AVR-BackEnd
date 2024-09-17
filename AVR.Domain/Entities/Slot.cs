using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class Slot
    {
        [Key] 
        public Guid SlotID { get; set; } = Guid.NewGuid();
        [Required] 
        public string StartTime { get; set; }
        [Required]
        public string EndTime { get; set; }
        //Appointment
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
