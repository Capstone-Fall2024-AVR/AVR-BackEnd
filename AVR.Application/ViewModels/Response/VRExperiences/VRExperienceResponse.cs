using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.VRExperiences
{
    public class VRExperienceResponse : IMapFrom<VRExperience>
    {
        public Guid VRExperienceID { get; set; }
        public string VideoUrlFile { get; set; } // Đường dẫn video của trải nghiệm VR
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public Guid ApartmentID { get; set; } // ID căn hộ liên kết
        public Guid AccountID { get; set; } // ID tài khoản người dùng đã tạo trải nghiệm
    }
}
