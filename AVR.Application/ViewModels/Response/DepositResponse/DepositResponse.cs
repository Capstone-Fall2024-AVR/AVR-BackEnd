using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Deposits
{
    public class DepositResponse : IMapFrom<Deposit>
    {
        public Guid DepositID { get; set; }
        public double depositPercentage { get; set; }
        public double constractNumber { get; set; }
        public double depositAmount { get; set; }
        public string note { get; set; }
        public string description { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset expiryDate { get; set; }
        public DepositStatus DepositStatus { get; set; }
    }
}
