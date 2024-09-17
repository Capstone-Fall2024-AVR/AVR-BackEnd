using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class VR_Access_Log
    {
        [Key] 
        public Guid VR_Access_LogID { get; set; } = Guid.NewGuid();
        [Required]
        public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.Now;

        //VRId
        public Guid VRExperienceID { get; set; }
        public virtual VRExperience VRExperiences { get; set;}
        
        

    }
}
