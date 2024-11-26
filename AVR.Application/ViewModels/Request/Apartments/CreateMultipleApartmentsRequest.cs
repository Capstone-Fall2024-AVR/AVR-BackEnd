using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Apartments
{
    public class CreateMultipleApartmentsRequest
    {
        [Required]
        public Guid ProjectApartmentID { get; set; }

        // Số lượng căn hộ muốn tạo
        [Required]
        [Range(1, 1000, ErrorMessage = "Số lượng căn hộ phải nằm trong khoảng từ 1 đến 1000.")]
        public int Quantity { get; set; }

        // Thông tin căn hộ mẫu nếu muốn duplicate
        [Required]
        public CreateApartmentRequest SampleApartment { get; set; }
    }
}
