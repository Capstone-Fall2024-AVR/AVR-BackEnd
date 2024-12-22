using AVR.Application.Services;
using AVR.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/payment")]
    public class PaymentController : ControllerBase
    {
        private readonly IVNPayService _vnPayService;
        private readonly IUnitOfWork _unitOfWork;

        public PaymentController(IVNPayService vnPayService, IUnitOfWork unitOfWork)
        {
            _vnPayService = vnPayService;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("create")]
        public async Task<IActionResult> CreatePaymentUrl(Guid depositId)
        {
            var paymentUrl = await _vnPayService.CreateVNPayUrl(depositId);
            return Ok(new { url = paymentUrl });
        }

        /*[HttpGet("disbursement")]
        public async Task<IActionResult> CreateDisbursementPaymentUrl(Guid depositId)
        {
            var paymentUrl = await _vnPayService.CreateDisbursementVNPayUrl(depositId);
            return Ok(new { url = paymentUrl });
        }

        [HttpGet("refund")]
        public async Task<IActionResult> CreateRefundPaymentUrl(Guid depositId)
        {
            var paymentUrl = await _vnPayService.CreateRefundVNPayUrl(depositId);
            return Ok(new { url = paymentUrl });
        }*/

        [HttpGet("callback")]
        public async Task<IActionResult> VNPayCallback([FromQuery] string vnp_OrderInfo, [FromQuery] string vnp_TransactionStatus, [FromQuery] string vnp_TransactionNo)
        {
            /*var isValidSignature = _vnPayService.ValidateVNPaySignature(Request.QueryString.Value, vnp_SecureHash);
            if (!isValidSignature)
            {
                return BadRequest("Invalid VNPay signature.");
            }*/

            // Kiểm tra xem vnp_TxnRef có phải là Guid hợp lệ không
            var depositId = new Guid(vnp_OrderInfo);

            await _vnPayService.ProcessPaymentResultAsync(depositId, vnp_TransactionStatus, vnp_TransactionNo);
            return Ok("Payment processed.");
        }

        [HttpPost("retry-payment")]
        public async Task<IActionResult> RetryPayment(Guid depositId)
        {
            await _vnPayService.RetryPaymentAsync(depositId);
            return Ok("Retrying payment.");
        }
    }

}
