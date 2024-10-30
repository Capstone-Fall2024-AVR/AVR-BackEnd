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
    public class Feedback
    {
        [Key]
        public Guid FeedbackID { get; set; } = Guid.NewGuid();
        [Required] 
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public float Rating { get; set; }
        [Required]
        public DateTimeOffset CreateDate { get; set; } = CoreHelper.SystemTimeNow;
        [Required]
        public FeedbackStatus FeedbackStatus { get; set; }

        //Account
        public Guid AccountID { get; set; }
        public virtual Account Accounts { get; set; }
    }
}
