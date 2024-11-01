using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.ProjectProviders
{
    public class AgreementUpdateRequestResponse : IMapFrom<AgreementUpdateRequest>
    {
        public Guid AgreementUpdateRequestID { get; set; }
        public string RequestTitle { get; set; }
        public string RequestDetails { get; set; }
        public string Description { get; set; }
        public DateTimeOffset RequestDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public string AgreementUpdateType { get; set; }
        public string AgreementUpdateStatus { get; set; }
        public Guid AccountID { get; set; }
    }
}
