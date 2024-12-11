using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Teams
{
    public class SellerDropdownResponse
    {
        public Guid SellerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAssignedToTeam { get; set; } // True nếu thuộc team, False nếu chưa
    }

}
