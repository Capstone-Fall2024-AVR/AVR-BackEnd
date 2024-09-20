using AVR.Application.ViewModels.Request.AuthRequest;
using AVR.Application.ViewModels.Response.AuthenResponse;
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
    }
}
