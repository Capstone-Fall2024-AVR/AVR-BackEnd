using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Accounts;
using AVR.Domain.Enums;
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

        [HttpGet("search")]
        public async Task<IActionResult> SearchAccounts([FromQuery] string? name, [FromQuery] string? email, [FromQuery] string? phoneNumber, [FromQuery] AccountStatus? status, [FromQuery] string? role, [FromQuery] int pageIndex = 1, [FromQuery] int pageSize = 5)
        {
            var accounts = await _accountService.SearchAccountsAsync(name, email, phoneNumber, status, role, pageIndex, pageSize);
            return CustomResult("Search results retrieved successfully.", accounts);
        }


        [HttpPost("create-account")]
        public async Task<IActionResult> CreateAccount(CreateAccountRequest request)
        {
            var account = await _accountService.CreateAccountAsync(request);
            return CustomResult("Tạo 1 account thành công", account);
        }

        [HttpPost("block-account/{accountId}")]
        public async Task<IActionResult> BlockAccount (Guid accountId)
        {
            var result = await _accountService.BlockUserAsync(accountId);
            return CustomResult("Khoá account thành công", result);
        }

        [HttpPut("update-account/{accountId}")]
        public async Task<IActionResult> UpdateAccount(Guid accountId, [FromBody] UpdateAccountRequest updateRequest)
        {
            var result = await _accountService.UpdateAccountAsync(accountId, updateRequest);
            return CustomResult("Cập nhật tài khoản thành công", result);
        }
        

    }
}
