using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using AVR.Infrastructure.Integrations.Mail;
using DocumentFormat.OpenXml.Bibliography;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.Quartz
{
    public class DisablePropertyJob : IJob
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INotificationService _notificationService;

        public DisablePropertyJob(IUnitOfWork unitOfWork, INotificationService notificationService)
        {
            _unitOfWork = unitOfWork;
            _notificationService = notificationService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            var verificationID = context.JobDetail.JobDataMap.GetGuid("verificationID");

            // Cập nhật trạng thái Property Verification
            var verification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationID);
            if (verification == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin Property Verification!");
            }
            var aoa = await _unitOfWork.ApartmentOwnerApartmentRepository.GetByIdAsync(verification.ApartmentOwnerApartmentID);
            if (verification != null && (verification.VerificationStatus == VerificationStatus.Accepted))
            {
                verification.VerificationStatus = VerificationStatus.Expirated;
                verification.UpdateDate = CoreHelper.SystemTimeNow;

                var notificationRequest = new NotificationRequest
                {
                    AccountID = aoa.ApartmentOwnerID,
                    Title = "Ký gửi hết hạn!",
                    Description = $"Hợp đồng ký gửi của bạn đã hết hạn",
                    NotificationTypes = NotificationType.PropertyRequest,
                    ReferenceId = verificationID
                };

                await _notificationService.CreateNotificationAsync(notificationRequest);

                _unitOfWork.PropertyVerificationRepository.Update(verification);

                await _unitOfWork.SaveAsync();
            }
        }
    }
}
