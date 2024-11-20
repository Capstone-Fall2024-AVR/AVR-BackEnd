using AVR.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Middleware
{
    public class ApiLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public ApiLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IApiLogService apiLogService)
        {
            // Extract user and API details
            var userId = context.User?.FindFirst("sub")?.Value ?? "Anonymous"; // Use JWT `sub` claim or mark as Anonymous
            var path = context.Request.Path;
            var method = context.Request.Method;
            var timestamp = DateTime.UtcNow;

            // Save log
            await apiLogService.LogApiUsageAsync(userId, path, method, timestamp);

            await _next(context);
        }
    }
}
