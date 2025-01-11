using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AVR.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using AVR.Application.Utils.GeneratorPDF;
using DocumentFormat.OpenXml.Spreadsheet;

namespace AVR.Infrastructure.Integrations.Mail
{
    public class SendMail : ISendMail
    {
        private readonly IConfiguration _configuration;
        private readonly EmailTemplateBuilder _emailTemplateBuilder;
        private readonly IUnitOfWork _unitOfWork;
        public SendMail(IConfiguration configuration, EmailTemplateBuilder emailTemplateBuilder, IUnitOfWork unitOfWork)
        {
            _configuration = configuration;
            _emailTemplateBuilder = emailTemplateBuilder;
            _unitOfWork = unitOfWork;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            // Kiểm tra địa chỉ email hợp lệ
            if (string.IsNullOrEmpty(toEmail) || !toEmail.Contains("@"))
            {
                throw new FormatException("Địa chỉ email không hợp lệ: " + toEmail);
            }

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

        // Thêm phương thức để gửi email thông báo chấp nhận deposit
        public async Task SendDepositAcceptedEmailAsync(string toEmail, string customerName, double depositAmount)
        {
            var bodyContent = $@"
                <html>
                    <head>
                        <style>
                            .email-container {{
                                width: 100%;
                                height: auto;
                                background-image: url('https://empirecityvn.com/wp-content/uploads/2022/06/nguon-cung-can-ho-cao-cap-1.jpg');
                                background-size: cover;
                                background-position: center;
                                position: relative;
                                padding: 0;
                                margin: 0;
                            }}
                            .content-box {{
                                background-color: rgba(255, 255, 255, 0.8); /* Nền trắng trong suốt */
                                padding: 20px;
                                margin: 0 auto;
                                width: 60%;
                                text-align: center;
                                position: absolute;
                                top: 50%;
                                left: 50%;
                                transform: translate(-50%, -50%); /* Giúp căn giữa nội dung */
                                border-radius: 8px;
                            }}
                            h2 {{
                                color: #333;
                            }}
                            p {{
                                font-size: 16px;
                                color: #555;
                            }}
                        </style>
                    </head>
                    <body>
                        <div class='email-container'>
                            <div class='content-box'>
                                <h2>Xin chào {customerName},</h2>
                                <p>Chúng tôi vui mừng thông báo rằng deposit của bạn đã được chấp nhận.</p>
                                <p>Số tiền deposit: <strong>{depositAmount} USD</strong></p>
                                <p>Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!</p>
                            </div>
                        </div>
                    </body>
                </html>
                ";
            await SendEmailAsync(toEmail, "Deposit Accepted", bodyContent);
        }



        // Thêm phương thức để gửi email thông báo từ chối deposit
        public async Task SendDepositRejectedEmailAsync(string toEmail, string customerName)
        {
            var bodyContent = $@"
                <html>
                    <head>
                        <style>
                            .email-container {{
                                width: 100%;
                                height: auto;
                                background-image: url('https://empirecityvn.com/wp-content/uploads/2022/06/nguon-cung-can-ho-cao-cap-1.jpg');
                                background-size: cover;
                                background-position: center;
                                position: relative;
                                padding: 0;
                                margin: 0;
                            }}
                            .content-box {{
                                background-color: rgba(255, 255, 255, 0.8); /* Nền trắng trong suốt */
                                padding: 20px;
                                margin: 0 auto;
                                width: 60%;
                                text-align: center;
                                position: absolute;
                                top: 50%;
                                left: 50%;
                                transform: translate(-50%, -50%); /* Giúp căn giữa nội dung */
                                border-radius: 8px;
                            }}
                            h2 {{
                                color: #333;
                            }}
                            p {{
                                font-size: 16px;
                                color: #555;
                            }}
                        </style>
                    </head>
                    <body>
                        <div class='email-container'>
                            <div class='content-box'>
                                <h2>Xin chào {customerName},</h2>
                                <p>Chúng tôi rất tiếc phải thông báo rằng deposit của bạn đã bị từ chối.</p>
                                <p>Vui lòng liên hệ với chúng tôi để biết thêm chi tiết.</p>
                            </div>
                        </div>
                    </body>
                </html>
                ";
            await SendEmailAsync(toEmail, "Deposit Rejected", bodyContent);
        }

        public async Task SendDepositDisableEmailAsync(string email, string customerName)
        {
            var bodyContent = $@"
                <html>
                    <head>
                        <style>
                            .email-container {{
                                width: 100%;
                                height: auto;
                                background-image: url('https://empirecityvn.com/wp-content/uploads/2022/06/nguon-cung-can-ho-cao-cap-1.jpg');
                                background-size: cover;
                                background-position: center;
                                position: relative;
                                padding: 0;
                                margin: 0;
                            }}
                            .content-box {{
                                background-color: rgba(255, 255, 255, 0.8); /* Nền trắng trong suốt */
                                padding: 20px;
                                margin: 0 auto;
                                width: 60%;
                                text-align: center;
                                position: absolute;
                                top: 50%;
                                left: 50%;
                                transform: translate(-50%, -50%); /* Giúp căn giữa nội dung */
                                border-radius: 8px;
                            }}
                            h2 {{
                                color: #333;
                            }}
                            p {{
                                font-size: 16px;
                                color: #555;
                            }}
                        </style>
                    </head>
                    <body>
                        <div class='email-container'>
                            <div class='content-box'>
                                <h2>Xin chào {customerName},</h2>
                                <p>Chúng tôi rất tiếc phải thông báo rằng deposit của bạn không được giải quyết.</p>
                                <p>Vui lòng liên hệ với chúng tôi để biết thêm chi tiết.</p>
                            </div>
                        </div>
                    </body>
                </html>
                ";
            await SendEmailAsync(email, "Yêu cầu đặt cọc không thể hoàn thành", bodyContent);
        }

        public async Task SendDepositSuccessEmailAsync(string toEmail, string customerName, Guid depositId, string transactionNo)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(deposit.ApartmentID);
            // Tạo nội dung email
            var bodyContent = $@"
        <html>
            <head>
                <style>
                    .email-container {{
                        width: 100%;
                        height: auto;
                        background-image: url('https://empirecityvn.com/wp-content/uploads/2022/06/nguon-cung-can-ho-cao-cap-1.jpg');
                        background-size: cover;
                        background-position: center;
                        position: relative;
                        padding: 0;
                        margin: 0;
                    }}
                    .content-box {{
                        background-color: rgba(255, 255, 255, 0.8);
                        padding: 20px;
                        margin: 0 auto;
                        width: 60%;
                        text-align: center;
                        position: absolute;
                        top: 50%;
                        left: 50%;
                        transform: translate(-50%, -50%);
                        border-radius: 8px;
                    }}
                    h2 {{
                        color: #333;
                    }}
                    p {{
                        font-size: 16px;
                        color: #555;
                    }}
                </style>
            </head>
            <body>
                <div class='email-container'>
                    <div class='content-box'>
                    <h2>Xin chào {customerName},</h2>
                    <p>Chúng tôi xác nhận rằng giao dịch đặt cọc của bạn đã hoàn tất thành công.</p>
                    <p><strong>Mã căn hộ:</strong> {apartment.ApartmentCode}</p>
                    <p><strong>Số tiền đặt cọc:</strong> {deposit.depositAmount} VND</p>
                    <p><strong>Số giao dịch:</strong> {transactionNo}</p>
                    <p><strong>Ngày giao dịch:</strong> {deposit.UpdateDate.ToString("dd/MM/yyyy HH:mm:ss")}</p>
                    <p>Cảm ơn bạn đã tin tưởng sử dụng dịch vụ của chúng tôi.</p>
                    <p>Nếu bạn có bất kỳ câu hỏi nào, vui lòng liên hệ với chúng tôi qua email <a href='mailto:luxerapartment8386@gmail.com'>luxerapartment8386@gmail.com</a> hoặc gọi đến hotline 0393713614.</p>
                 </div>
                </div>
            </body>
        </html>";

            // Tạo file PDF
            var pdfGenerator = new PdfGenerator();
            //var transactionPdf = pdfGenerator.GenerateTransactionConfirmationPdf(customerName, depositAmount, transactionNo);
            //var transferPdf = pdfGenerator.GenerateBankTransferConfirmationPdf(customerName, depositAmount, "Ngân hàng A", transactionNo);

            // Khởi tạo đối tượng SmtpClient
            var smtpClient = new SmtpClient(_configuration["EmailSettings:SmtpServer"])
            {
                Port = int.Parse(_configuration["EmailSettings:SmtpPort"]),
                Credentials = new NetworkCredential(
                    _configuration["EmailSettings:SmtpUsername"],
                    _configuration["EmailSettings:SmtpPassword"]
                ),
                EnableSsl = true,
            };

            // Tạo email với file đính kèm
            var mailMessage = new MailMessage
            {
                From = new MailAddress(_configuration["EmailSettings:FromEmail"]),
                Subject = "Xác nhận giao dịch đặt cọc",
                Body = bodyContent,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(toEmail);

            // Đính kèm file PDF
            //mailMessage.Attachments.Add(new Attachment(new MemoryStream(transactionPdf), "XacNhanGiaoDich.pdf", "application/pdf"));
            //mailMessage.Attachments.Add(new Attachment(new MemoryStream(transferPdf), "XacNhanChuyenKhoan.pdf", "application/pdf"));

            // Gửi email
            await smtpClient.SendMailAsync(mailMessage);
        }



    }
}

