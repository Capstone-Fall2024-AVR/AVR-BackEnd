/*using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class Customer
    {
        [Key]
        public Guid CustomerID { get; set; } = Guid.NewGuid();

        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerPhone { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public DateTimeOffset CreateAt { get; set; } = DateTimeOffset.Now;
        [Required]
        public DateTimeOffset UpdateAt { get; set; }
        [Required]
        public string imageUrl { get; set; }
        [Required]
        public Guid AccountID { get; set; }
        // Navigation properties
        public virtual Account Accounts { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }

        public virtual ICollection<RequestApartment> RequestApartments { get; set; }

        public virtual ICollection<ApartmentInteraction> ApartmentInteractions { get; set; } // Updated


    }
}
*/