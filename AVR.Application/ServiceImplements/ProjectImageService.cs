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
    public class ProjectImageService : IProjectImageService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectImageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task DeleteProjectImageAsync(Guid projectImageId)
        {
            // Kiểm tra hình ảnh có tồn tại không
            var projectImage = await _unitOfWork.ProjectImageRepository.GetByIdAsync(projectImageId);
            if (projectImage == null)
            {
                throw new CustomException.DataNotFoundException($"Không tìm thấy hình ảnh với ID {projectImageId}");
            }

            // Xóa hình ảnh
            _unitOfWork.ProjectImageRepository.Delete(projectImage);

            // Lưu thay đổi vào cơ sở dữ liệu
            await _unitOfWork.SaveAsync();
        }
    }
}
