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
        private readonly IFirebaseConfig _firebaseConfig;


        public AccountService(IFirebaseConfig firebaseConfig, IUnitOfWork unitOfWork, IMapper mapper, UserManager<Account> userManager, RoleManager<AccountRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _firebaseConfig = firebaseConfig;
        }


        //Block Account
        public async Task<bool> BlockUserAsync(Guid accountId)
        {
            var account = await _userManager.FindByIdAsync(accountId.ToString());
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy tài khoản người dùng.");
            }
            if (account.LockoutEnd.HasValue && account.LockoutEnd.Value > CoreHelper.SystemTimeNow)
            {
                throw new CustomException.InvalidDataException("Tài khoản này đã bị khóa trước đó.");
            }

            account.LockoutEnd = DateTimeOffset.MaxValue;
            account.AccountStatus = AccountStatus.Banned;

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

            // 3. Kiểm tra và upload Avatar (nếu có)
            string? AvatarImgUrl = null; // Biến lưu URL ảnh (nếu có)
            if (request.Avatar != null)
            {
                AvatarImgUrl = await _firebaseConfig.UploadImage(request.Avatar);
            }

            // 4. Tạo tài khoản
            var account = _mapper.Map<Account>(request);
            account.Email = request.Email;
            account.UserName = request.Email;
            account.Name = request.Name;
            account.Avatar = AvatarImgUrl; // Có thể null nếu Avatar không được upload
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
        public async Task<(IEnumerable<AccountResponse> Accounts, int TotalItem, int TotalPages)> SearchAccountsAsync(
             string? name,
             string? email,
             string? phoneNumber,
             AccountStatus? status,
             string? role,
             int pageIndex = 1,
             int pageSize = 5)
        {
            // Lấy danh sách các User có role tương ứng nếu role được chỉ định
            List<Guid> accountIdsWithRole = null;
            if (!string.IsNullOrEmpty(role))
            {
                // Lấy danh sách UserIds có role tương ứng
                var usersWithRole = await _userManager.GetUsersInRoleAsync(role);
                accountIdsWithRole = usersWithRole.Select(u => u.Id).ToList();
            }
        
            // Tạo bộ lọc
            Expression<Func<Account, bool>> filter = account =>
                (string.IsNullOrEmpty(name) || account.Name.Contains(name)) &&
                (string.IsNullOrEmpty(email) || account.Email.Contains(email)) &&
                (string.IsNullOrEmpty(phoneNumber) || account.PhoneNumber.Contains(phoneNumber)) &&
                (!status.HasValue || account.AccountStatus == status) &&
                (accountIdsWithRole == null || accountIdsWithRole.Contains(account.Id));
        
            // Đếm tổng số bản ghi phù hợp
            var totalItem = await _unitOfWork.AccountRepository.CountAsync(filter);
        
            // Lấy dữ liệu với phân trang
            var accounts = _unitOfWork.AccountRepository.Get(
                filter: filter,
                pageIndex: pageIndex,
                pageSize: pageSize
            );
        
            // Chuẩn bị dữ liệu phản hồi
            var accountsResponse = new List<AccountResponse>();
        
            foreach (var account in accounts)
            {
                var accountResponse = _mapper.Map<AccountResponse>(account);
        
                // Lấy danh sách vai trò
                var roles = await _userManager.GetRolesAsync(account);
                accountResponse.Roles = roles.ToList(); // Thêm vai trò vào phản hồi
        
                accountsResponse.Add(accountResponse);
            }
        
            int totalPages = (int)Math.Ceiling((double)totalItem / pageSize);
        
            return (accountsResponse, totalItem, totalPages);
        }




        //Update Account
        public async Task<bool> UpdateAccountAsync(Guid accountId, UpdateAccountRequest updateRequest)
        {
            var account = await _userManager.FindByIdAsync(accountId.ToString());
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy tài khoản người dùng.");
            }

            string AvatarImgUrl = null;
            if (updateRequest.Avatar != null)
            {
                AvatarImgUrl = await _firebaseConfig.UploadImage(updateRequest.Avatar);
            }


            // Update name
            if (!string.IsNullOrEmpty(updateRequest.Name))
            {
                account.Name = updateRequest.Name;
            }

            // Update phone number
            if (!string.IsNullOrEmpty(updateRequest.PhoneNumber))
            {
                account.PhoneNumber = updateRequest.PhoneNumber;
            }

            // Update avatar
            if (!string.IsNullOrEmpty(AvatarImgUrl))
            {
                account.Avatar = AvatarImgUrl;
            }

            // Unlock account if requested
            if (updateRequest.UnlockAccount)
            {
                account.LockoutEnd = null;  // Unlock the account
                account.AccessFailedCount = 0; // Reset failed login attempts
            }

            // Update roles if specified in the request
            if (updateRequest.Roles != null && updateRequest.Roles.Any())
            {
                // Get current roles assigned to the account
                var currentRoles = await _userManager.GetRolesAsync(account);

                // Remove roles that are no longer in the new set of roles
                var rolesToRemove = currentRoles.Except(updateRequest.Roles);
                var removeResult = await _userManager.RemoveFromRolesAsync(account, rolesToRemove);
                if (!removeResult.Succeeded)
                {
                    var errors = string.Join("; ", removeResult.Errors.Select(e => e.Description));
                    throw new CustomException.InvalidDataException($"Cập nhật vai trò thất bại khi xóa vai trò cũ: {errors}");
                }

                // Add new roles that are not already assigned to the account
                var rolesToAdd = updateRequest.Roles.Except(currentRoles);
                var addResult = await _userManager.AddToRolesAsync(account, rolesToAdd);
                if (!addResult.Succeeded)
                {
                    var errors = string.Join("; ", addResult.Errors.Select(e => e.Description));
                    throw new CustomException.InvalidDataException($"Cập nhật vai trò thất bại khi thêm vai trò mới: {errors}");
                }
            }

            // Save other account updates
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
