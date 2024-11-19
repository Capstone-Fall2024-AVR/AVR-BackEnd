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
    public class PropertyVerificationResponse : IMapFrom<PropertyVerification>
    {
        public Guid VerificationID { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public string ContractCode { get; set; }
        public string VerificationStatus { get; set; }
        public string VerificationName { get; set; }
        public string LegalDocumentsURL { get; set; }
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
