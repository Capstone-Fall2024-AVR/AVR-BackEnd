using AVR.Application.ViewModels.Request.PropertyVerifications;
using AVR.Application.ViewModels.Response.PropertyVerifications;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IPropertyVerificationService
    {
        // Tạo PropertyVerification mới
        Task<PropertyVerificationResponse> CreateAsync(PropertyVerificationRequest request);

        // Lấy tất cả PropertyVerifications
        Task<IEnumerable<PropertyVerificationResponse>> GetAllAsync();

        // Lấy PropertyVerification theo ID
        Task<PropertyVerificationResponse> GetByIdAsync(Guid verificationId);

        // Cập nhật PropertyVerification
        Task<PropertyVerificationResponse> UpdateAsync(Guid verificationId, UpdatePropertyVerificationRequest request);

        // Xóa PropertyVerification
        Task<bool> DeleteAsync(Guid verificationId);

        // Chấp nhận PropertyVerification
        Task<PropertyVerificationResponse> AcceptAsync(Guid verificationId);

        // Từ chối PropertyVerification
        Task<PropertyVerificationResponse> RejectAsync(Guid verificationId);

        // Tìm kiếm PropertyVerifications
        Task<(IEnumerable<PropertyVerificationResponse> Results, int TotalItems, int TotalPages)> SearchAsync(
            string? name = null,
            VerificationStatus? status = null,
            DateTimeOffset? startDate = null,
            DateTimeOffset? endDate = null,
            int pageIndex = 1,
            int pageSize = 10
        );
    }
}
