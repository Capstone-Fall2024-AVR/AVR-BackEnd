using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.VRExperiences;
using AVR.Application.ViewModels.Response.VRExperiences;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
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
    public class VRExperienceService : IVRExperienceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAzureBlobService _azureBlobService;
        private readonly IFileService _fileService;

        public VRExperienceService(IUnitOfWork unitOfWork, IMapper mapper, IAzureBlobService azureBlobService, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _azureBlobService = azureBlobService;
            _fileService = fileService;
        }

        // Get all VR experiences
        public async Task<IEnumerable<VRExperienceResponse>> GetAllVRExperiencesAsync()
        {
            var experiences = await _unitOfWork.VRExperienceRepository.GetAllAsync();
            if (experiences == null || !experiences.Any())
            {
                throw new CustomException.DataNotFoundException("Không có VR experiences nào.");
            }
            return _mapper.Map<IEnumerable<VRExperienceResponse>>(experiences);
        }

        // Get VR experience by ID
        public async Task<VRExperienceResponse> GetVRExperienceByIdAsync(Guid id)
        {
            var experience = await _unitOfWork.VRExperienceRepository.GetByIdAsync(id);
            if (experience == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy VR experience này.");
            }
            return _mapper.Map<VRExperienceResponse>(experience);
        }

        // Create a new VR experience
        public async Task<VRExperienceResponse> CreateVRExperienceAsync(CreateVRExperienceRequest request)
        {
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ này.");
            }

            /*var account = await _unitOfWork.TeamMemberRepository.GetByIdAsync(request.assignedTeamMemberID);
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy nhân viên này.");
            }*/

            /*// Upload file video lên Azure Blob Storage
            string videoUrl;
            using (var stream = request.VideoUrlFile.OpenReadStream())
            {
                var fileName = $"{Guid.NewGuid()}-{request.ApartmentID}{Path.GetExtension(request.VideoUrlFile.FileName)}";
                videoUrl = await _azureBlobService.UploadFileAsync(stream, fileName, request.VideoUrlFile.ContentType);
            }*/

            // Giải nén file .rar và upload file .html
            string htmlUrl;
            using (var rarStream = request.VideoUrlFile.OpenReadStream())
            {
                htmlUrl = await _fileService.ExtractAndUploadAsync(rarStream, "vr360-files");
            }

            var experience = _mapper.Map<VRExperience>(request);
            experience.video_url_file = htmlUrl; // Lưu URL video từ Azure Blob Storage
            experience.CreateDate = CoreHelper.SystemTimeNow;
            experience.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.VRExperienceRepository.Insert(experience);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<VRExperienceResponse>(experience);
        }

        // Search VR experiences with filters
        public async Task<(IEnumerable<VRExperienceResponse> Experiences, int TotalItem, int TotalPage)> SearchVRExperiencesAsync(
            Guid? apartmentId = null,
            Guid? assignedTeamMemberID = null,
            DateTimeOffset? startDate = null,
            DateTimeOffset? endDate = null,
            int pageIndex = 1,
            int pageSize = 10)
        {
            // Create a filter expression based on provided parameters
            Expression<Func<VRExperience, bool>> filter = v =>
                (!apartmentId.HasValue || v.ApartmentID == apartmentId) &&
                (!assignedTeamMemberID.HasValue || v.AssignedTeamMemberID == assignedTeamMemberID) &&
                (!startDate.HasValue || v.CreateDate >= startDate) &&
                (!endDate.HasValue || v.CreateDate <= endDate);

            // Calculate total items based on the filter
            var totalItem = await _unitOfWork.VRExperienceRepository.CountAsync(filter);

            // Get the paginated results
            var experiences = _unitOfWork.VRExperienceRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(v => v.CreateDate),
                pageIndex: pageIndex,
                pageSize: pageSize);

            // Map the filtered and paginated results to response objects
            var experiencesResponse = _mapper.Map<IEnumerable<VRExperienceResponse>>(experiences);
            int totalPages = (int)Math.Ceiling((double)totalItem / pageSize);

            return (experiencesResponse, totalItem, totalPages);
        }


        // Update an existing VR experience
        public async Task<VRExperienceResponse> UpdateVRExperienceAsync(Guid id, UpdateVRExperienceRequest request)
        {
            var experience = await _unitOfWork.VRExperienceRepository.GetByIdAsync(id);
            if (experience == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy VR experience này.");
            }

            // Update fields
            experience.video_url_file = request.VideoUrlFile ?? experience.video_url_file;
            experience.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.VRExperienceRepository.Update(experience);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<VRExperienceResponse>(experience);
        }

        public async Task<bool> DeleteVRExperienceAsync(Guid id)
        {
            var experience = await _unitOfWork.VRExperienceRepository.GetByIdAsync(id);
            if (experience == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy VR experience này.");
            }

            // Optionally delete related logs or files if needed
            _unitOfWork.VRExperienceRepository.Delete(experience);
            await _unitOfWork.SaveAsync();

            return true; // Return true if deletion is successful
        }


    }
}
