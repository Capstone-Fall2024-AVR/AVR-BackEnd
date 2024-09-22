using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AVR.Domain.Entities;
using Microsoft.VisualBasic;
using Firebase.Auth;



namespace AVR.Infrastructure.Data
{
    public class MyDbContext : IdentityDbContext<Account, AccountRole, Guid> { 
        public MyDbContext()
        {

        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ApartmentImage> ApartmentImages { get; set; }
        public DbSet<ApartmentInteraction> ApartmentInteractions { get; set; }
        public DbSet<ApartmentOwner> ApartmentOwners { get; set; }
        public DbSet<ApartmentProjectProvider> ApartmentProjectProvider { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Deposit> Deposit { get; set; }
        public DbSet<DepositCancel> DepositCancel { get; set; }
        public DbSet<DepositCancelType> DepositCancelType { get; set; }
        public DbSet<Facilities> Facilities { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Management> Managements { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<ProjectAccessLog> ProjectAccessLogs { get; set; }
        public DbSet<ProjectApartment> ProjectApartments { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<VR_Access_Log> VR_Access_Logs { get; set; }
        public DbSet<VRExperience> VRExperiences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {

                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Account
            modelBuilder.Entity<Account>()
                .HasOne(a => a.Managements)
                .WithOne(m => m.Accounts)
                .HasForeignKey<Management>(m => m.AccountID);

            modelBuilder.Entity<Account>()
                .HasOne(a => a.Customers)
                .WithOne(c => c.Accounts)
                .HasForeignKey<Customer>(c => c.AccountID);

            modelBuilder.Entity<Account>()
                .HasOne(a => a.ApartmentOwners)
                .WithOne(c => c.Accounts)
                .HasForeignKey<ApartmentOwner>(c => c.AccountID);

            modelBuilder.Entity<Account>()
                .HasOne(a => a.ApartmentProjectProviders)
                .WithOne(c => c.Accounts)
                .HasForeignKey<ApartmentProjectProvider>(c => c.AccountID);

            modelBuilder.Entity<Account>()
                .HasOne(a => a.Staffs)
                .WithOne(c => c.Accounts)
                .HasForeignKey<Staff>(c => c.AccountID);


            //Apartment
            modelBuilder.Entity<Apartment>()
                .HasOne(p => p.ProjectApartments)
                .WithMany(a => a.Apartments)
                .HasForeignKey(p => p.ProjectID)
                .OnDelete(DeleteBehavior.NoAction);

            //ApartmentImage
            modelBuilder.Entity<ApartmentImage>()
                .HasOne(a => a.Apartments)
                .WithMany(ai => ai.ApartmentImages)
                .HasForeignKey(a => a.ApartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            //ApartmentInteraction
            modelBuilder.Entity<ApartmentInteraction>()
                .HasOne(a => a.Apartments)
                .WithMany(ai => ai.ApartmentInteractions)
                .HasForeignKey(a => a.ApartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ApartmentInteraction>()
                .HasOne(c => c.Customers)
                .WithMany(ai => ai.ApartmentInteractions)
                .HasForeignKey(c => c.CustomerID)
                .OnDelete(DeleteBehavior.NoAction);

            //ApartmentOwner

            //ApartmentProjectProvider
            modelBuilder.Entity<ApartmentProjectProvider>()
                .HasOne(aptProvider => aptProvider.Accounts)
                .WithOne(account => account.ApartmentProjectProviders)
                .HasForeignKey<ApartmentProjectProvider>(aptProvider => aptProvider.AccountID)
                .OnDelete(DeleteBehavior.NoAction); // Or DeleteBehavior.Restrict

            //Appointment
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Staffs)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.StaffID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Appointment>()
                .HasOne(s => s.Slots)
                .WithMany(a => a.Appointments)
                .HasForeignKey(s => s.SlotID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Appointment>()
                .HasOne(c => c.Customers)
                .WithMany(a => a.Appointments)
                .HasForeignKey(c => c.CustomerID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Appointment>()
                .HasOne(ap => ap.Apartments)
                .WithMany(a => a.Appointments)
                .HasForeignKey(ap => ap.ApartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            //Customer

            //Deposit
            modelBuilder.Entity<Deposit>()
                .HasOne(c => c.Customers)
                .WithMany(d => d.Deposits)
                .HasForeignKey(c => c.CustomerID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Deposit>()
                .HasOne(a => a.Apartments)
                .WithMany(d => d.Deposits)
                .HasForeignKey(a => a.ApartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            //DepositCancel
            modelBuilder.Entity<DepositCancel>()
                .HasOne(d => d.Deposits)
                .WithMany(dc => dc.DepositCancels)
                .HasForeignKey(d => d.DepositID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DepositCancel>()
                .HasOne(d => d.DepositCancelTypes)
                .WithMany(dc => dc.DepositCancels)
                .HasForeignKey(d => d.DepositCancelTypeID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DepositCancel>()
                .HasOne(m => m.Managements)
                .WithMany(dc => dc.DepositCancels)
                .HasForeignKey(m => m.ManagementID)
                .OnDelete(DeleteBehavior.NoAction);

            //Feedback
            modelBuilder.Entity<Feedback>()
                .HasOne(a => a.Accounts)
                .WithMany(f => f.Feedbacks)
                .HasForeignKey(a => a.AccountID)
                .OnDelete(DeleteBehavior.NoAction);

            //Management

            //Notification
            modelBuilder.Entity<Notification>()
                .HasOne(a => a.Accounts)
                .WithMany(n => n.Notifications)
                .HasForeignKey(a => a.AccountID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Notification>()
                .HasOne(nt => nt.NotificationTypes)
                .WithMany(n => n.Notifications)
                .HasForeignKey(nt => nt.NotificationTypeID)
                .OnDelete(DeleteBehavior.NoAction);

            //NotificationType

            //ProjectAccessLog
            modelBuilder.Entity<ProjectAccessLog>()
                .HasOne(pa => pa.ProjectApartments)
                .WithMany(p => p.ProjectAccessLogs)
                .HasForeignKey(pa => pa.ProjectApartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            //ProjectApartment
            modelBuilder.Entity<ProjectApartment>()
                .HasOne(ap => ap.ApartmentProjectProviders)
                .WithMany(p => p.ProjectApartments)
                .HasForeignKey(ap => ap.ApartmentProjectProviderID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProjectApartment>()
                .HasOne(pi => pi.ProjectImages)
                .WithMany(p => p.ProjectApartments)
                .HasForeignKey(pi => pi.ProjectImageID)
                .OnDelete(DeleteBehavior.NoAction);

            //ProjectImage

            //RequestApartment
            modelBuilder.Entity<RequestApartment>()
                .HasOne(c => c.Customers)
                .WithMany(r => r.RequestApartments)
                .HasForeignKey(c => c.CustomerID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RequestApartment>()
                .HasOne(m => m.Managements)
                .WithMany(r => r.RequestApartments)
                .HasForeignKey(m => m.ManagementID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RequestApartment>()
                .HasOne(a => a.Apartments)
                .WithMany(r => r.RequestApartments)
                .HasForeignKey(a => a.ApartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            //Slot

            //Staff

            //Transaction

            //VR_Access_Log
            modelBuilder.Entity<VR_Access_Log>()
                .HasOne(v => v.VRExperiences)
                .WithMany(vr => vr.VR_Access_Logs)
                .HasForeignKey(v => v.VRExperienceID)
                .OnDelete(DeleteBehavior.NoAction);

            //VRExperience
            modelBuilder.Entity<VRExperience>()
                .HasOne(vr => vr.Staffs)
                .WithMany(v => v.VRExperiences)
                .HasForeignKey(vr => vr.StaffID)
                .OnDelete(DeleteBehavior.NoAction); // or DeleteBehavior.Restrict
            modelBuilder.Entity<VRExperience>()
                .HasOne(a => a.Apartments)
                .WithMany(v => v.VRExperiences)
                .HasForeignKey(a => a.ApartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            /**************************************************/

            var hasher = new PasswordHasher<User>();

            //1.AccountId
            var adminId = Guid.NewGuid();


            //2.RoleId
            var adminRoleId = Guid.NewGuid();
            var customerRoleId = Guid.NewGuid();
            var apartmentOnwerRoleId = Guid.NewGuid();
            var staffRoleId = Guid.NewGuid();
            var managementRoleId = Guid.NewGuid();
            var projectProviderRoleId = Guid.NewGuid();

            /**************************************************/


            modelBuilder.Entity<AccountRole>().HasData(
                new AccountRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN"},
                new AccountRole { Id = customerRoleId, Name = "Customer", NormalizedName = "CUSTOMER" },
                new AccountRole { Id = apartmentOnwerRoleId, Name = "Apartment Onwer", NormalizedName = "APARTMENT ONWER" },
                new AccountRole { Id = staffRoleId, Name = "Staff", NormalizedName = "STAFF" },
                new AccountRole { Id = managementRoleId, Name = "Management", NormalizedName = "MANAGEMENT" },
                new AccountRole { Id = projectProviderRoleId, Name = "Project Provider", NormalizedName = "PROJECT PROVIDER" }
             );

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    Id = adminId,
                    Name = "Quan",
                    Avatar = "",
                    UserName = "quansongngu13@gmail.com",
                    NormalizedUserName = "QUANSONGNGU13@GMAIL.COM",
                    Email = "quansongngu13@gmail.com",
                    NormalizedEmail = "QUANSONGNGU13@GMAIL.COM",
                    PhoneNumber = "0949035672",
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    EmailConfirmed = true,
                    

                }

             );

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid> { UserId = adminId, RoleId = adminRoleId }
                
            );

        }


    }
}
