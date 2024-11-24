using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.DepositResponse
{
    public class ApartmentInfo
    {
        public Guid ApartmentId { get; set; }
        public string ApartmentCode { get; set; }
        public string ApartmentName { get; set; }
    }
}
