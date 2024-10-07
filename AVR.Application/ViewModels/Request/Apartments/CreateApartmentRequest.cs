using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace AVR.Application.ViewModels.Request.Apartments
{
    public class CreateApartmentRequest : IMapFrom<Apartment>
    {
        [Required(ErrorMessage = "Vui lòng nhập tên căn hộ.")]
        public string ApartmentName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập diện tích.")]
        public string Area { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số lượng phòng.")]
        public string NumberOfRooms { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập vị trí.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập hướng.")]
        public string Direction { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá trên mét vuông.")]
        public string PricePerSquareMeter { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá đề xuất.")]
        public string RecommendedPrice { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày hết hạn.")]
        public DateTimeOffset ExpiryDate { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn trạng thái căn hộ.")]
        public ApartmentStatus ApartmentStatus { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại căn hộ.")]
        public ApartmentType ApartmentType { get; set; }

        // ID của dự án căn hộ liên kết
        [Required(ErrorMessage = "Vui lòng nhập ID của dự án căn hộ.")]
        public Guid ProjectApartmentID { get; set; }
    }

}
