using AVR.Application.Mapper;
using AVR.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.DepositRequest
{
    public class CreateDepositProfileRequest : IMapFrom<DepositProfile>
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string IdentityCardNumber { get; set; }

        [Required]
        public DateTime DateOfIssue { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        // Ảnh mặt trước và mặt sau sẽ là file tải lên
        [Required]
        public IFormFile IdentityCardFrontImage { get; set; }  // Ảnh CCCD mặt trước

        [Required]
        public IFormFile IdentityCardBackImage { get; set; }  // Ảnh CCCD mặt sau
    }
}
