using AVR.Domain.CustomException;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using AVR.Infrastructure.Integrations.Mail;
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

        public DisablePropertyJob(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
            if (verification != null && (verification.VerificationStatus == VerificationStatus.Accepted))
            {
                verification.VerificationStatus = VerificationStatus.Expirated;
                verification.UpdateDate = CoreHelper.SystemTimeNow;

                _unitOfWork.PropertyVerificationRepository.Update(verification);

                await _unitOfWork.SaveAsync();
            }
        }
    }
}
