using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Owners;
using AVR.Application.ViewModels.Response.Owners;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class ApartmentOwnerService : IApartmentOwnerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<Account> _userManager;

        public ApartmentOwnerService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<Account> userManager )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }


        // Tạo ApartmentOwner và ApartmentOwnerApartment đồng thời
        public async Task<ApartmentOwnerResponse> CreateApartmentOwnerAsync(CreateApartmentOwnerRequest request)
        {
            // Kiểm tra xem Account có tồn tại không
            var account = await _userManager.FindByIdAsync(request.AccountID.ToString());
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy tài khoản.");
            }


            // Map từ request thành thực thể ApartmentOwner và thêm AccountID
            var apartmentOwner = _mapper.Map<ApartmentOwner>(request);
            apartmentOwner.AccountID = request.AccountID;  // Gán AccountID vào ApartmentOwner

            // Thêm ApartmentOwner vào database
            _unitOfWork.ApartmentOwnerRepository.Insert(apartmentOwner);
            await _unitOfWork.SaveAsync();

            // Cập nhật vai trò của Account thành "Apartment Owner" nếu chưa có
            if (!await _userManager.IsInRoleAsync(account, "Apartment Owner"))
            {
                var roleResult = await _userManager.AddToRoleAsync(account, "Apartment Owner");
                if (!roleResult.Succeeded)
                {
                    throw new CustomException.InvalidDataException("Không thể gán vai trò Apartment Owner cho tài khoản.");
                }
            }

            return _mapper.Map<ApartmentOwnerResponse>(apartmentOwner);
        }


        // Lấy tất cả ApartmentOwner
        public async Task<IEnumerable<ApartmentOwnerResponse>> GetAllApartmentOwnersAsync()
        {
            var apartmentOwners = await _unitOfWork.ApartmentOwnerRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ApartmentOwnerResponse>>(apartmentOwners);
        }

        // Lấy ApartmentOwner theo ID
        public async Task<ApartmentOwnerResponse> GetApartmentOwnerByIdAsync(Guid apartmentOwnerId)
        {
            var apartmentOwner = await _unitOfWork.ApartmentOwnerRepository.GetByIdAsync(apartmentOwnerId);
            if (apartmentOwner == null)
                throw new CustomException.DataNotFoundException("Apartment Owner not found");

            return _mapper.Map<ApartmentOwnerResponse>(apartmentOwner);
        }

        // Cập nhật ApartmentOwner
        public async Task<ApartmentOwnerResponse> UpdateApartmentOwnerAsync(Guid apartmentOwnerId, UpdateApartmentOwnerRequest request)
        {
            var apartmentOwner = await _unitOfWork.ApartmentOwnerRepository.GetByIdAsync(apartmentOwnerId);
            if (apartmentOwner == null)
                throw new CustomException.DataNotFoundException("Apartment Owner not found");

            // Map dữ liệu từ request
            _mapper.Map(request, apartmentOwner);
            _unitOfWork.ApartmentOwnerRepository.Update(apartmentOwner);

            await _unitOfWork.SaveAsync();
            return _mapper.Map<ApartmentOwnerResponse>(apartmentOwner);
        }

        

        public async Task<(IEnumerable<ApartmentOwnerResponse> Owners, int TotalItems, int TotalPages)> SearchApartmentOwnersAsync(
                string? name = null,
                string? email = null,
                string? phoneNumber = null,
                int pageIndex = 1,
                int pageSize = 10)
        {
            // Xây dựng bộ lọc tìm kiếm dựa trên các tiêu chí
            Expression<Func<ApartmentOwner, bool>> filter = owner =>
                (string.IsNullOrEmpty(name) || owner.Name.Contains(name)) &&
                (string.IsNullOrEmpty(email) || owner.Email.Contains(email)) &&
                (string.IsNullOrEmpty(phoneNumber) || owner.PhoneNumber.Contains(phoneNumber));

            // Tính tổng số lượng bản ghi phù hợp với bộ lọc
            int totalItems = await _unitOfWork.ApartmentOwnerRepository.CountAsync(filter);

            // Tính tổng số trang dựa trên tổng số bản ghi và kích thước trang
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Truy vấn các bản ghi theo bộ lọc và phân trang
            var owners = _unitOfWork.ApartmentOwnerRepository.Get(
                filter: filter,
                orderBy: q => q.OrderBy(o => o.Name), // Sắp xếp theo tên hoặc các tiêu chí khác nếu cần
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Map kết quả sang response DTO
            var ownersResponse = _mapper.Map<IEnumerable<ApartmentOwnerResponse>>(owners);

            return (ownersResponse, totalItems, totalPages);
        }


    }
}
