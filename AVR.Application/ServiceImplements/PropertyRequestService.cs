using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.PropertyRequests;
using AVR.Application.ViewModels.Response.PropertyRequests;
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
    public class PropertyRequestService : IPropertyRequestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PropertyRequestService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreatePropertyRequestResponse> CreatePropertyRequest(CreatePropertyRequestRequest request)
        {
            var account = await _unitOfWork.AccountRepository.GetByIdAsync(request.AccountID);
            if(account == null)
            {
                throw new CustomException.DataNotFoundException("Account không tồn tại trong hệ thống");
            }

            var proPertyrequest = _mapper.Map<PropertyRequest>(request);
            proPertyrequest.RequestDate = DateTimeOffset.Now;
            proPertyrequest.RequestStatus = Domain.Enums.RequestStatus.Pending;

            _unitOfWork.PropertyRequestRepository.Insert(proPertyrequest);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreatePropertyRequestResponse>(proPertyrequest);
            return response;
        }

        public async Task<CreatePropertyRequestResponse> GetPropertyRequestById(Guid requestId)
        {
            var propertyRequest = await _unitOfWork.PropertyRequestRepository.GetByIdAsync(requestId);
            if(propertyRequest == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy yêu cầu kí gửi này !");
            }
            var response = _mapper.Map<CreatePropertyRequestResponse>(propertyRequest);

            return response;
        }

        public async Task<IEnumerable<CreatePropertyRequestResponse>> GetPropertyRequests()
        {
            var propertyRequest = await _unitOfWork.PropertyRequestRepository.GetAllAsync();
            if (propertyRequest == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy yêu cầu kí gửi nào !.");
            }
            var response = _mapper.Map<IEnumerable<CreatePropertyRequestResponse>>(propertyRequest);

            return response;
        }
    }
}
