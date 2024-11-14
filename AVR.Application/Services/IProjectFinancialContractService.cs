using AVR.Application.ViewModels.Request.ProjectFinancialContract.CreateProjectFinancialContractRequest;
using AVR.Application.ViewModels.Request.ProjectFinancialContract.UpdateProjectFinancialContractRequest;
using AVR.Application.ViewModels.Response.ProjectFinancialContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IProjectFinancialContractService
    {
        Task<ProjectFinancialContractResponse> CreateAsync(CreateProjectFinancialContractRequest request);
        Task<ProjectFinancialContractResponse> GetByIdAsync(Guid id);
        Task<IEnumerable<ProjectFinancialContractResponse>> GetAllAsync();
        Task<ProjectFinancialContractResponse> UpdateAsync(Guid id, UpdateProjectFinancialContractRequest request);
        Task DeleteAsync(Guid id);
    }
}
