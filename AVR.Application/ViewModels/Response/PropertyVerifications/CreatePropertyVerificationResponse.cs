using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.PropertyVerifications
{
    public class CreatePropertyVerificationResponse : IMapFrom<PropertyVerification>
    {
        public Guid VerificationID { get; set; }
        public Guid PropertyRequestID { get; set; }
        public Guid VerifiedBy { get; set; }
        public VerificationStatus VerificationStatus { get; set; }
        public string LegalDocumentsURL { get; set; }
        public string Comments { get; set; }
        public DateTimeOffset VerificationDate { get; set; }
    }
}
