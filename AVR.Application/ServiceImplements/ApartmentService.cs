using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Apartments;
using AVR.Application.ViewModels.Request.Projects;
using AVR.Application.ViewModels.Response.Apartments;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class ApartmentService : IApartmentService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ApartmentService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        //Tạo căn hộ cho project
        public async Task<CreateApartmentResponse> CreateApartment(CreateApartmentRequest request)
        {
            // Kiểm tra xem dự án căn hộ có tồn tại không
            var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(request.ProjectApartmentID);
            if (projectApartment == null)
            {
                throw new CustomException.InvalidDataException("Dự án căn hộ không tồn tại.");
            }

            // Tạo đối tượng Apartment từ request
            var apartment = _mapper.Map<Apartment>(request);
            apartment.ApartmentID = Guid.NewGuid();
            apartment.CreatedDate = DateTimeOffset.Now;
            apartment.UpdatedDate = DateTimeOffset.Now;

            // Lưu căn hộ vào cơ sở dữ liệu
            _unitOfWork.ApartmentRepository.Insert(apartment);
            await _unitOfWork.SaveAsync();

            // Lưu vào bảng trung gian ProjectApartmentApartment
            var projectApartmentApartment = new ProjectApartmentApartment
            {
                ProjectApartmentID = projectApartment.ProjectApartmentID,
                ApartmentID = apartment.ApartmentID
            };

            _unitOfWork.ProjectApartmentApartmentRepository.Insert(projectApartmentApartment);
            await _unitOfWork.SaveAsync();

            // Trả về response
            var response = _mapper.Map<CreateApartmentResponse>(apartment);
            return response;
        }


        //Tạo apartment cho apartment owner
        public async Task<CreateApartmentResponse> CreateApartmentForOwnerAsync(CreateApartmentForOwnerRequest request)
        {
            // Kiểm tra xem chủ sở hữu (Account) có tồn tại không
            var account = await _unitOfWork.AccountRepository.GetByIdAsync(request.AccountID);
            if (account == null)
            {
                throw new CustomException.InvalidDataException("Chủ sở hữu căn hộ không tồn tại.");
            }

            // Tạo đối tượng Apartment từ request
            var apartment = _mapper.Map<Apartment>(request);
            apartment.ApartmentID = Guid.NewGuid();
            apartment.CreatedDate = DateTimeOffset.Now;
            apartment.UpdatedDate = DateTimeOffset.Now;

            // Lưu căn hộ vào cơ sở dữ liệu
            _unitOfWork.ApartmentRepository.Insert(apartment);
            await _unitOfWork.SaveAsync();

            // Lưu vào bảng trung gian ApartmentOwnerApartment
            var apartmentOwnerApartment = new ApartmentOwnerApartment
            {
                ApartmentID = apartment.ApartmentID,
                AccountID = account.Id
            };

            _unitOfWork.ApartmentOwnerApartmentRepository.Insert(apartmentOwnerApartment);
            await _unitOfWork.SaveAsync();

            // Trả về response
            var response = _mapper.Map<CreateApartmentResponse>(apartment);
            return response;
        }


        //Add 1 list căn hộ cho project
        public async Task<IEnumerable<CreateApartmentResponse>> CreateApartmentList(CreateApartmentListRequest request)
        {
            // Kiểm tra xem dự án căn hộ có tồn tại không
            var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(request.ProjectApartmentID);
            if (projectApartment == null)
            {
                throw new CustomException.InvalidDataException("Dự án căn hộ không tồn tại.");
            }

            var responses = new List<CreateApartmentResponse>();

            foreach (var apartmentRequest in request.Apartments)
            {
                // Tạo đối tượng Apartment từ request
                var apartment = _mapper.Map<Apartment>(apartmentRequest);
                apartment.ApartmentID = Guid.NewGuid();
                apartment.CreatedDate = DateTimeOffset.Now;
                apartment.UpdatedDate = DateTimeOffset.Now;

                // Lưu căn hộ vào cơ sở dữ liệu
                _unitOfWork.ApartmentRepository.Insert(apartment);
                await _unitOfWork.SaveAsync();

                // Lưu vào bảng trung gian ProjectApartmentApartment
                var projectApartmentApartment = new ProjectApartmentApartment
                {
                    ProjectApartmentID = projectApartment.ProjectApartmentID,
                    ApartmentID = apartment.ApartmentID
                };

                _unitOfWork.ProjectApartmentApartmentRepository.Insert(projectApartmentApartment);
                await _unitOfWork.SaveAsync();

                // Thêm vào danh sách kết quả
                var response = _mapper.Map<CreateApartmentResponse>(apartment);
                response.ApartmentStatus = apartment.ApartmentStatus.ToString();
                responses.Add(response);
            }

            return responses;
        }



        //Get By id

        public async Task<CreateApartmentResponse> GetApartmentById(Guid id)
        {
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(id);
            if(apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy apartment này.");
            }
            var response = _mapper.Map<CreateApartmentResponse>(apartment);
            return response;
        }

        //Get list apartment
        public async Task<IEnumerable<CreateApartmentResponse>> GetApartments()
        {
            var apartments = await _unitOfWork.ApartmentRepository.GetAllAsync();
            if(apartments == null)
            {
                throw new CustomException.DataNotFoundException("List apartment này trống.");
            }
            var response = _mapper.Map<IEnumerable<CreateApartmentResponse>>(apartments);
            return response;
        }

        public async Task<IEnumerable<CreateApartmentResponse>> SearchApartments(
            string? apartmentName,
            string? address,
            List<ApartmentType>? apartmentTypes,  // Danh sách loại hình căn hộ
            decimal? minPrice,
            decimal? maxPrice,
            decimal? minArea,
            decimal? maxArea,
            int? numberOfRooms,
            int? numberOfBathrooms,
            List<Direction>? directions,  // Danh sách hướng nhà
            List<BalconyDirection>? balconyDirections,  // Danh sách hướng ban công
            int pageIndex = 1,
            int pageSize = 5)
        {
            // Tạo filter expression dựa trên các tham số tìm kiếm
            Expression<Func<Apartment, bool>> filter = a =>
                 (string.IsNullOrEmpty(apartmentName) || a.ApartmentName.Contains(apartmentName)) &&
                 (string.IsNullOrEmpty(address) || a.Address.Contains(address)) &&
                 (apartmentTypes == null || apartmentTypes.Count == 0 || apartmentTypes.Contains(a.ApartmentType)) &&
                 (!minPrice.HasValue || a.RecommendedPrice >= minPrice) &&  // Bắt điều kiện giá tối thiểu
                 (!maxPrice.HasValue || a.RecommendedPrice <= maxPrice) &&  // Bắt điều kiện giá tối đa
                 (!minArea.HasValue || a.Area >= minArea) &&
                 (!maxArea.HasValue || a.Area <= maxArea) &&
                 (!numberOfRooms.HasValue || a.NumberOfRooms == numberOfRooms) &&
                 (!numberOfBathrooms.HasValue || a.NumberOfBathrooms == numberOfBathrooms) &&
                 (directions == null || directions.Count == 0 || directions.Contains(a.Direction)) &&
                 (balconyDirections == null || balconyDirections.Count == 0 || balconyDirections.Contains(a.BalconyDirection));



            // Truy vấn từ repository với filter, sắp xếp và phân trang
            var apartments = _unitOfWork.ApartmentRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(a => a.CreatedDate),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Kiểm tra nếu không có kết quả trả về
            if (!apartments.Any())
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ nào phù hợp với tiêu chí tìm kiếm.");
            }

            // Ánh xạ kết quả trả về thành response
            var response = _mapper.Map<IEnumerable<CreateApartmentResponse>>(apartments);

            return response;
        }


        //Search


    }
}
