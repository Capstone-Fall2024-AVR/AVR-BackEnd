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

        // Tham gia vào phiên trò chuyện
        public async Task JoinChatSession(Guid connectionId, Guid sessionId)
        {
            await _chatHub.Groups.AddToGroupAsync(connectionId.ToString(), sessionId.ToString());
            Console.WriteLine($"Connection {connectionId} joined session {sessionId}");
        }

        // Rời khỏi phiên trò chuyện
        public async Task LeaveChatSession(Guid connectionId, Guid sessionId)
        {
            await _chatHub.Groups.RemoveFromGroupAsync(connectionId.ToString(), sessionId.ToString());
            Console.WriteLine($"Connection {connectionId} left session {sessionId}");
        }

        // Gửi tin nhắn đến người nhận trong phiên trò chuyện
        public async Task SendMessage(Guid sessionId, Guid senderId, Guid receiverId, string messageContent)
        {
            await _chatHub.Clients.User(receiverId.ToString()).SendAsync("ReceiveMessage", sessionId, senderId, messageContent);
            Console.WriteLine($"Sent message to {receiverId} in session {sessionId}: {messageContent}");
        }

        // Gửi thông báo
        public async Task SendNotification(Guid accountId, string title, string description, string type, Guid referenceId)
        {
            await _notificationHub.Clients.All.SendAsync("ReceiveNotification", accountId.ToString() ,title, description, type, referenceId.ToString());
            Console.WriteLine($"Sent notification to {accountId}: {title} - {description}");
        }
    }
}
