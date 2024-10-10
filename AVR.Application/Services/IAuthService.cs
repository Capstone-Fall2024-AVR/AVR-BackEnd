using AVR.Application.ViewModels.Request.Auth;
using AVR.Application.ViewModels.Response.AuthenResponse;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterUser(RegisterRequest registerRequest);
        Task<bool> ConfirmEmailAsync(string token, string email);
        Task<LoginResponse> Login(LoginRequest loginDTO);
        Task<bool> UnlockAccountAsync(string email);
        Task<bool> ForgotPasswordAsync(string email);
        Task<bool> ResetPasswordAsync(ResetPasswordRequest request);
        Task<LoginResponse> CheckGoogleLogin(string googleToken);

        Task SendOtpAsync(Account account, bool isResend);
        Task<bool> VerifyOtpAsync(string email, string otp);

        Task<bool> ResendOtpAsync(string email);

    }
}
