using AVR.Application.ViewModels.Request.Chats;
using AVR.Application.ViewModels.Response.Chats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IChatService
    {
        // Quản lý phiên trò chuyện
        Task<ChatSessionResponse> CreateChatSessionAsync(CreateChatSessionRequest request);
        Task<ChatSessionResponse> EndChatSessionAsync(Guid sessionId);

        // Quản lý tin nhắn
        Task<ChatMessageResponse> CreateChatMessageAsync(CreateChatMessageRequest request);

        // Truy xuất dữ liệu
        Task<IEnumerable<ChatMessageResponse>> GetChatHistoryAsync(Guid sessionId);

        Task<(IEnumerable<ChatMessageResponse> Results, int TotalItems, int TotalPages)> SearchChatMessagesAsync(
                Guid? sessionId = null,
                Guid? senderId = null,
                Guid? receiverId = null,
                string? messageContent = null,
                DateTimeOffset? startDate = null,
                DateTimeOffset? endDate = null,
                int pageIndex = 1,
                int pageSize = 10);


        Task<(IEnumerable<ChatSessionResponse> Results, int TotalItems, int TotalPages)> SearchChatSessionsAsync(
           Guid? customerId = null,
           Guid? supportStaffId = null,
           bool? isActive = null,
           DateTimeOffset? startDate = null,
           DateTimeOffset? endDate = null,
           int pageIndex = 1,
           int pageSize = 10);
    }
}
