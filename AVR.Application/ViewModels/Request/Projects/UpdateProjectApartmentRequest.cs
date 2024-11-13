using AVR.Application.Mapper;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AVR.Application.ViewModels.Request.Projects
{
    public class UpdateProjectApartmentRequest : IMapFrom<ProjectApartment>
    {
        [Required(ErrorMessage = "Vui lòng nhập tên dự án.")]
        public string ProjectApartmentName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả dự án.")]
        public string ProjectApartmentDescription { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập khoảng giá.")]
        public string Price_range { get; set; }

        public string? ApartmentArea { get; set; }
        public string? ProjectSize { get; set; }
        public DateTimeOffset? ConstructionStartYear { get; set; }
        public DateTimeOffset? ConstructionEndYear { get; set; }
        public string? Address { get; set; }
        public string? AddressUrl { get; set; }
        public string? TotalApartment { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn trạng thái dự án.")]
        public ProjectApartmentStatus ProjectApartmentStatus { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại dự án.")]
        public ProjectType ProjectType { get; set; }

        [Required(ErrorMessage = "Vui lòng cung cấp danh sách tiện ích.")]
        public List<Guid> FacilityIDs { get; set; }

        public List<IFormFile> Images { get; set; }
    }
}
