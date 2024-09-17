using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ApartmentInteraction
    {
        [Key]
        public Guid ApartmentInteractionID { get; set; } = Guid.NewGuid();
        [Required] 
        public DateTimeOffset InteractionDate { get; set; } = DateTimeOffset.Now;
        public InteractionType InteractionTypes { get; set; }

        //Account
        public Guid CustomerID { get; set; }
        public virtual Customer Customers { get; set; }
        //Apartment
        public Guid ApartmentID { get; set; }
        public virtual Apartment Apartments { get; set; }
        

    }
}
