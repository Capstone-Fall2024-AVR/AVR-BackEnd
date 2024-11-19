using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace AVR.Application.ViewModels.Request.Teams
{
    public class CreateTeamRequest : IMapFrom<Team>
    {
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public TeamType TeamType { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ID của tài khoản quản lý.")]
        public Guid ManagerAccountID { get; set; } // ID của Account sẽ làm quản lý nhóm
    }
}
