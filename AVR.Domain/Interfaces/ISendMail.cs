
namespace AVR.Domain.Interfaces
{
    public interface ISendMail
    {
        Task SendEmailAsync(string toEmail, string subject, string message);

        Task SendConfirmationEmailAsync(string email, string callbackUrl);

        Task SendForgotPasswordEmailAsync(string email, string callbackUrl);

        // Thêm phương thức mới cho Deposit
        Task SendDepositAcceptedEmailAsync(string email, string customerName, double depositAmount);

        Task SendDepositRejectedEmailAsync(string email, string customerName);
        Task SendDepositDisableEmailAsync(string email, string customerName);
    }
}
