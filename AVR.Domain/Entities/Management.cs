/*using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class Management
    {
        [Key]
        public Guid ManagementID { get; set; } = Guid.NewGuid();
        [Required]
        public string ManagementName { get; set; }
        [Required]
        public string ManagementPhone { get; set; }
        [Required]
        public string ManagementEmail { get; set; }
        [Required]
        public string imageUrl { get; set; }
        [Required]
        public DateTimeOffset CreateAt { get; set; } = DateTimeOffset.Now;
        [Required]
        public DateTimeOffset UpdateAt { get; set; }
        public Guid AccountID { get; set; }

        // Navigation properties
        public virtual Account Accounts { get; set; }
        public virtual ICollection<DepositCancel> DepositCancels { get; set; }
        public virtual ICollection<RequestApartment> RequestApartments { get; set; }
        public virtual ICollection<ProjectApartment> ProjectApartments { get; set; }
        public virtual ICollection<AgreementUpdateRequest> AgreementUpdateRequests { get; set; }  // New Navigation Property

    }
}
*/