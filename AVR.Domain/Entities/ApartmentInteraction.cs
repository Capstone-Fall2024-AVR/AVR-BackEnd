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
    public class ApartmentInteraction
    {
        [Key]
        public Guid ApartmentInteractionID { get; set; } = Guid.NewGuid();
        [Required]
        public DateTimeOffset InteractionDate { get; set; } = CoreHelper.SystemTimeNow;
        public InteractionType InteractionTypes { get; set; }

        // Replace Customer with Account
        public Guid AccountID { get; set; }
        public virtual Account Accounts { get; set; }

        //Apartment
        public Guid ApartmentID { get; set; }
        public virtual Apartment Apartments { get; set; }
    }

}
