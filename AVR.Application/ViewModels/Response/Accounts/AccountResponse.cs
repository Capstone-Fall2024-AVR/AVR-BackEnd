using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Accounts
{
    public class AccountResponse: IMapFrom<Account>
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string PhoneNumber { get; set; }

        public AccountStatus AccountStatus { get; set; }
    }
}
