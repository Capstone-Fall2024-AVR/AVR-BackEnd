using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class VRExperience
    {
        [Key] 
        public Guid VRExperienceID { get; set; } = Guid.NewGuid();
        [Required]
        public string video_url_file { get; set; }
        [Required]
        public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.Now;
        [Required]
        public DateTimeOffset UpdateDate { get; set; }

        //Apartment
        public Guid ApartmentID { get; set; }
        public virtual Apartment Apartments { get; set; }

        //CreateById
        public Guid StaffID { get; set; }
        public virtual Staff Staffs { get; set; }
        //VR_Access_Log
        public virtual ICollection<VR_Access_Log> VR_Access_Logs { get; set; }


    }
}
