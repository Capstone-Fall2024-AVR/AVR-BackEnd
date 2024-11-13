using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Auth;
using CoreApiResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/auth")]
    [ApiController]
    public class AuthController : BaseController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {

            var results = await _authService.Login(request);
            return CustomResult("Đăng nhập thành công.", results);
        }

        [HttpPost("unlock")]
        public async Task<IActionResult> UnlockAccount(string accountId)
        {
            var result = await _authService.UnlockAccountAsync(accountId);
            return CustomResult("Tài khoản đã được mở khóa thành công.", result);
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var results = await _authService.RegisterUser(request);
            return CustomResult("Tạo tài khoản thành công. Vui lòng kiểm tra email để xác nhận tài khoản trước khi đăng nhập.", results);
        }

        [HttpPost("ConfirmEmail")]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail([FromBody] ConfirmEmailRequest request)
        {
            var isConfirmed = await _authService.ConfirmEmailAsync(request.Token, request.Email);
            return CustomResult("Xác nhận email thành công.", isConfirmed);

        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordRequest request)
        {

            await _authService.ForgotPasswordAsync(request.Email);
            return CustomResult("Email khôi phục mật khẩu đã được gửi.");
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest request)
        {

            await _authService.ResetPasswordAsync(request);
            return CustomResult("Đặt lại mật khẩu thành công.");

        }
        [HttpPost("google-login")]
        public async Task<IActionResult> CheckGoogleLogin([FromBody] LoginGoogleRequest request)
        {
            var result = await _authService.CheckGoogleLogin(request.token);
            return CustomResult("Đăng nhập với Google thành công.", result);
        }


        [HttpPost("resend-OTP")]
        public async Task<IActionResult> ResendOTP(string email)
        {
            var result = await _authService.ResendOtpAsync(email);
            return CustomResult("OTP đã được gửi lại.", result);
        }


        [HttpPost("verify-OTP")]
        public async Task<IActionResult> VerifyOTP(string email, string otp)
        {
            var result = await _authService.VerifyOtpAsync(email, otp);
            return CustomResult("Xác thực OTP thành công.", result);
        }
    }
}
