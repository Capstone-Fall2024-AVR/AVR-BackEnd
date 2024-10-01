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

        public async Task<CreateApartmentResponse> CreateApartment(CreateApartmentRequest request)
        {
            var apartment = _mapper.Map<Apartment>(request);
            apartment.CreatedDate = DateTimeOffset.Now;
            apartment.UpdatedDate = DateTimeOffset.Now;
            apartment.ApartmentType = ApartmentType.Luxury;
            apartment.ApartmentStatus = ApartmentStatus.Available;

            await _unitOfWork.ApartmentRepository.InsertAsync(apartment);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreateApartmentResponse>(apartment);
            return response;

        }

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
    }
}
