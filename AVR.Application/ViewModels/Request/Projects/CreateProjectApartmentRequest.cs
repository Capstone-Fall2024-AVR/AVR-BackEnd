using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Projects
{
    public class CreateProjectApartmentRequest : IMapFrom<ProjectApartment>
    {
        [Required(ErrorMessage = "Vui lòng nhập tên dự án.")]
        public string ProjectApartmentName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả dự án.")]
        public string ProjectApartmentDescription { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập khoảng giá.")]
        public string Price_range { get; set; }

        // Khóa ngoại liên kết đến nhà cung cấp dự án
        [Required(ErrorMessage = "Vui lòng nhập ID của nhà cung cấp dự án.")]
        public Guid ApartmentProjectProviderID { get; set; }

        [Required(ErrorMessage = "Vui lòng đưa hình ảnh.")]
        public List<IFormFile> Images { get; set; } = new List<IFormFile>();

        [Required(ErrorMessage = "Vui lòng nhập Id của tiện ích.")]
        public List<Guid> FacilityIDs { get; set; }
    }

}
