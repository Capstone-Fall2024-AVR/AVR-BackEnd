using AVR.Domain.Enums;
using AVR.Domain.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class Notification 
    {
        [Key] 
        public Guid NotificationID { get; set; } = Guid.NewGuid();
        [Required] 
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTimeOffset Created { get; set; } = CoreHelper.SystemTimeNow;
        [Required]
        public bool IsRead { get; set; }

        public  NotificationType NotificationTypes { get; set; }
        //Account
        public Guid AccountID { get; set; }
        public virtual Account Accounts { get; set; }

        // ReferenceId - liên kết đến các đối tượng khác nhau
        public Guid ReferenceId { get; set; }

    }
}
