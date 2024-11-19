using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Teams
{
    public class TeamDetailResponse
    {
        public Guid TeamID { get; set; }
        public string TeamName { get; set; }
        public string Description { get; set; }
        public string ManagerName { get; set; }
        public List<TeamMemberDetailResponse> Members { get; set; }
    }

}
