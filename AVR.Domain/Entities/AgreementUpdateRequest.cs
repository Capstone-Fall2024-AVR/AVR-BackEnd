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
        public string RequestDetails { get; set; }  // Details of the request (e.g., what needs to be updated)
        [Required]
        public DateTimeOffset RequestDate { get; set; } = DateTimeOffset.Now;

        // Foreign Key to ApartmentProjectProvider
        public Guid ApartmentProjectProviderID { get; set; }
        public virtual ApartmentProjectProvider ApartmentProjectProvider { get; set; }

        // Thay thế Management bằng Account
        public Guid AccountID { get; set; }
        public virtual Account Accounts { get; set; }
    }
}