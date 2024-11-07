using AVR.Application.ViewModels.Response.DepositResponse;
using AVR.Application.ViewModels.Response.Deposits;
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
        Task<CreateDepositResponse> RequestDepositAsync(CreateDepositRequest request);
        Task<DepositResponse> AcceptDepositAsync(Guid depositId);
        Task<DepositResponse> RejectDepositAsync(Guid depositId);
        Task DisableDepositAsync(Guid depositId);

        //Ham Get
        Task<DepositResponse> GetDepositByIdAsync(Guid depositId);
        Task<IEnumerable<DepositResponse>> GetAllDepositsAsync(DepositStatus? depositStatus = null);
        Task<IEnumerable<DepositResponse>> GetDepositsByApartmentIdAsync(Guid apartmentId, DepositStatus? depositStatus = null);
        Task<IEnumerable<DepositResponse>> GetDepositsByAccountIdAsync(Guid accountId, DepositStatus? depositStatus = null);

        //trade
        Task<CreateDepositResponse> RequestTradeDepositAsync(Guid currentDepositId, string newApartmentCode);
        Task<DepositResponse> AcceptTradeDepositAsync(Guid tradeDepositId);
        Task<DepositResponse> RejectTradeDepositAsync(Guid tradeDepositId);

    }
}
