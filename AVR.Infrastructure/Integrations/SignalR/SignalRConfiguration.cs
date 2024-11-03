using AVR.Domain.Interfaces;
using Firebase.Auth;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.SignalR
{
    public class SignalRConfiguration : ISignalRConfiguration
    {
        private readonly IConfiguration _configuration;
        private readonly IHubContext<NotificationHub> _notificationHub;

        public SignalRConfiguration(IConfiguration configuration, IHubContext<NotificationHub> notificationHub)
        {
            _configuration = configuration;
            _notificationHub = notificationHub;
        }

        public async Task SendNotification(Guid accountId, string title, string description )
        {
            await _notificationHub.Clients.User(accountId.ToString()).SendAsync("ReceiveNotification", title, description);
            Console.WriteLine($"Sent notification to {accountId}: {title} - {description}"); // Log để kiểm tra
        }
    }
}
