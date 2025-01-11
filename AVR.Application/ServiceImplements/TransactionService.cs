using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Transaction.TransactionDisbursementRequest;
using AVR.Application.ViewModels.Response.Transaction.TransactionDisbursementResponse;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransactionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<(IEnumerable<TransactionDisbursementResponse> Transactions, int TotalItems, int TotalPages)> SearchTransactionsAsync(
         Guid? transactionId,
         Guid? depositId,
         Guid? accountId,
         string? transactionNo,
         TransactionTypes? transactionTypes,
         TransactionStatus? transactionStatus,
         string? keyword, // Tìm kiếm theo từ khóa
         int pageIndex = 1,
         int pageSize = 10)
        {
            // Tạo biểu thức lọc
            Expression<Func<Transaction, bool>> filter = t =>
                (!transactionId.HasValue || t.TransactionID == transactionId) &&
                (!depositId.HasValue || t.DepositID == depositId) &&
                (!accountId.HasValue || t.Deposits.AccountID == accountId) &&
                (string.IsNullOrEmpty(transactionNo) || t.TransactionNo.Contains(transactionNo)) &&
                (!transactionTypes.HasValue || t.TransactionType == transactionTypes) &&
                (!transactionStatus.HasValue || t.TransactionStatus == transactionStatus) &&
                (string.IsNullOrEmpty(keyword) ||
                 t.Deposits.Apartments.ApartmentCode.Contains(keyword) || // Tìm theo ApartmentCode
                 t.Deposits.DepositCode.Contains(keyword) ||              // Tìm theo DepositCode
                 t.TransactionNo.Contains(keyword));                      // Tìm theo TransactionNo

            // Lấy tổng số mục phù hợp
            int totalItems = await _unitOfWork.TransactionRepository.CountAsync(filter);

            // Tính tổng số trang
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Truy vấn giao dịch với lọc, sắp xếp và phân trang
            var transactions = _unitOfWork.TransactionRepository.Get(
                filter: filter,
                includeProperties: "Deposits,Deposits.Apartments,Deposits.DepositProfile",
                orderBy: q => q.OrderByDescending(t => t.TransactionDate),
                pageIndex: pageIndex,
                pageSize: pageSize);

            // Map kết quả sang DTO
            var transactionResponses = transactions.Select(transaction => new TransactionDisbursementResponse
            {
                TransactionId = transaction.TransactionID,
                CustomerName = transaction.Deposits.DepositProfile.FullName, 
                DepositCode = transaction.Deposits.DepositCode,
                TransactionNo = transaction.TransactionNo,
                ApartmentCode = transaction.Deposits.Apartments?.ApartmentCode, // Bảo vệ null cho Apartments
                description = transaction.description,
                AmountPaid = transaction.ammount,
                TransactionDate = transaction.TransactionDate,
                Status = transaction.TransactionStatus.ToString(),
                PaymentMethods = transaction.PaymentMethods.ToString(),
            }).ToList();

            return (transactionResponses, totalItems, totalPages);
        }

        public async Task<int> GetTransactionCountAsync(TransactionStatus? transactionStatus = null)
        {
            // Count transactions based on the provided status
            var transactionCount = transactionStatus.HasValue
                ? _unitOfWork.TransactionRepository.Get(t => t.TransactionStatus == transactionStatus).Count()
                : await _unitOfWork.TransactionRepository.GetAllAsync().ContinueWith(task => task.Result.Count);

            return transactionCount;
        }

    }
}
