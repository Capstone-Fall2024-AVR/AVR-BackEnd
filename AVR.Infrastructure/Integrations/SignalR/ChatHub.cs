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
            var userId = Context.UserIdentifier; // Lấy User Identifier từ CustomUserIdProvider
            Console.WriteLine($"NotificationHub: User connected with ID: {userId}");

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

        
    }
}
