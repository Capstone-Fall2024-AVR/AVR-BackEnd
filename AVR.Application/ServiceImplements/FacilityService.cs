using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.FacilitiesReq;
using AVR.Application.ViewModels.Response.FacilitiesRes;
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
    public class FacilityService : IFacilityService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FacilityService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // Get All Facilities
        public async Task<IEnumerable<FacilityResponse>> GetAllFacilitiesAsync()
        {
            var facilities = await _unitOfWork.FacilitiesRepository.GetAllAsync();
            if (facilities == null)
            {
                throw new CustomException.DataNotFoundException("Danh sách tiện ích trống.");
            }
            return _mapper.Map<IEnumerable<FacilityResponse>>(facilities);
        }

        // Get Facility by ID
        public async Task<FacilityResponse> GetFacilityByIdAsync(Guid id)
        {
            var facility = await _unitOfWork.FacilitiesRepository.GetByIdAsync(id);
            if (facility == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy tiện ích này.");
            }
            return _mapper.Map<FacilityResponse>(facility);
        }

        // Create a new Facility
        public async Task<FacilityResponse> CreateFacilityAsync(FacilityRequest request)
        {
            var facility = _mapper.Map<Facilities>(request);
            facility.FacilitiesID = Guid.NewGuid();

            await _unitOfWork.FacilitiesRepository.InsertAsync(facility);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<FacilityResponse>(facility);
        }
    }
}
