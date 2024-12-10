using AVR.Application.Mapper;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace AVR.Application.ViewModels.Request.Apartments
{
    public class UpdateApartmentRequest : IMapFrom<Apartment>
    {
        public string? ApartmentName { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public decimal? Area { get; set; } // Diện tích căn hộ (m2)
        public string? District { get; set; } // Quận
        public string? Ward { get; set; } // Phường
        public int? NumberOfRooms { get; set; } // Số phòng ngủ
        public int? NumberOfBathrooms { get; set; } // Số phòng tắm
        public string? Location { get; set; }
        public Direction? Direction { get; set; } // Hướng nhà (enum)
        public decimal? PricePerSquareMeter { get; set; } // Giá mỗi mét vuông
        public decimal? Price { get; set; } // Giá
        public DateTimeOffset? EffectiveStartDate { get; set; } // Ngày bắt đầu hiệu lực
        public DateTimeOffset? ExpiryDate { get; set; } // Ngày hết hạn
        public ApartmentStatus? ApartmentStatus { get; set; } // Trạng thái căn hộ (enum)
        public ApartmentType? ApartmentType { get; set; } // Loại căn hộ (enum)
        public PossessionType? PossessionType { get; set; } // Loại hình sở hữu (enum)
        public BalconyDirection? BalconyDirection { get; set; } // Hướng ban công (enum)
        public string? Building { get; set; } // Tòa nhà
        public int? Floor { get; set; } // Tầng
        public int? RoomNumber { get; set; } // Số phòng
        public Guid? ProjectApartmentID { get; set; } // Liên kết với dự án
        public Guid? AssignedAccountID { get; set; } // Nhân viên phụ trách
        public Guid? PropertyVerificationID { get; set; } // Thông tin xác minh tài sản
        public List<IFormFile>? Images { get; set; } // Hình ảnh mới (nếu có)
        public List<IFormFile>? VRVideoFiles { get; set; } // Danh sách video VR mới (nếu có)
    }
}
