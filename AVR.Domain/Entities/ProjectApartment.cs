using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Utils;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

public class ProjectApartment
{
    [Key]
    public Guid ProjectApartmentID { get; set; } = Guid.NewGuid();

    [Required]
    public string ProjectApartmentName { get; set; }

    [Required]
    public string ProjectCode { get; set; }

    [Required]
    public string ProjectApartmentDescription { get; set; }

    [Required]
    public string Price_range { get; set; }

    [AllowNull]
    public string? ApartmentArea { get; set; }

    [AllowNull]
    public string? ProjectArea { get; set; }

    [AllowNull]
    public string? ProjectSize { get; set; }

    [AllowNull]
    public DateTimeOffset? ConstructionStartYear { get; set; }

    [AllowNull]
    public DateTimeOffset? ConstructionEndYear { get; set; }

    [AllowNull]
    public string? Address { get; set; }

    [AllowNull]
    public string? AddressUrl { get; set; }

    [AllowNull]
    public string? TotalApartment {  get; set; }



    [Required]
    public DateTimeOffset UpdateDate { get; set; } = CoreHelper.SystemTimeNow;

    [Required]
    public DateTimeOffset CreateDate { get; set; } = CoreHelper.SystemTimeNow;

    [Required]
    public ProjectApartmentStatus ProjectApartmentStatus { get; set; }

    [Required]
    public ProjectType ProjectType { get; set; }
    // Foreign Key tới Team
    public Guid? TeamID { get; set; }
    public virtual Team Team { get; set; }

    //ProjectImage
    public virtual ICollection<ProjectImage> ProjectImages { get; set; }

    // Relationship with ApartmentProjectProvider
    public Guid ApartmentProjectProviderID { get; set; }
    public virtual ApartmentProjectProvider ApartmentProjectProvider { get; set; }

    //Project_Access_Log
    public virtual ICollection<ProjectAccessLog> ProjectAccessLogs { get; set; }

    // Direct relationship with Apartments
    public virtual ICollection<Apartment> Apartments { get; set; }

    public virtual ICollection<ProjectFacility> ProjectFacilities { get; set; }
    public virtual ICollection<ProjectFinancialContract> ProjectFinancialContracts { get; set; }
    public virtual ICollection<ProjectFile> ProjectFiles { get; set; }

}
