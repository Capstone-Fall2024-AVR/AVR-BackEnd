using AVR.Application.Services;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
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
            return $"APTO-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        }

        public async Task<string> GenerateApartmentCode(Guid apartmentID)
        {
            return $"APTP-{apartmentID.ToString().Substring(0, 8).ToUpper()}";
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

        public async Task<string> GenerateTeamCode(Guid TeamId)
        {
            var team = await _unitOfWork.TeamRepository.GetByIdAsync(TeamId);
            if (team == null)
            {
                throw new CustomException.DataNotFoundException("Khong tim thay team");
            }
            return $"TE-{TeamId.ToString().Substring(0, 8).ToUpper()}";
        }

        public async Task<string> GenerateContractCode(Guid PropertyVerificationId)
        {
            var contract = await _unitOfWork.PropertyVerificationRepository.GetByIdAsync(PropertyVerificationId);
            if ( contract == null)
            {
                throw new CustomException.DataNotFoundException("Khong tim thay contract");
            }
            return $"CT-{PropertyVerificationId.ToString().Substring(0, 8).ToUpper()}";
        }

        public async Task<string> GenerateAppointmentRequestCode(Guid AppointmentRequestId)
        {
            return $"ATR-{AppointmentRequestId.ToString().Substring(0, 8).ToUpper()}";
        }

        public async Task<string> GenerateAppointmentCode(Guid AppointmentId)
        {
            return $"AT-{AppointmentId.ToString().Substring(0, 8).ToUpper()}";
        }

        public async Task<string> GeneratePropertyRequestCode(Guid PropertyId)
        {
            return $"PRR-{PropertyId.ToString().Substring(0, 8).ToUpper()}";
        }

    }
}
