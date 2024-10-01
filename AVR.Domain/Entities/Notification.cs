using AVR.Domain.Enums;
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
        public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
        [Required]
        public DateTimeOffset Updated { get; set;} = DateTimeOffset.Now;
        [Required]
        public NotificationStatus NotificationStatus { get; set; }
        [Required]
        public bool IsRead { get; set; }

        //NotificationType
        public Guid NotificationTypeID { get; set; }
        public virtual NotificationType NotificationTypes { get; set; }
        //Account
        public Guid AccountID { get; set; }
        public virtual Account Accounts { get; set; }
        //ReferenceId
        public Guid ReferenceID { get; set; }
    }
}
