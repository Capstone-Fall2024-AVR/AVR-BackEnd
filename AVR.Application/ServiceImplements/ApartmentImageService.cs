using AVR.Domain.Interfaces;
using AVR.Application.Services;
using AVR.Domain.CustomException;
using System;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class ApartmentImageService : IApartmentImageService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApartmentImageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeleteApartmentImageAsync(Guid apartmentImageId)
        {
            // Kiểm tra xem ApartmentImage có tồn tại hay không
            var apartmentImage = await _unitOfWork.ApartmentImageRepository.GetByIdAsync(apartmentImageId);
            if (apartmentImage == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy Apartment Image.");
            }

            // Xóa ApartmentImage
            _unitOfWork.ApartmentImageRepository.Delete(apartmentImage);

            // Lưu thay đổi vào cơ sở dữ liệu
            await _unitOfWork.SaveAsync();

            return true;
        }
    }
}
