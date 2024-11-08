using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AVR.Domain.Utils;

public class Apartment
{
    [Key]
    public Guid ApartmentID { get; set; } = Guid.NewGuid();

    [Required]
    public string ApartmentName { get; set; }
    [Required]
    public string ApartmentCode { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public DateTimeOffset CreatedDate { get; set; } = CoreHelper.SystemTimeNow;

    [Required]
    public DateTimeOffset UpdatedDate { get; set; } = CoreHelper.SystemTimeNow;

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
    public decimal Price { get; set; }  // Giá đề xuất

    [Required]
    public DateTimeOffset ExpiryDate { get; set; }  // Ngày hết hạn

    [Required]
    public ApartmentStatus ApartmentStatus { get; set; }  // Trạng thái căn hộ (enum)

    [Required]
    public ApartmentType ApartmentType { get; set; }  // Loại hình căn hộ (enum)


    [Required]
    public BalconyDirection BalconyDirection { get; set; }  // Hướng ban công (enum)








    // Foreign key for ProjectApartment
    public Guid ProjectApartmentID { get; set; }  // Foreign key
    public virtual ProjectApartment ProjectApartment { get; set; }
    public virtual PropertyVerification PropertyVerification { get; set; }


    // Foreign Key tới TeamMember (người tạo hoặc quản lý căn hộ)
    public Guid? AssignedTeamMemberID { get; set; }
    public virtual TeamMember AssignedTeamMember { get; set; }


    public virtual ICollection<VRExperience> VRExperiences { get; set; }
    public virtual ICollection<ApartmentImage> ApartmentImages { get; set; }
    public virtual ICollection<Appointment> Appointments { get; set; }
    public virtual ICollection<Deposit> Deposits { get; set; }
    public virtual ICollection<ApartmentInteraction> ApartmentInteractions { get; set; }
    public virtual ICollection<RequestApartment> RequestApartments { get; set; }
    public virtual ApartmentOwnerApartment ApartmentOwnerApartment { get; set; }
    public virtual ICollection<AppointmentRequest> AppointmentRequests { get; set; }
}
