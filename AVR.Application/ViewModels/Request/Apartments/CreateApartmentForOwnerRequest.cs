using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AVR.Application.ViewModels.Request.Apartments
{
    public class CreateApartmentForOwnerRequest : IMapFrom<Apartment>
    {
        [Required(ErrorMessage = "Vui lòng nhập tên căn hộ.")]
        public string ApartmentName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập diện tích.")]
        public decimal Area { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Quận, Huyện.")]
        public string District { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Phường, Xã.")]
        public string Ward { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số lượng phòng.")]
        public int NumberOfRooms { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số lượng phòng tắm.")]
        public int NumberOfBathrooms { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập vị trí.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập hướng.")]
        public Direction Direction { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá trên mét vuông.")]
        public decimal PricePerSquareMeter { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá đề xuất.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày hết hạn.")]
        public DateTimeOffset ExpiryDate { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại căn hộ.")]
        public ApartmentType ApartmentType { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn hướng ban công.")]
        public BalconyDirection BalconyDirection { get; set; }

        // ID của dự án căn hộ liên kết
        [Required(ErrorMessage = "Vui lòng nhập ID của dự án căn hộ.")]
        public Guid ProjectApartmentID { get; set; }  // Thêm ProjectApartmentID vào request

        // ID của chủ sở hữu căn hộ liên kết
        [Required(ErrorMessage = "Vui lòng nhập ID của chủ sở hữu căn hộ.")]
        public Guid AccountID { get; set; }

        public List<IFormFile>? Images { get; set; } = new List<IFormFile>();

        // Tệp video VR cho trải nghiệm VR
        public IFormFile? VRVideoFile { get; set; }
        // ID của nhân viên liên kết tạo VRExperience
        [Required(ErrorMessage = "Vui lòng nhập ID của nhân viên tạo trải nghiệm VR.")]
        public Guid StaffID { get; set; }
    }
}
