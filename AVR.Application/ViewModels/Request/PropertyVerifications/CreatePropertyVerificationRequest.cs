using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.PropertyVerifications
{
    public class CreatePropertyVerificationRequest : IMapFrom<PropertyVerification>
    {
        [Required]
        public Guid PropertyRequestID { get; set; }

        [Required]
        public VerificationStatus VerificationStatus { get; set; }

        public string LegalDocumentsURL { get; set; }

        public string Comments { get; set; }
    }
}
