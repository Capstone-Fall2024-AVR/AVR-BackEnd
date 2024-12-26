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
            // Kiểm tra LowestPrice phải lớn hơn 100,000,000
            if (request.LowestPrice <= 100000000)
            {
                throw new CustomException.InvalidDataException("LowestPrice phải lớn hơn 100,000,000.");
            }

            // Kiểm tra HighestPrice phải lớn hơn LowestPrice
            if (request.HighestPrice <= request.LowestPrice)
            {
                throw new CustomException.InvalidDataException("HighestPrice phải lớn hơn LowestPrice.");
            }

            // Lấy danh sách các contract liên quan đến cùng ProjectApartmentID
            var existingContracts = _unitOfWork.ProjectFinancialContractRepository
                .Get(p => p.ProjectApartmentID == request.ProjectApartmentID)
                .ToList();

            // Kiểm tra giá trị LowestPrice và HighestPrice không trùng lặp với các contract hiện tại
            foreach (var contract in existingContracts)
            {
                if ((request.LowestPrice < contract.HighestPrice && request.HighestPrice > contract.LowestPrice))
                {
                    throw new CustomException.InvalidDataException("Khoảng giá trị LowestPrice và HighestPrice không được chồng lấn với các contract hiện có.");
                }
            }

            // Tạo mới financial contract
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
            // Lấy financial contract hiện tại từ database
            var financialContract = await _unitOfWork.ProjectFinancialContractRepository.GetByIdAsync(id);
            if (financialContract == null)
            {
                throw new CustomException.DataNotFoundException("Financial contract không tồn tại.");
            }

            // Kiểm tra LowestPrice phải lớn hơn 100,000,000
            if (request.LowestPrice <= 100000000)
            {
                throw new CustomException.InvalidDataException("LowestPrice phải lớn hơn 100,000,000.");
            }

            // Kiểm tra HighestPrice phải lớn hơn LowestPrice
            if (request.HighestPrice <= request.LowestPrice)
            {
                throw new CustomException.InvalidDataException("HighestPrice phải lớn hơn LowestPrice.");
            }

            // Lấy danh sách các contract liên quan đến cùng ProjectApartmentID, ngoại trừ contract hiện tại
            var existingContracts = _unitOfWork.ProjectFinancialContractRepository
                .Get(p => p.ProjectApartmentID == financialContract.ProjectApartmentID && p.FinancialContractID != id)
                .ToList();

            // Kiểm tra giá trị LowestPrice và HighestPrice không trùng lặp với các contract hiện tại
            foreach (var contract in existingContracts)
            {
                if ((request.LowestPrice < contract.HighestPrice && request.HighestPrice > contract.LowestPrice))
                {
                    throw new CustomException.InvalidDataException("Khoảng giá trị LowestPrice và HighestPrice không được chồng lấn với các contract hiện có.");
                }
            }

            // Map dữ liệu từ request sang entity hiện tại
            _mapper.Map(request, financialContract);

            // Cập nhật dữ liệu
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
