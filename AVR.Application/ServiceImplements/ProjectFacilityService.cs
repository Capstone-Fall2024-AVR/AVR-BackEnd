using AVR.Application.Services;
using AVR.Domain.CustomException;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class ProjectFacilityService : IProjectFacilityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectFacilityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeleteProjectFacilityAsync(Guid projectFacilityId)
        {
            // Kiểm tra xem ProjectFacility có tồn tại hay không
            var projectFacility = await _unitOfWork.ProjectFacilityRepository.GetByIdAsync(projectFacilityId);
            if (projectFacility == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy Project Facility.");
            }

            // Xóa ProjectFacility
            _unitOfWork.ProjectFacilityRepository.Delete(projectFacility);

            // Lưu thay đổi vào cơ sở dữ liệu
            await _unitOfWork.SaveAsync();

            return true;
        }
    }
}
