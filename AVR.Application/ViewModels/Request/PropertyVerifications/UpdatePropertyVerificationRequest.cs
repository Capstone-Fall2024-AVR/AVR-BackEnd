using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Http;

public class UpdatePropertyVerificationRequest : IMapFrom<PropertyVerification>
{
    public string? VerificationName { get; set; } // Tên của phiên xác minh

    public VerificationStatus? VerificationStatus { get; set; } // Trạng thái xác nhận

    public List<IFormFile>? LegalDocumentFiles { get; set; } // Danh sách tệp tài liệu pháp lý

    public string? Comments { get; set; } // Ghi chú từ nhân viên xác nhận

    // Thông tin hợp đồng
    public decimal? PropertyValue { get; set; } // Giá trị căn hộ

    public decimal? DepositValue { get; set; } // Giá trị đặt cọc

    public decimal? BrokerageFee { get; set; } // Số tiền môi giới

    public decimal? SecurityDeposit { get; set; } // Tiền ký quỹ

    public decimal? CommissionRate { get; set; } // Tỷ lệ hoa hồng

    public DateTimeOffset? EffectiveDate { get; set; } // Ngày bắt đầu hiệu lực

    public DateTimeOffset? ExpiryDate { get; set; } // Ngày kết thúc hiệu lực
}
