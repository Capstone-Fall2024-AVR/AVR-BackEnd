using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    public class ProjectApartmentApartment
    {
        [Key]  // Đánh dấu đây là khóa chính
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid ProjectApartmentID { get; set; }
        public ProjectApartment ProjectApartment { get; set; }

        public Guid ApartmentID { get; set; }
        public Apartment Apartment { get; set; }

        // Bạn có thể thêm các thuộc tính khác nếu cần thiết
    }

}
