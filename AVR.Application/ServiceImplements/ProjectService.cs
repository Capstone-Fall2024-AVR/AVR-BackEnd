using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Projects;
using AVR.Application.ViewModels.Response.Projects;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class ProjectService : IProjectService

    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ProjectService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<ProjectApartmentResponse> CreateProjectApartmentAsync(CreateProjectApartmentRequest request)
        {
            // Kiểm tra xem nhà cung cấp dự án có tồn tại không
            var provider = await _unitOfWork.ApartmentProjectProviderRepository.GetByIdAsync(request.ApartmentProjectProviderID);
            if (provider == null)
            {
                throw new CustomException.InvalidDataException("Nhà cung cấp dự án không tồn tại.");
            }

            // Ánh xạ request sang thực thể ProjectApartment
            var projectApartment = _mapper.Map<ProjectApartment>(request);
            projectApartment.CreateDate = DateTimeOffset.Now;
            projectApartment.UpdateDate = DateTimeOffset.Now;

            // Liên kết dự án với nhà cung cấp dự án
            projectApartment.ApartmentProjectProviderID = request.ApartmentProjectProviderID;

            // Lưu dự án căn hộ vào cơ sở dữ liệu
            _unitOfWork.ProjectApartmentRepository.Insert(projectApartment);
            await _unitOfWork.SaveAsync();

            // Ánh xạ từ ProjectApartment sang ProjectApartmentResponse
            var response = _mapper.Map<ProjectApartmentResponse>(projectApartment);
            response.ApartmentProjectProviderName = provider.ApartmentProjectProviderName;

            return response;
        }

        public async Task<IEnumerable<ProjectApartmentResponse>> GetAllProject()
        {
            var projects = await _unitOfWork.ProjectApartmentRepository.GetAllAsync();
            if (projects == null)
            {
                throw new CustomException.DataNotFoundException("List project empty !");
            }
            var response = _mapper.Map<IEnumerable<ProjectApartmentResponse>>(projects);
            
            return response;
        }
        public async Task<ProjectApartmentResponse> GetProjectById(Guid id)
        {
            var project = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(id);
            if (project == null)
            {
                throw new CustomException.DataNotFoundException("Not found this project !");
            }
            return _mapper.Map<ProjectApartmentResponse>(project);
        }
    }
}
