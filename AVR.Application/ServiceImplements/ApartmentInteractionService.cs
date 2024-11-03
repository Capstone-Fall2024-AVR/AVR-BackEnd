using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ApartmentInteractions;
using AVR.Application.ViewModels.Response.ApartmentInteractions;
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
    public class ApartmentInteractionService : IApartmentInteractionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ApartmentInteractionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ApartmentInteractionResponse>> GetAllAsync()
        {
            var interactions = await _unitOfWork.ApartmentInteractionRepository.GetAllAsync();
            if (!interactions.Any())
            {
                throw new CustomException.DataNotFoundException("No interactions found.");
            }

            return _mapper.Map<IEnumerable<ApartmentInteractionResponse>>(interactions);
        }

        public async Task<ApartmentInteractionResponse> GetByIdAsync(Guid interactionId)
        {
            var interaction = await _unitOfWork.ApartmentInteractionRepository.GetByIdAsync(interactionId);
            if (interaction == null)
            {
                throw new CustomException.DataNotFoundException("Interaction not found.");
            }

            return _mapper.Map<ApartmentInteractionResponse>(interaction);
        }

        public async Task<ApartmentInteractionResponse> CreateAsync(CreateApartmentInteractionRequest request)
        {
            var account = await _unitOfWork.AccountRepository.GetByIdAsync(request.AccountID);
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Account not found.");
            }

            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Apartment not found.");
            }

            var interaction = _mapper.Map<ApartmentInteraction>(request);
            interaction.InteractionDate = CoreHelper.SystemTimeNow;

            _unitOfWork.ApartmentInteractionRepository.Insert(interaction);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<ApartmentInteractionResponse>(interaction);
        }

        public async Task<IEnumerable<ApartmentInteractionResponse>> SearchAsync(
            Guid? accountId,
            InteractionType? interactionType,
            Guid? apartmentId,
            DateTimeOffset? date,
            int pageIndex = 1,
            int pageSize = 10)
        {
            Expression<Func<ApartmentInteraction, bool>> filter = i =>
                (!accountId.HasValue || i.AccountID == accountId) &&
                (!interactionType.HasValue || i.InteractionTypes == interactionType) &&
                (!apartmentId.HasValue || i.ApartmentID == apartmentId) &&
                (!date.HasValue || i.InteractionDate.Date == date.Value.Date);

            var interactions = _unitOfWork.ApartmentInteractionRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(i => i.InteractionDate),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            return _mapper.Map<IEnumerable<ApartmentInteractionResponse>>(interactions);
        }
    }
}
