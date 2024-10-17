using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Apartment
{
    [Key]
    public Guid ApartmentID { get; set; } = Guid.NewGuid();

    [Required]
    public string ApartmentName { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.Now;

    [Required]
    public DateTimeOffset UpdatedDate { get; set; } = DateTimeOffset.Now;

    [Required]
    public string Address { get; set; }

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Area { get; set; }  // Diện tích căn hộ (đơn vị: m2)
    [Required]
    public string District { get; set; }  // Quận, Huyện

    [Required]
    public string Ward { get; set; }  // Phường, Xã

    [Required]
    public int NumberOfRooms { get; set; }  // Số phòng ngủ

    [Required]
    public int NumberOfBathrooms { get; set; }  // Số phòng tắm

    [Required]
    public string Location { get; set; }

    [Required]
    public Direction Direction { get; set; }  // Hướng nhà (enum)

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal PricePerSquareMeter { get; set; }  // Giá mỗi mét vuông

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal RecommendedPrice { get; set; }  // Giá đề xuất

    [Required]
    public DateTimeOffset ExpiryDate { get; set; }  // Ngày hết hạn

    [Required]
    public ApartmentStatus ApartmentStatus { get; set; }  // Trạng thái căn hộ (enum)

    [Required]
    public ApartmentType ApartmentType { get; set; }  // Loại hình căn hộ (enum)

    [Required]
    public SaleStatus SaleStatus { get; set; }  // Trạng thái bán hàng (enum)

    [Required]
    public BalconyDirection BalconyDirection { get; set; }  // Hướng ban công (enum)

    // Foreign key for ProjectApartment
    public Guid ProjectApartmentID { get; set; }  // Foreign key
    public virtual ProjectApartment ProjectApartment { get; set; }

    // Foreign key to PropertyVerification
    public Guid? VerificationID { get; set; }  // Foreign key to PropertyVerification
    public virtual PropertyVerification PropertyVerification { get; set; }

    // Navigation properties
    public virtual ICollection<ApartmentFacility> ApartmentFacilities { get; set; }
    public virtual ICollection<VRExperience> VRExperiences { get; set; }
    public virtual ICollection<ApartmentImage> ApartmentImages { get; set; }
    public virtual ICollection<Appointment> Appointments { get; set; }
    public virtual ICollection<Deposit> Deposits { get; set; }
    public virtual ICollection<ApartmentInteraction> ApartmentInteractions { get; set; }
    public virtual ICollection<RequestApartment> RequestApartments { get; set; }
    public virtual ICollection<ApartmentOwnerApartment> ApartmentOwnerApartments { get; set; }
}
