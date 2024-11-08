using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Teams;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/teammembers")]
    [ApiController]
    public class TeamMemberController : BaseController
    {
        private readonly ITeamMemberService _teamMemberService;

        public TeamMemberController(ITeamMemberService teamMemberService)
        {
            _teamMemberService = teamMemberService;
        }

        // Get all team members
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllTeamMembers()
        {
            var teamMembers = await _teamMemberService.GetAllTeamMembersAsync();
            return CustomResult("Danh sách thành viên trong team được tải thành công.", teamMembers);
        }

        // Get team member by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeamMemberById(Guid id)
        {
            var teamMember = await _teamMemberService.GetTeamMemberByIdAsync(id);
            return CustomResult("Thông tin thành viên trong team được tải thành công.", teamMember);
        }

        // Search team members
        [HttpGet("search")]
        public async Task<IActionResult> SearchTeamMembers(
            [FromQuery] Guid? teamId,
            [FromQuery] Guid? accountId,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 10)
        {
            var teamMembers = await _teamMemberService.SearchTeamMembersAsync(teamId, accountId, pageIndex, pageSize);
            return CustomResult("Kết quả tìm kiếm thành viên trong team.", teamMembers);
        }

        // Create team members
        [HttpPost("create")]
        public async Task<IActionResult> CreateTeamMembers([FromForm] CreateTeamMembersRequest  request)
        {
            var newTeamMembers = await _teamMemberService.CreateTeamMembersAsync(request.TeamId, request.AccountIds);
            return CustomResult("Thành viên được thêm vào team thành công.", newTeamMembers);
        }

        // Update team member
        [HttpPut("update/{teamMemberId}")]
        public async Task<IActionResult> UpdateTeamMember(Guid teamMemberId, [FromBody] UpdateTeamMemberRequest request)
        {
            var updatedTeamMember = await _teamMemberService.UpdateTeamMemberAsync(teamMemberId, request.NewAccountId);
            return CustomResult("Cập nhật thành viên trong team thành công.", updatedTeamMember);
        }

        [HttpDelete("delete/{teamMemberId}")]
        public async Task<IActionResult> DeleteTeamMember(Guid teamMemberId)
        {
            var updatedTeamMember = await _teamMemberService.DeleteTeamMemberAsync(teamMemberId);
            return CustomResult("Xóa thành viên trong team thành công.", updatedTeamMember);
        }
    }
}
