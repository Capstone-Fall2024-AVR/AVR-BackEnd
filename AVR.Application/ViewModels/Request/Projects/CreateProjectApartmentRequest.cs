using AVR.Application.Mapper;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        public string? ApartmentArea { get; set; }
        public string? ProjectArea { get; set; }
        public string? ProjectSize { get; set; }
        public DateTimeOffset? ConstructionStartYear { get; set; }
        public DateTimeOffset? ConstructionEndYear { get; set; }
        public string? Address { get; set; }
        public string? AddressUrl { get; set; }
        public string? TotalApartment { get; set; }

        
        public Guid? ApartmentProjectProviderID { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Id của tiện ích.")]
        public List<Guid> FacilityIDs { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại dự án.")]
        public ProjectType ProjectType { get; set; }

        public Guid? TeamID { get; set; }

        [Required(ErrorMessage = "Vui lòng đưa hình ảnh.")]
        public List<IFormFile> Images { get; set; } = new List<IFormFile>();
    }
}
