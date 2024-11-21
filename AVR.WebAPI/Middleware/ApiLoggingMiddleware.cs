using AVR.Application.Services;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

public class ApiLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public ApiLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, IApiLogService apiLogService)
    {
        // Extract JWT token from the Authorization header
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

        string? userId = null;
        string? userName = null;
        string? userRole = null;

        if (!string.IsNullOrEmpty(token))
        {
            try
            {
                // Decode the JWT token
                var jwtToken = new JwtSecurityTokenHandler().ReadToken(token) as JwtSecurityToken;

                if (jwtToken != null)
                {
                    // Extract claims from the token
                    userId = jwtToken.Claims.FirstOrDefault(c => c.Type == "id")?.Value;
                    userName = jwtToken.Claims.FirstOrDefault(c => c.Type == "name")?.Value;
                    userRole = jwtToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role")?.Value;
                }
            }
            catch
            {
                // Handle invalid token (optional)
                userId = "InvalidToken";
            }
        }

        // Log API request details
        var path = context.Request.Path;
        var method = context.Request.Method;
        var timestamp = DateTime.UtcNow;

        // Save log to the database using IApiLogService
        /*await apiLogService.LogApiUsageAsync(
            userId ?? "Anonymous",
            userName ?? "Anonymous",
            userRole ?? "Anonymous",
            path,
            method,
            timestamp
        );*/

        // Proceed to the next middleware
        await _next(context);
    }
}
