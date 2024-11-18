using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.DepositResponse
{
    public class CreateDepositResponse : IMapFrom<Deposit>
    {
        public Guid DepositID { get; set; }
        public string DepositCode { get; set; }
        public double depositPercentage { get; set; }
        public double depositAmount { get; set; }
        public double paymentAmount { get; set; }
        public double BrokerageFee { get; set; }
        public double CommissionFee { get; set; }
        public double? TradeFee { get; set; }
        public string note { get; set; }
        public string description { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset expiryDate { get; set; }
        public string DepositStatus { get; set; }
        public string DepositType { get; set; }
        public Guid AccountID { get; set; }
        public Guid ApartmentID { get; set; }

        // Profile information from DepositProfile
        public DepositProfileResponse DepositProfile { get; set; }
    }
}
