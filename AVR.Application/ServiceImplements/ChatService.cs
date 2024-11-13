using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Chats;
using AVR.Application.ViewModels.Response.Chats;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using DocumentFormat.OpenXml.Office2016.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class ChatService : IChatService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISignalRConfiguration _signalRChat;
        private readonly IMapper _mapper;

        public ChatService(IUnitOfWork unitOfWork, IMapper mapper, ISignalRConfiguration signalRConfiguration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _signalRChat = signalRConfiguration;
        }

        // Tạo phiên trò chuyện
        public async Task<ChatSessionResponse> CreateChatSessionAsync(CreateChatSessionRequest request)
        {
            var session = _mapper.Map<ChatSession>(request);
            session.StartTime = CoreHelper.SystemTimeNow;
            session.IsActive = true;
            _unitOfWork.ChatSessionRepository.Insert(session);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<ChatSessionResponse>(session);

            //CallSignalR
            await _signalRChat.JoinChatSession(response.CustomerId, response.Id);
            await _signalRChat.JoinChatSession(response.SupportStaffId, response.Id);


            return response;
        }

        // Kết thúc phiên trò chuyện
        public async Task<ChatSessionResponse> EndChatSessionAsync(Guid sessionId)
        {
            var session = await _unitOfWork.ChatSessionRepository.GetByIdAsync(sessionId);
            if (session == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy phiên trò chuyện.");

            session.EndTime = DateTimeOffset.UtcNow;
            session.IsActive = false;

            _unitOfWork.ChatSessionRepository.Update(session);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<ChatSessionResponse>(session);
            //CallSignalR
            await _signalRChat.LeaveChatSession(response.CustomerId, response.Id);
            await _signalRChat.LeaveChatSession(response.SupportStaffId, response.Id);

            return response;
        }

        // Tạo tin nhắn mới
        public async Task<ChatMessageResponse> CreateChatMessageAsync(CreateChatMessageRequest request)
        {
            var session = _unitOfWork.ChatSessionRepository.Get(a=>a.Id == request.SessionId && a.IsActive == false);
            if (session != null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy phiên trò chuyện hoặc phiên trò chuyện đã kết thúc.");
            }    
            
            var message = _mapper.Map<ChatMessage>(request);
            message.Timestamp = CoreHelper.SystemTimeNow;
            _unitOfWork.ChatMessageRepository.Insert(message);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<ChatMessageResponse>(message);

            await _signalRChat.SendMessage(response.SessionId, response.SenderId, response.ReceiverId, response.MessageContent);

            return response;
        }

        // Lấy lịch sử tin nhắn của một phiên trò chuyện
        public async Task<IEnumerable<ChatMessageResponse>> GetChatHistoryAsync(Guid sessionId)
        {
            var messages = _unitOfWork.ChatMessageRepository.Get(
                filter: m => m.SessionId == sessionId,
                orderBy: q => q.OrderBy(m => m.Timestamp)
                
            );
            return _mapper.Map<IEnumerable<ChatMessageResponse>>(messages);
        }


        // In ChatService.cs
        public async Task<(IEnumerable<ChatMessageResponse> Results, int TotalItems, int TotalPages)> SearchChatMessagesAsync(
            Guid? sessionId = null,
            Guid? senderId = null,
            Guid? receiverId = null,
            string? messageContent = null,
            DateTimeOffset? startDate = null,
            DateTimeOffset? endDate = null,
            int pageIndex = 1,
            int pageSize = 10)
        {
            // Build the filter expression based on the search parameters
            Expression<Func<ChatMessage, bool>> filter = m =>
                (!sessionId.HasValue || m.SessionId == sessionId) &&
                (!senderId.HasValue || m.SenderId == senderId) &&
                (!receiverId.HasValue || m.ReceiverId == receiverId) &&
                (string.IsNullOrEmpty(messageContent) || m.MessageContent.Contains(messageContent)) &&
                (!startDate.HasValue || m.Timestamp >= startDate) &&
                (!endDate.HasValue || m.Timestamp <= endDate);

            // Count total items matching the filter
            int totalItems = await _unitOfWork.ChatMessageRepository.CountAsync(filter);

            // Get paginated results
            var messages = _unitOfWork.ChatMessageRepository.Get(
                filter: filter,
                orderBy: q => q.OrderBy(m => m.Timestamp),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Calculate total pages
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Map results to response DTOs
            var results = _mapper.Map<IEnumerable<ChatMessageResponse>>(messages);

            return (results, totalItems, totalPages);
        }


        public async Task<(IEnumerable<ChatSessionResponse> Results, int TotalItems, int TotalPages)> SearchChatSessionsAsync(
            Guid? customerId = null,
            Guid? supportStaffId = null,
            bool? isActive = null,
            DateTimeOffset? startDate = null,
            DateTimeOffset? endDate = null,
            int pageIndex = 1,
            int pageSize = 10)
        {
            // Build the filter expression based on the search parameters
            Expression<Func<ChatSession, bool>> filter = s =>
                (!customerId.HasValue || s.CustomerId == customerId) &&
                (!supportStaffId.HasValue || s.SupportStaffId == supportStaffId) &&
                (!isActive.HasValue || s.IsActive == isActive) &&
                (!startDate.HasValue || s.StartTime >= startDate) &&
                (!endDate.HasValue || (s.EndTime.HasValue && s.EndTime <= endDate));

            // Count total items matching the filter
            int totalItems = await _unitOfWork.ChatSessionRepository.CountAsync(filter);

            // Get paginated results
            var sessions = _unitOfWork.ChatSessionRepository.Get(
                filter: filter,
                orderBy: q => q.OrderBy(s => s.StartTime),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Calculate total pages
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Map results to response DTOs
            var results = _mapper.Map<IEnumerable<ChatSessionResponse>>(sessions);

            return (results, totalItems, totalPages);
        }


    }
}
