using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.AccessLogs;
using AVR.Application.ViewModels.Response.AccessLogs;
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
    public class AccessLogService : IAccessLogService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AccessLogService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProjectAccessLogResponse> CreateProjectAccessLogAsync(CreateProjectAccessLogRequest request)
        {
            // Map từ request sang entity
            var log = _mapper.Map<ProjectAccessLog>(request);
            log.accessDate = CoreHelper.SystemTimeNow;

            // Thêm log vào cơ sở dữ liệu
            _unitOfWork.ProjectAccessLogRepository.Insert(log);
            await _unitOfWork.SaveAsync();

            // Lấy thông tin bổ sung cho phản hồi
            var projectApartment = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(request.ProjectApartmentID);
            if (projectApartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy dự án căn hộ.");
            }

            // Map sang response
            var response = _mapper.Map<ProjectAccessLogResponse>(log);
            response.ProjectApartmentName = projectApartment.ProjectApartmentName; // Gắn tên dự án

            return response;
        }

        public async Task<VRAccessLogResponse> CreateVRAccessLogAsync(CreateVRAccessLogRequest request)
        {
            // Map từ request sang entity
            var log = _mapper.Map<VR_Access_Log>(request);
            log.CreateDate = CoreHelper.SystemTimeNow;

            // Thêm log vào cơ sở dữ liệu
            _unitOfWork.VRAccessLogRepository.Insert(log);
            await _unitOfWork.SaveAsync();

            // Lấy thông tin bổ sung cho phản hồi
            var vrExperience = await _unitOfWork.VRExperienceRepository.GetByIdAsync(request.VRExperienceID);
            if (vrExperience == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy trải nghiệm VR.");
            }

            // Map sang response
            var response = _mapper.Map<VRAccessLogResponse>(log);
            //response.vr = vrExperience.Title; // Gắn tiêu đề VR Experience
            response.Video_url_file = vrExperience.video_url_file;

            return response;
        }


        public async Task<IEnumerable<ProjectAccessLogResponse>> GetProjectAccessLogsAsync(Guid projectId)
        {
            var logs = _unitOfWork.ProjectAccessLogRepository.Get(
                filter: log => log.ProjectApartmentID == projectId,
                includeProperties: "ProjectApartments" // Bao gồm thông tin dự án
            );

            return logs.Select(log => new ProjectAccessLogResponse
            {
                ProjectAccessLogID = log.ProjectAccessLogID,
                AccessDate = log.accessDate,
                ProjectApartmentID = log.ProjectApartmentID,
                ProjectApartmentName = log.ProjectApartments?.ProjectApartmentName ?? "Không xác định"
            });
        }


        public async Task<IEnumerable<VRAccessLogResponse>> GetVRAccessLogsAsync(Guid vrExperienceId)
        {
            var logs = _unitOfWork.VRAccessLogRepository.Get(
                filter: log => log.VRExperienceID == vrExperienceId,
                includeProperties: "VRExperiences" // Bao gồm thông tin trải nghiệm VR
            );

            return logs.Select(log => new VRAccessLogResponse
            {
                VRAccessLogID = log.VR_Access_LogID,
                CreateDate = log.CreateDate,
                VRExperienceID = log.VRExperienceID,
                Video_url_file = log.VRExperiences?.video_url_file ?? "Không xác định"
            });
        }


        public async Task DeleteProjectAccessLogAsync(Guid logId)
        {
            var log = await _unitOfWork.ProjectAccessLogRepository.GetByIdAsync(logId);
            if (log == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy log của dự án.");
            _unitOfWork.ProjectAccessLogRepository.Delete(log);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteVRAccessLogAsync(Guid logId)
        {
            var log = await _unitOfWork.VRAccessLogRepository.GetByIdAsync(logId);
            if (log == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy log VR.");
            _unitOfWork.VRAccessLogRepository.Delete(log);
            await _unitOfWork.SaveAsync();
        }

        public async Task<(IEnumerable<ProjectAccessLogResponse> Logs, int TotalItems, int TotalPages)> SearchProjectAccessLogsAsync(
            Guid? projectApartmentId,
            DateTimeOffset? fromDate,
            DateTimeOffset? toDate,
            int pageIndex = 1,
            int pageSize = 5)
        {
            // Tạo bộ lọc dựa trên điều kiện
            Expression<Func<ProjectAccessLog, bool>> filter = log =>
                (!projectApartmentId.HasValue || log.ProjectApartmentID == projectApartmentId) &&
                (!fromDate.HasValue || log.accessDate >= fromDate) &&
                (!toDate.HasValue || log.accessDate <= toDate);

            // Đếm tổng số bản ghi phù hợp
            var totalItems = await _unitOfWork.ProjectAccessLogRepository.CountAsync(filter);

            // Lấy dữ liệu có phân trang
            var logs = _unitOfWork.ProjectAccessLogRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(log => log.accessDate),
                includeProperties: "ProjectApartments", // Bao gồm thông tin dự án
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Map kết quả sang response DTO
            var logResponses = logs.Select(log => new ProjectAccessLogResponse
            {
                ProjectAccessLogID = log.ProjectAccessLogID,
                AccessDate = log.accessDate,
                ProjectApartmentID = log.ProjectApartmentID,
                ProjectApartmentName = log.ProjectApartments?.ProjectApartmentName ?? "Không xác định"
            }).ToList();

            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            return (logResponses, totalItems, totalPages);
        }


        public async Task<(IEnumerable<VRAccessLogResponse> Logs, int TotalItems, int TotalPages)> SearchVRAccessLogsAsync(
            Guid? vrExperienceId,
            DateTimeOffset? fromDate,
            DateTimeOffset? toDate,
            int pageIndex = 1,
            int pageSize = 5)
        {
            // Tạo bộ lọc dựa trên điều kiện
            Expression<Func<VR_Access_Log, bool>> filter = log =>
                (!vrExperienceId.HasValue || log.VRExperienceID == vrExperienceId) &&
                (!fromDate.HasValue || log.CreateDate >= fromDate) &&
                (!toDate.HasValue || log.CreateDate <= toDate);

            // Đếm tổng số bản ghi phù hợp
            var totalItems = await _unitOfWork.VRAccessLogRepository.CountAsync(filter);

            // Lấy dữ liệu có phân trang
            var logs = _unitOfWork.VRAccessLogRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(log => log.CreateDate),
                includeProperties: "VRExperiences", // Bao gồm thông tin VRExperience
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Map kết quả sang response DTO
            var logResponses = logs.Select(log => new VRAccessLogResponse
            {
                VRAccessLogID = log.VR_Access_LogID,
                CreateDate = log.CreateDate,
                VRExperienceID = log.VRExperienceID,
                Video_url_file = log.VRExperiences?.video_url_file ?? "Không xác định"
            }).ToList();

            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            return (logResponses, totalItems, totalPages);
        }


    }
}
