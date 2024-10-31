using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Notifications
{
    public class NotificationResponse : IMapFrom<Notification>
    {
        public Guid NotificationID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Created { get; set; }
        public bool IsRead { get; set; }
        public string NotificationTypes { get; set; }
        public Guid AccountID { get; set; }
        public Guid? ReferenceId { get; set; }
    }
}
