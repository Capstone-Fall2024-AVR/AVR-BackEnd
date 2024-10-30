using AVR.Domain.Utils;
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
        public DateTimeOffset CreateDate { get; set; } = CoreHelper.SystemTimeNow;
        [Required]
        public DateTimeOffset UpdateDate { get; set; }

        // Thay thế Staff bằng Account
        public Guid ApartmentID { get; set; }
        public virtual Apartment Apartments { get; set; }

        // Thay StaffID bằng AccountID
        public Guid AccountID { get; set; }
        public virtual Account Accounts { get; set; }

        public virtual ICollection<VR_Access_Log> VR_Access_Logs { get; set; }
    }

}
