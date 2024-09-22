using AVR.Application.Services;
using CoreApiResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/accounts")]
    [ApiController]
    public class AccountController : BaseController
    {
        public readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;

        }


        [HttpGet("{accountId}")]
        
        public async Task<IActionResult> GetUserInfo(Guid accountId)
        {
            var account = await _accountService.GetAccountInfoAsync(accountId);
            return CustomResult("Tải dữ liệu thành công.", account);
        }

        [HttpGet("get-all")]
        
        public async Task<IActionResult> GetAllAccounts()
        {
            var accounts = await _accountService.GetAllAccountsAsync();
            return CustomResult("Tải dữ liệu thành công.", accounts);
        }



    }
}
