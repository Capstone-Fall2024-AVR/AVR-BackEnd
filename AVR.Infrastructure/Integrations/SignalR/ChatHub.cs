using AVR.Application.ViewModels.Response.Chats;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.SignalR
{
    public class ChatHub : Hub
    {
        // Gửi tin nhắn trong phiên trò chuyện
      
        public async Task SendMessage(ChatMessageResponse response)
        {
            // Ping tin nhắn cho người nhận
            await Clients.User(response.ReceiverId.ToString()).SendAsync("ReceiveMessage", response);
        }

        // Tham gia vào một phiên trò chuyện
        public async Task JoinChatSession(Guid sessionId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, sessionId.ToString());
        }

        // Rời khỏi phiên trò chuyện
        public async Task LeaveChatSession(Guid sessionId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, sessionId.ToString());
        }
    }
}

