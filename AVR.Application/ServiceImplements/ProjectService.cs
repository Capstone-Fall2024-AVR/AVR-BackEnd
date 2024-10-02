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

        public async Task<CreateProjectResponse> CreateProject(CreateProjectRequest request)
        {
            var projectProvider = await _unitOfWork.ApartmentProjectProviderRepository.GetByIdAsync(request.ApartmentProjectProviderID);
            if (projectProvider == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy Project Provider.");
            }
            var apartment = _mapper.Map<ProjectApartment>(request);
            apartment.CreateDate = DateTimeOffset.Now;
            apartment.UpdateDate = DateTimeOffset.Now;
            apartment.ProjectApartmentStatus = Domain.Enums.ProjectApartmentStatus.Available;

            await _unitOfWork.ProjectApartmentRepository.InsertAsync(apartment);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreateProjectResponse>(apartment);
            return response;

        }

        public async Task<IEnumerable<CreateProjectResponse>> GetAllProject()
        {
            var projects = await _unitOfWork.ProjectApartmentRepository.GetAllAsync();
            if (projects == null)
            {
                throw new CustomException.DataNotFoundException("List project empty !");
            }
            var response = _mapper.Map<IEnumerable<CreateProjectResponse>>(projects);
            return response;
        }
        public async Task<CreateProjectResponse> GetProjectById(Guid id)
        {
            var project = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(id);
            if (project == null)
            {
                throw new CustomException.DataNotFoundException("Not found this project !");
            }
            return _mapper.Map<CreateProjectResponse>(project);
        }
    }
}
