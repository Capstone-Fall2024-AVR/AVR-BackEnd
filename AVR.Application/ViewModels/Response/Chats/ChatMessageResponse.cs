using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Chats
{
    public class ChatMessageResponse : IMapFrom<ChatMessage>
    {
        public Guid Id { get; set; }
        public Guid SessionId { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public string MessageContent { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }
}
