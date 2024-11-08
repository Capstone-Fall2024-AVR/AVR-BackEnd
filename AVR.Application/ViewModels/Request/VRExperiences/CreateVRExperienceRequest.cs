using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.VRExperiences
{
    public class CreateVRExperienceRequest : IMapFrom<VRExperience>
    {
        [Required]
        public string VideoUrlFile { get; set; } // Đường dẫn video cho trải nghiệm VR

        [Required]
        public Guid ApartmentID { get; set; } // ID căn hộ liên kết với trải nghiệm

        [Required]
        public Guid assignedTeamMemberID { get; set; } // ID tài khoản người dùng đã tạo trải nghiệm
    }
}
