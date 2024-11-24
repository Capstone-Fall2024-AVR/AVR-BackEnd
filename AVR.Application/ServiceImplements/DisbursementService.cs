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
    public class DisbursementService : IDisbursementService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IUnitOfWork _unitOfWork;

        public DisbursementService(IConfiguration configuration, IHttpContextAccessor contextAccessor, IUnitOfWork unitOfWork)
        {
            _configuration = configuration;
            _contextAccessor = contextAccessor;
            _unitOfWork = unitOfWork;
        }

        public async Task<string> CreateDisbursementVNPayUrl(Guid projectId, decimal totalAmount)
        {
            // Fetch the project
            var project = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(projectId);
            if (project == null)
            {
                throw new CustomException.DataNotFoundException("Project not found.");
            }

            // Create a new disbursement record
            var disbursement = new Disbursement
            {
                TotalAmount = totalAmount,
                ProjectApartmentID = projectId,
                TransactionCode = "",
                Status = DisbursementTransaction.Pending,
                CreateDate = CoreHelper.SystemTimeNow,
                UpdateDate = CoreHelper.SystemTimeNow
            };

            _unitOfWork.DisbursementRepository.Insert(disbursement);
            await _unitOfWork.SaveAsync();

            // Configure VNPay payment
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
            var urlCallBack = $"{_configuration["VnPay:DisbursementCallbackUrl"]}";

            double multipliedAmount = (double)(totalAmount * 100); // Convert to VND
            pay.AddRequestData("vnp_Version", _configuration["Vnpay:Version"]);
            pay.AddRequestData("vnp_Command", _configuration["Vnpay:Command"]);
            pay.AddRequestData("vnp_TmnCode", _configuration["Vnpay:TmnCode"]);
            pay.AddRequestData("vnp_Amount", multipliedAmount.ToString());
            pay.AddRequestData("vnp_CreateDate", timeNow.ToString("yyyyMMddHHmmss"));
            pay.AddRequestData("vnp_CurrCode", _configuration["Vnpay:CurrCode"]);
            pay.AddRequestData("vnp_IpAddr", pay.GetIpAddress(context));
            pay.AddRequestData("vnp_Locale", _configuration["Vnpay:Locale"]);
            pay.AddRequestData("vnp_OrderInfo", disbursement.DisbursementID.ToString());
            pay.AddRequestData("vnp_OrderType", "VNPay");
            pay.AddRequestData("vnp_ReturnUrl", urlCallBack);
            pay.AddRequestData("vnp_TxnRef", tick);

            var paymentUrl = pay.CreateRequestUrl(_configuration["Vnpay:BaseUrl"], _configuration["Vnpay:HashSecret"]);
            return paymentUrl;
        }


        public async Task ProcessDisbursementResultAsync(Guid disbursementId, string transactionStatus, string transactionNo)
        {
            // Fetch the disbursement record
            var disbursement = await _unitOfWork.DisbursementRepository.GetByIdAsync(disbursementId);
            if (disbursement == null)
            {
                throw new CustomException.DataNotFoundException("Disbursement not found.");
            }

            // Update the status based on transaction result
            if (transactionStatus == "00") // Successful payment
            {
                disbursement.Status = DisbursementTransaction.Completed;
                disbursement.TransactionCode = transactionNo;
            }
            else
            {
                disbursement.Status = DisbursementTransaction.Failed;
            }

            disbursement.UpdateDate = CoreHelper.SystemTimeNow;
            _unitOfWork.DisbursementRepository.Update(disbursement);

            await _unitOfWork.SaveAsync();
        }

    }
}
