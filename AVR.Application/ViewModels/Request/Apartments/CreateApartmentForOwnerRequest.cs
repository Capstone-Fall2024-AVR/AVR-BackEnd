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
        [Required(ErrorMessage = "Tên căn hộ là bắt buộc.")]
        public string ApartmentName { get; set; }

        [Required(ErrorMessage = "Mô tả là bắt buộc.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Địa chỉ là bắt buộc.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Diện tích là bắt buộc.")]
        public decimal Area { get; set; }

        public string? District { get; set; }

        public string? Ward { get; set; }

        [Required(ErrorMessage = "Số lượng phòng là bắt buộc.")]
        public int NumberOfRooms { get; set; }

        [Required(ErrorMessage = "Số lượng phòng tắm là bắt buộc.")]
        public int NumberOfBathrooms { get; set; }

        public string? Location { get; set; }

        [Required(ErrorMessage = "Hướng căn hộ là bắt buộc.")]
        public Direction Direction { get; set; }


        [Required(ErrorMessage = "Loại căn hộ là bắt buộc.")]
        public ApartmentType ApartmentType { get; set; }

        [Required(ErrorMessage = "Hướng ban công là bắt buộc.")]
        public BalconyDirection BalconyDirection { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tòa nhà.")]
        public string Building { get; set; } // Tòa nhà

        [Required(ErrorMessage = "Vui lòng nhập tầng.")]
        public int Floor { get; set; } // Tầng

        [Required(ErrorMessage = "Vui lòng nhập số phòng.")]
        public int RoomNumber { get; set; } // Số phòng

        [Required(ErrorMessage = "ID của PropertyVerification là bắt buộc.")]
        public Guid PropertyVerificationID { get; set; }

        [Required(ErrorMessage = "ID của Dự Án ký gửi là bắt buộc.")]
        public Guid ProjectApartmentID { get; set; }

        public List<IFormFile>? Images { get; set; } = new List<IFormFile>();

        public IFormFile? VRVideoFile { get; set; }
    }


}
