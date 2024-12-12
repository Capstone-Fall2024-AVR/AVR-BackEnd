using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Notifications;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using Quartz;
using System;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.Quartz
{
    public class WarningPropertyJob : IJob
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INotificationService _notificationService;

        public WarningPropertyJob(IUnitOfWork unitOfWork, INotificationService notificationService)
        {
            _unitOfWork = unitOfWork;
            _notificationService = notificationService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            var verificationID = context.JobDetail.JobDataMap.GetGuid("verificationID");

            // Lấy PropertyVerification từ cơ sở dữ liệu
            var verification = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(verificationID);
            if (verification == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy thông tin Property Verification!");
            }

            if (verification.VerificationStatus == VerificationStatus.Accepted)
            {
                // Gửi thông báo cảnh báo đến chủ sở hữu
                var notificationRequest = new NotificationRequest
                {
                    AccountID = verification.ApartmentOwnerApartment.ApartmentOwnerID,
                    Title = "Cảnh báo sắp hết hạn!",
                    Description = $"Hợp đồng ký gửi của bạn sẽ hết hạn vào ngày {verification.ExpiryDate:dd/MM/yyyy}. Vui lòng gia hạn hợp đồng nếu cần thiết.",
                    NotificationTypes = NotificationType.PropertyRequest,
                    ReferenceId = verificationID
                };

                await _notificationService.CreateNotificationAsync(notificationRequest);
            }
        }
    }
}
