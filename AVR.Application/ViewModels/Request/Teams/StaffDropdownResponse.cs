using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Teams
{
    public class StaffDropdownResponse
    {
        public Guid StaffId { get; set; }
        public string Name { get; set; }
        public bool IsAssignedToTeam { get; set; } // true nếu staff đã có team
    }

}
