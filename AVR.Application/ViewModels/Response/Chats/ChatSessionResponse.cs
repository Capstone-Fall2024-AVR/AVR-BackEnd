using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Chats
{
    public class ChatSessionResponse : IMapFrom<ChatSession>
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid SupportStaffId { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset? EndTime { get; set; }
        public bool IsActive { get; set; }
    }
}
