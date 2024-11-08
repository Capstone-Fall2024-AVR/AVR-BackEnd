using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Teams;
using AVR.Domain.Enums;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{

    [Route("api/v1/teams")]
    [ApiController]
    public class TeamController : BaseController
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        // Get all Teams
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllTeams()
        {
            var teams = await _teamService.GetAllTeamsAsync();
            return CustomResult("Danh sách các team được tải thành công.", teams);
        }

        // Get Team by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeamById(Guid id)
        {
            var team = await _teamService.GetTeamByIdAsync(id);
            return CustomResult("Thông tin team được tải thành công.", team);
        }

        // Create a new Team
        [HttpPost("create")]
        public async Task<IActionResult> CreateTeam([FromBody] CreateTeamRequest request)
        {
            var newTeam = await _teamService.CreateTeamAsync(request);
            return CustomResult("Team mới được tạo thành công.", newTeam);
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateTeam(Guid id, [FromBody] UpdateTeamRequest request)
        {
            var updatedTeam = await _teamService.UpdateTeamAsync(id, request);
            return CustomResult("Thông tin team được cập nhật thành công.", updatedTeam);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchTeams(
                [FromQuery] string? teamName,
                [FromQuery] TeamType? teamType,
                [FromQuery] Guid? accountId,
                [FromQuery] int pageIndex = 1,
                [FromQuery] int pageSize = 10)
        {
            var teams = await _teamService.SearchTeamsAsync(teamName, teamType, accountId, pageIndex, pageSize);
            return CustomResult("Kết quả tìm kiếm các team.", teams);
        }

    }
}
