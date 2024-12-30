using AVR.Application.Services;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using AVR.Domain.Utils.VNPay;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class VNPayService : IVNPayService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISendMail _sendMail;
        private readonly IDepositScheduler _depositScheduler;

        public VNPayService(IConfiguration configuration, IHttpContextAccessor contextAccessor, IUnitOfWork unitOfWork, ISendMail sendMail, IDepositScheduler depositScheduler)
        {
            _configuration = configuration;
            _contextAccessor = contextAccessor;
            _unitOfWork = unitOfWork;
            _sendMail = sendMail;
            _depositScheduler = depositScheduler;
        }

        public async Task<string> CreateVNPayUrl(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new Exception("Deposit not found.");
            }
            if (deposit.DepositStatus != DepositStatus.Accept)
            {
                throw new CustomException.InvalidDataException("Yêu cầu đặt cọc chưa được chấp nhận!.");
            }

            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(deposit.ApartmentID);
            if (apartment == null)
            {
                throw new Exception("Apartment not found.");
            }

            // Tính tổng số tiền thanh toán
            var amount = deposit.paymentAmount;

            // Cấu hình VNPay URL
            HttpContext context = _contextAccessor.HttpContext;
            var pay = new VnPayLibrary();
            var timeZoneId = _configuration["TimeZoneId"];
            if (string.IsNullOrEmpty(timeZoneId))
            {
                throw new Exception("TimeZoneId is not configured.");
            }

            var timeZoneById = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            var timeNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneById);
            var tick = DateTime.Now.Ticks.ToString();
            var urlCallBack = $"{_configuration["VnPay:CallbackUrl"]}";

            double multipliedAmount = (double)(amount * 100);  // Convert to VND
            pay.AddRequestData("vnp_Version", _configuration["Vnpay:Version"]);
            pay.AddRequestData("vnp_Command", _configuration["Vnpay:Command"]);
            pay.AddRequestData("vnp_TmnCode", _configuration["Vnpay:TmnCode"]);
            pay.AddRequestData("vnp_Amount", multipliedAmount.ToString());
            pay.AddRequestData("vnp_CreateDate", timeNow.ToString("yyyyMMddHHmmss"));
            pay.AddRequestData("vnp_CurrCode", _configuration["Vnpay:CurrCode"]);
            pay.AddRequestData("vnp_IpAddr", pay.GetIpAddress(context));
            pay.AddRequestData("vnp_Locale", _configuration["Vnpay:Locale"]);
            pay.AddRequestData("vnp_OrderInfo", $"{depositId}");
            pay.AddRequestData("vnp_OrderType", "VNPay");
            pay.AddRequestData("vnp_ReturnUrl", urlCallBack);
            pay.AddRequestData("vnp_TxnRef", tick);

            var paymentUrl = pay.CreateRequestUrl(_configuration["Vnpay:BaseUrl"], _configuration["Vnpay:HashSecret"]);
            return paymentUrl;
        }

        public bool ValidateVNPaySignature(string queryString, string vnp_SecureHash)
        {
            var pay = new VnPayLibrary();

            // Bỏ '?' ở đầu query string nếu có
            queryString = queryString.TrimStart('?');

            foreach (var param in queryString.Split('&'))
            {
                var keyValue = param.Split('=');
                if (keyValue.Length == 2 && keyValue[0] != "vnp_SecureHash" && keyValue[0] != "vnp_SecureHashType")
                {
                    pay.AddResponseData(keyValue[0], keyValue[1]);
                }
            }

            // Validate signature
            return pay.ValidateSignature(vnp_SecureHash, _configuration["VnPay:HashSecret"]);
        }


        public async Task ProcessPaymentResultAsync(Guid depositId, string transactionStatus, string TransactionNo)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new Exception("Deposit not found.");
            }

            var apartments = await _unitOfWork.ApartmentRepository.GetByIdAsync(deposit.ApartmentID);
            if (apartments == null)
            {
                throw new Exception("Deposit not found.");
            }
            var transactionTypes = TransactionTypes.Deposit;

            if (deposit.DepositType == DepositType.Trade && deposit.DisbursementStatus == DisbursementStatus.PendingDisbursement)
            {
                transactionTypes = TransactionTypes.Trade;
            }

            /*if (deposit.DepositType == DepositType.Refund && deposit.DisbursementStatus == DisbursementStatus.PendingDisbursement)
            {
                transactionTypes = TransactionTypes.Refund;
            }

            if (deposit.DisbursementStatus == DisbursementStatus.ProcessingDisbursement)
            {
                transactionTypes = TransactionTypes.Disbursement;
            }*/
            // Cập nhật trạng thái Deposit dựa trên kết quả thanh toán
            if (transactionStatus == "00") // Thanh toán thành công
            {
                deposit.DepositStatus = DepositStatus.Paid;
                // Gửi email xác nhận kèm file PDF
                var account = await _unitOfWork.AccountRepository.GetByIdAsync(deposit.AccountID);
                if (account != null)
                {
                    await _sendMail.SendDepositSuccessEmailAsync(
                        account.Email,
                        account.Name,
                        deposit.depositAmount,
                        TransactionNo
                    );
                }
                // Cập nhật giao dịch thành công
                var transaction = new Transaction
                {
                    DepositID = deposit.DepositID,
                    TransactionDate = CoreHelper.SystemTimeNow,
                    ammount = deposit.paymentAmount,
                    TransactionNo = TransactionNo,
                    description = deposit.description,
                    note = "Thanh toán thành công",
                    TransactionStatus = TransactionStatus.Completed,
                    TransactionType = transactionTypes,
                    CreateDate = CoreHelper.SystemTimeNow,
                    UpdateDate = CoreHelper.SystemTimeNow,
                    PaymentMethods = PaymentMethod.VNPay
                };
                await _unitOfWork.TransactionRepository.InsertAsync(transaction);
                apartments.ApartmentStatus = ApartmentStatus.Sold;
                await _unitOfWork.ApartmentRepository.UpdateAsync(apartments);
                
                if(transactionTypes == TransactionTypes.Deposit || transactionTypes == TransactionTypes.Trade)
                {
                    await _depositScheduler.ScheduleDisbursementDepositJob(transaction);
                } 

                if(deposit.DepositType == DepositType.Trade)
                {
                    var oldDeposit = _unitOfWork.DepositRepository.Get(d => d.DepositCode == deposit.OldDepositCode).FirstOrDefault();
                    if (oldDeposit == null)
                    {
                        throw new CustomException.DataNotFoundException("Khong tim thay dat coc giu cho cu");
                    }
                    oldDeposit.DepositStatus = DepositStatus.Disable;
                    oldDeposit.note = "Đặt cọc giữ chỗ này đã bị hủy do trao đổi căn hộ khác.";
                    await _unitOfWork.DepositRepository.UpdateAsync(oldDeposit);
                    
                }

                /*else if (transactionTypes == TransactionTypes.Refund)
                {
                    deposit.DisbursementStatus = DisbursementStatus.DisbursementFailed;
                }
                else if (transactionTypes == TransactionTypes.Disbursement) 
                {
                    deposit.DisbursementStatus = DisbursementStatus.DisbursementCompleted;
                }*/

            }
            else // Thanh toán thất bại
            {
                deposit.DepositStatus = DepositStatus.PaymentFailed;
            }

            await _unitOfWork.SaveAsync();
        }

        public async Task RetryPaymentAsync(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new Exception("Deposit not found.");
            }

            if (deposit.DepositStatus != DepositStatus.PaymentFailed)
            {
                throw new Exception("Only deposits with failed payment status can be retried.");
            }

            // Gọi lại chức năng tạo URL thanh toán
            await CreateVNPayUrl(depositId);
        }

        public async Task<string> CreateDisbursementVNPayUrl(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new Exception("Deposit not found.");
            }
            if (deposit.DepositStatus != DepositStatus.Paid)
            {
                throw new CustomException.InvalidDataException("Yêu cầu đặt cọc chưa được thanh toán!.");
            }
            if(deposit.DisbursementStatus != DisbursementStatus.ProcessingDisbursement)
            {
                throw new CustomException.InvalidDataException("Yêu cầu giải ngân không hợp lệ!");
            }

            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(deposit.ApartmentID);
            if (apartment == null)
            {
                throw new Exception("Apartment not found.");
            }

            // Tính tổng số tiền thanh toán
            var amount = 0.0;

            //find deposit value from Project Financial Contract
            var projectfee = _unitOfWork.ProjectFinancialContractRepository
                .Get(pf => pf.ProjectApartmentID == apartment.ProjectApartmentID &&
                    pf.LowestPrice <= apartment.Price &&
                    pf.HighestPrice > apartment.Price
                ).FirstOrDefault();
            if (projectfee != null)
            {
                amount = (double)(projectfee.DepositAmount - projectfee.DepositAmount * projectfee.BrokerageFee);
            }

            //find deposit value from Property Verification
            var property = _unitOfWork.PropertyVerificationRepository
                .Get(pr => pr.ApartmentOwnerApartmentID == apartment.ApartmentID
                ).FirstOrDefault();

            if (property != null)
            {
                amount = (double)(property.DepositValue - property.DepositValue * property.BrokerageFee);

            }

            // Cấu hình VNPay URL
            HttpContext context = _contextAccessor.HttpContext;
            var pay = new VnPayLibrary();
            var timeZoneId = _configuration["TimeZoneId"];
            if (string.IsNullOrEmpty(timeZoneId))
            {
                throw new Exception("TimeZoneId is not configured.");
            }

            var timeZoneById = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            var timeNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneById);
            var tick = DateTime.Now.Ticks.ToString();
            var urlCallBack = $"{_configuration["VnPay:CallbackUrl"]}";

            double multipliedAmount = (double)(amount * 100);  // Convert to VND
            pay.AddRequestData("vnp_Version", _configuration["Vnpay:Version"]);
            pay.AddRequestData("vnp_Command", _configuration["Vnpay:Command"]);
            pay.AddRequestData("vnp_TmnCode", _configuration["Vnpay:TmnCode"]);
            pay.AddRequestData("vnp_Amount", multipliedAmount.ToString());
            pay.AddRequestData("vnp_CreateDate", timeNow.ToString("yyyyMMddHHmmss"));
            pay.AddRequestData("vnp_CurrCode", _configuration["Vnpay:CurrCode"]);
            pay.AddRequestData("vnp_IpAddr", pay.GetIpAddress(context));
            pay.AddRequestData("vnp_Locale", _configuration["Vnpay:Locale"]);
            pay.AddRequestData("vnp_OrderInfo", $"{depositId}");
            pay.AddRequestData("vnp_OrderType", "VNPay");
            pay.AddRequestData("vnp_ReturnUrl", urlCallBack);
            pay.AddRequestData("vnp_TxnRef", tick);

            var paymentUrl = pay.CreateRequestUrl(_configuration["Vnpay:BaseUrl"], _configuration["Vnpay:HashSecret"]);
            return paymentUrl;
        }

        public async Task<string> CreateRefundVNPayUrl(Guid depositId)
        {
            var deposit = await _unitOfWork.DepositRepository.GetByIdAsync(depositId);
            if (deposit == null)
            {
                throw new Exception("Deposit not found.");
            }
            if (deposit.DepositStatus != DepositStatus.Paid)
            {
                throw new CustomException.InvalidDataException("Yêu cầu đặt cọc chưa được chấp nhận!.");
            }

            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(deposit.ApartmentID);
            if (apartment == null)
            {
                throw new Exception("Apartment not found.");
            }

            // Tính tổng số tiền thanh toán
            var amount = (double)deposit.depositAmount;


            // Cấu hình VNPay URL
            HttpContext context = _contextAccessor.HttpContext;
            var pay = new VnPayLibrary();
            var timeZoneId = _configuration["TimeZoneId"];
            if (string.IsNullOrEmpty(timeZoneId))
            {
                throw new Exception("TimeZoneId is not configured.");
            }

            var timeZoneById = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            var timeNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneById);
            var tick = DateTime.Now.Ticks.ToString();
            var urlCallBack = $"{_configuration["VnPay:CallbackUrl"]}";

            double multipliedAmount = (double)(amount * 100);  // Convert to VND
            pay.AddRequestData("vnp_Version", _configuration["Vnpay:Version"]);
            pay.AddRequestData("vnp_Command", _configuration["Vnpay:Command"]);
            pay.AddRequestData("vnp_TmnCode", _configuration["Vnpay:TmnCode"]);
            pay.AddRequestData("vnp_Amount", multipliedAmount.ToString());
            pay.AddRequestData("vnp_CreateDate", timeNow.ToString("yyyyMMddHHmmss"));
            pay.AddRequestData("vnp_CurrCode", _configuration["Vnpay:CurrCode"]);
            pay.AddRequestData("vnp_IpAddr", pay.GetIpAddress(context));
            pay.AddRequestData("vnp_Locale", _configuration["Vnpay:Locale"]);
            pay.AddRequestData("vnp_OrderInfo", $"{depositId}");
            pay.AddRequestData("vnp_OrderType", "VNPay");
            pay.AddRequestData("vnp_ReturnUrl", urlCallBack);
            pay.AddRequestData("vnp_TxnRef", tick);

            var paymentUrl = pay.CreateRequestUrl(_configuration["Vnpay:BaseUrl"], _configuration["Vnpay:HashSecret"]);
            return paymentUrl;
        }
    }

}
