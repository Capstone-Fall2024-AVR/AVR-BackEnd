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

        /*//AccountRoleID
        public Guid AccountRoleID { get; set; }
        public virtual ICollection<AccountRole> Roles { get; set; }*/

        // Navigation properties
        //FeedbackID
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        //Notification
        public virtual ICollection<Notification> Notifications { get; set; }
        //Customer
        public virtual Customer Customers { get; set; }
        //Staff
        public virtual Staff Staffs { get; set; }
        //Management
        public virtual Management Managements { get; set; }
        
        //ApartmentOwner
        public virtual ApartmentOwner ApartmentOwners { get; set; }
        //ApartmentProjectProvider
        public virtual ApartmentProjectProvider ApartmentProjectProviders { get; set; }
        /*//VR_Access_Log
        public virtual VR_Access_Log VR_Access_Logs { get; set; }*/


    }
}
