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

        public async Task<IEnumerable<TransactionDisbursementResponse>> DisburseTransactionsAsync(TransactionDisbursementRequest request)
        {
            var transactions = _unitOfWork.TransactionRepository.Get(
                t => t.TransactionStatus == TransactionStatus.Completed && t.TransactionDate <= DateTimeOffset.Now && t.Deposits.Apartments.ProjectApartmentID == request.ProjectId);

            var disbursementResponses = new List<TransactionDisbursementResponse>();

            foreach (var transaction in transactions)
            {
                transaction.TransactionStatus = TransactionStatus.Disbursed;
                transaction.UpdateDate = DateTimeOffset.Now;

                disbursementResponses.Add(new TransactionDisbursementResponse
                {
                    TransactionId = transaction.TransactionID,
                    AmountPaid = transaction.ammount,
                    DisbursementDate = transaction.UpdateDate,
                    Status = transaction.TransactionStatus
                });

                _unitOfWork.TransactionRepository.Update(transaction);
            }

            await _unitOfWork.SaveAsync();

            return disbursementResponses;
        }

        public async Task UpdateTransactionStatusAsync()
        {
            var disbursedTransactions = _unitOfWork.TransactionRepository.Get(t => t.TransactionStatus == TransactionStatus.Disbursed);

            foreach (var transaction in disbursedTransactions)
            {
                transaction.TransactionStatus = TransactionStatus.Closed;
                transaction.UpdateDate = DateTimeOffset.Now;
                _unitOfWork.TransactionRepository.Update(transaction);
            }

            await _unitOfWork.SaveAsync();
        }

        public async Task<FileContentResult> ExportDisbursedApartmentsToExcelAsync(Guid projectId)
        {
            // Lấy danh sách các căn hộ đã giải ngân
            var disbursedTransactions = _unitOfWork.TransactionRepository.Get(
                t => t.TransactionStatus == TransactionStatus.Closed && // Lọc các giao dịch đã giải ngân
                t.Deposits.Apartments.ProjectApartmentID == projectId,
                includeProperties: "Deposits,Deposits.Apartments" // Bao gồm thông tin về Deposit và Apartment
            );
            var project = await _unitOfWork.ProjectApartmentRepository.GetByIdAsync(projectId);
            if( project == null )
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy dự án!");
            }

            // Tạo file Excel bằng ClosedXML
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Disbursed Apartments");
                worksheet.Cell(1, 1).Value = $"PROJECT: {project.ProjectApartmentName.ToUpper()}";
                worksheet.Cell(2, 1).Value = "Apartment ID";
                worksheet.Cell(2, 2).Value = "Apartment Name";
                worksheet.Cell(2, 3).Value = "Disbursed Amount";
                worksheet.Cell(2, 4).Value = "Transaction Date";

                int row = 3;
                foreach (var transaction in disbursedTransactions)
                {
                    worksheet.Cell(row, 1).Value = transaction.Deposits.ApartmentID.ToString();
                    worksheet.Cell(row, 2).Value = transaction.Deposits.Apartments.ApartmentName;
                    worksheet.Cell(row, 3).Value = transaction.ammount;
                    worksheet.Cell(row, 4).Value = transaction.TransactionDate.ToString();
                    row++;

                    transaction.TransactionStatus = TransactionStatus.Excel;
                    await _unitOfWork.TransactionRepository.UpdateAsync(transaction);
                }
                await _unitOfWork.SaveAsync();

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    // Trả về file Excel dưới dạng FileContentResult
                    return new FileContentResult(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = "Disbursed_Apartments.xlsx"
                    };
                }
            }

        }

        public async Task<IEnumerable<TransactionDisbursementResponse>> SearchTransactionsAsync(
            Guid? transactionId,
            Guid? depositId,
            TransactionStatus? transactionStatus,
            int pageIndex = 1,
            int pageSize = 10)
        {
            // Construct filter expression
            Expression<Func<Transaction, bool>> filter = t =>
                (!transactionId.HasValue || t.TransactionID == transactionId) &&
                (!depositId.HasValue || t.DepositID == depositId) &&
                (!transactionStatus.HasValue || t.TransactionStatus == transactionStatus);

            // Retrieve transactions with filter, order by TransactionDate, and apply pagination
            var transactions = _unitOfWork.TransactionRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(t => t.TransactionDate),
                pageIndex: pageIndex,
                pageSize: pageSize);

            // Map to response
            var transactionResponses = transactions.Select(transaction => new TransactionDisbursementResponse
            {
                TransactionId = transaction.TransactionID,
                AmountPaid = transaction.ammount,
                DisbursementDate = transaction.UpdateDate,
                Status = transaction.TransactionStatus
            }).ToList();

            return transactionResponses;
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