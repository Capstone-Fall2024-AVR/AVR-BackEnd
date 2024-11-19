using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Teams
{
    public class TeamResponse : IMapFrom<Team>
    {
        public Guid TeamID { get; set; }

        public string TeamCode { get; set; }
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public string TeamType { get; set; }
        public string ManagerName { get; set; } // Tên trưởng nhóm
    }
}
