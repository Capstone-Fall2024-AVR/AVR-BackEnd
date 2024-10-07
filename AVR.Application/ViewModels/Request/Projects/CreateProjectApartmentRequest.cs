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
    public class CreateProjectApartmentRequest : IMapFrom<ProjectApartment>
    {
        [Required(ErrorMessage = "Vui lòng nhập tên dự án.")]
        public string ProjectApartmentName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả dự án.")]
        public string ProjectApartmentDescription { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập khoảng giá.")]
        public string Price_range { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trạng thái của dự án.")]
        public ProjectApartmentStatus ProjectApartmentStatus { get; set; }

        // Khóa ngoại liên kết đến nhà cung cấp dự án
        [Required(ErrorMessage = "Vui lòng nhập ID của nhà cung cấp dự án.")]
        public Guid ApartmentProjectProviderID { get; set; }
    }

}
