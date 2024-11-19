using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.PropertyVerifications
{
    public class ContractSummaryResponse
    {
        public string ContractCode { get; set; } // Mã hợp đồng
        public string ApartmentCode { get; set; } // Mã căn hộ
        public string OwnerName { get; set; } // Tên chủ sở hữu
        public DateTimeOffset EffectiveDate { get; set; } // Ngày bắt đầu
        public DateTimeOffset ExpiryDate { get; set; } // Ngày kết thúc
        public VerificationStatus VerificationStatus { get; set; } // Trạng thái xác minh
        public string LegalDocumentsURL { get; set; } // URL tài liệu pháp lý
    }

}
