using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AVR.Application.ViewModels.Request.PropertyVerifications
{
    public class UpdatePropertyVerificationRequest : IMapFrom<PropertyVerification>
    {
        [Required]
        public string VerificationName { get; set; } // Tên của phiên xác minh

        [Required]
        public VerificationStatus VerificationStatus { get; set; } // Trạng thái xác nhận

        public List<IFormFile>? LegalDocumentFiles { get; set; } // Danh sách tệp tài liệu pháp lý

        public string? Comments { get; set; } // Ghi chú từ nhân viên xác nhận

        // Thông tin hợp đồng
        [Required]
        public decimal PropertyValue { get; set; } // Giá trị căn hộ

        [Required]
        public decimal DepositValue { get; set; } // Giá trị đặt cọc

        [Required]
        public decimal BrokerageFee { get; set; } // Số tiền môi giới

        [Required]
        public decimal SecurityDeposit { get; set; } // Tiền ký quỹ

        [Required]
        public decimal CommissionRate { get; set; } // Tỷ lệ hoa hồng

        [Required]
        public DateTimeOffset EffectiveDate { get; set; } // Ngày bắt đầu hiệu lực

        [Required]
        public DateTimeOffset ExpiryDate { get; set; } // Ngày kết thúc hiệu lực
    }
}
