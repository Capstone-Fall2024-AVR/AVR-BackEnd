using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Teams
{
    public class CreateTeamMembersRequest
    {
        [Required(ErrorMessage = "Vui lòng nhập ID của team.")]
        public Guid TeamId { get; set; }

        [Required(ErrorMessage = "Vui lòng cung cấp danh sách các ID tài khoản.")]
        public List<Guid> AccountIds { get; set; }
    }
}
