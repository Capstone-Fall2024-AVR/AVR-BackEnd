using AVR.Application.Services;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;

public class ApiLogService : IApiLogService
{
    private readonly IUnitOfWork _unitOfWork;

    public ApiLogService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task LogApiUsageAsync(string userId, string useName, string useRole, string path, string method, DateTime timestamp)
    {
        var logEntry = new ApiLog
        {
            UserId = userId,
            UserName = useName,
            UserRole = useRole,
            Path = path,
            Method = method,
            Timestamp = timestamp
        };

        _unitOfWork.ApiLogRepository.Insert(logEntry);
        await _unitOfWork.SaveAsync();
    }
}
