using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class RequestApartment
    {
        [Key] 
        public int RequestApartmentID { get; set; }
        [Required] 
        public string ResponseMessage { get; set; }
        [Required]
        public string RequestMessage { get; set;}
        [Required]
        public string Note { get; set;}
        [Required]
        public DateTimeOffset CreateDate { get; set;} = DateTimeOffset.Now;
        [Required]
        public DateTimeOffset ResponseDate { get; set;} = DateTimeOffset.Now;

        //Apartment
        public Guid ApartmentID { get; set; }
        public virtual Apartment Apartments { get; set; }
        //Management
        public Guid ManagementID { get; set; }
        public virtual Management Managements { get; set; }
        //Customer
        public Guid CustomerID { get; set; }
        public virtual Customer Customers { get; set; }
        
    }
}
