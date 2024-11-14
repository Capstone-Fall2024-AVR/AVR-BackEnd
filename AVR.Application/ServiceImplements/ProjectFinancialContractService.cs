using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ProjectFinancialContract.CreateProjectFinancialContractRequest;
using AVR.Application.ViewModels.Request.ProjectFinancialContract.UpdateProjectFinancialContractRequest;
using AVR.Application.ViewModels.Response.ProjectFinancialContract;
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
    public class ProjectFinancialContractService : IProjectFinancialContractService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProjectFinancialContractService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProjectFinancialContractResponse> CreateAsync(CreateProjectFinancialContractRequest request)
        {
            var financialContract = _mapper.Map<ProjectFinancialContract>(request);
            _unitOfWork.ProjectFinancialContractRepository.Insert(financialContract);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<ProjectFinancialContractResponse>(financialContract);
        }

        public async Task<ProjectFinancialContractResponse> GetByIdAsync(Guid id)
        {
            var financialContract = await _unitOfWork.ProjectFinancialContractRepository.GetByIdAsync(id);
            if (financialContract == null)
            {
                throw new CustomException.DataNotFoundException("Financial contract not found.");
            }
            return _mapper.Map<ProjectFinancialContractResponse>(financialContract);
        }

        public async Task<IEnumerable<ProjectFinancialContractResponse>> GetAllAsync()
        {
            var contracts = await _unitOfWork.ProjectFinancialContractRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProjectFinancialContractResponse>>(contracts);
        }

        public async Task<ProjectFinancialContractResponse> UpdateAsync(Guid id, UpdateProjectFinancialContractRequest request)
        {
            var financialContract = await _unitOfWork.ProjectFinancialContractRepository.GetByIdAsync(id);
            if (financialContract == null)
            {
                throw new CustomException.DataNotFoundException("Financial contract not found.");
            }

            _mapper.Map(request, financialContract);
            _unitOfWork.ProjectFinancialContractRepository.Update(financialContract);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<ProjectFinancialContractResponse>(financialContract);
        }

        public async Task DeleteAsync(Guid id)
        {
            var financialContract = await _unitOfWork.ProjectFinancialContractRepository.GetByIdAsync(id);
            if (financialContract == null)
            {
                throw new CustomException.DataNotFoundException("Financial contract not found.");
            }

            _unitOfWork.ProjectFinancialContractRepository.Delete(financialContract);
            await _unitOfWork.SaveAsync();
        }
    }
}
