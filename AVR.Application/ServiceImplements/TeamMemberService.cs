using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Teams;
using AVR.Application.ViewModels.Response.Teams;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class TeamMemberService : ITeamMemberService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<Account> _userManager;

        public TeamMemberService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<Account> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }
        // Get all team members
        public async Task<IEnumerable<TeamMemberResponse>> GetAllTeamMembersAsync()
        {
            var teamMembers = await _unitOfWork.TeamMemberRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TeamMemberResponse>>(teamMembers);
        }

        // Get team member by ID
        public async Task<TeamMemberResponse> GetTeamMemberByIdAsync(Guid id)
        {
            var teamMember = await _unitOfWork.TeamMemberRepository.GetByIdAsync(id);
            if (teamMember == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy thành viên trong team.");

            return _mapper.Map<TeamMemberResponse>(teamMember);
        }

        // Search team members
        public async Task<(IEnumerable<TeamMemberResponse> Results, int TotalItems, int TotalPages)> SearchTeamMembersAsync(
            Guid? teamId,
            Guid? accountId,
            int pageIndex,
            int pageSize)
        {
            // Tạo bộ lọc dựa trên các điều kiện tìm kiếm
            Expression<Func<TeamMember, bool>> filter = tm =>
                (!teamId.HasValue || tm.TeamID == teamId) &&
                (!accountId.HasValue || tm.AccountID == accountId);

            // Đếm tổng số bản ghi phù hợp với bộ lọc (Total Items)
            int totalItems = await _unitOfWork.TeamMemberRepository.CountAsync(filter);

            // Lấy dữ liệu từ repository với bộ lọc và phân trang
            var teamMembers = _unitOfWork.TeamMemberRepository.Get(
                filter: filter,
                orderBy: q => q.OrderBy(tm => tm.TeamID),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Tính tổng số trang (Total Pages)
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Map kết quả sang DTO
            var results = _mapper.Map<IEnumerable<TeamMemberResponse>>(teamMembers);

            return (results, totalItems, totalPages);
        }


        // Create team members (add multiple members to a team)
        public async Task<IEnumerable<TeamMemberResponse>> CreateTeamMembersAsync(Guid teamId, List<Guid> accountIds)
        {
            var team = await _unitOfWork.TeamRepository.GetByIdAsync(teamId);
            if (team == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy team.");

            var teamMembers = new List<TeamMember>();
            foreach (var accountId in accountIds)
            {
                var account = await _unitOfWork.AccountRepository.GetByIdAsync(accountId);
                if (account == null)
                    throw new CustomException.DataNotFoundException($"Không tìm thấy tài khoản với ID {accountId}.");

                // Kiểm tra vai trò của tài khoản (Staff hoặc Seller)
                var isStaffOrSeller = await _userManager.IsInRoleAsync(account, "Staff") || await _userManager.IsInRoleAsync(account, "Seller");
                if (!isStaffOrSeller)
                    throw new CustomException.InvalidDataException($"Tài khoản với ID {accountId} không có vai trò Staff hoặc Seller.");

                // Kiểm tra xem tài khoản đã là thành viên trong team chưa
                var existingTeamMember = _unitOfWork.TeamMemberRepository.Get(tm => tm.TeamID == teamId && tm.AccountID == accountId).FirstOrDefault();
                if (existingTeamMember != null)
                    throw new CustomException.InvalidDataException($"Tài khoản với ID {accountId} đã là thành viên của team.");

                var teamMember = new TeamMember
                {
                    TeamID = teamId,
                    AccountID = accountId,
                    TeamMemberID = Guid.NewGuid()
                };

                teamMembers.Add(teamMember);
                _unitOfWork.TeamMemberRepository.Insert(teamMember);
            }

            await _unitOfWork.SaveAsync();
            return _mapper.Map<IEnumerable<TeamMemberResponse>>(teamMembers);
        }


        // Update team member
        public async Task<TeamMemberResponse> UpdateTeamMemberAsync(Guid teamMemberId, Guid newAccountId)
        {
            var teamMember = await _unitOfWork.TeamMemberRepository.GetByIdAsync(teamMemberId);
            if (teamMember == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy thành viên trong team.");

            var newAccount = await _unitOfWork.AccountRepository.GetByIdAsync(newAccountId);
            if (newAccount == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy tài khoản mới.");

            teamMember.AccountID = newAccountId;
            _unitOfWork.TeamMemberRepository.Update(teamMember);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<TeamMemberResponse>(teamMember);
        }

        // Delete team member
        public async Task<bool> DeleteTeamMemberAsync(Guid teamMemberId)
        {
            var teamMember = await _unitOfWork.TeamMemberRepository.GetByIdAsync(teamMemberId);
            if (teamMember == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy thành viên trong team.");

            _unitOfWork.TeamMemberRepository.Delete(teamMember);
            await _unitOfWork.SaveAsync();

            return true;
        }


        public async Task<IEnumerable<StaffDropdownResponse>> GetAvailableStaffAsync()
        {
            // Lấy danh sách tất cả staff
            var allStaff = await _userManager.Users.ToListAsync();

            // Lấy danh sách các staff đã thuộc team
            var staffInTeams = _unitOfWork.TeamMemberRepository
                .Get(tm => tm.IsManager || !tm.IsManager) // Lấy tất cả TeamMember
                .Select(tm => tm.AccountID)
                .ToHashSet();

            // Map dữ liệu và đánh dấu trạng thái
            var staffResponses = allStaff.Select(staff => new StaffDropdownResponse
            {
                StaffId = staff.Id,
                Name = staff.Name,
                IsAssignedToTeam = staffInTeams.Contains(staff.Id)
            });

            return staffResponses;
        }
    }
}
