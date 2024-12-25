using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.PropertyVerifications
{
    public class ContractSummaryResponse
    {
        public string ContractCode { get; set; }
        public string ApartmentCode { get; set; }
        public string OwnerName { get; set; }
        public DateTimeOffset EffectiveDate { get; set; }
        public DateTimeOffset ExpiryDate { get; set; }
        public VerificationStatus VerificationStatus { get; set; }
        public List<string> LegalDocumentsURL { get; set; } = new List<string>();
    }


}
