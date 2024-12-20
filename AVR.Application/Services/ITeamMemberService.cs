using AVR.Application.ViewModels.Request.Teams;
using AVR.Application.ViewModels.Response.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface ITeamMemberService
    {
        Task<IEnumerable<TeamMemberResponse>> GetAllTeamMembersAsync();
        Task<TeamMemberResponse> GetTeamMemberByIdAsync(Guid id);
        Task<(IEnumerable<TeamMemberResponse> TeamMembers, int TotalItems, int TotalPages)> SearchTeamMembersAsync(
            string? name,
            Guid? teamId,
            Guid? accountId,
            bool? isManager,
            int pageIndex = 1,
            int pageSize = 10);
        Task<IEnumerable<TeamMemberResponse>> CreateTeamMembersAsync(Guid teamId, List<Guid> accountIds);
        Task<TeamMemberResponse> UpdateTeamMemberAsync(Guid teamMemberId, Guid newAccountId);
        Task<bool> DeleteTeamMemberAsync(Guid teamMemberId);
        Task<(IEnumerable<TeamMemberResponse> TeamMembers, int TotalItems, int TotalPages)> GetTeamMembersByAccountIdAsync(Guid accountId, int pageIndex = 1, int pageSize = 10);


    }
}
