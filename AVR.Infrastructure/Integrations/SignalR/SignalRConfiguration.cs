using AVR.Domain.Interfaces;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.SignalR
{
    public class SignalRConfiguration : ISignalRConfiguration
    {
        private readonly IConfiguration _configuration;
        private readonly IHubContext<NotificationHub> _notificationHub;
        private readonly IHubContext<ChatHub> _chatHub;

        public SignalRConfiguration(IConfiguration configuration, IHubContext<NotificationHub> notificationHub, IHubContext<ChatHub> chatHub)
        {
            _configuration = configuration;
            _notificationHub = notificationHub;
            _chatHub = chatHub;
        }

        public async Task SendChatNotification(Guid sessionId, Guid senderId, string messageContent, DateTimeOffset timestamp)
        {
            await _notificationHub.Clients.All.SendAsync("ReceiveChatMessage", sessionId.ToString(), senderId.ToString(), messageContent, timestamp.ToString("o"));
            Console.WriteLine($"Sent chat message to session {sessionId}: {messageContent}");
        }

        public async Task JoinChatSession(Guid accountId, Guid sessionId)
        {
            await _notificationHub.Groups.AddToGroupAsync(accountId.ToString(), sessionId.ToString());
            Console.WriteLine($"Account {accountId} joined session {sessionId}");
        }

        public async Task LeaveChatSession(Guid accountId, Guid sessionId)
        {
            await _notificationHub.Groups.RemoveFromGroupAsync(accountId.ToString(), sessionId.ToString());
            Console.WriteLine($"Account {accountId} left session {sessionId}");
        }

        // Gửi thông báo
        public async Task SendNotification(Guid accountId, string title, string description, string type, Guid referenceId)
        {
            await _notificationHub.Clients.User(accountId.ToString()).SendAsync("ReceiveNotification", accountId.ToString() ,title, description, type, referenceId.ToString());
            Console.WriteLine($"Sent notification to {accountId}: {title} - {description}");
        }
    }
}
