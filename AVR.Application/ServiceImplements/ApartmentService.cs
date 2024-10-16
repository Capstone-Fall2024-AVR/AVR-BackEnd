using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Apartments;
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
        private readonly IFirebaseConfig _firebaseConfig;
        public ApartmentService(IMapper mapper, IUnitOfWork unitOfWork, IFirebaseConfig firebaseConfig)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _firebaseConfig = firebaseConfig;
        }

        /*//Tạo căn hộ cho project
        public async Task<CreateApartmentResponse> CreateApartmentForProject(CreateApartmentForProjectRequest request)
        {
            // Kiểm tra xem dự án có tồn tại không
            var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(request.ProjectApartmentID);
            if (projectApartment == null)
            {
                throw new CustomException.DataNotFoundException("Dự án căn hộ không tồn tại.");
            }

            // Tạo căn hộ từ request
            var apartment = _mapper.Map<Apartment>(request);
            apartment.ApartmentID = Guid.NewGuid();
            apartment.CreatedDate = DateTimeOffset.Now;
            apartment.UpdatedDate = DateTimeOffset.Now;
            apartment.ApartmentStatus = ApartmentStatus.Available;

            // Lưu căn hộ vào cơ sở dữ liệu
            _unitOfWork.ApartmentRepository.Insert(apartment);
            await _unitOfWork.SaveAsync();

            // Lưu vào bảng trung gian ProjectApartmentApartment
            var projectApartmentApartment = new ProjectApartmentApartment
            {
                ProjectApartmentID = projectApartment.ProjectApartmentID,
                ApartmentID = apartment.ApartmentID
            };

            // Upload hình ảnh lên Firebase và lưu vào cơ sở dữ liệu
            var imageResponses = new List<ApartmentImageResponse>();
            if (request.Images != null && request.Images.Count > 0)
            {
                foreach (var file in request.Images)
                {
                    var imageUrl = await _firebaseConfig.UploadImage(file); // Upload hình lên Firebase

                    var apartmentImage = new ApartmentImage
                    {
                        ApartmentImageID = Guid.NewGuid(),
                        Description = file.FileName,
                        ImageUrl = imageUrl,
                        CreateDate = DateTimeOffset.Now,
                        UpdateDate = DateTimeOffset.Now,
                        ApartmentID = apartment.ApartmentID
                    };

                    _unitOfWork.ApartmentImageRepository.Insert(apartmentImage);
                    imageResponses.Add(new ApartmentImageResponse
                    {
                        ApartmentImageID = apartmentImage.ApartmentImageID,
                        Description = apartmentImage.Description,
                        ImageUrl = apartmentImage.ImageUrl
                    });
                }

                await _unitOfWork.SaveAsync();
            }

            _unitOfWork.ProjectApartmentApartmentRepository.Insert(projectApartmentApartment);
            await _unitOfWork.SaveAsync();

            // Trả về response sau khi lưu thành công
            var response = _mapper.Map<CreateApartmentResponse>(apartment);
            response.Images = imageResponses;
            return response;
        }
*/


        //Tạo apartment cho apartment owner
        public async Task<CreateApartmentForOwnerResponse> CreateApartmentForOwnerAsync(CreateApartmentForOwnerRequest request)
        {
            // Kiểm tra xem chủ sở hữu (Account) có tồn tại không
            var account = await _unitOfWork.AccountRepository.GetByIdAsync(request.AccountID);
            if (account == null)
            {
                throw new CustomException.InvalidDataException("Chủ sở hữu căn hộ không tồn tại.");
            }

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
            apartment.ApartmentStatus = ApartmentStatus.Available;
            apartment.ProjectApartmentID = request.ProjectApartmentID;  // Gán ProjectApartmentID cho căn hộ

            // Lưu căn hộ vào cơ sở dữ liệu
            _unitOfWork.ApartmentRepository.Insert(apartment);
            await _unitOfWork.SaveAsync();

            // Lưu vào bảng trung gian ApartmentOwnerApartment
            var apartmentOwnerApartment = new ApartmentOwnerApartment
            {
                ApartmentID = apartment.ApartmentID,
                AccountID = account.Id
            };

            // Upload hình ảnh lên Firebase và lưu vào cơ sở dữ liệu
            var imageResponses = new List<ApartmentImageResponse>();
            if (request.Images != null && request.Images.Count > 0)
            {
                foreach (var file in request.Images)
                {
                    var imageUrl = await _firebaseConfig.UploadImage(file); // Upload hình lên Firebase

                    var apartmentImage = new ApartmentImage
                    {
                        ApartmentImageID = Guid.NewGuid(),
                        Description = file.FileName,
                        ImageUrl = imageUrl,
                        CreateDate = DateTimeOffset.Now,
                        UpdateDate = DateTimeOffset.Now,
                        ApartmentID = apartment.ApartmentID
                    };

                    _unitOfWork.ApartmentImageRepository.Insert(apartmentImage);
                    imageResponses.Add(new ApartmentImageResponse
                    {
                        ApartmentImageID = apartmentImage.ApartmentImageID,
                        Description = apartmentImage.Description,
                        ImageUrl = apartmentImage.ImageUrl
                    });
                }

                await _unitOfWork.SaveAsync();
            }

            _unitOfWork.ApartmentOwnerApartmentRepository.Insert(apartmentOwnerApartment);
            await _unitOfWork.SaveAsync();

            // Trả về response bao gồm thông tin căn hộ và tên của chủ sở hữu
            var response = _mapper.Map<CreateApartmentForOwnerResponse>(apartment);
            response.Images = imageResponses;

            // Thêm thông tin về chủ sở hữu
            response.OwnerName = account.Name;  // Giả sử Account có thuộc tính Name
            response.OwnerEmail = account.Email;  // Giả sử Account có thuộc tính Email

            return response;
        }
        //Create apartment
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

            // Gắn ProjectApartmentID vào Apartment
            apartment.ProjectApartmentID = projectApartment.ProjectApartmentID;

            // Lưu căn hộ vào cơ sở dữ liệu
            _unitOfWork.ApartmentRepository.Insert(apartment);
            await _unitOfWork.SaveAsync();

            // Xử lý hình ảnh nếu có
            var imageResponses = new List<ApartmentImageResponse>();
            if (request.Images != null && request.Images.Count > 0)
            {
                foreach (var file in request.Images)
                {
                    var imageUrl = await _firebaseConfig.UploadImage(file); // Upload hình lên Firebase

                    var apartmentImage = new ApartmentImage
                    {
                        ApartmentImageID = Guid.NewGuid(),
                        Description = file.FileName,
                        ImageUrl = imageUrl,
                        CreateDate = DateTimeOffset.Now,
                        UpdateDate = DateTimeOffset.Now,
                        ApartmentID = apartment.ApartmentID
                    };

                    _unitOfWork.ApartmentImageRepository.Insert(apartmentImage);
                    imageResponses.Add(new ApartmentImageResponse
                    {
                        ApartmentImageID = apartmentImage.ApartmentImageID,
                        Description = apartmentImage.Description,
                        ImageUrl = apartmentImage.ImageUrl
                    });
                }

                await _unitOfWork.SaveAsync();
            }

            // Trả về response
            var response = _mapper.Map<CreateApartmentResponse>(apartment);
            response.Images = imageResponses; // Trả về danh sách hình ảnh
            response.ProjectApartmentName = projectApartment.ProjectApartmentName; // Trả thêm tên dự án

            return response;
        }





        //Add 1 list căn hộ cho project

        public Task<IEnumerable<CreateApartmentResponse>> CreateApartmentList(CreateApartmentListRequest request)
        {
            throw new NotImplementedException();
        }





        //Get By id

        public async Task<CreateApartmentResponse> GetApartmentById(Guid id)
        {
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(id);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy apartment này.");
            }

            // Lấy tên dự án liên quan
            var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);

            if (projectApartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy dự án căn hộ liên quan.");
            }

            // Lấy danh sách hình ảnh liên quan đến căn hộ
            var apartmentImages = _unitOfWork.ApartmentImageRepository.Get(img => img.ApartmentID == id);

            // Ánh xạ kết quả trả về thành response
            var response = _mapper.Map<CreateApartmentResponse>(apartment);
            response.ProjectApartmentName = projectApartment.ProjectApartmentName; // Thêm tên dự án
            response.Images = apartmentImages.Select(img => new ApartmentImageResponse
            {
                ApartmentImageID = img.ApartmentImageID,
                Description = img.Description,
                ImageUrl = img.ImageUrl
            }).ToList();

            return response;
        }


        //Get list apartment
        //Get list apartment
        public async Task<IEnumerable<CreateApartmentResponse>> GetApartments()
        {
            var apartments = await _unitOfWork.ApartmentRepository.GetAllAsync();
            if (apartments == null || !apartments.Any())
            {
                throw new CustomException.DataNotFoundException("List apartment này trống.");
            }

            var responseList = new List<CreateApartmentResponse>();

            foreach (var apartment in apartments)
            {
                // Lấy tên dự án liên quan
                var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);
                if (projectApartment == null)
                {
                    throw new CustomException.DataNotFoundException($"Không tìm thấy dự án cho căn hộ: {apartment.ApartmentName}");
                }

                // Lấy danh sách hình ảnh liên quan đến căn hộ
                var apartmentImages = _unitOfWork.ApartmentImageRepository.Get(img => img.ApartmentID == apartment.ApartmentID);

                // Ánh xạ kết quả trả về thành response
                var response = _mapper.Map<CreateApartmentResponse>(apartment);
                response.ProjectApartmentName = projectApartment.ProjectApartmentName; // Thêm tên dự án
                response.Images = apartmentImages.Select(img => new ApartmentImageResponse
                {
                    ApartmentImageID = img.ApartmentImageID,
                    Description = img.Description,
                    ImageUrl = img.ImageUrl
                }).ToList();

                responseList.Add(response);
            }

            return responseList;
        }


        public async Task<IEnumerable<CreateApartmentResponse>> SearchApartments(
            string? apartmentName,
            string? address,
            string? district,  // Quận, Huyện
            string? ward,      // Phường, Xã
            List<ApartmentType>? apartmentTypes,  // Danh sách loại hình căn hộ
            decimal? minPrice,
            decimal? maxPrice,
            decimal? minArea,
            decimal? maxArea,
            int? numberOfRooms,
            int? numberOfBathrooms,
            List<Direction>? directions,  // Danh sách hướng nhà
            List<BalconyDirection>? balconyDirections,  // Danh sách hướng ban công
            List<SaleStatus>? saleStatuses,  // Danh sách trạng thái bán hàng
            int pageIndex = 1,
            int pageSize = 5)
        {
            // Tạo filter expression dựa trên các tham số tìm kiếm
            Expression<Func<Apartment, bool>> filter = a =>
                 (string.IsNullOrEmpty(apartmentName) || a.ApartmentName.Contains(apartmentName)) &&
                 (string.IsNullOrEmpty(address) || a.Address.Contains(address)) &&
                 (string.IsNullOrEmpty(district) || a.District.Contains(district)) &&  // Thêm điều kiện lọc theo Quận, Huyện
                 (string.IsNullOrEmpty(ward) || a.Ward.Contains(ward)) &&  // Thêm điều kiện lọc theo Phường, Xã
                 (apartmentTypes == null || apartmentTypes.Count == 0 || apartmentTypes.Contains(a.ApartmentType)) &&
                 (!minPrice.HasValue || a.RecommendedPrice >= minPrice) &&  // Bắt điều kiện giá tối thiểu
                 (!maxPrice.HasValue || a.RecommendedPrice <= maxPrice) &&  // Bắt điều kiện giá tối đa
                 (!minArea.HasValue || a.Area >= minArea) &&
                 (!maxArea.HasValue || a.Area <= maxArea) &&
                 (!numberOfRooms.HasValue || a.NumberOfRooms == numberOfRooms) &&
                 (!numberOfBathrooms.HasValue || a.NumberOfBathrooms == numberOfBathrooms) &&
                 (directions == null || directions.Count == 0 || directions.Contains(a.Direction)) &&
                 (balconyDirections == null || balconyDirections.Count == 0 || balconyDirections.Contains(a.BalconyDirection)) &&
                 (saleStatuses == null || saleStatuses.Count == 0 || saleStatuses.Contains(a.SaleStatus));  // Điều kiện lọc theo SaleStatus;

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
            var responseList = new List<CreateApartmentResponse>();

            foreach (var apartment in apartments)
            {
                // Lấy danh sách hình ảnh cho từng căn hộ
                var apartmentImages = _unitOfWork.ApartmentImageRepository.Get(img => img.ApartmentID == apartment.ApartmentID);

                var imageResponses = apartmentImages.Select(img => new ApartmentImageResponse
                {
                    ApartmentImageID = img.ApartmentImageID,
                    Description = img.Description,
                    ImageUrl = img.ImageUrl
                }).ToList();

                // Lấy tên dự án từ ProjectApartment
                var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(apartment.ProjectApartmentID);
                var projectApartmentName = projectApartment?.ProjectApartmentName ?? "Không rõ dự án";

                // Map response từ apartment và thêm danh sách hình ảnh và tên dự án
                var response = _mapper.Map<CreateApartmentResponse>(apartment);
                response.Images = imageResponses; // Trả về danh sách hình ảnh
                response.ProjectApartmentName = projectApartmentName; // Trả thêm tên dự án

                responseList.Add(response);
            }

            return responseList;
        }


    }
}
