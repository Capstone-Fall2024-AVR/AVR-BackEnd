using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Accounts;
using AVR.Application.ViewModels.Request.Auth;
using AVR.Application.ViewModels.Response.Accounts;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<AccountRole> _roleManager;

        public AccountService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<Account> userManager, RoleManager<AccountRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        //Block Account
        public async Task<bool> BlockUserAsync(Guid accountId)
        {
            var account = await _userManager.FindByEmailAsync(accountId.ToString());
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy tài khoản người dùng.");
            }
            if (account.LockoutEnd.HasValue && account.LockoutEnd.Value > CoreHelper.SystemTimeNow)
            {
                throw new CustomException.InvalidDataException("Tài khoản này đã bị khóa trước đó.");
            }

            account.LockoutEnd = DateTimeOffset.MaxValue;

            // 4. Cập nhật thông tin tài khoản
            var result = await _userManager.UpdateAsync(account);
            if (!result.Succeeded)
            {
                var errors = string.Join("; ", result.Errors.Select(e => e.Description));
                throw new CustomException.InvalidDataException($"Khóa tài khoản thất bại: {errors}");
            }

            return true;

        }


        //Create Account
        public async Task<bool> CreateAccountAsync(CreateAccountRequest request)
        {
            // 1. Kiểm tra mật khẩu có khớp với xác nhận mật khẩu không
            if (request.Password != request.ConfirmPassword)
            {
                throw new CustomException.InvalidDataException("Password và ConfirmPassword không trùng khớp.");
            }

            // 2. Kiểm tra email đã tồn tại trong hệ thống chưa
            var existingUser = await _userManager.FindByEmailAsync(request.Email);
            if (existingUser != null)
            {
                throw new CustomException.InvalidDataException("Email đã tồn tại trong hệ thống.");
            }

            var account = _mapper.Map<Account>(request);
            account.Email = request.Email;
            account.UserName = request.Email;
            account.Name = request.Name;
            account.Avatar = "";
            account.EmailConfirmed = true;
            account.AccountStatus = AccountStatus.Active;

            var result = await _userManager.CreateAsync(account, request.Password);

            if (!result.Succeeded)
            {
                // Nối các lỗi lại nếu có
                var errors = string.Join("; ", result.Errors.Select(e => e.Description));
                throw new CustomException.InvalidDataException($"Đăng ký thất bại: {errors}");
            }

            var roleResult = await _userManager.AddToRoleAsync(account, request.Role);
            if (!roleResult.Succeeded)
            {
                throw new CustomException.InvalidDataException("Gán vai trò thất bại.");
            }
            
            return true;


        }

      

        //GetAccountInfo
        public async Task<AccountResponse> GetAccountInfoAsync(Guid userId)
        {
            var account = await _unitOfWork.AccountRepository.GetByIdAsync(userId);
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Người dùng này không tồn tại.");
            }
            var roles = await _userManager.GetRolesAsync(account);
            var accountResponse = _mapper.Map<AccountResponse>(account);
            accountResponse.Roles = roles.ToList();
            return accountResponse;
        }

        //Get All
        public async Task<IEnumerable<AccountResponse>> GetAllAccountsAsync()
        {
            var accounts = await _unitOfWork.AccountRepository.GetAllAsync();
            if (accounts == null)
            {
                throw new CustomException.DataNotFoundException("List người dùng trống.");
            }

            var accountsResponse = new List<AccountResponse>();

            foreach (var account in accounts)
            {
                var accountResponse = _mapper.Map<AccountResponse>(account);

                // Get roles for each user
                var roles = await _userManager.GetRolesAsync(account);
                accountResponse.Roles = roles.ToList(); // Add roles to the response

                accountsResponse.Add(accountResponse);
            }

            return accountsResponse;
        }


        //Search account
        public async Task<(IEnumerable<AccountResponse> Accounts, int TotalItem)> SearchAccountsAsync(
            string? name,
            string? email,
            string? phoneNumber,
            AccountStatus? status,
            string? role,
            int pageIndex = 1,
            int pageSize = 5)
        {
            // Create a filter for the search query
            Expression<Func<Account, bool>> filter = account =>
                (string.IsNullOrEmpty(name) || account.Name.Contains(name)) &&
                (string.IsNullOrEmpty(email) || account.Email.Contains(email)) &&
                (string.IsNullOrEmpty(phoneNumber) || account.PhoneNumber.Contains(phoneNumber)) &&
                (!status.HasValue || account.AccountStatus == status);

            // Calculate the total number of accounts that match the filter
            var totalItem = await _unitOfWork.AccountRepository.CountAsync(filter);

            // Get accounts based on the filter with pagination
            var accounts = _unitOfWork.AccountRepository.Get(
                filter: filter,
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            var accountsResponse = new List<AccountResponse>();

            foreach (var account in accounts)
            {
                var accountResponse = _mapper.Map<AccountResponse>(account);

                // Fetch roles for each account
                var roles = await _userManager.GetRolesAsync(account);

                // Filter by role if specified
                if (!string.IsNullOrEmpty(role) && !roles.Contains(role))
                {
                    continue;
                }

                accountResponse.Roles = roles.ToList(); // Add roles to the response
                accountsResponse.Add(accountResponse);
            }

            return (accountsResponse, totalItem);
        }




        //Update Account
        public async Task<bool> UpdateAccountAsync(Guid accountId, UpdateAccountRequest updateRequest)
        {
            var account = await _userManager.FindByIdAsync(accountId.ToString());
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy tài khoản người dùng.");
            }

            var updateAccount = _mapper.Map<Account>(updateRequest);

            // 2. Cập nhật tên (nếu có)
            if (!string.IsNullOrEmpty(updateRequest.Name))
            {
                account.Name = updateRequest.Name;
            }

            // 3. Cập nhật số điện thoại (nếu có)
            if (!string.IsNullOrEmpty(updateRequest.PhoneNumber))
            {
                account.PhoneNumber = updateRequest.PhoneNumber;
            }

            // 4. Cập nhật avatar (nếu có)
            if (!string.IsNullOrEmpty(updateRequest.Avatar))
            {
                account.Avatar = updateRequest.Avatar;
            }

            // 5. Mở khóa tài khoản (nếu có yêu cầu mở khóa)
            if (updateRequest.UnlockAccount)
            {
                account.LockoutEnd = null;  // Mở khóa tài khoản
                account.AccessFailedCount = 0; // Đặt lại số lần thất bại đăng nhập
            }

            // 6. Lưu các thay đổi khác
            var updateResult = await _userManager.UpdateAsync(account);
            if (!updateResult.Succeeded)
            {
                var errors = string.Join("; ", updateResult.Errors.Select(e => e.Description));
                throw new CustomException.InvalidDataException($"Cập nhật tài khoản thất bại: {errors}");
            }

            return true;
        }
    }
}
