using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Teams
{

    public class UpdateTeamMemberRequest
    {
        [Required(ErrorMessage = "Vui lòng nhập ID của team.")]
        public Guid TeamId { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ID của thành viên trong team.")]
        public Guid TeamMemberId { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ID tài khoản mới.")]
        public Guid NewAccountId { get; set; }
    }
}
