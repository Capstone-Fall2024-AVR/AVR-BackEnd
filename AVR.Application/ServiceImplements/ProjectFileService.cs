using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ProjectFile.CreateProjectFileRequest;
using AVR.Application.ViewModels.Request.ProjectFile.UpdateProjectFileRequest;
using AVR.Application.ViewModels.Response.ProjectFile.ProjectFileResponse;
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
    public class ProjectFileService : IProjectFileService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFirebaseConfig _firebaseConfig;

        public ProjectFileService(IFirebaseConfig firebaseConfig, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _firebaseConfig = firebaseConfig;
        }

        public async Task<ProjectFileResponse> CreateProjectFileAsync(CreateProjectFileRequest request)
        {
            var projectFileUrl = await _firebaseConfig.UploadImage(request.ProjectFileUrl);
            var projectFile = _mapper.Map<ProjectFile>(request);
            projectFile.CreateDate = CoreHelper.SystemTimeNow;
            projectFile.UpdateDate = CoreHelper.SystemTimeNow;
            projectFile.ProjectFileUrl = projectFileUrl;

            _unitOfWork.ProjectFileRepository.Insert(projectFile);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<ProjectFileResponse>(projectFile);
        }

        public async Task<ProjectFileResponse> GetProjectFileByIdAsync(Guid id)
        {
            var projectFile = await _unitOfWork.ProjectFileRepository.GetByIdAsync(id);
            if (projectFile == null) throw new KeyNotFoundException("Project file not found");

            return _mapper.Map<ProjectFileResponse>(projectFile);
        }

        public async Task<IEnumerable<ProjectFileResponse>> GetAllProjectFilesAsync()
        {
            var projectFiles = _unitOfWork.ProjectFileRepository.GetAll();
            return _mapper.Map<List<ProjectFileResponse>>(projectFiles);
        }

        public async Task<ProjectFileResponse> UpdateProjectFileAsync(Guid id, UpdateProjectFileRequest request)
        {
            var projectFile = await _unitOfWork.ProjectFileRepository.GetByIdAsync(id);
            if (projectFile == null) throw new KeyNotFoundException("Project file not found");

            _mapper.Map(request, projectFile);
            projectFile.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.ProjectFileRepository.Update(projectFile);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<ProjectFileResponse>(projectFile);
        }

        public async Task<IEnumerable<ProjectFileResponse>> GetProjectFilesCloseToExpiryAsync(int daysBeforeExpiry = 7)
        {
            var now = CoreHelper.SystemTimeNow;
            var thresholdDate = now.AddDays(daysBeforeExpiry);

            var projectFiles = _unitOfWork.ProjectFileRepository.Get(
                filter: pf => pf.ExpiryDate <= thresholdDate && pf.ExpiryDate > now,
                orderBy: q => q.OrderBy(pf => pf.ExpiryDate) // Sắp xếp theo ngày hết hạn (gần nhất ở đầu)
            );

            var results = projectFiles.Select(pf => new ProjectFileResponse
            {
                ProjectFileID = pf.ProjectFileID,
                ProjectFileUrl = pf.ProjectFileUrl,
                Description = pf.Description,
                CreateDate = pf.CreateDate,
                UpdateDate = pf.UpdateDate,
                ExpiryDate = pf.ExpiryDate,
                ProjectApartmentID = pf.ProjectApartmentID
            });

            return await Task.FromResult(results);
        }

        public async Task<bool> DeleteProjectFileAsync(Guid id)
        {
            var projectFile = await _unitOfWork.ProjectFileRepository.GetByIdAsync(id);
            if (projectFile == null) throw new KeyNotFoundException("Project file not found");

            _unitOfWork.ProjectFileRepository.Delete(projectFile);
            await _unitOfWork.SaveAsync();

            return true;
        }

        public async Task<(IEnumerable<ProjectFileResponse> ProjectFiles, int TotalItem, int TotalPage)> SearchProjectsFiles(
            Guid? projectId,
            ProjectFileType? fileType,
            string? keyword,
            int pageIndex = 1,
            int pageSize = 5)
        {
            // Tạo bộ lọc
            Expression<Func<ProjectFile, bool>> filter = pf =>
                (!projectId.HasValue || pf.ProjectApartmentID == projectId) &&
                (!fileType.HasValue || pf.ProjectFileTypes == fileType) &&
                (string.IsNullOrEmpty(keyword) || pf.Description.Contains(keyword) || pf.ProjectFileUrl.Contains(keyword));

            // Tổng số lượng bản ghi phù hợp
            int totalItem = await _unitOfWork.ProjectFileRepository.CountAsync(filter);

            // Truy vấn dữ liệu theo bộ lọc, sắp xếp và phân trang
            var projectFiles = _unitOfWork.ProjectFileRepository.Get(
                filter: filter,
                includeProperties: "ProjectApartment",
                orderBy: q => q.OrderByDescending(pf => pf.CreateDate),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Ánh xạ sang DTO
            var response = projectFiles.Select(pf => _mapper.Map<ProjectFileResponse>(pf));

            // Tính tổng số trang
            int totalPages = (int)Math.Ceiling((double)totalItem / pageSize);

            return (response, totalItem, totalPages);
        }

    }
}
