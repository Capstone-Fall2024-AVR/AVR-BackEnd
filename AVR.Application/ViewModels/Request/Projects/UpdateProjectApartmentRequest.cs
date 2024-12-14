using AVR.Application.Mapper;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

public class UpdateProjectApartmentRequest : IMapFrom<ProjectApartment>
{
    public string? ProjectApartmentName { get; set; }

    public string? ProjectApartmentDescription { get; set; }

    public string? Price_range { get; set; }

    public string? ApartmentArea { get; set; }
    public string? ProjectArea { get; set; }
    public string? ProjectSize { get; set; }
    public DateTimeOffset? ConstructionStartYear { get; set; }
    public DateTimeOffset? ConstructionEndYear { get; set; }
    public string? Address { get; set; }
    public string? AddressUrl { get; set; }
    public string? TotalApartment { get; set; }

    public string? LicensingAuthority { get; set; }

    public DateTimeOffset? LicensingDate { get; set; }

    public ProjectApartmentStatus? ProjectApartmentStatus { get; set; }

    public ProjectType? ProjectType { get; set; }

    public List<Guid>? FacilityIDs { get; set; }

    public List<IFormFile>? Images { get; set; }
}
