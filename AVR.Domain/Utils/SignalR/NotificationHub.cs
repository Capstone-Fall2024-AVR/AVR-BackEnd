using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Utils.SignalR
{
    public class NotificationHub : Hub
    {
        public async Task SendNotification(string userId, string title, string description)
        {
            await Clients.User(userId).SendAsync("ReceiveNotification", title, description);
        }
    }
}
