using AutoMapper;
using AVR.Application.Services;
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
    public class ApartmentService : IApartmentService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ApartmentService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        public async Task<Apartment> GetApartmentById(Guid id)
        {
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(id);
            if(apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy apartment này.");
            }
            return apartment;
        }

        public async Task<IEnumerable<Apartment>> GetApartments()
        {
            var apartments = await _unitOfWork.ApartmentRepository.GetAllAsync();
            if(apartments == null)
            {
                throw new CustomException.DataNotFoundException("List apartment này trống.");
            }
            return apartments;
        }
    }
}
