using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Application.ViewModels.Response.Accounts;
using AVR.Application.ViewModels.Response.Notifications;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils.SignalR;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class NotificationService: INotificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ISignalRConfiguration _signalRConfiguration;
        //private readonly IHubContext<NotificationHub> _hubContext;
        //private readonly INotificationHub _notificationHub;


        public NotificationService(IUnitOfWork unitOfWork, IMapper mapper, ISignalRConfiguration signalRConfiguration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _signalRConfiguration = signalRConfiguration;
            //_hubContext = hubContext;
           // _notificationHub = notificationHub;
        }

        public async Task<NotificationResponse> CreateNotificationAsync(NotificationRequest request)
        {
            var notificationType = await _unitOfWork.NotificationTypeRepository.GetByIdAsync(request.NotificationTypeID);
            if (notificationType == null)
            {
                throw new CustomException.DataNotFoundException("Không có kiểu thông báo này.");
            }

            var account = await _unitOfWork.AccountRepository.GetByIdAsync(request.AccountID);
            if(account == null)
            {
                throw new CustomException.DataNotFoundException("Không có người dùng này");
            }



            var notification = _mapper.Map<Notification>(request);
            notification.Created = DateTimeOffset.Now;         
            notification.IsRead = false;
            await _unitOfWork.NotificationRepository.InsertAsync(notification);
            await _unitOfWork.SaveAsync();

            // Send notification via SignalR
            await _signalRConfiguration.SendNotification(request.AccountID, request.Title, request.Description);


            var response = _mapper.Map<NotificationResponse>(notification);
            return response;

        }

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
    }
}
