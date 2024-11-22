using AVR.Application.Mapper;
using AVR.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace AVR.Application.ViewModels.Request.PropertyVerifications
{
    public class PropertyVerificationRequest : IMapFrom<PropertyVerification>
    {
        [Required(ErrorMessage = "Tên hợp đồng là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Tên hợp đồng không được vượt quá 100 ký tự.")]
        public string VerificationName { get; set; }

        [Required(ErrorMessage = "Tài liệu pháp lý là bắt buộc.")]
        public IFormFile LegalDocumentFile { get; set; }

        [MaxLength(500, ErrorMessage = "Ghi chú không được vượt quá 500 ký tự.")]
        public string? Comments { get; set; }

        // Nếu ApartmentOwnerApartmentID đã tồn tại, sử dụng ID này
        public Guid? ApartmentOwnerApartmentID { get; set; }

        // Nếu cần tạo mới ApartmentOwnerApartment
        [Required(ErrorMessage = "ID của chủ sở hữu là bắt buộc nếu chưa có ApartmentOwnerApartment.")]
        public Guid ApartmentOwnerID { get; set; }

        [Required(ErrorMessage = "ID nhân viên được phân công là bắt buộc nếu chưa có ApartmentOwnerApartment.")]
        public Guid AssignedAccountID { get; set; }

        [Required(ErrorMessage = "Giá trị tài sản là bắt buộc.")]
        public decimal PropertyValue { get; set; }

        [Required(ErrorMessage = "Giá trị đặt cọc là bắt buộc.")]
        public decimal DepositValue { get; set; }

        [Required(ErrorMessage = "Phí môi giới là bắt buộc.")]
        public decimal BrokerageFee { get; set; }

        [Required(ErrorMessage = "Tỷ lệ hoa hồng là bắt buộc.")]
        public decimal CommissionRate { get; set; }

        [Required(ErrorMessage = "Ngày bắt đầu hiệu lực là bắt buộc.")]
        [DataType(DataType.Date, ErrorMessage = "Ngày bắt đầu hiệu lực không hợp lệ.")]
        public DateTimeOffset EffectiveDate { get; set; }

        [Required(ErrorMessage = "Ngày kết thúc hiệu lực là bắt buộc.")]
        [DataType(DataType.Date, ErrorMessage = "Ngày kết thúc hiệu lực không hợp lệ.")]
        public DateTimeOffset ExpiryDate { get; set; }
    }
}
