using AVR.Application.Mapper;
using AVR.Application.ServiceImplements;
using AVR.Application.Services;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using AVR.Infrastructure.Authentication;
using AVR.Infrastructure.Data;
using AVR.Infrastructure.Integrations.Firebase;
using AVR.Infrastructure.Integrations.Mail;
using AVR.Infrastructure.Integrations.Quartz;
using AVR.Infrastructure.Integrations.SignalR;
using AVR.Infrastructure.Repository;
using Firebase.Auth;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using FirebaseConfig = AVR.Infrastructure.Integrations.Firebase.FirebaseConfig;

namespace AVR.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection InfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabase(configuration);

            services.AddRepositories();

            //services.AddRabbitMQServices(configuration);

            services.AddQuartzAndSchedule();

            services.AddServices();

            services.AddSignalR(options =>
            {
                options.ClientTimeoutInterval = TimeSpan.FromMinutes(5); // Thời gian chờ lâu hơn
                options.KeepAliveInterval = TimeSpan.FromMinutes(2);     // Gửi ping để duy trì kết nối
            });

            services.AddJWT(configuration);

            services.AddUtils();

            services.AddExternalServices();

            services.AddPayOS(configuration);

            services.AddAutoMapper(typeof(MappingProfile));


            return services;
        }

        //Service
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<EmailTemplateBuilder>();
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IApartmentService, ApartmentService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectProviderService, ProjectProviderService>();
            services.AddScoped<IDepositService, DepositService>();
            services.AddScoped<IPropertyRequestService, PropertyRequestService>();
            services.AddScoped<IPropertyVerificationService, PropertyVerificationService>();
            services.AddScoped<IAppointmentRequestService, AppointmentRequestService>();
            services.AddScoped<INotificationTypeService, NotificationTypeService>();
            services.AddScoped<IFacilityService, FacilityService>();
            services.AddScoped<IProjectFacilityService, ProjectFacilityService>();
            services.AddScoped<ISettingsService, SettingsService>();
        }

        //Database
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default"),
                b => b.MigrationsAssembly(typeof(DependencyInjection).Assembly.FullName)),
                ServiceLifetime.Scoped);
        }

        //AddAuthentication
        public static void AddJWT(this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddIdentity<Account, AccountRole>().AddEntityFrameworkStores<MyDbContext>().AddDefaultTokenProviders();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey
                    (Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!))
                };


            });

            services.Configure<IdentityOptions>(options =>
            {
                // Set your desired password requirements here
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 0;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
            });

            services.AddScoped<IAuthentication, Authen>();
        }

        //Repository
        public static void AddRepositories(this IServiceCollection services)
        {
            //Repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            //UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void AddQuartzAndSchedule(this IServiceCollection services)
        {
            /*// Đăng ký Quartz và các dịch vụ liên quan
            services.AddQuartz(q =>
            {
                q.UseMicrosoftDependencyInjectionJobFactory();

                // Cấu hình cho Job CheckDepositExpiryJob
                var jobKey = new JobKey("CheckDepositExpiryJob");
                q.AddJob<CheckDepositExpiryJob>(opts => opts.WithIdentity(jobKey));

                // Lên lịch cho job chạy lúc 19:20 mỗi ngày
                q.AddTrigger(opts => opts
                    .ForJob(jobKey)
                    .WithIdentity("CheckDepositExpiryTrigger")
                    .WithCronSchedule("0 30 19 * * ?")); // 19h20 hàng ngày
            });

            services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);

            // Đăng ký các dịch vụ và job
            services.AddScoped<CheckDepositExpiryJob>();*/
            // Cấu hình Quartz
            // Đăng ký Quartz
            services.AddQuartz(q =>
            {
                // Sử dụng Microsoft Dependency Injection cho Quartz
                q.UseMicrosoftDependencyInjectionJobFactory();
            });

            // Đăng ký dịch vụ ISchedulerFactory và IScheduler
            services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
            services.AddSingleton(provider =>
            {
                var schedulerFactory = provider.GetRequiredService<ISchedulerFactory>();
                var scheduler = schedulerFactory.GetScheduler().Result;
                scheduler.JobFactory = provider.GetRequiredService<IJobFactory>();
                scheduler.Start().Wait();
                return scheduler;
            });

            // Đăng ký Quartz Hosted Service để Quartz chạy trong nền
            services.AddQuartzHostedService(options => options.WaitForJobsToComplete = true);

            // Đăng ký các dịch vụ cần thiết
            services.AddScoped<DisableDepositJob>(); // Job cần được đăng ký là Scoped hoặc Transient
            services.AddScoped<DisableApartmentJob>();
            services.AddSingleton<IDepositScheduler, DepositScheduler>();
            services.AddSingleton<IApartmentScheduler, ApartmentScheduler>();
        }


        //Utils
        public static void AddUtils(this IServiceCollection services)
        {
            services.AddScoped<IVNPayService, VNPayService>();
            /*

            services.AddScoped<IGenerateCode, GenerateCode>();

            services.AddScoped<IValidation, Validation>();*/

        }


        //External
        public static void AddExternalServices(this IServiceCollection services)
        {
            services.AddScoped<IFirebaseConfig, FirebaseConfig>();
            services.AddScoped<ISignalRConfiguration, SignalRConfiguration>();


            services.AddScoped<ISendMail, SendMail>();
        }


        //PayOS
        public static void AddPayOS(this IServiceCollection services, IConfiguration configuration)
        {
            /*PayOS payOS = new PayOS(configuration["Environment:PAYOS_CLIENT_ID"] ?? throw new Exception("Cannot find environment"),
                                    configuration["Environment:PAYOS_API_KEY"] ?? throw new Exception("Cannot find environment"),
                                    configuration["Environment:PAYOS_CHECKSUM_KEY"] ?? throw new Exception("Cannot find environment"));

            services.AddSingleton(payOS);

            services.AddControllersWithViews();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {
                        policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
                    });
            });*/
        }
    }
}
