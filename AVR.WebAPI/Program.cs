using AVR.Application.ServiceImplements;
using AVR.Application.Services;
using AVR.Infrastructure.DependencyInjection;
using AVR.Infrastructure.Integrations.SignalR;
using AVR.WebAPI.Filters;
using AVR.WebAPI.Middleware;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder
            .WithOrigins(
            "https://avrcapstone.azurewebsites.net",
            "http://127.0.0.1:5500",  
            "http://localhost:3000",  
            "http://localhost:5174", 
            "http://10.0.2.2:5173",  // Genymotion Emulator  
            "http://10.0.2.2:8081",  // Android Emulator  
            "http://10.0.3.2:8081",  // Genymotion Emulator  
            "http://192.168.1.100:5173",  // LAN IP  
            "http://192.168.1.101:5173",  // LAN IP của thiết bị khác  
            "http://192.168.1.100:8081",  // LAN IP  
            "http://192.168.1.101:8081",  // LAN IP của thiết bị khác  
            "http://expo.dev",  // Thêm domain của Expo nếu cần  
            "http://192.168.1.100:19000"  // Expo local server  
            )
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
            
    });
});
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "AVR API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });

    option.SchemaFilter<OptionalArraySchemaFilter>();
});

builder.Services.Configure<IISServerOptions>(options =>
{
    options.MaxRequestBodySize = 100 * 1024 * 1024;
});

// Configure multipart form options (file size limit)
builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 100 * 1024 * 1024; // 100 MB
});

builder.Services.Configure<IISServerOptions>(options =>
{
    options.MaxRequestBodySize = 100 * 1024 * 1024;
});

builder.Services.Configure<KestrelServerOptions>(options =>
{
    options.Limits.MaxRequestBodySize = 100 * 1024 * 1024; // 100 MB
});
// Configure Kestrel for large file upload
builder.WebHost.ConfigureKestrel(options =>
{
    options.Limits.MaxRequestBodySize = 100 * 1024 * 1024; // 100 MB
});



// Add custom services and dependencies
builder.Services.InfrastructureService(builder.Configuration);


var app = builder.Build();


// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "AVR API V1");
        c.RoutePrefix = string.Empty;
        c.EnableTryItOutByDefault();
    });
}


app.UseHttpsRedirection();


// Middleware configuration
app.UseRouting();
app.UseCors("CorsPolicy");

app.UseAuthentication();

app.UseMiddleware<ExceptionMiddleware>();
app.UseMiddleware<ApiLoggingMiddleware>();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<NotificationHub>("/notificationHub");
    endpoints.MapHub<ChatHub>("/chatHub");
    endpoints.MapControllers();
});

app.Run();
