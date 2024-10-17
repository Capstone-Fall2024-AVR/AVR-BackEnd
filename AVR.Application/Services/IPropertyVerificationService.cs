using AVR.Application.ViewModels.Request.PropertyVerifications;
using AVR.Application.ViewModels.Response.PropertyVerifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IPropertyVerificationService
    {
        Task<CreatePropertyVerificationResponse> CreatePropertyVerification(CreatePropertyVerificationRequest request);
        Task<IEnumerable<CreatePropertyVerificationResponse>> GetPropertyVerifications();
        Task<CreatePropertyVerificationResponse> GetPropertyVerificationById(Guid verificationId);
    }
}
