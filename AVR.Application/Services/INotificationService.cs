using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Response.Accounts;
using AVR.Application.ViewModels.Response.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface INotificationService
    {
        Task<NotificationResponse> GetNotificationAsync(Guid notificationId);
        Task<IEnumerable<NotificationResponse>> GetAllNotificationsAsync();

        Task<NotificationResponse> CreateNotificationAsync(NotificationRequest request);
    }
}
