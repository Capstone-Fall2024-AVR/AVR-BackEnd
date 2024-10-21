using AVR.Application.ViewModels.Request.Accounts;
using AVR.Application.ViewModels.Request.Auth;
using AVR.Application.ViewModels.Response.Accounts;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IAccountService
    {
        //Get all
        Task<AccountResponse> GetAccountInfoAsync(Guid userId);
        Task<IEnumerable<AccountResponse>> GetAllAccountsAsync();

        Task<bool> CreateAccountAsync(CreateAccountRequest request);
        Task<bool> BlockUserAsync(Guid accountId);
        Task<bool> UpdateAccountAsync(Guid accountId, UpdateAccountRequest request);

        Task<IEnumerable<AccountResponse>> SearchAccountsAsync(string? name, string? email, string? phoneNumber, AccountStatus? status, string? role);
    }
}
