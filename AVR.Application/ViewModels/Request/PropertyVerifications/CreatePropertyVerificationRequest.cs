using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.PropertyVerifications
{
    public class CreatePropertyVerificationRequest : IMapFrom<PropertyVerification>
    {

        // ID của dự án căn hộ liên kết
        [Required(ErrorMessage = "Vui lòng nhập ID của căn hộ.")]
        public Guid ApartmentID { get; set; }  // Thêm ProjectApartmentID vào request
        [Required(ErrorMessage = "Vui lòng đưa file xác thực.")]
        public IFormFile LegalDocumentsURL { get; set; }

        public string Comments { get; set; }
    }
}
