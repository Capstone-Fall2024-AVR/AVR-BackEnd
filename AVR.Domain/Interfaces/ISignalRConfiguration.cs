using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Interfaces
{
    public interface ISignalRConfiguration
    {
        Task SendNotification(Guid accountId, string title, string description, string type, Guid referenceId);

        Task SendMessage(Guid sessionId, Guid senderId, Guid receiverId, string messageContent);

        Task JoinChatSession(Guid accountId, Guid sessionId);
        Task LeaveChatSession(Guid accountId, Guid sessionId);
    }
}
