using AVR.Domain.Interfaces;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.SignalR
{
    public class SignalRConfiguration : ISignalRConfiguration
    {
        private readonly IConfiguration _configuration;
        private readonly IHubContext<NotificationHub> _notificationHub;
        private readonly IHubContext<ChatHub> _chatHub;
        private readonly ILogger<SignalRConfiguration> _logger;

        public SignalRConfiguration(
            IConfiguration configuration,
            IHubContext<NotificationHub> notificationHub,
            IHubContext<ChatHub> chatHub,
            ILogger<SignalRConfiguration> logger)
        {
            _configuration = configuration;
            _notificationHub = notificationHub;
            _chatHub = chatHub;
            _logger = logger;
        }

        public async Task SendChatNotification(Guid sessionId, Guid senderId, Guid? receiverId, string messageContent, DateTimeOffset timestamp)
        {
            //await _chatHub.Clients.User(sessionId.ToString()).SendAsync("ReceiveChatMessage", sessionId.ToString(), senderId.ToString(), messageContent, timestamp.ToString("o"));

            await _chatHub.Clients.User(receiverId.ToString()).SendAsync("ReceiveChatMessage", sessionId.ToString(), senderId.ToString(), messageContent, timestamp.ToString("o"));
            _logger.LogInformation($"Sent chat message to session {sessionId}: {messageContent}");
        }

        public async Task SendNotification(Guid accountId, string title, string description, string type, Guid referenceId)
        {
            await _notificationHub.Clients.User(accountId.ToString()).SendAsync("ReceiveNotification", accountId.ToString(), title, description, type, referenceId.ToString());
            _logger.LogInformation($"Sent notification to {accountId}: {title} - {description}");
        }
    }
}
