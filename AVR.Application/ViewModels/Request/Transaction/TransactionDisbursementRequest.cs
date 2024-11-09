using AVR.Application.Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Transaction.TransactionDisbursementRequest
{
    public class TransactionDisbursementRequest
    {
        [Required]
        public Guid ProjectId { get; set; }
    }
}
