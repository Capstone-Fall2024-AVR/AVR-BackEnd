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
using AVR.Domain.Enums;
using Microsoft.Identity.Client;



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
        public DbSet<DepositCancelType> DepositCancelTypes { get; set; }
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

            modelBuilder.Entity<Apartment>()
                .HasOne(ao => ao.ApartmentOwners)
                .WithMany(a => a.Apartments)
                .HasForeignKey(ao => ao.ApartmentOwnerID)
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
                .HasOne(ap => ap.Managements)
                .WithMany(p => p.ProjectApartments)
                .HasForeignKey(ap => ap.ManagementID)
                .OnDelete(DeleteBehavior.NoAction);


            //ProjectImage
            modelBuilder.Entity<ProjectImage>()
                .HasOne(p => p.ProjectApartments)
                .WithMany(pa => pa.ProjectImages)
                .HasForeignKey(p => p.ProjectApartmentID)
                .OnDelete(DeleteBehavior.Cascade);



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
            var staffId = Guid.NewGuid();
            var customerId = Guid.NewGuid();
            var managementId = Guid.NewGuid();
            var apartmentOwnerId = Guid.NewGuid();
            var apartmentProjectProviderId = Guid.NewGuid();

            //2.RoleId
            var adminRoleId = Guid.NewGuid();
            var customerRoleId = Guid.NewGuid();
            var apartmentOnwerRoleId = Guid.NewGuid();
            var staffRoleId = Guid.NewGuid();
            var managementRoleId = Guid.NewGuid();
            var projectProviderRoleId = Guid.NewGuid();

            /**************************************************/

            //AccountRole
            modelBuilder.Entity<AccountRole>().HasData(
                new AccountRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN"},
                new AccountRole { Id = customerRoleId, Name = "Customer", NormalizedName = "CUSTOMER" },
                new AccountRole { Id = apartmentOnwerRoleId, Name = "Apartment Onwer", NormalizedName = "APARTMENT ONWER" },
                new AccountRole { Id = staffRoleId, Name = "Staff", NormalizedName = "STAFF" },
                new AccountRole { Id = managementRoleId, Name = "Management", NormalizedName = "MANAGEMENT" },
                new AccountRole { Id = projectProviderRoleId, Name = "Project Provider", NormalizedName = "PROJECT PROVIDER" }
             );

            //Account
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
                },

                new Account
                {
                    Id = staffId,
                    Name = "John Doe",
                    UserName = "johndoe@example.com",
                    NormalizedUserName = "JOHNDOE@EXAMPLE.COM",
                    Email = "johndoe@example.com",
                    NormalizedEmail = "JOHNDOE@EXAMPLE.COM",
                    PhoneNumber = "123456789",
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "StaffPassword123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    EmailConfirmed = true,
                },

                new Account
                {
                    Id = customerId,
                    Name = "Michael Smith", 
                    Avatar = "",
                    UserName = "michael.smith@example.com",
                    NormalizedUserName = "MICHAEL.SMITH@EXAMPLE.COM",
                    Email = "michael.smith@example.com",
                    NormalizedEmail = "MICHAEL.SMITH@EXAMPLE.COM",
                    PhoneNumber = "0123456789",
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "password123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    EmailConfirmed = true
                },

                new Account
                {
                    Id = managementId,
                    Name = "Alice Johnson", // Management name
                    Avatar = "",
                    UserName = "alice.johnson@example.com",
                    NormalizedUserName = "ALICE.JOHNSON@EXAMPLE.COM",
                    Email = "alice.johnson@example.com",
                    NormalizedEmail = "ALICE.JOHNSON@EXAMPLE.COM",
                    PhoneNumber = "0987654321",
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "password123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    EmailConfirmed = true
                },

                new Account
                {
                    Id = apartmentOwnerId,
                    Name = "David Brown", // Apartment owner name
                    Avatar = "",
                    UserName = "david.brown@example.com",
                    NormalizedUserName = "DAVID.BROWN@EXAMPLE.COM",
                    Email = "david.brown@example.com",
                    NormalizedEmail = "DAVID.BROWN@EXAMPLE.COM",
                    PhoneNumber = "0123456789",
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "password123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    EmailConfirmed = true
                },

                new Account
                {
                    Id = apartmentProjectProviderId,
                    Name = "Construction Corp", // Example provider name
                    Avatar = "",
                    UserName = "construction.corp@example.com",
                    NormalizedUserName = "CONSTRUCTION.CORP@EXAMPLE.COM",
                    Email = "construction.corp@example.com",
                    NormalizedEmail = "CONSTRUCTION.CORP@EXAMPLE.COM",
                    PhoneNumber = "0987654321",
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "securepassword"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    EmailConfirmed = true
                }
             );

            //Staff
            var StaffID = Guid.NewGuid();
            modelBuilder.Entity<Staff>().HasData(
                new Staff
                {
                    StaffID = StaffID,
                    StaffName = "John Doe",
                    StaffPhone = "123456789",
                    StaffEmail = "johndoe@example.com",
                    imageUrl = "https://example.com/images/johndoe.png",
                    CreateAt = DateTimeOffset.Now,
                    UpdateAt = DateTimeOffset.Now,
                    AccountID = staffId // Linking to the seeded Account
                }
            );

            //Customer
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerID = Guid.NewGuid(),
                    CustomerName = "Michael Smith", // Updated name
                    CustomerEmail = "michael.smith@example.com",
                    CustomerPhone = "0123456789",
                    CustomerAddress = "123 Main St, Example City",
                    CreateAt = DateTimeOffset.Now,
                    UpdateAt = DateTimeOffset.Now,
                    imageUrl = "https://example.com/profile.jpg",
                    AccountID = customerId
                }
            );

            var customerAccountIds = new List<Guid>
                {
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    Guid.NewGuid()
                };

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    Id = customerAccountIds[0],
                    Name = "Alice Smith",
                    UserName = "alice.smith@example.com",
                    NormalizedUserName = "ALICE.SMITH@EXAMPLE.COM",
                    Email = "alice.smith@example.com",
                    NormalizedEmail = "ALICE.SMITH@EXAMPLE.COM",
                    PhoneNumber = "0901234567",
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "password123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    EmailConfirmed = true
                },
                new Account
                {
                    Id = customerAccountIds[1],
                    Name = "Bob Johnson",
                    UserName = "bob.johnson@example.com",
                    NormalizedUserName = "BOB.JOHNSON@EXAMPLE.COM",
                    Email = "bob.johnson@example.com",
                    NormalizedEmail = "BOB.JOHNSON@EXAMPLE.COM",
                    PhoneNumber = "0902345678",
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "password123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    EmailConfirmed = true
                },
                new Account
                {
                    Id = customerAccountIds[2],
                    Name = "Charlie Brown",
                    UserName = "charlie.brown@example.com",
                    NormalizedUserName = "CHARLIE.BROWN@EXAMPLE.COM",
                    Email = "charlie.brown@example.com",
                    NormalizedEmail = "CHARLIE.BROWN@EXAMPLE.COM",
                    PhoneNumber = "0903456789",
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "password123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    EmailConfirmed = true
                },
                new Account
                {
                    Id = customerAccountIds[3],
                    Name = "Diana Prince",
                    UserName = "diana.prince@example.com",
                    NormalizedUserName = "DIANA.PRINCE@EXAMPLE.COM",
                    Email = "diana.prince@example.com",
                    NormalizedEmail = "DIANA.PRINCE@EXAMPLE.COM",
                    PhoneNumber = "0904567890",
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "password123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    EmailConfirmed = true
                },
                new Account
                {
                    Id = customerAccountIds[4],
                    Name = "Eve Adams",
                    UserName = "eve.adams@example.com",
                    NormalizedUserName = "EVE.ADAMS@EXAMPLE.COM",
                    Email = "eve.adams@example.com",
                    NormalizedEmail = "EVE.ADAMS@EXAMPLE.COM",
                    PhoneNumber = "0905678901",
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "password123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    EmailConfirmed = true
                }
            );

            //Customer
            var CustomerID = new List<Guid>
                {
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    Guid.NewGuid()
                };
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerID = CustomerID[0],
                    CustomerName = "Alice Smith",
                    CustomerEmail = "alice.smith@example.com",
                    CustomerPhone = "0901234567",
                    CustomerAddress = "123 Maple St, Cityville",
                    CreateAt = DateTimeOffset.Now,
                    UpdateAt = DateTimeOffset.Now,
                    imageUrl = "https://example.com/images/alice.jpg",
                    AccountID = customerAccountIds[0]
                },
                new Customer
                {
                    CustomerID = CustomerID[1],
                    CustomerName = "Bob Johnson",
                    CustomerEmail = "bob.johnson@example.com",
                    CustomerPhone = "0902345678",
                    CustomerAddress = "456 Oak St, Townsville",
                    CreateAt = DateTimeOffset.Now,
                    UpdateAt = DateTimeOffset.Now,
                    imageUrl = "https://example.com/images/bob.jpg",
                    AccountID = customerAccountIds[1]
                },
                new Customer
                {
                    CustomerID = CustomerID[2],
                    CustomerName = "Charlie Brown",
                    CustomerEmail = "charlie.brown@example.com",
                    CustomerPhone = "0903456789",
                    CustomerAddress = "789 Pine St, Villagetown",
                    CreateAt = DateTimeOffset.Now,
                    UpdateAt = DateTimeOffset.Now,
                    imageUrl = "https://example.com/images/charlie.jpg",
                    AccountID = customerAccountIds[2]
                },
                new Customer
                {
                    CustomerID = CustomerID[3],
                    CustomerName = "Diana Prince",
                    CustomerEmail = "diana.prince@example.com",
                    CustomerPhone = "0904567890",
                    CustomerAddress = "101 Elm St, Hamlet",
                    CreateAt = DateTimeOffset.Now,
                    UpdateAt = DateTimeOffset.Now,
                    imageUrl = "https://example.com/images/diana.jpg",
                    AccountID = customerAccountIds[3]
                },
                new Customer
                {
                    CustomerID = CustomerID[4],
                    CustomerName = "Eve Adams",
                    CustomerEmail = "eve.adams@example.com",
                    CustomerPhone = "0905678901",
                    CustomerAddress = "202 Birch St, Metropolis",
                    CreateAt = DateTimeOffset.Now,
                    UpdateAt = DateTimeOffset.Now,
                    imageUrl = "https://example.com/images/eve.jpg",
                    AccountID = customerAccountIds[4]
                }
            );


            //Management
            var managementAccountId = Guid.NewGuid();

            modelBuilder.Entity<Management>().HasData(
                new Management
                {
                    ManagementID = managementAccountId,
                    ManagementName = "Alice Johnson", 
                    ManagementPhone = "0987654321",
                    ManagementEmail = "alice.johnson@example.com",
                    imageUrl = "https://example.com/profile.jpg",
                    CreateAt = DateTimeOffset.Now,
                    UpdateAt = DateTimeOffset.Now,
                    AccountID = managementId 
                }
            );

            //ApartmentOwner
            var apartmentOwnerId1 = Guid.NewGuid();
            modelBuilder.Entity<ApartmentOwner>().HasData(
                new ApartmentOwner
                {
                    ApartmentOwnerID = apartmentOwnerId1,
                    OwnerShipCertificate = "Ownership_Certificate_001.pdf",
                    LandUserRightCertificate = "Land_User_Right_Certificate_001.pdf",
                    ConstructionPermit = "Construction_Permit_001.pdf",
                    OtherDocuments = "Other_Documents_001.pdf",
                    AccountID = apartmentOwnerId 
                }
            );

            //ApartmentProjectProvider
            modelBuilder.Entity<ApartmentProjectProvider>().HasData(
                new ApartmentProjectProvider
                {
                    ApartmentProjectProviderID = Guid.NewGuid(),
                    ApartmentProjectProviderName = "Construction Corp", // Name of the provider
                    ApartmentProjectDescription = "A leading provider of luxury apartment projects.",
                    LegallInfor = "Legal Information and Compliance Details.",
                    Location = "123 Construction Ave, Citytown, ST 12345",
                    DiagramUrl = "https://example.com/diagram.png", // URL to the project diagram
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now,
                    AccountID = apartmentProjectProviderId // Link to the account
                }
            );

            //ProjectApartment
            var projectApartmentID1 = Guid.NewGuid();
            var projectApartmentID2 = Guid.NewGuid();

            modelBuilder.Entity<ProjectApartment>().HasData(
                new ProjectApartment
                {
                    ProjectApartmentID = projectApartmentID1,
                    ProjectApartmentName = "Luxury Apartment",
                    ProjectApartmentDescription = "A spacious luxury apartment with modern amenities.",
                    Price_range = "500,000 - 1,000,000 USD",
                    ProjectApartmentStatus = ProjectApartmentStatus.Available,
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now,
                    ManagementID = managementAccountId, // Management reference
                },
                 new ProjectApartment
                {
                    ProjectApartmentID = projectApartmentID2,
                    ProjectApartmentName = "Penthouse Suite",
                    ProjectApartmentDescription = "A luxurious penthouse suite with stunning views.",
                    Price_range = "1,000,000 - 2,000,000 USD",
                    ProjectApartmentStatus = ProjectApartmentStatus.Available,
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now,
                    ManagementID = managementAccountId,
                 }
            );

            // ProjectAccessLog
            modelBuilder.Entity<ProjectAccessLog>().HasData(
                new ProjectAccessLog
                {
                    ProjectAccessLogID = Guid.NewGuid(),
                    accessDate = DateTimeOffset.Now,
                    ProjectApartmentID = projectApartmentID1 // Reference to first ProjectApartment
                },
                new ProjectAccessLog
                {
                    ProjectAccessLogID = Guid.NewGuid(),
                    accessDate = DateTimeOffset.Now,
                    ProjectApartmentID = projectApartmentID2 // Reference to second ProjectApartment
                }
            );

            // ProjectImage
            var projectImageId1 = Guid.NewGuid();
            var projectImageId2 = Guid.NewGuid();

            modelBuilder.Entity<ProjectImage>().HasData(
                new ProjectImage
                {
                    ProjectImageID = projectImageId1,
                    Name = "Luxury Apartment Image",
                    Description = "Image of the luxury apartment",
                    Url = "https://example.com/luxury-apartment.jpg",
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now,
                    ProjectApartmentID = projectApartmentID1 // Reference to first ProjectApartment
                },
                new ProjectImage
                {
                    ProjectImageID = projectImageId2,
                    Name = "Penthouse Suite Image",
                    Description = "Image of the penthouse suite",
                    Url = "https://example.com/penthouse-suite.jpg",
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now,
                    ProjectApartmentID = projectApartmentID2 // Reference to second ProjectApartment
                }
            );

            //Apartment
            var apartmentID1 = Guid.NewGuid();
            var apartmentID2 = Guid.NewGuid();

            modelBuilder.Entity<Apartment>().HasData(
                new Apartment
                {
                    ApartmentID = apartmentID1,
                    ApartmentName = "Skyline Apartment",
                    Description = "A modern apartment with a skyline view.",
                    CreatedDate = DateTimeOffset.Now,
                    UpdatedDate = DateTimeOffset.Now,
                    address = "123 Skyline Road, New City",
                    area = "1500 sqft",
                    numberOfRooms = "3",
                    location = "City Center",
                    direction = "North-East",
                    pricePerSquareMeter = "3000 USD",
                    recommendedPrice = "450,000 USD",
                    expiryDate = DateTimeOffset.Now.AddYears(5),
                    ApartmentStatus = ApartmentStatus.Available,
                    ApartmentType = ApartmentType.Residential,
                    ProjectID = projectApartmentID1,    // Reference to ProjectApartment
                    ApartmentOwnerID = apartmentOwnerId1, // Reference to ApartmentOwner
                },
                new Apartment
                {
                    ApartmentID = apartmentID2,
                    ApartmentName = "Ocean View Apartment",
                    Description = "A luxurious apartment with an ocean view.",
                    CreatedDate = DateTimeOffset.Now,
                    UpdatedDate = DateTimeOffset.Now,
                    address = "456 Ocean Drive, Coastal City",
                    area = "1800 sqft",
                    numberOfRooms = "4",
                    location = "Beachfront",
                    direction = "South-West",
                    pricePerSquareMeter = "3500 USD",
                    recommendedPrice = "650,000 USD",
                    expiryDate = DateTimeOffset.Now.AddYears(3),
                    ApartmentStatus = ApartmentStatus.Sold,
                    ApartmentType = ApartmentType.Luxury,
                    ProjectID = projectApartmentID1,    // Reference to ProjectApartment
                    ApartmentOwnerID = apartmentOwnerId1  // Reference to ApartmentOwner
                }
            );

            // Facilities IDs
            var facilitiesID1 = Guid.NewGuid();
            var facilitiesID2 = Guid.NewGuid();

            modelBuilder.Entity<Facilities>().HasData(
                new Facilities
                {
                    FacilitiesID = facilitiesID1,
                    FacilitiesName = "Swimming Pool",
                    FacilitiesDescription = "A large outdoor swimming pool."
                },
                new Facilities
                {
                    FacilitiesID = facilitiesID2,
                    FacilitiesName = "Gym",
                    FacilitiesDescription = "A fully equipped fitness gym."
                }
            );

            // ApartmentFacility IDs
            var apartmentFacilityID1 = Guid.NewGuid();
            var apartmentFacilityID2 = Guid.NewGuid();

            modelBuilder.Entity<ApartmentFacility>().HasData(
                new ApartmentFacility
                {
                    ApartmentFacilityID = apartmentFacilityID1,
                    ApartmentID = apartmentID1,     // Reference to Apartment
                    FacilityID = facilitiesID1      // Reference to "Swimming Pool"
                },
                new ApartmentFacility
                {
                    ApartmentFacilityID = apartmentFacilityID2,
                    ApartmentID = apartmentID2,     // Reference to another Apartment
                    FacilityID = facilitiesID2      // Reference to "Gym"
                }
            );

            //ApartmentImage 
            var apartmentImageID1 = Guid.NewGuid();
            var apartmentImageID2 = Guid.NewGuid();

            modelBuilder.Entity<ApartmentImage>().HasData(
                new ApartmentImage
                {
                    ApartmentImageID = apartmentImageID1,
                    Description = "Living Room View",
                    ImageUrl = "https://example.com/apartment1-livingroom.jpg",
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now,
                    ApartmentID = apartmentID1 // Reference to the first Apartment
                },
                new ApartmentImage
                {
                    ApartmentImageID = apartmentImageID2,
                    Description = "Bedroom View",
                    ImageUrl = "https://example.com/apartment1-bedroom.jpg",
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now,
                    ApartmentID = apartmentID1 // Reference to the first Apartment
                }
            );

            //VRExperience 
            var vrExperienceID1 = Guid.NewGuid();
            var vrExperienceID2 = Guid.NewGuid();


            modelBuilder.Entity<VRExperience>().HasData(
                new VRExperience
                {
                    VRExperienceID = vrExperienceID1,
                    video_url_file = "https://example.com/vr-experience1.mp4",
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now,
                    ApartmentID = apartmentID1, // Reference to the first Apartment
                    StaffID = StaffID // Reference to the staff member who created it
                },
                new VRExperience
                {
                    VRExperienceID = vrExperienceID2,
                    video_url_file = "https://example.com/vr-experience2.mp4",
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now,
                    ApartmentID = apartmentID2, // Reference to the second Apartment
                    StaffID = StaffID // Reference to the same staff member
                }
            );

            //VR_Access_Log 
            modelBuilder.Entity<VR_Access_Log>().HasData(
                new VR_Access_Log
                {
                    VR_Access_LogID = Guid.NewGuid(),
                    CreateDate = DateTimeOffset.Now,
                    VRExperienceID = vrExperienceID1 // Reference to the first VR experience
                },
                new VR_Access_Log
                {
                    VR_Access_LogID = Guid.NewGuid(),
                    CreateDate = DateTimeOffset.Now,
                    VRExperienceID = vrExperienceID2 // Reference to the second VR experience
                }
            );

            //ApartmentInteraction 
            modelBuilder.Entity<ApartmentInteraction>().HasData(
                new ApartmentInteraction
                {
                    ApartmentInteractionID = Guid.NewGuid(),
                    InteractionDate = DateTimeOffset.Now,
                    InteractionTypes = InteractionType.View, // Replace with an appropriate InteractionType
                    CustomerID = CustomerID[0], // Reference to the first Customer
                    ApartmentID = apartmentID1  // Reference to the first Apartment
                },
                new ApartmentInteraction
                {
                    ApartmentInteractionID = Guid.NewGuid(),
                    InteractionDate = DateTimeOffset.Now,
                    InteractionTypes = InteractionType.Inquiry, // Replace with an appropriate InteractionType
                    CustomerID = CustomerID[0], // Reference to the second Customer
                    ApartmentID = apartmentID2  // Reference to the second Apartment
                }
            );

            //RequestApartment
            var RequestApartmentID1 = Guid.NewGuid();
            var RequestApartmentID2 = Guid.NewGuid();

            modelBuilder.Entity<RequestApartment>().HasData(
                new RequestApartment
                {
                    RequestApartmentID = RequestApartmentID1, // Use an appropriate ID
                    ResponseMessage = "Your request has been received.",
                    RequestMessage = "I would like to know more about this apartment.",
                    Note = "Please respond as soon as possible.",
                    CreateDate = DateTimeOffset.Now,
                    ResponseDate = DateTimeOffset.Now.AddDays(1),
                    ApartmentID = apartmentID1, // Reference to the first Apartment
                    ManagementID = managementAccountId, // Reference to Management
                    CustomerID = CustomerID[0] // Reference to the first Customer
                },
                new RequestApartment
                {
                    RequestApartmentID = RequestApartmentID2, // Use an appropriate ID
                    ResponseMessage = "The apartment is still available.",
                    RequestMessage = "Is this apartment still available for booking?",
                    Note = "Looking forward to your response.",
                    CreateDate = DateTimeOffset.Now,
                    ResponseDate = DateTimeOffset.Now.AddDays(1),
                    ApartmentID = apartmentID2, // Reference to the second Apartment
                    ManagementID = managementAccountId, // Reference to Management
                    CustomerID = CustomerID[1] // Reference to the second Customer
                }
            );

            //Slot 
            var slotID1 = Guid.NewGuid();
            var slotID2 = Guid.NewGuid();

            modelBuilder.Entity<Slot>().HasData(
                new Slot
                {
                    SlotID = slotID1,
                    StartTime = "09:00 AM",
                    EndTime = "10:00 AM"
                },
                new Slot
                {
                    SlotID = slotID2,
                    StartTime = "10:00 AM",
                    EndTime = "11:00 AM"
                }
            );

            //Appointment 
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    AppointmentID = Guid.NewGuid(),
                    Title = "Viewing Appointment for Skyline Apartment",
                    Description = "Schedule a viewing for the Skyline Apartment.",
                    AssignedBy = "Admin",
                    CreateDate = DateTimeOffset.Now,
                    UpdatedDate = DateTimeOffset.Now,
                    AssignedDate = DateTimeOffset.Now,
                    AppointmentDate = DateTimeOffset.Now.AddDays(1), // Appointment scheduled for tomorrow
                    AppointmentStatus = AppointmentStatus.Confirmed, // Replace with an appropriate status
                    AppointmentTypes = AppointmentTypes.Viewing, // Replace with an appropriate type
                    CustomerID = CustomerID[4], // Reference to the Customer
                    SlotID = slotID1, // Reference to the first Slot
                    StaffID = StaffID, // Reference to the Staff
                    ApartmentID = apartmentID1 // Reference to the Apartment
                },
                new Appointment
                {
                    AppointmentID = Guid.NewGuid(),
                    Title = "Inquiry Appointment for Ocean View Apartment",
                    Description = "Discuss details about the Ocean View Apartment.",
                    AssignedBy = "Admin",
                    CreateDate = DateTimeOffset.Now,
                    UpdatedDate = DateTimeOffset.Now,
                    AssignedDate = DateTimeOffset.Now,
                    AppointmentDate = DateTimeOffset.Now.AddDays(2), // Appointment scheduled for the day after tomorrow
                    AppointmentStatus = AppointmentStatus.Pending, // Replace with an appropriate status
                    AppointmentTypes = AppointmentTypes.Inquiry, // Replace with an appropriate type
                    CustomerID = CustomerID[3], // Reference to the Customer
                    SlotID = slotID2, // Reference to the second Slot
                    StaffID = StaffID, // Reference to the Staff
                    ApartmentID = apartmentID2 // Reference to the Apartment
                }
            );

            //DepositCancelType 
            var depositCancelTypeID1 = Guid.NewGuid();
            modelBuilder.Entity<DepositCancelType>().HasData(
                new DepositCancelType
                {
                    DepositCancelTypeID = depositCancelTypeID1,
                    DepositCancelName = "Customer Request",
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now
                }
            );

            //Deposit 
            var DepositID = Guid.NewGuid();
            modelBuilder.Entity<Deposit>().HasData(
                new Deposit
                {
                    DepositID = DepositID,
                    depositPercentage = 20.0,
                    constractNumber = 12345,
                    depositAmount = 50000,
                    note = "Initial deposit for apartment",
                    description = "Deposit for Skyline Apartment.",
                    UpdateDate = DateTimeOffset.Now,
                    expiryDate = DateTimeOffset.Now.AddMonths(1),
                    DepositStatus = DepositStatus.Active, // Replace with an appropriate status
                    CustomerID = CustomerID[2], // Reference to Customer
                    ApartmentID = apartmentID1 // Reference to Apartment
                }
            );

            //Transaction 
            var transactionID1 = Guid.NewGuid();

            modelBuilder.Entity<Transaction>().HasData(
                new Transaction
                {
                    TransactionID = transactionID1,
                    ammount = 50000,
                    note = "Deposit payment",
                    description = "Payment for initial deposit.",
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now,
                    TransactionDate = DateTimeOffset.Now,
                    TransactionStatus = TransactionStatus.Completed, // Replace with an appropriate status
                    DepositID = DepositID // Reference to the Deposit (replace with the correct DepositID)
                }
            );

            //DepositCancel 
            modelBuilder.Entity<DepositCancel>().HasData(
                new DepositCancel
                {
                    DepositCancelID = Guid.NewGuid(),
                    RecoveryPrice = "45000",
                    CancelDate = DateTimeOffset.Now,
                    RefundDate = DateTimeOffset.Now.AddDays(5),
                    updateAt = DateTimeOffset.Now,
                    DepositID = DepositID, // Reference to the Deposit (replace with the correct DepositID)
                    ManagementID = managementAccountId, // Reference to Management
                    DepositCancelTypeID = depositCancelTypeID1 // Reference to DepositCancelType
                }
            );

            //Feedback 
            modelBuilder.Entity<Feedback>().HasData(
                new Feedback
                {
                    FeedbackID = Guid.NewGuid(),
                    Title = "Great Service!",
                    Description = "I really enjoyed the experience. Highly recommend!",
                    Rating = 5.0f,
                    CreateDate = DateTimeOffset.Now,
                    FeedbackStatus = FeedbackStatus.Active, // Replace with an appropriate status
                    AccountID = customerAccountIds[0] // Reference to Account
                },
                new Feedback
                {
                    FeedbackID = Guid.NewGuid(),
                    Title = "Could be better",
                    Description = "The service was okay, but there's room for improvement.",
                    Rating = 3.5f,
                    CreateDate = DateTimeOffset.Now,
                    FeedbackStatus = FeedbackStatus.Active, // Replace with an appropriate status
                    AccountID = customerAccountIds[1] // Reference to Account
                }
            );

            //NotificationType
            var notificationTypeID1 = Guid.NewGuid();
            modelBuilder.Entity<NotificationType>().HasData(
                new NotificationType
                {
                    NotificationTypeID = notificationTypeID1,
                    NotificationTypeName = "General",
                    NotificationTypeDescription = "General notifications for users."
                }
            );

            //Notification 
            modelBuilder.Entity<Notification>().HasData(
                new Notification
                {
                    NotificationID = Guid.NewGuid(),
                    Title = "Welcome to Our Service",
                    Description = "Thank you for joining us! We hope you enjoy your experience.",
                    Created = DateTimeOffset.Now,
                    Updated = DateTimeOffset.Now,
                    NotificationStatus = NotificationStatus.Unread, // Replace with an appropriate status
                    IsRead = false,
                    NotificationTypeID = notificationTypeID1, // Reference to NotificationType
                    AccountID = customerAccountIds[2], // Reference to Account
                    ReferenceID = Guid.NewGuid() // Example reference ID
                },
                new Notification
                {
                    NotificationID = Guid.NewGuid(),
                    Title = "New Feature Available",
                    Description = "Check out our new feature that enhances your experience!",
                    Created = DateTimeOffset.Now,
                    Updated = DateTimeOffset.Now,
                    NotificationStatus = NotificationStatus.Unread, // Replace with an appropriate status
                    IsRead = false,
                    NotificationTypeID = notificationTypeID1, // Reference to NotificationType
                    AccountID = customerAccountIds[1], // Reference to Account
                    ReferenceID = Guid.NewGuid() // Example reference ID
                }
            );

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid> { UserId = adminId, RoleId = adminRoleId }
                
            );

        }


    }
}
