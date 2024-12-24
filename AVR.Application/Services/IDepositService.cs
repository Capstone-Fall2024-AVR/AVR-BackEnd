using AVR.Application.ViewModels.Request.DepositRequest;
using AVR.Application.ViewModels.Response.DepositResponse;
using AVR.Application.ViewModels.Response.Deposits;
using AVR.Application.ViewModels.Response.Projects;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IDepositService
    {
        //Task<CreateDepositResponse> RequestDepositAsync(CreateDepositRequest request);
        Task<CreateDepositResponse> RequestDepositV2Async(CreateDepositRequest request);
        Task<DepositResponse> AcceptDepositAsync(Guid depositId, Guid staffID);
        Task<DepositResponse> RejectDepositAsync(Guid depositId, Guid staffID, string? note);
        Task DisableDepositAsync(Guid depositId, string note);

        //Ham Get
        Task<(IEnumerable<DepositResponse> Deposits, int TotalItems, int TotalPages)> SearchDeposits(
            Guid? depositId,
            string? depositCode,
            string? apartmentCode,
            string? keyword,
            Guid? apartmentId,
            Guid? accountId,
            Guid? ownerId,
            Guid? teamId,
            Guid? projectApartmentId,
            DepositStatus? depositStatus,
            DepositType? depositType,
            DisbursementStatus? disbursementStatus,
            int pageIndex = 1,
            int pageSize = 5);
        Task<DepositResponse> GetDepositByIdAsync(Guid depositId);
        Task<IEnumerable<DepositResponse>> GetAllDepositsAsync(DepositStatus? depositStatus = null);
        Task<IEnumerable<DepositResponse>> GetDepositsByApartmentIdAsync(Guid apartmentId, DepositStatus? depositStatus = null);
        Task<IEnumerable<DepositResponse>> GetDepositsByAccountIdAsync(Guid accountId, DepositStatus? depositStatus = null);
        Task<DepositResponse> DisburseDepositAsync(Guid depositId, Guid ManagerId, DisbursementStatus? disbursementStatus = null);


        //refund
        Task<DepositResponse> RefundDepositAsync(Guid depositId, Guid staffId);

        //trade
        //Task<CreateDepositResponse> RequestTradeDepositAsync(Guid currentDepositId, string newApartmentCode);
        Task<CreateDepositResponse> RequestTradeDepositV2Async(Guid currentDepositId, string newApartmentCode);
        Task<DepositResponse> AcceptTradeDepositAsync(Guid tradeDepositId, Guid staffId);
        Task<DepositResponse> RejectTradeDepositAsync(Guid tradeDepositId, Guid staffId, string? note);

        //total
        Task<int> GetTotalDepositsAsync(DepositStatus? depositStatus = null);
        Task<string> ExportDetailedFinancialDataAsync(Guid projectId);

        //Disbursement
        //Task<ProjectDisbursementResponse> GetProjectDisbursementDetailsAsync(Guid projectId);

        //statistics
        Task<IEnumerable<RevenueSummaryResponse>> GetRevenueSummaryAsync(string period, int? year = null);
    }
}
