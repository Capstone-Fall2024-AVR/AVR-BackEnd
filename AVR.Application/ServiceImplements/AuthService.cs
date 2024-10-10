using AutoMapper;
using AVR.Application.Services;
using AVR.Application.Utils.OTP;
using AVR.Application.ViewModels.Request.Auth;
using AVR.Application.ViewModels.Response.AuthenResponse;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
        private readonly ISendMail _sendMail;

        public AuthService(
            SignInManager<Account> signInManager,
            UserManager<Account> userManager,
            IAuthentication authentication, IUnitOfWork unitOfWork, IMapper mapper, ISendMail sendMail)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _authentication = authentication;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _sendMail = sendMail;
            
        }

        public Task<LoginResponse> CheckGoogleLogin(string googleToken)
        {
            throw new NotImplementedException();
        }

        //Confirm Mail
        public async Task<bool> ConfirmEmailAsync(string token, string email)
        {
            if (string.IsNullOrWhiteSpace(token) || string.IsNullOrWhiteSpace(email))
                throw new CustomException.InvalidDataException("Invalid email confirmation request.");

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                throw new CustomException.InvalidDataException($"Không tìm thấy người dùng với email {email}.");

            var result = await _userManager.ConfirmEmailAsync(user, token);
            return result.Succeeded;
        }

        public async Task<bool> ForgotPasswordAsync(string email)
        {
            var account = await _userManager.FindByEmailAsync(email);
            if (account == null) return false;

            var token = await _userManager.GeneratePasswordResetTokenAsync(account);
            //var callbackUrl = $"https://localhost:5000/resetpassword?token={token}&email={email}";


            /*await _sendMail.SendForgotPasswordEmailAsync(email, callbackUrl);*/
            /*await _sendMail.SendEmailAsync(email, token, $"token={token}");*/
            await SendOtpAsync(account);

            return true;
        }

        //Login
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


        //Register
        public async Task<bool> RegisterUser(RegisterRequest registerRequest)
        {
            if (registerRequest.Password != registerRequest.ConfirmPassword)
            {
                throw new CustomException.InvalidDataException("Password và ConfirmPassword không trùng khớp.");
            }

            var existingUser = await _userManager.FindByEmailAsync(registerRequest.Email);
            if (existingUser != null)
            {
                throw new CustomException.InvalidDataException("Email đã tồn tại trong hệ thống.");
            }

            var account = _mapper.Map<Account>(registerRequest);
            account.Email = account.UserName= registerRequest.Email;
            account.Avatar = "";
            account.EmailConfirmed = false;
            var result = await _userManager.CreateAsync(account, registerRequest.Password);

            if (!result.Succeeded)
            {
                var errors = string.Join("; ", result.Errors.Select(e => e.Description));
                throw new CustomException.InvalidDataException($"Đăng ký thất bại: {errors}");
            }

            var roleResult = await _userManager.AddToRoleAsync(account, "Customer");
            if (!roleResult.Succeeded)
            {
                throw new CustomException.InvalidDataException("Gán vai trò thất bại.");
            }

            /* var token = await _userManager.GenerateEmailConfirmationTokenAsync(account);
             await _sendMail.SendEmailAsync(registerRequest.Email, "hehe" ,token);*/

            await SendOtpAsync(account);
            return true;

        }

        //Reset password
        public async Task<bool> ResetPasswordAsync(ResetPasswordRequest request)
        {
            if (request.NewPassword != request.ConfirmPassword)
            {
                throw new CustomException.InvalidDataException("Mật khẩu mới và xác nhận mật khẩu không giống nhau.");
            }

            var account = await _userManager.FindByEmailAsync(request.Email);

            if (account == null)
            {
                throw new CustomException.InvalidDataException("Email không tồn tài trong hệ thống");
            }
            var result = await _userManager.ResetPasswordAsync(account, request.Token, request.NewPassword);
            
            return result.Succeeded;
        }


        //SendOTP
        public async Task SendOtpAsync(Account account, bool isResend = false)
        {
            
            // Kiểm tra nếu OTP hiện tại còn hiệu lực, không cần gửi lại trừ khi yêu cầu resend
            if (account.OtpExpiryTime.HasValue && account.OtpExpiryTime > DateTime.UtcNow && !isResend)
            {
                throw new CustomException.InvalidDataException("OTP hiện tại vẫn còn hiệu lực.");
            }

            // Gọi phương thức GenerateOtp từ lớp OtpGenerator trong thư mục Utils
            var otp = OtpGenerator.GenerateOtp();

              
            // Lưu OTP và thời gian hết hạn
            account.EmailConfirmationOtp = otp;
            account.OtpExpiryTime = DateTime.UtcNow.AddMinutes(1); // OTP hết hạn sau 1 phút

            // Cập nhật thông tin vào tài khoản
            await _userManager.UpdateAsync(account);

            // Gửi OTP qua email
            await _sendMail.SendEmailAsync(account.Email, isResend ? "OTP mới" : "OTP xác nhận", $"Mã OTP của bạn là: {otp}");
        }

        //Unlock account
        public async Task<bool> UnlockAccountAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy email.");
            }

            await _userManager.SetLockoutEndDateAsync(user, null);
            return true;
        }

        
        //Verify account
        public async Task<bool> VerifyOtpAsync(string email, string otp)
        {
            var account = await _userManager.FindByEmailAsync(email);
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy tài khoản với email này.");
            }

            // Kiểm tra OTP có khớp và còn hiệu lực không
            if (account.EmailConfirmationOtp != otp)
            {
                throw new CustomException.InvalidDataException("Mã OTP không chính xác.");
            }

            if (account.OtpExpiryTime < DateTime.UtcNow)
            {
                throw new CustomException.InvalidDataException("Mã OTP đã hết hạn.");
            }

            // Nếu OTP đúng và còn hiệu lực, xóa OTP và xác nhận email
            account.EmailConfirmed = true;
            account.EmailConfirmationOtp = null;
            account.OtpExpiryTime = null;

            await _userManager.UpdateAsync(account);

            return true;
        }

        // Resend OTP
        public async Task<bool> ResendOtpAsync(string email)
        {
            var account = await _userManager.FindByEmailAsync(email);
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy tài khoản với email này.");
            }

            // Gửi lại OTP
            await SendOtpAsync(account, true);

            return true;
        }


    }
}
