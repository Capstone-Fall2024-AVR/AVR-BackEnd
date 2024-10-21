using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.DepositResponse
{
    public class DepositProfileResponse : IMapFrom<DepositProfile>
    {
        public string FullName { get; set; }
        public string IdentityCardNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentityCardFrontImage { get; set; }
        public string IdentityCardBackImage { get; set; }
    }
}
