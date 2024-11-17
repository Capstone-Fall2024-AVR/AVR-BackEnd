using AVR.Application.Mapper;
using AVR.Application.ViewModels.Response.FacilitiesRes;
using AVR.Application.ViewModels.Response.ProjectFinancialContract;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;

namespace AVR.Application.ViewModels.Response.Projects
{
    public class ProjectApartmentResponse : IMapFrom<ProjectApartment>
    {
        public Guid ProjectApartmentID { get; set; }
        public string ProjectApartmentName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectApartmentDescription { get; set; }
        public string Price_range { get; set; }
        public string? ApartmentArea { get; set; }
        public string? ProjectArea { get; set; }
        public string? ProjectSize { get; set; }
        public DateTimeOffset? ConstructionStartYear { get; set; }
        public DateTimeOffset? ConstructionEndYear { get; set; }
        public string? Address { get; set; }
        public string? AddressUrl { get; set; }
        public string? TotalApartment { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public string ProjectApartmentStatus { get; set; }
        public Guid ApartmentProjectProviderID { get; set; }
        public string ApartmentProjectProviderName { get; set; }
        public List<ProjectImageResponse> ProjectImages { get; set; }
        public List<FacilityResponse> Facilities { get; set; }
        public string ProjectType { get; set; }
        public string TeamName { get; set; }

        // List of financial contracts
        public List<ProjectFee> FinancialContracts { get; set; }

        //List file
        public List<ProjectFileSearchResponse> ProjectFiles { get; set; }

        // Số lượng căn hộ trong dự án theo trạng thái
        public int TotalApartments { get; set; }
        public Dictionary<ApartmentStatus, int> ApartmentStatusCount { get; set; } = new Dictionary<ApartmentStatus, int>();
    }
}
