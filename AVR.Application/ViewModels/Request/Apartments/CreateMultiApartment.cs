using AVR.Application.Mapper;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AVR.Application.ViewModels.Request.Apartments
{
    public class CreateMultiApartment : IMapFrom<Apartment>
    {
        [Required(ErrorMessage = "Tên căn hộ là bắt buộc.")]
        [MaxLength(100, ErrorMessage = "Tên căn hộ không được vượt quá 100 ký tự.")]
        public string ApartmentName { get; set; }

        [Required(ErrorMessage = "Mô tả căn hộ là bắt buộc.")]
        [MaxLength(500, ErrorMessage = "Mô tả không được vượt quá 500 ký tự.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Địa chỉ căn hộ là bắt buộc.")]
        [MaxLength(300, ErrorMessage = "Địa chỉ không được vượt quá 300 ký tự.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Diện tích căn hộ là bắt buộc.")]
        [Range(1, 10000, ErrorMessage = "Diện tích phải nằm trong khoảng từ 1 đến 10,000 m².")]
        public decimal Area { get; set; }

        [MaxLength(50, ErrorMessage = "Quận không được vượt quá 50 ký tự.")]
        public string? District { get; set; }

        [MaxLength(50, ErrorMessage = "Phường không được vượt quá 50 ký tự.")]
        public string? Ward { get; set; }

        [Required(ErrorMessage = "Số lượng phòng ngủ là bắt buộc.")]
        [Range(1, 10, ErrorMessage = "Số lượng phòng ngủ phải từ 1 đến 10.")]
        public int NumberOfRooms { get; set; }

        [Required(ErrorMessage = "Số lượng phòng tắm là bắt buộc.")]
        [Range(1, 10, ErrorMessage = "Số lượng phòng tắm phải từ 1 đến 10.")]
        public int NumberOfBathrooms { get; set; }

        [MaxLength(200, ErrorMessage = "Vị trí không được vượt quá 200 ký tự.")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Hướng căn hộ là bắt buộc.")]
        public Direction Direction { get; set; }

        [Required(ErrorMessage = "Giá căn hộ là bắt buộc.")]
        [Range(1, 1_000_000_000, ErrorMessage = "Giá căn hộ phải từ 1 đến 1,000,000,000.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Ngày bắt đầu hiệu lực là bắt buộc.")]
        [DataType(DataType.Date)]
        public DateTimeOffset EffectiveDate { get; set; }

        [Required(ErrorMessage = "Ngày hết hạn là bắt buộc.")]
        [DataType(DataType.Date)]
        public DateTimeOffset ExpiryDate { get; set; }

        [Required(ErrorMessage = "Loại căn hộ là bắt buộc.")]
        public ApartmentType ApartmentType { get; set; }

        [Required(ErrorMessage = "Hướng ban công là bắt buộc.")]
        public BalconyDirection BalconyDirection { get; set; }

        [Required(ErrorMessage = "Tòa nhà là bắt buộc.")]
        [MaxLength(100, ErrorMessage = "Tên tòa nhà không được vượt quá 100 ký tự.")]
        public string Building { get; set; } // Tòa nhà

        [Required(ErrorMessage = "Tầng là bắt buộc.")]
        [Range(1, 100, ErrorMessage = "Tầng phải nằm trong khoảng từ 1 đến 100.")]
        public int Floor { get; set; } // Tầng

        [Required(ErrorMessage = "Số phòng là bắt buộc.")]
        [Range(1, 1000, ErrorMessage = "Số phòng phải nằm trong khoảng từ 1 đến 1000.")]
        public int RoomNumber { get; set; } // Số phòng

        // Danh sách file ảnh (nếu có)
        public List<IFormFile>? Images { get; set; } = new List<IFormFile>();

        // Danh sách file video VR (hỗ trợ upload file)
        public List<IFormFile>? VRVideoFiles { get; set; } = new List<IFormFile>();

        [Required(ErrorMessage = "Vui lòng cung cấp ID của nhân viên được chỉ định.")]
        public Guid AssignedAccountID { get; set; }
    }
}
