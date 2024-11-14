using AVR.Application.Mapper;
using AVR.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.PropertyVerifications
{
    public class PropertyVerificationRequest : IMapFrom<PropertyVerification>
    {
        public string VerificationName { get; set; }
        public IFormFile LegalDocumentFile { get; set; }
        public string? Comments { get; set; }
        public Guid ApartmentOwnerApartmentID { get; set; }
        public decimal PropertyValue { get; set; }
        public decimal DepositValue { get; set; }
        public decimal BrokerageFee { get; set; }
        public decimal SecurityDeposit { get; set; }
        public decimal CommissionRate { get; set; }
        public DateTimeOffset EffectiveDate { get; set; }
        public DateTimeOffset ExpiryDate { get; set; }
    }

}
