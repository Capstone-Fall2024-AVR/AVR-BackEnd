using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.AuthRequest;
using AVR.Application.ViewModels.Response.AuthenResponse;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{

    public class AuthService : IAuthService
    {
        private readonly IAuthentication _authentication;
        private readonly SignInManager<Account> _signInManager;
        private readonly UserManager<Account> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
       /* private readonly ISendMail _sendMail;
        private readonly IConfiguration _configuration;*/
        public AuthService(
            SignInManager<Account> signInManager,
            UserManager<Account> userManager,
            IAuthentication authentication, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _authentication = authentication;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            /*_sendMail = sendMail;
            _configuration = configuration;*/
        }

        public Task<LoginResponse> CheckGoogleLogin(string googleToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ConfirmEmailAsync(string token, string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ForgotPasswordAsync(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginResponse> Login(LoginRequest loginDTO)
        {
            var account = _unitOfWork.AccountRepository.Get(r => r.Email == loginDTO.Email).FirstOrDefault();

            if (account == null)
            {
                throw new CustomException.InvalidDataException("Email hoặc mật khẩu không hợp lệ.");
            }

            if (!account.EmailConfirmed)
            {
                throw new CustomException.ForbbidenException("Tài khoản chưa được xác nhận. Vui lòng kiểm tra email để xác nhận.");
            }

            if (account.LockoutEnabled && account.LockoutEnd.HasValue && account.LockoutEnd.Value > DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(7)))
            {
                var remainingLockoutTime = account.LockoutEnd.Value - DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(7));
                throw new CustomException.ForbbidenException($"Tài khoản của bạn đã bị khóa. Vui lòng thử lại sau {remainingLockoutTime.TotalMinutes:N0} phút.");
            }

            if (!_authentication.VerifyPassword(loginDTO.Password, account.PasswordHash, account))
            {

                account.AccessFailedCount++;

                if (account.AccessFailedCount >= 3)
                {
                    account.LockoutEnd = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(7)).AddMinutes(15);
                    await _unitOfWork.SaveAsync();
                    throw new CustomException.ForbbidenException("Bạn đã đăng nhập sai quá số lần quy định. Tài khoản đã bị khóa trong 15 phút.");
                }

                await _unitOfWork.SaveAsync();
                throw new CustomException.InvalidDataException("Email hoặc mật khẩu không hợp lệ.");
            }

            if (account.LockoutEnd.HasValue && account.LockoutEnd.Value > DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(7)))
            {
                var remainingLockoutTime = account.LockoutEnd.Value - DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(7));
                throw new CustomException.ForbbidenException($"Tài khoản của bạn đã bị khóa. Vui lòng thử lại sau {remainingLockoutTime.TotalMinutes:N0} phút.");
            }

            account.AccessFailedCount = 0;
            account.LockoutEnd = null;
            await _unitOfWork.SaveAsync();

            string token = _authentication.GenerateJWTToken(account);

            return new LoginResponse { token = token };
        }

        public Task<bool> RegisterUser(RegisterRequest registerRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResetPasswordAsync(ResetPasswordRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UnlockAccountAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
