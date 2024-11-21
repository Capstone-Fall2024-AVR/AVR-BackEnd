using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Notifications
{
    public class NotificationRequest : IMapFrom<Notification>
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public NotificationType NotificationTypes { get; set; }

        [Required]
        public Guid AccountID { get; set; }

        public Guid ReferenceId { get; set; }

    }
}
