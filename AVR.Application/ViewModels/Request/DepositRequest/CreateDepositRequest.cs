using AVR.Application.Mapper;
using AVR.Application.ViewModels.Request.DepositRequest;
using AVR.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

public class CreateDepositRequest : IMapFrom<Deposit>
{
    [Required]
    [Range(10, 100, ErrorMessage = "Phần trăm deposit phải từ 10% đến 100%.")]
    public double depositPercentage { get; set; }

    [Required]
    public string note { get; set; } = "Initial deposit for apartment";

    [Required]
    public DateTimeOffset expiryDate { get; set; }

    [Required]
    public Guid AccountID { get; set; }

    [Required]
    public Guid ApartmentID { get; set; }

    // Thêm thông tin hồ sơ deposit
    [Required]
    public CreateDepositProfileRequest DepositProfile { get; set; }
}
