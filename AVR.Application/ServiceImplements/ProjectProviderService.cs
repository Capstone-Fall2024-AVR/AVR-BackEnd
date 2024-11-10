using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ProjectProviders;
using AVR.Application.ViewModels.Response.ProjectProviders;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class ProjectProviderService : IProjectProviderService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<AccountRole> _roleManager;
        private readonly ISendMail _sendMail;
        public ProjectProviderService(IMapper mapper, IUnitOfWork unitOfWork, UserManager<Account> userManager, RoleManager<AccountRole> roleManager, ISendMail sendMail)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _roleManager = roleManager;
            _sendMail = sendMail;
        }

        public async Task<ApartmentProjectProviderResponse> CreateProjectProvider(CreateApartmentProjectProviderRequest request)
        {
            if (request.Password != request.ConfirmPassword)
            {
                throw new CustomException.InvalidDataException("Mật khẩu và xác nhận mật khẩu không khớp.");
            }

            // Kiểm tra nếu email đã tồn tại
            var existingUser = await _userManager.FindByEmailAsync(request.Email);
            if (existingUser != null)
            {
                throw new CustomException.InvalidDataException("Email đã tồn tại.");
            }

            var account = new Account
            {
                Email = request.Email,
                UserName = request.Email,
                Name = request.Name, // Lưu thêm thông tin tên từ request
                EmailConfirmed = false,
                AccountStatus = AccountStatus.Active,
                LockoutEnabled = true,
                
            };

            // Lưu tài khoản người dùng
            var userCreationResult = await _userManager.CreateAsync(account, request.Password);
            if (!userCreationResult.Succeeded)
            {
                var errors = string.Join("; ", userCreationResult.Errors.Select(e => e.Description));
                throw new CustomException.InvalidDataException($"Tạo tài khoản thất bại: {errors}");
            }

            var roleResult = await _userManager.AddToRoleAsync(account, "Project Provider");
            if (!roleResult.Succeeded)
            {
                throw new CustomException.InvalidDataException("Gán vai trò thất bại.");
            }

            // Ánh xạ thông tin nhà cung cấp dự án từ request và lưu
            var projectProvider = _mapper.Map<ApartmentProjectProvider>(request);
            projectProvider.ApartmentProjectProviderID = Guid.NewGuid();
            projectProvider.AccountID = account.Id; // Liên kết tài khoản với nhà cung cấp dự án
            projectProvider.CreateDate = CoreHelper.SystemTimeNow;
            projectProvider.UpdateDate = CoreHelper.SystemTimeNow;

            _unitOfWork.ApartmentProjectProviderRepository.Insert(projectProvider);
            _unitOfWork.Save();

            // Gửi email xác nhận
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(account);
            await _sendMail.SendEmailAsync(request.Email, "Vui lòng xác nhận email", token);

            return _mapper.Map<ApartmentProjectProviderResponse>(projectProvider);
        }

        public async Task<ApartmentProjectProvider> GetProjectProviderById(Guid id)
        {
            var projectProvider = await _unitOfWork.ApartmentProjectProviderRepository.GetByIdAsync(id);
            if (projectProvider == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy Project Provider.");
            }
            return projectProvider;
        }


        public async Task<IEnumerable<ApartmentProjectProvider>> GetProjectProviders()
        {
            var projectProviders = await _unitOfWork.ApartmentProjectProviderRepository.GetAllAsync();
            if (projectProviders == null)
            {
                throw new CustomException.DataNotFoundException("List Project Provider not found");
            }
            return projectProviders;

        }

        public async Task<(IEnumerable<ApartmentProjectProviderResponse> Providers, int TotalItem)> SearchProjectProviders(
             string? providerName,
             string? location,
             Guid? accountId = null,
             DateTimeOffset? createdAfter = null,
             DateTimeOffset? createdBefore = null,
             int pageIndex = 1,
             int pageSize = 5)
        {
            // Create a filter expression based on provided parameters
            Expression<Func<ApartmentProjectProvider, bool>> filter = provider =>
                (string.IsNullOrEmpty(providerName) || provider.ApartmentProjectProviderName.Contains(providerName)) &&
                (string.IsNullOrEmpty(location) || provider.Location.Contains(location)) &&
                (!accountId.HasValue || provider.AccountID == accountId) &&
                (!createdAfter.HasValue || provider.CreateDate >= createdAfter) &&
                (!createdBefore.HasValue || provider.CreateDate <= createdBefore);

            // Calculate total items based on the filter
            var totalItem = await _unitOfWork.ApartmentProjectProviderRepository.CountAsync(filter);

            // Get the paginated results
            var projectProviders = _unitOfWork.ApartmentProjectProviderRepository.Get(
                filter: filter,
                orderBy: q => q.OrderByDescending(a => a.CreateDate),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            // Map the filtered and paginated results to response objects
            var providersResponse = _mapper.Map<IEnumerable<ApartmentProjectProviderResponse>>(projectProviders);

            return (providersResponse, totalItem);
        }

    }
}
