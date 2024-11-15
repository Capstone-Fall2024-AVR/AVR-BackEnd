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

        [Required(ErrorMessage = "Quận/Huyện là bắt buộc.")]
        public string District { get; set; }

        [Required(ErrorMessage = "Phường/Xã là bắt buộc.")]
        public string Ward { get; set; }

        [Required(ErrorMessage = "Số lượng phòng là bắt buộc.")]
        public int NumberOfRooms { get; set; }

        [Required(ErrorMessage = "Số lượng phòng tắm là bắt buộc.")]
        public int NumberOfBathrooms { get; set; }

        [Required(ErrorMessage = "Vị trí là bắt buộc.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Hướng căn hộ là bắt buộc.")]
        public Direction Direction { get; set; }

        [Required(ErrorMessage = "Giá mỗi mét vuông là bắt buộc.")]
        public decimal PricePerSquareMeter { get; set; }

/*        [Required(ErrorMessage = "Giá đề xuất là bắt buộc.")]
        public decimal Price { get; set; }*/


        [Required(ErrorMessage = "Loại căn hộ là bắt buộc.")]
        public ApartmentType ApartmentType { get; set; }

        [Required(ErrorMessage = "Hướng ban công là bắt buộc.")]
        public BalconyDirection BalconyDirection { get; set; }

        [Required(ErrorMessage = "ID của ApartmentOwnerApartment là bắt buộc.")]
        public Guid ApartmentOwnerApartmentID { get; set; }

        [Required(ErrorMessage = "ID của Dự Án ký gửi là bắt buộc.")]
        public Guid ProjectApartmentID { get; set; }

        public List<IFormFile>? Images { get; set; } = new List<IFormFile>();

        public IFormFile? VRVideoFile { get; set; }
    }

}
