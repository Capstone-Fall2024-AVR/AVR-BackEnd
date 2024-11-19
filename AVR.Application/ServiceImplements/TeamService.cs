using AutoMapper;
using AVR.Application.Services;
using AVR.Application.Utils.GenerateCode;
using AVR.Application.ViewModels.Request.Teams;
using AVR.Application.ViewModels.Response.Teams;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
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
    public class TeamService : ITeamService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<Account> _userManager;
        private readonly IGenerateCode _generateCode;

        public TeamService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<Account> userManager, IGenerateCode generateCode)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
            _generateCode = generateCode;
        }
        public async Task<IEnumerable<TeamResponse>> GetAllTeamsAsync()
        {
            // Lấy danh sách các team
            var teams = await _unitOfWork.TeamRepository.GetAllAsync();
            var teamResponses = _mapper.Map<List<TeamResponse>>(teams);

            // Duyệt qua từng team để lấy thông tin trưởng nhóm
            foreach (var teamResponse in teamResponses)
            {
                // Tìm TeamMember là trưởng nhóm
                var teamMember = _unitOfWork.TeamMemberRepository
                    .Get(v => v.TeamID == teamResponse.TeamID && v.IsManager == true)
                    .FirstOrDefault();

                string managerName = "Không rõ";

                if (teamMember != null)
                {
                    // Lấy thông tin Account của trưởng nhóm
                    var account = _unitOfWork.AccountRepository
                        .Get(i => i.Id == teamMember.AccountID)
                        .FirstOrDefault();

                    if (account != null)
                    {
                        managerName = account.Name; // Gán tên trưởng nhóm
                    }
                }

                // Gán tên trưởng nhóm vào team response
                teamResponse.ManagerName = managerName;
            }

            return teamResponses;
        }

        public async Task<TeamResponse> GetTeamByIdAsync(Guid teamId)
        {
            // Lấy thông tin team
            var team = await _unitOfWork.TeamRepository.GetByIdAsync(teamId);
            if (team == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy team.");

            // Tìm TeamMember là trưởng nhóm
            var teamMember = _unitOfWork.TeamMemberRepository
                .Get(v => v.TeamID == teamId && v.IsManager == true)
                .FirstOrDefault();

            string managerName = "Không rõ";

            if (teamMember != null)
            {
                // Lấy thông tin Account của trưởng nhóm
                var account = _unitOfWork.AccountRepository
                    .Get(i => i.Id == teamMember.AccountID)
                    .FirstOrDefault();

                if (account != null)
                {
                    managerName = account.Name; // Gán tên trưởng nhóm
                }
            }

            // Map thông tin team sang response
            var response = _mapper.Map<TeamResponse>(team);
            response.ManagerName = managerName;

            return response;
        }


        public async Task<TeamResponse> CreateTeamAsync(CreateTeamRequest request)
        {
            // Kiểm tra xem Account (Staff) có tồn tại không
            var account = await _userManager.FindByIdAsync(request.ManagerAccountID.ToString());
            if (account == null || !await _userManager.IsInRoleAsync(account, "Staff"))
            {
                throw new CustomException.DataNotFoundException("Tài khoản không tồn tại hoặc không có vai trò Staff.");
            }

            // Kiểm tra xem tài khoản này đã là manager của team nào chưa
            var existingTeamMember = _unitOfWork.TeamMemberRepository
                .Get(tm => tm.AccountID == request.ManagerAccountID && tm.IsManager)
                .FirstOrDefault();

            if (existingTeamMember != null)
            {
                throw new CustomException.InvalidDataException("Tài khoản đã là trưởng nhóm của một team khác.");
            }

            // Tạo Team
            var team = _mapper.Map<Team>(request);
            team.TeamCode = "string";
            _unitOfWork.TeamRepository.Insert(team);
            await _unitOfWork.SaveAsync();

            // Tạo TeamMember và gắn với Account
            var teamMember = new TeamMember
            {
                AccountID = request.ManagerAccountID,
                TeamID = team.TeamID,
                IsManager = true,
            };

            _unitOfWork.TeamMemberRepository.Insert(teamMember);
            await _unitOfWork.SaveAsync();

            team.TeamCode = await _generateCode.GenerateTeamCode(team.TeamID);
            _unitOfWork.TeamRepository.Update(team);
            await _unitOfWork.SaveAsync();

            // Trả về response với thông tin team
            var response = _mapper.Map<TeamResponse>(team);
            response.ManagerName = account.Name;
            return response;
        }



        public async Task<TeamResponse> UpdateTeamAsync(Guid teamId, UpdateTeamRequest request)
        {
            var team = await _unitOfWork.TeamRepository.GetByIdAsync(teamId);
            if (team == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy team.");

            // Cập nhật thông tin team
            _mapper.Map(request, team);
            _unitOfWork.TeamRepository.Update(team);

            // Cập nhật trưởng nhóm nếu có thay đổi
            if (request.ManagerAccountID.HasValue)
            {
                var managerAccount = await _userManager.FindByIdAsync(request.ManagerAccountID.ToString());
                if (managerAccount == null || !await _userManager.IsInRoleAsync(managerAccount, "Staff"))
                {
                    throw new CustomException.DataNotFoundException("Tài khoản không tồn tại hoặc không có vai trò Staff.");
                }

                // Kiểm tra xem tài khoản này đã là manager của team nào chưa
                var existingTeamMember = _unitOfWork.TeamMemberRepository
                    .Get(tm => tm.AccountID == request.ManagerAccountID && tm.IsManager && tm.TeamID != teamId)
                    .FirstOrDefault();

                if (existingTeamMember != null)
                {
                    throw new CustomException.InvalidDataException("Tài khoản đã là trưởng nhóm của một team khác.");
                }

                // Xóa trưởng nhóm cũ (nếu có)
                var existingManager = team.TeamMembers.FirstOrDefault(tm => tm.IsManager);
                if (existingManager != null)
                {
                    _unitOfWork.TeamMemberRepository.Delete(existingManager);
                }

                // Thêm trưởng nhóm mới
                var newManager = new TeamMember
                {
                    AccountID = request.ManagerAccountID.Value,
                    TeamID = team.TeamID,
                    IsManager = true
                };
                _unitOfWork.TeamMemberRepository.Insert(newManager);
            }

            await _unitOfWork.SaveAsync();
            return _mapper.Map<TeamResponse>(team);
        }



        public async Task<(IEnumerable<TeamResponse> Teams, int TotalItem, int TotalPage)> SearchTeamsAsync(
            string? keyword,
            TeamType? teamType,
            Guid? accountId,
            int pageIndex,
            int pageSize)
        {
            // Tìm tất cả các TeamMember là trưởng nhóm
            var managerTeamMembers = _unitOfWork.TeamMemberRepository
                .Get(tm => tm.IsManager)
                .ToList();

            // Lọc các Account tương ứng với từ khóa trong tên trưởng nhóm (nếu có)
            IEnumerable<Guid> filteredManagerIds = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                filteredManagerIds = _unitOfWork.AccountRepository
                    .Get(a => a.Name.Contains(keyword))
                    .Select(a => a.Id)
                    .ToList();
            }

            // Create a filter expression based on the provided parameters
            Expression<Func<Team, bool>> filter = t =>
                (string.IsNullOrEmpty(keyword) || t.TeamName.Contains(keyword) ||
                 (filteredManagerIds != null && t.TeamMembers.Any(tm => tm.IsManager && filteredManagerIds.Contains(tm.AccountID)))) &&
                (!teamType.HasValue || t.TeamType == teamType) &&
                (!accountId.HasValue || t.TeamMembers.Any(tm => tm.AccountID == accountId));

            // Calculate total items based on the filter
            var totalItem = await _unitOfWork.TeamRepository.CountAsync(filter);

            // Calculate total pages
            var totalPage = (int)Math.Ceiling((double)totalItem / pageSize);

            // Get the paginated results with the filter applied
            var teams = _unitOfWork.TeamRepository.Get(
                filter: filter,
                orderBy: q => q.OrderBy(t => t.TeamName),
                pageIndex: pageIndex,
                pageSize: pageSize
            ).ToList();

            // Map the teams to TeamResponse
            var teamResponses = _mapper.Map<List<TeamResponse>>(teams);

            // Add ManagerName to each TeamResponse
            foreach (var teamResponse in teamResponses)
            {
                // Find the TeamMember who is the manager
                var teamMember = managerTeamMembers.FirstOrDefault(tm => tm.TeamID == teamResponse.TeamID && tm.IsManager);

                string resolvedManagerName = "Không rõ";

                if (teamMember != null)
                {
                    // Get the Account information of the manager
                    var account = _unitOfWork.AccountRepository
                        .Get(i => i.Id == teamMember.AccountID)
                        .FirstOrDefault();

                    if (account != null)
                    {
                        resolvedManagerName = account.Name; // Set the manager's name
                    }
                }

                // Set the ManagerName in the response
                teamResponse.ManagerName = resolvedManagerName;
            }

            // Return the result
            return (teamResponses, totalItem, totalPage);
        }



        public async Task<IEnumerable<StaffDropdownResponse>> GetAvailableStaffAsync()
        {
            // Lấy danh sách tất cả tài khoản thuộc vai trò "Staff"
            var staffRole = await _userManager.GetUsersInRoleAsync("Staff");

            // Lấy danh sách các staff đã thuộc team
            var staffInTeams = _unitOfWork.TeamMemberRepository
                .Get(tm => tm.IsManager || !tm.IsManager) // Lấy tất cả TeamMember
                .Select(tm => tm.AccountID)
                .ToHashSet();

            // Map dữ liệu và đánh dấu trạng thái
            var staffResponses = staffRole.Select(staff => new StaffDropdownResponse
            {
                StaffId = staff.Id,
                Name = staff.Name,
                IsAssignedToTeam = staffInTeams.Contains(staff.Id)
            });

            return staffResponses;
        }

        public async Task<(TeamDetailResponse TeamDetails, int TotalItem, int TotalPage, int PageIndex, int PageSize)> GetTeamByIDetailsAsync(Guid teamId, int pageIndex, int pageSize)
        {
            // Lấy thông tin nhóm
            var team = await _unitOfWork.TeamRepository.GetByIdAsync(teamId);
            if (team == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy nhóm.");

            // Lấy thông tin trưởng nhóm
            var manager = _unitOfWork.TeamMemberRepository.Get(tm => tm.TeamID == teamId && tm.IsManager, includeProperties: "Account")
                .Select(tm => tm.Account)
                .FirstOrDefault();

            // Lấy tổng số thành viên trong nhóm
            var totalItems = await _unitOfWork.TeamMemberRepository.CountAsync(tm => tm.TeamID == teamId);

            // Tính tổng số trang
            var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Lấy danh sách thành viên trong nhóm với phân trang
            var teamMembers = _unitOfWork.TeamMemberRepository.Get(
                filter: tm => tm.TeamID == teamId,
                includeProperties: "Account",
                orderBy: q => q.OrderBy(tm => tm.Account.Name),
                pageIndex: pageIndex,
                pageSize: pageSize
            ).Select(tm => new TeamMemberDetailResponse
            {
                Name = tm.Account.Name,
                PhoneNumber = tm.Account.PhoneNumber,
                Email = tm.Account.Email,
                Status = tm.Account.LockoutEnabled && tm.Account.LockoutEnd.HasValue && tm.Account.LockoutEnd > DateTimeOffset.UtcNow
                    ? "Vô hiệu hóa"
                    : "Đang hoạt động"
            }).ToList();

            // Map thông tin chi tiết nhóm
            var response = new TeamDetailResponse
            {
                TeamID = team.TeamID,
                TeamName = team.TeamName,
                Description = team.TeamDescription,
                ManagerName = manager?.Name ?? "Không rõ",
                Members = teamMembers
            };

            return (response, totalItems, totalPages, pageIndex, pageSize);
        }




    }
}
