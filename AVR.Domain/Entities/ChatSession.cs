using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ChatSession
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }  // ID của khách hàng
        public Guid? SupportStaffId { get; set; }  // ID của nhân viên hỗ trợ
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset? EndTime { get; set; }  // Thời gian kết thúc phiên trò chuyện
        public bool IsActive { get; set; } = true;  // Trạng thái của phiên trò chuyện

        public virtual Account Customer { get; set; }
        public virtual Account SupportStaff { get; set; }
        public virtual ICollection<ChatMessage> Messages { get; set; } = new List<ChatMessage>();
    }

}
