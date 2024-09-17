using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class NotificationType
    {
        [Key] 
        public Guid NotificationTypeID { get; set; } = Guid.NewGuid();
        [Required]
        public string NotificationTypeName { get; set; }
        [Required]
        public string NotificationTypeDescription { get; set; }
        //Notification
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
