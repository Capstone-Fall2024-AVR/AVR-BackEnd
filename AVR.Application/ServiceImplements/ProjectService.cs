using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Projects;
using AVR.Application.ViewModels.Response.Apartments;
using AVR.Application.ViewModels.Response.FacilitiesRes;
using AVR.Application.ViewModels.Response.Projects;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class ProjectService : IProjectService

    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFirebaseConfig _firebaseConfig;
        public ProjectService(IMapper mapper, IUnitOfWork unitOfWork, IFirebaseConfig firebaseConfig)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _firebaseConfig = firebaseConfig;
        }

        public async Task<ProjectApartmentResponse> CreateProjectApartmentAsync(CreateProjectApartmentRequest request)
        {
            // Kiểm tra xem nhà cung cấp dự án có tồn tại không
            var provider = await _unitOfWork.ApartmentProjectProviderRepository.GetByIdAsync(request.ApartmentProjectProviderID);
            if (provider == null)
            {
                throw new CustomException.InvalidDataException("Nhà cung cấp dự án không tồn tại.");
            }

            var team = await _unitOfWork.TeamRepository.GetByIdAsync(request.TeamID);
            if (team == null)
            {
                throw new CustomException.InvalidDataException("Team không tồn tại.");
            }


            // Ánh xạ request sang thực thể ProjectApartment
            var projectApartment = _mapper.Map<ProjectApartment>(request);
            projectApartment.CreateDate = CoreHelper.SystemTimeNow;
            projectApartment.UpdateDate = CoreHelper.SystemTimeNow;
            projectApartment.ProjectApartmentStatus = Domain.Enums.ProjectApartmentStatus.Available;
            projectApartment.ProjectType = request.ProjectType;

            // Liên kết dự án với nhà cung cấp dự án
            projectApartment.ApartmentProjectProviderID = request.ApartmentProjectProviderID;
            _unitOfWork.ProjectApartmentRepository.Insert(projectApartment);
            await _unitOfWork.SaveAsync();

            // Xử lý hình ảnh nếu có
            var imageResponses = new List<ProjectImageResponse>();
            if (request.Images != null && request.Images.Count > 0)
            {
                foreach (var file in request.Images)
                {
                    var imageUrl = await _firebaseConfig.UploadImage(file); // Upload hình lên Firebase

                    var projectImage = new ProjectImage
                    {
                        ProjectImageID = Guid.NewGuid(),
                        Name = file.Name,
                        Description = file.FileName,
                        Url = imageUrl,
                        CreateDate = CoreHelper.SystemTimeNow,
                        UpdateDate = CoreHelper.SystemTimeNow,
                        ProjectApartmentID = projectApartment.ProjectApartmentID
                    };

                    _unitOfWork.ProjectImageRepository.Insert(projectImage);
                    imageResponses.Add(_mapper.Map<ProjectImageResponse>(projectImage));
                }

                //await _unitOfWork.SaveAsync();
            }

            // Tạo các tiện ích dự án từ request và liên kết vào dự án
            var facilityResponses = new List<FacilityResponse>();
            foreach (var facilityId in request.FacilityIDs)
            {
                var facility = await _unitOfWork.FacilitiesRepository.GetByIdAsync(facilityId);
                if (facility != null)
                {
                    var projectFacility = new ProjectFacility
                    {
                        ProjectFacilityID = Guid.NewGuid(),
                        FacilityID = facilityId,
                        ProjectApartmentId = projectApartment.ProjectApartmentID
                    };
                    //projectApartment.ProjectFacilities.Add(projectFacility);

                    _unitOfWork.ProjectFacilityRepository.Insert(projectFacility);
                    facilityResponses.Add(_mapper.Map<FacilityResponse>(facility));
                    
                }
            }

            // Lưu dự án căn hộ vào cơ sở dữ liệu
            await _unitOfWork.SaveAsync();

            // Ánh xạ từ ProjectApartment sang ProjectApartmentResponse
            var response = _mapper.Map<ProjectApartmentResponse>(projectApartment);
            response.ApartmentProjectProviderName = provider.ApartmentProjectProviderName;
            response.ProjectImages = imageResponses;
            response.Facilities = facilityResponses;
            return response;
        }

        public async Task<IEnumerable<ProjectApartmentResponse>> GetAllProject()
        {
            var projects = _unitOfWork.ProjectApartmentRepository.Get(includeProperties: "ProjectImages,ProjectFacilities.Facility");
            if (projects == null)
            {
                throw new CustomException.DataNotFoundException("List project empty !");
            }
            var response = projects.Select(project =>
            {
                var projectResponse = _mapper.Map<ProjectApartmentResponse>(project);
                projectResponse.ProjectImages = _mapper.Map<List<ProjectImageResponse>>(project.ProjectImages);
                projectResponse.Facilities = _mapper.Map<List<FacilityResponse>>(project.ProjectFacilities.Select(pf => pf.Facility).ToList());
                return projectResponse;
            });

            return response;
        }
        public async Task<ProjectApartmentResponse> GetProjectById(Guid id)
        {
            var project = _unitOfWork.ProjectApartmentRepository.Get(c => c.ProjectApartmentID == id, includeProperties: "ProjectImages,ProjectFacilities.Facility").FirstOrDefault();
            if (project == null)
            {
                throw new CustomException.DataNotFoundException("Not found this project !");
            }

            var response = _mapper.Map<ProjectApartmentResponse>(project);
            response.ProjectImages = _mapper.Map<List<ProjectImageResponse>>(project.ProjectImages);
            response.Facilities = _mapper.Map<List<FacilityResponse>>(project.ProjectFacilities.Select(pf => pf.Facility).ToList());

            return response;
        }

        public async Task<(IEnumerable<ProjectApartmentResponse> Projects, int TotalItem, int TotalPage)> SearchProjects(
                string? projectName,
                List<ProjectApartmentStatus>? statuses,
                decimal? minPrice,
                decimal? maxPrice,
                Guid? teamId,
                int pageIndex = 1,
                int pageSize = 5)
        {
            // Tạo bộ lọc
            Expression<Func<ProjectApartment, bool>> filter = p =>
                (string.IsNullOrEmpty(projectName) || p.ProjectApartmentName.Contains(projectName)) &&
                (statuses == null || statuses.Count == 0 || statuses.Contains(p.ProjectApartmentStatus)) &&
                (!minPrice.HasValue || Convert.ToDecimal(p.Price_range) >= minPrice) &&
                (!maxPrice.HasValue || Convert.ToDecimal(p.Price_range) <= maxPrice) &&
                (!teamId.HasValue || p.TeamID == teamId);  // Lọc theo TeamID nếu có;


            var totalItem = await _unitOfWork.ProjectApartmentRepository.CountAsync(filter);


            // Truy vấn với filter và phân trang
            var projects = _unitOfWork.ProjectApartmentRepository.Get(
                filter: filter,
                includeProperties: "ProjectImages,ProjectFacilities.Facility",
                orderBy: q => q.OrderByDescending(p => p.CreateDate),
                pageIndex: pageIndex,
                pageSize: pageSize
            );


            // Ánh xạ kết quả
            var response = projects.Select(project =>
            {
                var projectResponse = _mapper.Map<ProjectApartmentResponse>(project);
                projectResponse.ProjectImages = _mapper.Map<List<ProjectImageResponse>>(project.ProjectImages);
                projectResponse.Facilities = _mapper.Map<List<FacilityResponse>>(project.ProjectFacilities.Select(pf => pf.Facility).ToList());
                return projectResponse;
            });
            int totalPages = (int)Math.Ceiling((double)totalItem / pageSize);

            return (response, totalItem, totalPages);
        }

        public async Task<ProjectApartmentResponse> UpdateProjectApartmentAsync(Guid projectId, UpdateProjectApartmentRequest request)
        {
            // Lấy dự án hiện tại
            var project = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(projectId);
            if (project == null)
            {
                throw new CustomException.DataNotFoundException("Dự án không tồn tại.");
            }

            // Cập nhật thông tin cơ bản của dự án
            project.ProjectApartmentName = request.ProjectApartmentName;
            project.ProjectApartmentDescription = request.ProjectApartmentDescription;
            project.Price_range = request.Price_range;
            project.UpdateDate = CoreHelper.SystemTimeNow;
            project.ProjectApartmentStatus = request.ProjectApartmentStatus;
            project.ProjectType = request.ProjectType;

            // Xử lý tiện ích
            var existingFacilities = _unitOfWork.ProjectFacilityRepository.Get(f => f.ProjectApartmentId == projectId);
            _unitOfWork.ProjectFacilityRepository.Delete(existingFacilities);

            foreach (var facilityId in request.FacilityIDs)
            {
                var facility = await _unitOfWork.FacilitiesRepository.GetByIdAsync(facilityId);
                if (facility != null)
                {
                    var projectFacility = new ProjectFacility
                    {
                        ProjectFacilityID = Guid.NewGuid(),
                        FacilityID = facilityId,
                        ProjectApartmentId = projectId
                    };
                    _unitOfWork.ProjectFacilityRepository.Insert(projectFacility);
                }
            }

            // Xử lý hình ảnh
            var existingImages = _unitOfWork.ProjectImageRepository.Get(i => i.ProjectApartmentID == projectId);
            _unitOfWork.ProjectImageRepository.Delete(existingImages);

            var imageResponses = new List<ProjectImageResponse>();
            if (request.Images != null && request.Images.Count > 0)
            {
                foreach (var file in request.Images)
                {
                    var imageUrl = await _firebaseConfig.UploadImage(file);

                    var projectImage = new ProjectImage
                    {
                        ProjectImageID = Guid.NewGuid(),
                        Name = file.Name,
                        Description = file.FileName,
                        Url = imageUrl,
                        CreateDate = CoreHelper.SystemTimeNow,
                        UpdateDate = CoreHelper.SystemTimeNow,
                        ProjectApartmentID = project.ProjectApartmentID
                    };

                    _unitOfWork.ProjectImageRepository.Insert(projectImage);
                    imageResponses.Add(_mapper.Map<ProjectImageResponse>(projectImage));
                }
            }

            await _unitOfWork.SaveAsync();

            // Chuẩn bị phản hồi
            var response = _mapper.Map<ProjectApartmentResponse>(project);
            response.ProjectImages = imageResponses;
            response.Facilities = request.FacilityIDs.Select(facilityId =>
            {
                var facility = _unitOfWork.FacilitiesRepository.GetByID(facilityId);
                return _mapper.Map<FacilityResponse>(facility);
            }).ToList();

            return response;
        }

    }
}
