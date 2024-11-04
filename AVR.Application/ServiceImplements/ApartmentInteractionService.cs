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

        public async Task<ApartmentInteractionResponse> CreateOrUpdateInteractionAsync(CreateApartmentInteractionRequest request)
        {
            // Kiểm tra Account
            var account = await _unitOfWork.AccountRepository.GetByIdAsync(request.AccountID);
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Account not found.");
            }

            // Kiểm tra Apartment
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Apartment not found.");
            }

            // Lấy tương tác hiện tại dựa trên loại tương tác và các thông tin khác
            var existingInteraction = _unitOfWork.ApartmentInteractionRepository.Get(
                i => i.AccountID == request.AccountID && i.ApartmentID == request.ApartmentID && i.InteractionTypes == request.InteractionTypes
            ).FirstOrDefault();

            if (existingInteraction != null)
            {
                // Nếu tương tác đã tồn tại
                if (request.InteractionTypes == InteractionType.History)
                {
                    // Nếu là History, cập nhật thời gian tương tác
                    existingInteraction.InteractionDate = CoreHelper.SystemTimeNow;
                    _unitOfWork.ApartmentInteractionRepository.Update(existingInteraction);
                }
                else if (request.InteractionTypes == InteractionType.Liked)
                {
                    // Nếu là Liked, chuyển đổi trạng thái yêu thích hoặc không yêu thích
                    existingInteraction.InteractionTypes = InteractionType.Liked;
                    existingInteraction.InteractionDate = CoreHelper.SystemTimeNow;
                    _unitOfWork.ApartmentInteractionRepository.Update(existingInteraction);
                }
            }
            else
            {
                // Nếu không có tương tác nào, tạo mới
                var interaction = _mapper.Map<ApartmentInteraction>(request);
                interaction.InteractionDate = CoreHelper.SystemTimeNow;
                _unitOfWork.ApartmentInteractionRepository.Insert(interaction);
            }

            await _unitOfWork.SaveAsync();

            // Trả về kết quả
            var response = _mapper.Map<ApartmentInteractionResponse>(existingInteraction ?? _unitOfWork.ApartmentInteractionRepository.Get(i => i.AccountID == request.AccountID && i.ApartmentID == request.ApartmentID && i.InteractionTypes == request.InteractionTypes).FirstOrDefault());
            return response;
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


        public async Task DeleteInteractionAsync(Guid apartmentId, Guid accountId)
        {
            // Tìm kiếm tương tác dựa trên ApartmentId và AccountId
            var interaction = _unitOfWork.ApartmentInteractionRepository
                                               .Get(i => i.ApartmentID == apartmentId && i.AccountID == accountId);

            if (interaction == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy tương tác để xóa.");
            }

            // Xóa tương tác
            _unitOfWork.ApartmentInteractionRepository.Delete(interaction);
            await _unitOfWork.SaveAsync();
        }
    }
}
