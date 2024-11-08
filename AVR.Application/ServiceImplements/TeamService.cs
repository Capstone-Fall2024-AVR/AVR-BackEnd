using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Teams;
using AVR.Application.ViewModels.Response.Teams;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class TeamService : ITeamService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TeamService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TeamResponse>> GetAllTeamsAsync()
        {
            var teams = await _unitOfWork.TeamRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TeamResponse>>(teams);
        }

        public async Task<TeamResponse> GetTeamByIdAsync(Guid teamId)
        {
            var team = await _unitOfWork.TeamRepository.GetByIdAsync(teamId);
            if (team == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy team.");

            return _mapper.Map<TeamResponse>(team);
        }

        public async Task<TeamResponse> CreateTeamAsync(CreateTeamRequest request)
        {
            var team = _mapper.Map<Team>(request);

            _unitOfWork.TeamRepository.Insert(team);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<TeamResponse>(team);
        }

        public async Task<TeamResponse> UpdateTeamAsync(Guid teamId, UpdateTeamRequest request)
        {
            var team = await _unitOfWork.TeamRepository.GetByIdAsync(teamId);
            if (team == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy team.");

            _mapper.Map(request, team);
            _unitOfWork.TeamRepository.Update(team);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<TeamResponse>(team);
        }


        public async Task<IEnumerable<TeamResponse>> SearchTeamsAsync(string? teamName, TeamType? teamType, Guid? accountId, int pageIndex, int pageSize)
        {
            // Tạo điều kiện tìm kiếm
            Expression<Func<Team, bool>> filter = t =>
                (string.IsNullOrEmpty(teamName) || t.TeamName.Contains(teamName)) &&
                (!teamType.HasValue || t.TeamType == teamType) &&
                (!accountId.HasValue || t.TeamMembers.Any(tm => tm.AccountID == accountId));

            // Lấy danh sách team từ repository với filter và phân trang
            var teams = _unitOfWork.TeamRepository.Get(
                filter: filter,
                orderBy: q => q.OrderBy(t => t.TeamName),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Map kết quả thành response
            return _mapper.Map<IEnumerable<TeamResponse>>(teams);
        }
    }
}
