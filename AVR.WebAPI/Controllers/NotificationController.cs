using AVR.Application.ServiceImplements;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Domain.Enums;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/notifications")]
    [ApiController]
    public class NotificationController : BaseController
    {
        private readonly INotificationService _notificationService;
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet("{notiId}")]

        public async Task<IActionResult> GetNotiInfo(Guid notiId)
        {
            var noti = await _notificationService.GetNotificationAsync(notiId);
            return CustomResult("Tải dữ liệu thành công.", noti);
        }

        [HttpGet("get-all")]

        public async Task<IActionResult> GetAllNotis()
        {
            var notis = await _notificationService.GetAllNotificationsAsync();
            return CustomResult("Tải dữ liệu thành công.", notis);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateNotification(NotificationRequest request)
        {
            var notis = await _notificationService.CreateNotificationAsync(request);
            return CustomResult("Tạo notification thành công.", notis);
        }

        [HttpPut("{notiId}/mark-as-read")]
        public async Task<IActionResult> MarkAsRead(Guid notiId)
        {
            var updatedNoti = await _notificationService.MarkAsReadAsync(notiId);
            return CustomResult("Đánh dấu thông báo là đã đọc thành công.", updatedNoti);
        }

        [HttpPut("mark-all-as-read/{accountId}")]
        public async Task<IActionResult> MarkAllAsRead(Guid accountId)
        {
            await _notificationService.MarkAllAsReadAsync(accountId);
            return CustomResult("Đánh dấu tất cả thông báo là đã đọc thành công.");
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchNotifications(
            [FromQuery] List<NotificationType>? notificationType,
            [FromQuery] Guid? accountId,
            [FromQuery] string? title,
            [FromQuery] bool? isRead,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 5)
        {
            var (results, totalItems, totalPages) = await _notificationService.SearchNotificationsAsync(
                notificationType, accountId, title, isRead, pageIndex, pageSize);

            return CustomResult("Kết quả tìm kiếm", new
            {
                
                TotalItems = totalItems,
                TotalPages = totalPages,
                Results = results,
                CurrentPage = pageIndex,
                PageSize = pageSize
            });
        }

    }
}
