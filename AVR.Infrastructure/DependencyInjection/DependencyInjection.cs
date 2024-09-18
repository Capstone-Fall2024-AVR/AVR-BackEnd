using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using AVR.Infrastructure.Authentication;
using AVR.Infrastructure.Data;
using AVR.Infrastructure.Integrations.Mail;
using AVR.Infrastructure.Repository;
using Firebase.Auth;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

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

            services.AddSignalR();

            services.AddAuthentication(configuration);

            services.AddUtils();

            services.AddExternalServices();

            services.AddPayOS(configuration);

            //services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }

        //Service
        public static void AddServices(this IServiceCollection services)
        {
            

        }

        //Database
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default"),
                b => b.MigrationsAssembly(typeof(DependencyInjection).Assembly.FullName)),
                ServiceLifetime.Scoped);
        }

        //AddAuthentication bị trùng với hệ thống
        public static void AddAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            /*services.AddScoped<EmailTemplateBuilder>();*/
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
            /*services.AddQuartz(options =>
            {
                options.UseMicrosoftDependencyInjectionJobFactory();


            });
            services.AddQuartzHostedService(options => options.WaitForJobsToComplete = true);
            services.ConfigureOptions<QuartzJobSetup>();

            services.AddSingleton(provider => provider.GetRequiredService<ISchedulerFactory>().GetScheduler().Result);


            services.AddScoped<IJobScheduler, JobScheduler>();*/
        }


        //Utils
        public static void AddUtils(this IServiceCollection services)
        {
            /*services.AddScoped<IVNPayService, VNPayService>();

            services.AddScoped<IGenerateCode, GenerateCode>();

            services.AddScoped<IValidation, Validation>();*/

        }


        //External
        public static void AddExternalServices(this IServiceCollection services)
        {
            /*services.AddScoped<IFirebaseConfig, FirebaseConfig>();

            services.AddScoped<IQuartzTask, QuartzTask>();

            services.AddScoped<ISendMail, SendMail>();*/
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
