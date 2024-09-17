using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class DepositCancelType
    {
        [Key] 
        public Guid DepositCancelTypeID { get; set; } = Guid.NewGuid();
        [Required]
        public string DepositCancelName { get; set;}
        [Required]
        public DateTimeOffset CreateDate { get; set;}
        [Required]
        public DateTimeOffset UpdateDate { get; set;}
        //DepositCancelType
        public virtual ICollection<DepositCancel> DepositCancels { get; set; }

    }
}
