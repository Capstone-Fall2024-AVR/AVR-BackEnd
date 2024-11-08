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


        // Thuộc tính theo dõi số lượng yêu cầu đang xử lý
        public int? ActiveAssignmentCount { get; set; } = 0;

        // Các thuộc tính khác
        public virtual ICollection<RequestAssignment> RequestAssignments { get; set; }



        // One-to-Many relationship for PropertyRequests as Owner
        public virtual ICollection<PropertyRequest> OwnedPropertyRequests { get; set; } 

        // One-to-Many relationship for PropertyRequests as Staff
        public virtual ICollection<PropertyRequest> AssignedPropertyRequests { get; set; }

        // Navigation properties
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ApartmentOwnerApartment ApartmentOwnerApartment { get; set; }
        public virtual ApartmentProjectProvider ApartmentProjectProviders { get; set; }

        // Thay thế Staff bằng Account
        public virtual ICollection<Appointment> Appointments { get; set; }

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

        // Thêm danh sách AppointmentRequest
        public virtual ICollection<AppointmentRequest> CustomerAppointmentRequests { get; set; } // For Customer role
        public virtual ICollection<AppointmentRequest> StaffAppointmentRequests { get; set; } // For Staff role

        // Quan hệ với TeamMember
        public virtual ICollection<TeamMember> TeamMembers { get; set; }

    }

}
