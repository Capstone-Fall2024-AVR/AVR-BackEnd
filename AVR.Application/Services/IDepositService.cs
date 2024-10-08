using AVR.Application.ViewModels.Request.Deposits;
using AVR.Application.ViewModels.Response.Deposits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IDepositService
    {
        Task<DepositResponse> RequestDepositAsync(CreateDepositRequest request);
        Task<DepositResponse> AcceptDepositAsync(Guid depositId);
        Task<DepositResponse> RejectDepositAsync(Guid depositId);
        Task DisableDepositAsync(Guid depositId);
    }
}
