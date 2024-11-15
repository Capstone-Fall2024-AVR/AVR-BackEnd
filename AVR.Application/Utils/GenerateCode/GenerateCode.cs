using AVR.Application.Services;
using AVR.Domain.CustomException;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Utils.GenerateCode
{
    public class GenerateCode : IGenerateCode
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenerateCode(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public string GenerateAptOwnerCode()
        {
            return $"APT-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        }

        public async Task<string> GenerateApartmentCode(Guid apartmentID)
        {
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(apartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ!");
            }
            var project = _unitOfWork.ProjectApartmentRepository.Get(p => p.ProjectApartmentID == apartment.ProjectApartmentID).FirstOrDefault();
            if (project == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy Project");
            }
            return $"{project.ProjectApartmentName.ToString().Substring(0, 3).ToUpper()}-{apartmentID.ToString().Substring(0, 8).ToUpper()}";
        }

        public async Task<string> GenerateProjectCode(Guid ProjectID)
        {
            var project = _unitOfWork.ProjectApartmentRepository.GetByID(ProjectID);
            if (project == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy Project");
            }
            return $"PRO-{ProjectID.ToString().Substring(0, 8).ToUpper()}";

        }

        public async Task<string> GenerateDepositCode(Guid DepositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(DepositId);
            if (deposit == null)
            {
                throw new CustomException.DataNotFoundException("Khong tim thay deposit");
            }
            return $"DPS-{DepositId.ToString().Substring(0, 8).ToUpper()}";
        }
    }
}
