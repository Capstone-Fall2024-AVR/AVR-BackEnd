using AVR.Domain.Enums;
using AVR.Domain.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class AgreementUpdateRequest
    {
        [Key]
        public Guid AgreementUpdateRequestID { get; set; } = Guid.NewGuid();
        [Required]
        public string RequestTitle { get; set; }
        [Required]
        public string RequestDetails { get; set; }  // Details of the request (e.g., what needs to be updated)
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTimeOffset RequestDate { get; set; } = CoreHelper.SystemTimeNow;
        [Required]
        public DateTimeOffset UpdateDate { get; set; } = CoreHelper.SystemTimeNow;
        [Required]
        public AgreementUpdateType AgreementUpdateType { get; set; }
        [Required]
        public AgreementUpdateStatus AgreementUpdateStatus { get; set; }

        public Guid AccountID { get; set; }
        public virtual Account Accounts { get; set; }
    }
}