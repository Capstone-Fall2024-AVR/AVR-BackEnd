using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Owners
{
    public class CreateApartmentOwnerRequest : IMapFrom<ApartmentOwner>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalID { get; set; }
        public DateTimeOffset IssueDate { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Nationality { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public Guid AccountID { get; set; }

        public Guid AssignedTeamMemberID { get; set; }
    }
}
