using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Teams
{
    public class TeamMemberResponse : IMapFrom<TeamMember>
    {
        public Guid TeamMemberID { get; set; }
        public Guid AccountID { get; set; }
        public string Name { get; set; } 
        public string PhoneNumber { get; set; }
        public string Email { get; set; } 
        public Guid TeamID { get; set; }
        public bool IsManager { get; set; }
    }
}
