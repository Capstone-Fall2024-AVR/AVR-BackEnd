using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Teams
{
    public class CreateTeamRequest : IMapFrom<Team>
    {
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public TeamType TeamType { get; set; }
    }
}
