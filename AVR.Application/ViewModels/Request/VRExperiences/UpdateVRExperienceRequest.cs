using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.VRExperiences
{
    public class UpdateVRExperienceRequest : IMapFrom<VRExperience>
    {
        public string? VideoUrlFile { get; set; } // Đường dẫn video mới cho trải nghiệm, nếu cần cập nhật
    }
}
