using AVR.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class Account : IdentityUser<Guid>
    {
        [Required]
        public AccountStatus AccountStatus { get; set; }
        public string? Name { get; set; }
        public string? Avatar { get; set; }

        public string? EmailConfirmationOtp { get; set; }
        public DateTime? OtpExpiryTime { get; set; }

        // Navigation properties
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<ApartmentOwnerApartment> ApartmentOwnerApartments { get; set; }
        public virtual ApartmentProjectProvider ApartmentProjectProviders { get; set; }

        // Thay thế Staff bằng Account
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<VRExperience> VRExperiences { get; set; }

        // Thay thế Customer bằng Account
        public virtual ICollection<ApartmentInteraction> ApartmentInteractions { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }

        // Thêm các navigation properties sau khi thay thế Management
        public virtual ICollection<RequestApartment> RequestApartments { get; set; }
        public virtual ICollection<DepositCancel> DepositCancels { get; set; }
        public virtual ICollection<ProjectApartment> ProjectApartments { get; set; }
        public virtual ICollection<AgreementUpdateRequest> AgreementUpdateRequests { get; set; }

        // Separate navigation properties for Appointments based on roles
        public virtual ICollection<Appointment> CustomerAppointments { get; set; } // For Customer role
        public virtual ICollection<Appointment> StaffAppointments { get; set; } // For Staff role
        public virtual ICollection<Appointment> ProjectProviderAppointments { get; set; } // For Project Provider role
    }

}
