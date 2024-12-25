using AVR.Application.Mapper;
using AVR.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.PropertyVerifications
{
    public class RenewContractRequest : IMapFrom<PropertyVerification>
    {
        [Required(ErrorMessage = "ID căn hộ là bắt buộc.")]
        public Guid ApartmentID { get; set; }

        [Required(ErrorMessage = "Tên hợp đồng là bắt buộc.")]
        public string VerificationName { get; set; }

        [Required(ErrorMessage = "Giá trị căn hộ là bắt buộc.")]
        public decimal PropertyValue { get; set; }

        [Required(ErrorMessage = "Giá trị đặt cọc là bắt buộc.")]
        public decimal DepositValue { get; set; }

        [Required(ErrorMessage = "Phí môi giới là bắt buộc.")]
        public decimal BrokerageFee { get; set; }

        [Required(ErrorMessage = "Tiền ký quỹ là bắt buộc.")]
        public decimal SecurityDeposit { get; set; }

        [Required(ErrorMessage = "Tỷ lệ hoa hồng là bắt buộc.")]
        public decimal CommissionRate { get; set; }

        [Required(ErrorMessage = "Ngày bắt đầu hiệu lực là bắt buộc.")]
        public DateTimeOffset EffectiveDate { get; set; }

        [Required(ErrorMessage = "Ngày hết hạn là bắt buộc.")]
        public DateTimeOffset ExpiryDate { get; set; }

        public List<IFormFile> LegalDocumentFiles { get; set; } // Tệp tài liệu pháp lý mới, nếu có
    }

}
