using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Utils;
using System.ComponentModel.DataAnnotations;

public class ProjectApartment
{
    [Key]
    public Guid ProjectApartmentID { get; set; } = Guid.NewGuid();

    [Required]
    public string ProjectApartmentName { get; set; }

    [Required]
    public string ProjectApartmentDescription { get; set; }

    [Required]
    public string Price_range { get; set; }

    [Required]
    public DateTimeOffset UpdateDate { get; set; } = CoreHelper.SystemTimeNow;

    [Required]
    public DateTimeOffset CreateDate { get; set; } = CoreHelper.SystemTimeNow;

    [Required]
    public ProjectApartmentStatus ProjectApartmentStatus { get; set; }

    [Required]
    public ProjectType ProjectType { get; set; }

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
}
