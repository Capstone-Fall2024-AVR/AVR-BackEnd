using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class DepositCancel
    {
        [Key]
        public Guid DepositCancelID { get; set; } = Guid.NewGuid();
        [Required]
        public string RecoveryPrice { get; set; }
        [Required]
        public DateTimeOffset CancelDate { get; set; } = DateTimeOffset.Now;
        [Required]
        public DateTimeOffset RefundDate { get; set; }
        [Required]
        public DateTimeOffset updateAt { get; set; }

        //Deposit
        public Guid DepositID { get; set; }
        public virtual Deposit Deposits { get; set; }

        // Thay thế Management bằng Account
        public Guid AccountID { get; set; }
        public virtual Account Accounts { get; set; }

        //DepositCancelType
        public Guid DepositCancelTypeID { get; set; }
        public virtual DepositCancelType DepositCancelTypes { get; set; }
    }

}
