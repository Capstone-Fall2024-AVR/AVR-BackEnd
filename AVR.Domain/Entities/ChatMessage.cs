using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ChatMessage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid SenderId { get; set; }  // ID của người gửi
        public Guid? ReceiverId { get; set; }  // ID của người nhận
        public Guid SessionId { get; set; }  // Liên kết với ChatSession
        public string MessageContent { get; set; }
        public DateTimeOffset Timestamp { get; set; }

        public string? ImageUrl { get; set; }

        public virtual ChatSession Session { get; set; }  // Điều hướng đến ChatSession
        public virtual Account Sender { get; set; }
        public virtual Account Receiver { get; set; }   
    }

}
