using AVR.Application.ViewModels.Request.PropertyVerifications;
using AVR.Application.ViewModels.Response.PropertyVerifications;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IPropertyVerificationService
    {
       
        Task<PropertyVerificationResponse> CreateAsync(PropertyVerificationRequest request);

  
        Task<IEnumerable<PropertyVerificationResponse>> GetAllAsync();

        Task<PropertyVerificationResponse> GetByIdAsync(Guid verificationId);

    
        Task<PropertyVerificationResponse> UpdateAsync(Guid verificationId, UpdatePropertyVerificationRequest request);


        Task<bool> DeleteAsync(Guid verificationId);

        Task<PropertyVerificationResponse> AcceptAsync(Guid verificationId);


        Task<PropertyVerificationResponse> RejectAsync(Guid verificationId, string? comment);


        Task<(IEnumerable<PropertyVerificationResponse> Results, int TotalItems, int TotalPages)> SearchAsync(
            string? keyword = null,
            VerificationStatus? status = null,
            DateTimeOffset? startDate = null,
            DateTimeOffset? endDate = null,
            int pageIndex = 1,
            int pageSize = 10);

        Task<PropertyVerificationResponse> RenewContractAsync(RenewContractRequest request);

        Task<(IEnumerable<ContractSummaryResponse> Results, int TotalItems, int TotalPages)> SearchContractsAsync(
                string? ownerName = null,
                string? contractCode = null,
                VerificationStatus? status = null,
                DateTimeOffset? startDate = null,
                DateTimeOffset? endDate = null,
                int pageIndex = 1,
                int pageSize = 10);

        Task<IEnumerable<PropertyVerificationResponse>> GetNearExpiryVerificationsAsync(int days);
    }
}
