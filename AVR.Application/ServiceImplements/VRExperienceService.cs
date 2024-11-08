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

        public VRExperienceService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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

            var account = await _unitOfWork.TeamMemberRepository.GetByIdAsync(request.assignedTeamMemberID);
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy nhân viên này.");
            }

            var experience = _mapper.Map<VRExperience>(request);
            experience.CreateDate = CoreHelper.SystemTimeNow;
            experience.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.VRExperienceRepository.Insert(experience);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<VRExperienceResponse>(experience);
        }

        // Search VR experiences with filters
        public async Task<IEnumerable<VRExperienceResponse>> SearchVRExperiencesAsync(
            Guid? apartmentId = null,
            Guid? assignedTeamMemberID = null,
            DateTimeOffset? startDate = null,
            DateTimeOffset? endDate = null,
            int pageIndex = 1,
            int pageSize = 10)
        {
            Expression<Func<VRExperience, bool>> filter = v =>
                (!apartmentId.HasValue || v.ApartmentID == apartmentId) &&
                (!assignedTeamMemberID.HasValue || v.AssignedTeamMemberID == assignedTeamMemberID) &&
                (!startDate.HasValue || v.CreateDate >= startDate) &&
                (!endDate.HasValue || v.CreateDate <= endDate);

            var experiences = _unitOfWork.VRExperienceRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(v => v.CreateDate),
                pageIndex: pageIndex,
                pageSize: pageSize);

            if (!experiences.Any())
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy VR experience nào phù hợp với tiêu chí tìm kiếm.");
            }
            return _mapper.Map<IEnumerable<VRExperienceResponse>>(experiences);
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
    }
}
