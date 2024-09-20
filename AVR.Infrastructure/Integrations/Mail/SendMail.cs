using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AVR.Domain.Interfaces;
using Microsoft.Extensions.Configuration;

namespace AVR.Infrastructure.Integrations.Mail
{
    public class SendMail : ISendMail
    {
        private readonly IConfiguration _configuration;
        //private readonly EmailTemplateBuilder _emailTemplateBuilder;
        public SendMail(IConfiguration configuration)
        {
            _configuration = configuration;
            //_emailTemplateBuilder = emailTemplateBuilder;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            var smtpClient = new SmtpClient(_configuration["EmailSettings:SmtpServer"])
            {
                Port = int.Parse(_configuration["EmailSettings:SmtpPort"]),
                Credentials = new NetworkCredential(_configuration["EmailSettings:SmtpUsername"], _configuration["EmailSettings:SmtpPassword"]),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_configuration["EmailSettings:FromEmail"]),
                Subject = subject,
                Body = message,
                IsBodyHtml = true,
            };

            mailMessage.To.Add(toEmail);

            await smtpClient.SendMailAsync(mailMessage);
        }

        public async Task SendConfirmationEmailAsync(string email, string callbackUrl)
        {
            var emailTemplateBuilder = new EmailTemplateBuilder();
            var emailBody = emailTemplateBuilder.BuildConfirmationEmailBody(email, callbackUrl);

            await SendEmailAsync(email, "Xác nhận tài khoản", emailBody);
        }

        public async Task SendForgotPasswordEmailAsync(string email, string callbackUrl)
        {
            var emailTemplateBuilder = new EmailTemplateBuilder();
            var emailBody = emailTemplateBuilder.BuildForgotPasswordEmailBody(email, callbackUrl);

            // Sử dụng SendMail để gửi email với nội dung HTML đã tạo
            await SendEmailAsync(email, "Đặt lại mật khẩu", emailBody);
        }
    }
}

