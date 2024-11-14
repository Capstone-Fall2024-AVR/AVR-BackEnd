using AVR.Application.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.ProjectFinancialContract
{
    public class ProjectFinancialContractResponse : IMapFrom<Domain.Entities.ProjectFinancialContract>
    {
        public Guid FinancialContractID { get; set; }
        public decimal LowestPrice { get; set; }
        public decimal HighestPrice { get; set; }
        public decimal DepositAmount { get; set; }
        public decimal BrokerageFee { get; set; }
        public decimal CommissionFee_1 { get; set; }
        public Guid ProjectApartmentID { get; set; }
    }
}
