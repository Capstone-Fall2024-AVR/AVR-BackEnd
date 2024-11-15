using AVR.Application.Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.ProjectFinancialContract.UpdateProjectFinancialContractRequest
{
    public class UpdateProjectFinancialContractRequest : IMapFrom<Domain.Entities.ProjectFinancialContract>
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
        public decimal CommissionFee { get; set; }

        [Required]
        public Guid ProjectApartmentID { get; set; }
    }
}
