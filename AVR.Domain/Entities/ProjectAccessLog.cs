using AVR.Domain.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ProjectAccessLog
    {
        [Key] 
        public Guid ProjectAccessLogID { get; set; } = Guid.NewGuid();
        [Required]
        public DateTimeOffset accessDate { get; set; } = CoreHelper.SystemTimeNow;

        //ProjectApartment
        public Guid ProjectApartmentID { get; set; }
        public virtual ProjectApartment ProjectApartments { get; set; }
        


    }
}
