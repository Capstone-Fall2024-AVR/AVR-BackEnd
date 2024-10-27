using AVR.Application.ServiceImplements;
using AVR.Application.Services;
using AVR.Infrastructure.DependencyInjection;
using AVR.Infrastructure.Integrations.SignalR;
using AVR.WebAPI.Filters;
using AVR.WebAPI.Middleware;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
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
app.UseCors("CorsPolicy");

// Middleware configuration
app.UseRouting();

app.UseAuthentication();

app.UseMiddleware<ExceptionMiddleware>();
app.UseAuthorization();


app.MapControllers();
app.MapHub<NotificationHub>("/notificationHub");

app.Run();
