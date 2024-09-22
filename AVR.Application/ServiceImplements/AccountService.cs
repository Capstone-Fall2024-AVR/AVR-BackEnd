using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Response.Accounts;
using AVR.Domain.CustomException;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<AccountResponse> GetAccountInfoAsync(Guid userId)
        {
            var account = await _unitOfWork.AccountRepository.GetByIdAsync(userId);
            if (account == null)
            {
                throw new CustomException.DataNotFoundException("Người dùng này không tồn tại.");
            }
            var accountResponse = _mapper.Map<AccountResponse>(account);
            return accountResponse;
        }

        public async Task<IEnumerable<AccountResponse>> GetAllAccountsAsync()
        {
            var accounts = await _unitOfWork.AccountRepository.GetAllAsync();
            if (accounts == null) 
            { 
                throw new CustomException.DataNotFoundException("List người dùng trống.");
            
            }
            var accountsResponse = _mapper.Map<IEnumerable<AccountResponse>>(accounts);
            return accountsResponse;
        }
    }
}
