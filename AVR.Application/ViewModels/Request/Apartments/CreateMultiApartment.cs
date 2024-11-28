using AVR.Application.Mapper;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Apartments
{
    public class CreateMultiApartment : IMapFrom<Apartment>
    {
        [Required(ErrorMessage = "Vui lòng nhập tên căn hộ.")]
        public string ApartmentName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập diện tích.")]
        public decimal Area { get; set; }

        public string? District { get; set; }

        public string? Ward { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số lượng phòng.")]
        public int NumberOfRooms { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số lượng phòng tắm.")]
        public int NumberOfBathrooms { get; set; }

        public string? Location { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập hướng.")]
        public Direction Direction { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá đề xuất.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày bắt đầu hiệu lực.")]
        public DateTimeOffset EffectiveDate { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày hết hạn.")]
        public DateTimeOffset ExpiryDate { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại căn hộ.")]
        public ApartmentType ApartmentType { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn hướng ban công.")]
        public BalconyDirection BalconyDirection { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tòa nhà.")]
        public string Building { get; set; } // Tòa nhà

        [Required(ErrorMessage = "Vui lòng nhập tầng.")]
        public int Floor { get; set; } // Tầng

        [Required(ErrorMessage = "Vui lòng nhập số phòng.")]
        public int RoomNumber { get; set; } // Số phòng

        public List<IFormFile>? Images { get; set; } = new List<IFormFile>();

        public IFormFile? VRVideoFile { get; set; }

        public Guid AssignedAccountID { get; set; }
    }


}
