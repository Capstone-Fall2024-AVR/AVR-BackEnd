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
            // Kiểm tra xem phiên trò chuyện đã tồn tại hay chưa
            var existingSession = _unitOfWork.ChatSessionRepository
                .Get(s => s.CustomerId == request.CustomerId && s.IsActive).FirstOrDefault();

            if (existingSession != null)
            {
                // Nếu đã tồn tại, trả về thông tin phiên trò chuyện đó
                return _mapper.Map<ChatSessionResponse>(existingSession);
            }


            // Kiểm tra khách hàng
            var customer = await _unitOfWork.AccountRepository.GetByIdAsync(request.CustomerId);
            if (customer == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy khách hàng.");
            }

            // Tạo phiên trò chuyện
            var session = _mapper.Map<ChatSession>(request);
            session.StartTime = CoreHelper.SystemTimeNow;
            session.IsActive = true;
            _unitOfWork.ChatSessionRepository.Insert(session);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<ChatSessionResponse>(session);

            return response;
        }


        // Kết thúc phiên trò chuyện
        public async Task<ChatSessionResponse> EndChatSessionAsync(Guid sessionId)
        {
            // Tìm phiên trò chuyện
            var session = await _unitOfWork.ChatSessionRepository.GetByIdAsync(sessionId);
            if (session == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy phiên trò chuyện.");
            }

            // Kết thúc phiên trò chuyện
            session.EndTime = CoreHelper.SystemTimeNow;
            session.IsActive = false;

            _unitOfWork.ChatSessionRepository.Update(session);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<ChatSessionResponse>(session);


            return response;
        }


        // Tạo tin nhắn mới
        public async Task<ChatMessageResponse> CreateChatMessageAsync(CreateChatMessageRequest request)
        {
            // Lấy thông tin phiên trò chuyện
            var session = await _unitOfWork.ChatSessionRepository.GetByIdAsync(request.SessionId);
            if (session == null || !session.IsActive)
            {
                throw new CustomException.DataNotFoundException("Phiên trò chuyện không tồn tại hoặc đã kết thúc.");
            }

            // Tạo tin nhắn
            var message = _mapper.Map<ChatMessage>(request);
            message.Timestamp = CoreHelper.SystemTimeNow;

            // Nếu chưa có nhân viên tham gia phiên, ReceiverId sẽ để trống (null)
            if (!session.SupportStaffId.HasValue)
            {
                message.ReceiverId = null;
            }
            else
            {
                // Nếu đã có nhân viên tham gia, gán ReceiverId là ID của nhân viên hỗ trợ
                message.ReceiverId = session.SupportStaffId.Value;
            }

            _unitOfWork.ChatMessageRepository.Insert(message);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<ChatMessageResponse>(message);

            await _signalRChat.SendChatNotification(response.SessionId, response.SenderId, response.ReceiverId, response.MessageContent, response.Timestamp);

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


        public async Task<bool> IsChatSessionExists(Guid customerId)
        {
            var session = _unitOfWork.ChatSessionRepository.Get(s =>
                s.CustomerId == customerId &&
                s.IsActive
            ).FirstOrDefault();

            return session != null;
        }

        public async Task<ChatSessionResponse> AssignStaffToChatSessionAsync(Guid sessionId, Guid staffId)
        {
            // Kiểm tra phiên trò chuyện
            var session = await _unitOfWork.ChatSessionRepository.GetByIdAsync(sessionId);
            if (session == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy phiên trò chuyện.");
            }

            // Kiểm tra trạng thái phiên
            if (!session.IsActive)
            {
                throw new CustomException.InvalidDataException("Phiên trò chuyện không hoạt động.");
            }

            // Kiểm tra nhân viên hỗ trợ
            var staff = await _unitOfWork.AccountRepository.GetByIdAsync(staffId);
            if (staff == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy nhân viên hỗ trợ.");
            }

            if(!session.SupportStaffId.HasValue)
            {
                session.SupportStaffId = staffId;
                _unitOfWork.ChatSessionRepository.Update(session);
                await _unitOfWork.SaveAsync();

                return _mapper.Map<ChatSessionResponse>(session);
            }

            throw new CustomException.InvalidDataException("Phiên trò chuyện đã có nhân viên hỗ trợ.");
        }


        public async Task<ChatSessionResponse> LeaveChatSessionAsync(Guid sessionId, Guid staffId)
        {
            // Kiểm tra phiên trò chuyện
            var session = await _unitOfWork.ChatSessionRepository.GetByIdAsync(sessionId);
            if (session == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy phiên trò chuyện.");
            }

            // Kiểm tra trạng thái phiên
            if (!session.IsActive)
            {
                throw new CustomException.InvalidDataException("Phiên trò chuyện đã kết thúc.");
            }

            // Kiểm tra nhân viên có thuộc phiên này không
            if (session.SupportStaffId != staffId)
            {
                throw new CustomException.InvalidDataException("Nhân viên không thuộc phiên trò chuyện này.");
            }

            // Gỡ nhân viên khỏi phiên
            session.SupportStaffId = null;

            _unitOfWork.ChatSessionRepository.Update(session);
            await _unitOfWork.SaveAsync();

            // Gửi thông báo qua SignalR để đồng bộ trạng thái
            await _signalRChat.LeaveChatSession(staffId, session.Id);

            // Trả về thông tin phiên trò chuyện đã cập nhật
            return _mapper.Map<ChatSessionResponse>(session);
        }


        public async Task<IEnumerable<ChatMessageResponse>> GetAllChatMessagesAsync()
        {
            var messages = await _unitOfWork.ChatMessageRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ChatMessageResponse>>(messages);
        }

        public async Task<ChatMessageResponse> GetChatMessageByIdAsync(Guid messageId)
        {
            var message = await _unitOfWork.ChatMessageRepository.GetByIdAsync(messageId);
            if (message == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy tin nhắn.");
            }
            return _mapper.Map<ChatMessageResponse>(message);
        }

        public async Task<IEnumerable<ChatSessionResponse>> GetAllChatSessionsAsync()
        {
            var sessions = await _unitOfWork.ChatSessionRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ChatSessionResponse>>(sessions);
        }

        public async Task<ChatSessionResponse> GetChatSessionByIdAsync(Guid sessionId)
        {
            var session = await _unitOfWork.ChatSessionRepository.GetByIdAsync(sessionId);
            if (session == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy phiên trò chuyện.");
            }
            return _mapper.Map<ChatSessionResponse>(session);
        }

    }
}
