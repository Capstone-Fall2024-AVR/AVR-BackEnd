using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Apartments
{
    public class CreateApartmentListRequest
    {
        public Guid ProjectApartmentID { get; set; }  // ID của project apartment (nếu tạo cho project)
        public List<CreateApartmentRequest> Apartments { get; set; }  // Danh sách các căn hộ
    }
}
