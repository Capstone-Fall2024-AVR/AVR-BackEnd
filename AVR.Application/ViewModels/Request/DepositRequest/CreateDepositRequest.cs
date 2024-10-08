using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Deposits
{
    public class CreateDepositRequest : IMapFrom<Deposit>
    {
        [Required]
        [Range(10, 100, ErrorMessage = "Phần trăm deposit phải từ 10% đến 100%.")]
        public double depositPercentage { get; set; }

        [Required]
        public double constractNumber { get; set; }

        [Required]
        public string note { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public DateTimeOffset expiryDate { get; set; }

        [Required]
        public Guid AccountID { get; set; }

        [Required]
        public Guid ApartmentID { get; set; }
    }
}
