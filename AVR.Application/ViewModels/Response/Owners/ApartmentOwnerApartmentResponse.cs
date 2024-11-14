using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Owners
{
    public class ApartmentOwnerApartmentResponse: IMapFrom<ApartmentOwnerApartment>
    {
        public Guid ApartmentOwnerApartmentID { get; set; }
        public Guid ApartmentOwnerID { get; set; }
        public Guid AssignedTeamMemberID { get; set; }
        public Guid? ApartmentID { get; set; }
        public string OwnershipStatus { get; set; }
    }
}
