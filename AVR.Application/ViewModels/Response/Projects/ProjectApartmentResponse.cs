using AVR.Application.Mapper;
using AVR.Application.ViewModels.Response.FacilitiesRes;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Projects
{
    public class ProjectApartmentResponse : IMapFrom<ProjectApartment>
    {
        public Guid ProjectApartmentID { get; set; }
        public string ProjectApartmentName { get; set; }
        public string ProjectApartmentDescription { get; set; }
        public string Price_range { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public string ProjectApartmentStatus { get; set; }

        // Thông tin về nhà cung cấp dự án
        public Guid ApartmentProjectProviderID { get; set; }
        public string ApartmentProjectProviderName { get; set; }
        // Danh sách hình ảnh của dự án
        public List<ProjectImageResponse> ProjectImages { get; set; }

        // Danh sách các tiện ích của dự án
        public List<FacilityResponse> Facilities { get; set; }
        public string ProjectType { get; set; }
        public Guid TeamID { get; set; }
    }

}
