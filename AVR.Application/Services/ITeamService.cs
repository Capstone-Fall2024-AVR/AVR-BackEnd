using AVR.Application.ViewModels.Request.Teams;
using AVR.Application.ViewModels.Response.Teams;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface ITeamService
    {
        Task<IEnumerable<TeamResponse>> GetAllTeamsAsync();
        Task<TeamResponse> GetTeamByIdAsync(Guid teamId);
        Task<TeamResponse> CreateTeamAsync(CreateTeamRequest request);
        Task<TeamResponse> UpdateTeamAsync(Guid teamId, UpdateTeamRequest request);
        Task<(IEnumerable<TeamResponse> Teams, int TotalItem, int TotalPage)> SearchTeamsAsync(
            string? teamName,
            TeamType? teamType,
            Guid? accountId,
            int pageIndex,
            int pageSize);
    }
}
