using AVR.Application.ServiceImplements;
using AVR.Application.Services;
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

    }
}
