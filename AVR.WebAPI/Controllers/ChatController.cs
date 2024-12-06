using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Chats;
using AVR.Domain.CustomException;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/chats")]
    [ApiController]
    public class ChatController : BaseController
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpGet("messages")]
        public async Task<IActionResult> GetAllChatMessages()
        {
            var messages = await _chatService.GetAllChatMessagesAsync();
            return CustomResult("Danh sách tin nhắn.", messages);
        }

        [HttpGet("messages/{messageId}")]
        public async Task<IActionResult> GetChatMessageById(Guid messageId)
        {
            try
            {
                var message = await _chatService.GetChatMessageByIdAsync(messageId);
                return CustomResult("Thông tin tin nhắn.", message);
            }
            catch (CustomException.DataNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        [HttpGet("sessions")]
        public async Task<IActionResult> GetAllChatSessions()
        {
            var sessions = await _chatService.GetAllChatSessionsAsync();
            return CustomResult("Danh sách phiên trò chuyện.", sessions);
        }

        [HttpGet("sessions/{sessionId}")]
        public async Task<IActionResult> GetChatSessionById(Guid sessionId)
        {
            try
            {
                var session = await _chatService.GetChatSessionByIdAsync(sessionId);
                return CustomResult("Thông tin phiên trò chuyện.", session);
            }
            catch (CustomException.DataNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }


        // Tạo một phiên trò chuyện mới
        [HttpPost("create-session")]
        public async Task<IActionResult> CreateChatSession([FromBody] CreateChatSessionRequest request)
        {
            var session = await _chatService.CreateChatSessionAsync(request);
            return CustomResult("Phiên trò chuyện đã được tạo thành công.", session);
        }

        // Kết thúc một phiên trò chuyện
        [HttpPost("end-session/{sessionId}")]
        public async Task<IActionResult> EndChatSession(Guid sessionId)
        {
            var session = await _chatService.EndChatSessionAsync(sessionId);
            return CustomResult("Phiên trò chuyện đã kết thúc.", session);
        }

        // Lấy lịch sử tin nhắn của một phiên trò chuyện
        [HttpGet("history/{sessionId}")]
        public async Task<IActionResult> GetChatHistory(Guid sessionId)
        {
            var messages = await _chatService.GetChatHistoryAsync(sessionId);
            return CustomResult("Lịch sử tin nhắn đã được tải thành công.", messages);
        }

        // Gửi tin nhắn trong một phiên trò chuyện
        [HttpPost("send-message")]
        public async Task<IActionResult> SendMessage([FromForm] CreateChatMessageRequest request)
        {
            var message = await _chatService.CreateChatMessageAsync(request);
            return CustomResult("Tin nhắn đã được gửi thành công.", message);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchChatMessages(
            [FromQuery] Guid? sessionId,
            [FromQuery] Guid? senderId,
            [FromQuery] Guid? receiverId,
            [FromQuery] string? messageContent,
            [FromQuery] DateTimeOffset? startDate,
            [FromQuery] DateTimeOffset? endDate,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 10)
        {
            var (results, totalItems, totalPages) = await _chatService.SearchChatMessagesAsync(
                sessionId, senderId, receiverId, messageContent, startDate, endDate, pageIndex, pageSize
            );

            return CustomResult("Kết quả tìm kiếm tin nhắn", new 
            {
                TotalItems = totalItems, 
                TotalPages = totalPages, 
                Results = results, 
                CurrentPage = pageIndex, 
                PageSize = pageSize 
            });
        }


        [HttpGet("search-sessions")]
        public async Task<IActionResult> SearchChatSessions(
            [FromQuery] Guid? customerId,
            [FromQuery] Guid? supportStaffId,
            [FromQuery] bool? isActive,
            [FromQuery] DateTimeOffset? startDate,
            [FromQuery] DateTimeOffset? endDate,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 10)
        {
            var (results, totalItems, totalPages) = await _chatService.SearchChatSessionsAsync(
                customerId, supportStaffId, isActive, startDate, endDate, pageIndex, pageSize
            );

            return CustomResult("Kết quả tìm kiếm phiên trò chuyện", new 
            { 
                
                TotalItems = totalItems, 
                TotalPages = totalPages,
                Results = results,
                CurrentPage = pageIndex,
                PageSize = pageSize
            });
        }

        [HttpPost("assign-staff")]
        public async Task<IActionResult> AssignStaffToSession([FromQuery] Guid sessionId, [FromQuery] Guid staffId)
        {
            var session = await _chatService.AssignStaffToChatSessionAsync(sessionId, staffId);
            return CustomResult("Nhân viên đã được gán vào phiên trò chuyện thành công.", session);
        }

        [HttpPost("staff-leave-session")]
        public async Task<IActionResult> StaffLeaveSession([FromQuery] Guid sessionId, [FromQuery] Guid staffId)
        {
            var session = await _chatService.LeaveChatSessionAsync(sessionId, staffId);
            return CustomResult("Nhân viên đã rời phiên trò chuyện.", session);
        }

    }
}
