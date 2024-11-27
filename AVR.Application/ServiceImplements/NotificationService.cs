using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Response.Accounts;
using AVR.Application.ViewModels.Response.Notifications;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using AVR.Domain.Utils.SignalR;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AVR.Application.ServiceImplements
{
    public class NotificationService: INotificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ISignalRConfiguration _signalRConfiguration;
        


        public NotificationService(IUnitOfWork unitOfWork, IMapper mapper, ISignalRConfiguration signalRConfiguration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _signalRConfiguration = signalRConfiguration;
           
        }
        //Create
        public async Task<NotificationResponse> CreateNotificationAsync(NotificationRequest request)
        {
            

            var account = await _unitOfWork.AccountRepository.GetByIdAsync(request.AccountID);
            if(account == null)
            {
                throw new CustomException.DataNotFoundException("Không có người dùng này");
            }
            if (!Enum.IsDefined(typeof(NotificationType), request.NotificationTypes))
            {
                throw new CustomException.InvalidDataException("Loại thông báo không hợp lệ.");
            }

            var notification = _mapper.Map<Notification>(request);
            notification.Created = CoreHelper.SystemTimeNow;         
            notification.IsRead = false;
            await _unitOfWork.NotificationRepository.InsertAsync(notification);
            await _unitOfWork.SaveAsync();

            // Send notification via SignalR
            await _signalRConfiguration.SendNotification(request.AccountID, request.Title, request.Description, request.NotificationTypes.ToString(), request.ReferenceId);


            var response = _mapper.Map<NotificationResponse>(notification);
            return response;

        }

        //Get all
        public async Task<IEnumerable<NotificationResponse>> GetAllNotificationsAsync()
        {
            var notifications = await _unitOfWork.NotificationRepository.GetAllAsync();
            if (notifications == null)
            {
                throw new CustomException.DataNotFoundException("List thông báo này trống.");
            }

            var response = _mapper.Map<IEnumerable<NotificationResponse>>(notifications);
            return response;
        }

        public async Task<NotificationResponse> GetNotificationAsync(Guid notificationId)
        {
            var noti = await _unitOfWork.NotificationRepository.GetByIdAsync(notificationId);
            if (noti == null)
            {
                throw new CustomException.DataNotFoundException("Không tồn tại noti này.");

            }
            var response = _mapper.Map<NotificationResponse>(noti);
            return response;
        }


        // Mark Notification as Read
        public async Task<NotificationResponse> MarkAsReadAsync(Guid notificationId)
        {
            
            var notification = await _unitOfWork.NotificationRepository.GetByIdAsync(notificationId);
            if (notification == null)
            {
                throw new CustomException.DataNotFoundException("Không tồn tại thông báo này.");
            }

            notification.IsRead = true;
            await _unitOfWork.NotificationRepository.UpdateAsync(notification);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<NotificationResponse>(notification);
            return response;
        }

        // Mark All Notifications as Read for a User
        public async Task MarkAllAsReadAsync(Guid accountId)
        {
            var notifications = _unitOfWork.NotificationRepository.Get(n => n.AccountID == accountId && !n.IsRead);
            foreach (var notification in notifications)
            {
                notification.IsRead = true;
            }
            await _unitOfWork.SaveAsync();
        }



        public async Task<(IEnumerable<NotificationResponse> Results, int TotalItems, int TotalPages)> SearchNotificationsAsync(
             List<NotificationType>? notificationType,
             Guid? accountId,
             string? title,
             bool? isRead,
             int pageIndex = 1,
             int pageSize = 5)
        {
            // Tạo bộ lọc dựa trên các điều kiện tìm kiếm
            Expression<Func<Notification, bool>> filter = n =>
                (notificationType == null || notificationType.Count == 0 || notificationType.Contains(n.NotificationTypes)) &&
                (!accountId.HasValue || n.AccountID == accountId.Value) &&
                (string.IsNullOrEmpty(title) || n.Title.Contains(title)) &&
                (!isRead.HasValue || n.IsRead == isRead.Value);

            // Đếm tổng số bản ghi phù hợp với bộ lọc (Total Items)
            int totalItems = await _unitOfWork.NotificationRepository.CountAsync(filter);

            // Lấy dữ liệu từ repository với bộ lọc và phân trang
            var notifications = _unitOfWork.NotificationRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(n => n.Created),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Tính tổng số trang (Total Pages)
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Map kết quả sang DTO
            var results = _mapper.Map<IEnumerable<NotificationResponse>>(notifications);

            return (results, totalItems, totalPages);
        }




    }
}
