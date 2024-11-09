using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Transaction.TransactionDisbursementRequest;
using AVR.Application.ViewModels.Response.Transaction.TransactionDisbursementResponse;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
