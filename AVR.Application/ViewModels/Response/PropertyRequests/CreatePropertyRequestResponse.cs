using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.PropertyRequests
{
    public class CreatePropertyRequestResponse : IMapFrom<PropertyRequest>
    {
        public Guid RequestID { get; set; }
        public Guid AccountID { get; set; }
        public string PropertyName { get; set; }
        public string Description { get; set; }
        public decimal ExpectedPrice { get; set; }
        public string Address { get; set; }
        public DateTimeOffset RequestDate { get; set; }
        public string RequestStatus { get; set; } // Trạng thái của yêu cầu
    }
}
