using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Response.Accounts;
using AVR.Application.ViewModels.Response.Notifications;
using AVR.Domain.Enums;
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
        Task<NotificationResponse> MarkAsReadAsync(Guid notificationId);
        Task MarkAllAsReadAsync(Guid accountId);
        Task<IEnumerable<NotificationResponse>> SearchNotificationsAsync(
               List<NotificationType>? notificationType,
               Guid? accountId,
               string? title,
               bool? isRead,
               int pageIndex = 1,
               int pageSize = 5);
    }
}
