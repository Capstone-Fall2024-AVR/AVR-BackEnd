using AVR.Application.Services;
using AVR.Domain.CustomException;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.Quartz
{
    public class DisableApartmentJob : IJob
    {

        private readonly IUnitOfWork _unitOfWork;

        public DisableApartmentJob(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            var apartmentID = context.JobDetail.JobDataMap.GetGuid("apartmentID");
            // Cập nhật trạng thái Deposit và Apartment
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(apartmentID);
            if (apartment != null && apartment.ApartmentStatus == ApartmentStatus.Available)
            {
                apartment.ApartmentStatus = ApartmentStatus.Expired;
                apartment.UpdatedDate = CoreHelper.SystemTimeNow;

                _unitOfWork.ApartmentRepository.Update(apartment);
                await _unitOfWork.SaveAsync();
            }
        }
    }
}
