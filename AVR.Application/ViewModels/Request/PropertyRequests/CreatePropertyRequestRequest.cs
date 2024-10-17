using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.PropertyRequests
{
    public class CreatePropertyRequestRequest : IMapFrom<PropertyRequest>
    {
        [Required]
        public Guid OwnerID { get; set; }  // ID của owner

        [Required(ErrorMessage = "Vui lòng nhập tên căn hộ.")]
        public string PropertyName { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá mong muốn.")]
        public decimal ExpectedPrice { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ căn hộ.")]
        public string Address { get; set; }
    }
}
