using AVR.Application.ViewModels.Response.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IAccountService
    {

        Task<AccountResponse> GetAccountInfoAsync(Guid userId);
        Task<IEnumerable<AccountResponse>> GetAllAccountsAsync();

    }
}
