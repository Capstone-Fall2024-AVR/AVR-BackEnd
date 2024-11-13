using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Chats
{
    public class CreateChatSessionRequest : IMapFrom<ChatSession>
    {
        public Guid CustomerId { get; set; }
        public Guid SupportStaffId { get; set; }
    }
}
