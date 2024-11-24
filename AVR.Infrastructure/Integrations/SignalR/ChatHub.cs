using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.SignalR
{
    public class ChatHub : Hub
    {
        // Khi người dùng kết nối
        public override Task OnConnectedAsync()
        {
            var userId = Context.UserIdentifier;
            Console.WriteLine($"ChatHub: User connected with ID: {userId}");

            // Log thêm toàn bộ Claims để kiểm tra
            var claims = Context.User?.Claims.Select(c => $"{c.Type}: {c.Value}").ToList();
            Console.WriteLine($"NotificationHub: User Claims: {string.Join(", ", claims ?? new List<string>())}");

            return base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var userId = Context.UserIdentifier;
            Console.WriteLine($"ChatHub: User disconnected with ID: {userId}");

            await base.OnDisconnectedAsync(exception);
        }

        // Join Group (Chat Session)
        public async Task JoinGroup(string groupId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupId);
            Console.WriteLine($"Connection {Context.ConnectionId} joined group {groupId}");
        }

        // Leave Group (Chat Session)
        public async Task LeaveGroup(string groupId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupId);
            Console.WriteLine($"Connection {Context.ConnectionId} left group {groupId}");
        }
    }
}
