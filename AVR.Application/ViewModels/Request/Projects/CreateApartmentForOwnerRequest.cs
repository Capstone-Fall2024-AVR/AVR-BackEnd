using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Projects
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

        // ID của chủ sở hữu căn hộ (Account)
        [Required(ErrorMessage = "Vui lòng nhập ID của chủ sở hữu căn hộ.")]
        public Guid AccountID { get; set; }
    }

}
