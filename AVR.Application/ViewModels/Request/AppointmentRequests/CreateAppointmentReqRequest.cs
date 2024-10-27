using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.AppointmentRequests
{
    public class CreateAppointmentReqRequest : IMapFrom<AppointmentRequest>
    {
        [Required]
        public Guid CustomerID { get; set; }
        [Required]
        public Guid ApartmentID { get; set; }
        public DateTimeOffset? PreferredDate { get; set; }
        public TimeSpan? PreferredTime { get; set; }
    }
}
