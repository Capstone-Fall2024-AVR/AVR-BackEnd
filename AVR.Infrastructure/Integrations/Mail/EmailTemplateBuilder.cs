using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.Mail
{
    public class EmailTemplateBuilder
    {
        public string BuildEmailTemplate(string title, string bodyContent)
        {
            return $@"
            <!DOCTYPE html>
            <html>
            <head>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        margin: 0;
                        padding: 0;
                        background-color: #f4f4f4;
                    }}
                    .container {{
                        width: 100%;
                        max-width: 600px;
                        margin: 20px auto;
                        background-color: #ffffff;
                        padding: 0;
                        border-radius: 8px;
                        box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
                        border: 2px solid #4caf50;
                    }}
                    .header {{
                        text-align: center;
                        background-color: #4caf50;
                        color: #ffffff;
                        padding: 10px 0;
                        border-radius: 8px 8px 0 0;
                    }}
                    .header h1 {{
                        margin: 0;
                        font-size: 24px;
                    }}
                    .header img {{
                        width: 100px;
                        height: 100px;
                        margin-bottom: 10px;
                        border-radius: 50%;
                    }}
                    .content {{
                        padding: 20px;
                    }}
                    .content h2 {{
                        color: #333333;
                        font-size: 20px;
                    }}
                    .content p {{
                        color: #555555;
                        font-size: 16px;
                        line-height: 1.6;
                    }}
                    .button {{
                        text-align: center;
                        margin: 20px 0;
                    }}
                    .button a {{
                        background-color: #4caf50;
                        color: white;
                        padding: 10px 20px;
                        text-decoration: none;
                        border-radius: 4px;
                        font-size: 16px;
                    }}
                    .footer {{
                        text-align: center;
                        padding: 10px;
                        font-size: 12px;
                        color: #aaaaaa;
                        border-radius: 0 0 8px 8px;
                    }}
                    .footer p {{
                        margin: 5px 0;
                    }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <div class='header'>
                        
                        <h1>{title}</h1>
                    </div>
                    <div class='content'>
                        {bodyContent}
                    </div>
                    <div class='footer'>
                       
                    </div>
                </div>
            </body>
            </html>
            ";
        }

        public string BuildConfirmationEmailBody(string email, string callbackUrl)
        {
            var bodyContent = $@"
                <h2>Xin chào {email},</h2>
                <p>
                    Cảm ơn bạn đã đăng ký tài khoản tại AVR! Vui lòng xác nhận tài khoản của bạn bằng cách nhấn vào nút bên dưới.
                </p>
                <div class='button'>
                    <a href='{callbackUrl}'>Xác nhận tài khoản</a>
                </div>
                <p>Nếu bạn đã xác nhận tài khoản, xin vui lòng bỏ qua email này.</p>
            ";

            return BuildEmailTemplate("Xác nhận tài khoản", bodyContent);
        }

        public string BuildForgotPasswordEmailBody(string email, string callbackUrl)
        {
            var bodyContent = $@"
                <h2>Xin chào {email},</h2>
                <p>
                    Bạn đã yêu cầu đặt lại mật khẩu cho tài khoản tại AVR.
                </p>
                <p>
                    Vui lòng nhấn vào nút bên dưới để đặt lại mật khẩu của bạn:
                </p>
                <div class='button'>
                    <a href='{callbackUrl}'>Đặt lại mật khẩu</a>
                </div>
                <p>Nếu bạn không yêu cầu đặt lại mật khẩu, xin vui lòng bỏ qua email này.</p>
            ";

            return BuildEmailTemplate("Đặt lại mật khẩu", bodyContent);
        }

        public string BuildDepositAcceptedEmail(string customerName, double depositAmount)
        {
            var bodyContent = $@"
            <h2>Xin chào {customerName},</h2>
            <p>Chúng tôi vui mừng thông báo rằng deposit của bạn đã được chấp nhận.</p>
            <p>Số tiền deposit: <strong>{depositAmount} VND</strong></p>
            <img src='https://empirecityvn.com/wp-content/uploads/2022/06/nguon-cung-can-ho-cao-cap-1.jpg' alt='Accepted' style='width:100%; height:auto;' />
            <p>Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!</p>
        ";

            return BuildEmailTemplate("Deposit Accepted", bodyContent);
        }

        public string BuildDepositRejectedEmail(string customerName)
        {
            var bodyContent = $@"
            <h2>Xin chào {customerName},</h2>
            <p>Chúng tôi rất tiếc phải thông báo rằng deposit của bạn đã bị từ chối.</p>
            <img src='https://empirecityvn.com/wp-content/uploads/2022/06/nguon-cung-can-ho-cao-cap-1.jpg' alt='Rejected' style='width:100%; height:auto;' />
            <p>Vui lòng liên hệ với chúng tôi để biết thêm chi tiết.</p>
        ";

            return BuildEmailTemplate("Deposit Rejected", bodyContent);
        }
    }
}
