using AVR.Application.Mapper;
using Microsoft.AspNetCore.Http;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.ProjectFinancialContract.CreateProjectFinancialContractRequest
{
    public class CreateProjectFinancialContractRequest : IMapFrom<Domain.Entities.ProjectFinancialContract>
    {
        [Required]
        public decimal LowestPrice { get; set; }

        [Required]
        public decimal HighestPrice { get; set; }

        [Required]
        public decimal DepositAmount { get; set; }

        [Required]
        public decimal BrokerageFee { get; set; }

        [Required]
        public decimal CommissionFee_1 { get; set; }

        [Required]
        public Guid ProjectApartmentID { get; set; }
    }
}
