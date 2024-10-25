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
        public DbSet<AgreementUpdateRequest> AgreementUpdateRequests { get; set; }
        public DbSet<ApartmentImage> ApartmentImages { get; set; }
        public DbSet<ProjectFacility> ProjectFacilities { get; set; }
        public DbSet<ApartmentInteraction> ApartmentInteractions { get; set; }
        /*public DbSet<ApartmentOwner> ApartmentOwners { get; set; }*/
        public DbSet<ApartmentProjectProvider> ApartmentProjectProvider { get; set; }
        public DbSet<ApartmentOwnerApartment> ApartmentOwnerApartments { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        /*public DbSet<Customer> Customer { get; set; }*/
        public DbSet<Deposit> Deposit { get; set; }
        public DbSet<DepositCancel> DepositCancel { get; set; }
        public DbSet<DepositCancelType> DepositCancelTypes { get; set; }
        public DbSet<Facilities> Facilities { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        /*public DbSet<Management> Managements { get; set; }*/
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<ProjectAccessLog> ProjectAccessLogs { get; set; }
        public DbSet<ProjectApartment> ProjectApartments { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }
        //public DbSet<ProjectApartmentApartment> ProjectApartmentApartments { get; set; }
        public DbSet<RequestApartment> RequestApartments { get; set; }
        public DbSet<Slot> Slots { get; set; }  
        /*public DbSet<Staff> Staffs { get; set; }*/
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<VR_Access_Log> VR_Access_Logs { get; set; }
        public DbSet<VRExperience> VRExperiences { get; set; }
        public DbSet<PropertyRequest> PropertyRequest { get; set; }
        public DbSet<PropertyVerification> PropertyVerification { get; set; }

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

            // PropertyRequest -> Account (Owner)
            modelBuilder.Entity<PropertyRequest>()
                .HasOne(pr => pr.Owner)
                .WithMany(a => a.OwnedPropertyRequests)
                .HasForeignKey(pr => pr.OwnerID)
                .OnDelete(DeleteBehavior.NoAction);

            // PropertyRequest -> Account (Staff)
            modelBuilder.Entity<PropertyRequest>()
                .HasOne(pr => pr.Staff)
                .WithMany(a => a.AssignedPropertyRequests)
                .HasForeignKey(pr => pr.StaffID)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<PropertyVerification>()
                 .HasOne(pv => pv.Apartment)
                 .WithOne(a => a.PropertyVerification)
                 .HasForeignKey<PropertyVerification>(pv => pv.ApartmentID)
                 .OnDelete(DeleteBehavior.Cascade);

            //Account
            modelBuilder.Entity<Account>()
                .HasOne(a => a.ApartmentProjectProviders)
                .WithOne(c => c.Accounts)
                .HasForeignKey<ApartmentProjectProvider>(c => c.AccountID);

            

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
                .HasOne(ai => ai.Accounts)
                .WithMany(a => a.ApartmentInteractions)
                .HasForeignKey(ai => ai.AccountID)
                .OnDelete(DeleteBehavior.Restrict);

            

            //AgreementUpdateRequest
            modelBuilder.Entity<AgreementUpdateRequest>()
                .HasOne(aur => aur.Accounts)
                .WithMany(ac => ac.AgreementUpdateRequests) // Thêm thuộc tính trong Account nếu cần
                .HasForeignKey(aur => aur.AccountID)
                .OnDelete(DeleteBehavior.NoAction);

            //ApartmentOwner
            // Mối quan hệ giữa Account và Apartment thông qua ApartmentOwnerApartment
            modelBuilder.Entity<ApartmentOwnerApartment>()
                .HasOne(aoa => aoa.Account)  // Một ApartmentOwnerApartment có một Account
                .WithOne(a => a.ApartmentOwnerApartment)  // Một Account chỉ có thể sở hữu một Apartment
                .HasForeignKey<ApartmentOwnerApartment>(aoa => aoa.AccountID)  // ForeignKey là AccountID
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApartmentOwnerApartment>()
                .HasOne(aoa => aoa.Apartment)  // Một ApartmentOwnerApartment thuộc về một Apartment
                .WithOne(a => a.ApartmentOwnerApartment)  // Một Apartment chỉ có thể thuộc về một chủ sở hữu tại một thời điểm
                .HasForeignKey<ApartmentOwnerApartment>(aoa => aoa.ApartmentID)  // ForeignKey là ApartmentID
                .OnDelete(DeleteBehavior.Cascade);

            //ApartmentProjectProvider

            // Appointment 

            // Relationship for Customer
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Customer)  // Customer Account
                .WithMany(ac => ac.CustomerAppointments)  // Use CustomerAppointments navigation property
                .HasForeignKey(a => a.CustomerID)  // Foreign key is CustomerID
                .OnDelete(DeleteBehavior.Restrict);

            // Relationship for Staff
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Staff)  // Staff Account
                .WithMany(ac => ac.StaffAppointments)  // Use StaffAppointments navigation property
                .HasForeignKey(a => a.StaffID)  // Foreign key is StaffID
                .OnDelete(DeleteBehavior.Restrict);

            // Relationship for Project Provider
            

            // Relationship for Apartment
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Apartments)
                .WithMany(ap => ap.Appointments)
                .HasForeignKey(a => a.ApartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship for Slot
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Slots)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.SlotID)
                .OnDelete(DeleteBehavior.NoAction);


           

            //Deposit
            modelBuilder.Entity<Deposit>()
                .HasOne(d => d.Accounts)
                .WithMany(a => a.Deposits)
                .HasForeignKey(d => d.AccountID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Deposit>()
                .HasOne(a => a.Apartments)
                .WithMany(d => d.Deposits)
                .HasForeignKey(a => a.ApartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Deposit>()
               .HasOne(d => d.DepositProfile)
               .WithOne(dp => dp.Deposit)
               .HasForeignKey<DepositProfile>(dp => dp.DepositID)
               .OnDelete(DeleteBehavior.Cascade);

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
                .HasOne(dc => dc.Accounts)
                .WithMany(ac => ac.DepositCancels) // Thêm thuộc tính trong Account nếu cần
                .HasForeignKey(dc => dc.AccountID)
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
                .HasOne(pa => pa.ApartmentProjectProvider)
                .WithMany(ap => ap.ProjectApartments)
                .HasForeignKey(pa => pa.ApartmentProjectProviderID)
                .OnDelete(DeleteBehavior.NoAction); // Or DeleteBehavior.Restrict

            modelBuilder.Entity<ProjectApartment>()
                .HasMany(p => p.Apartments)
                .WithOne(a => a.ProjectApartment)
                .HasForeignKey(a => a.ProjectApartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            //ProjectImage
            modelBuilder.Entity<ProjectImage>()
                .HasOne(p => p.ProjectApartments)
                .WithMany(pa => pa.ProjectImages)
                .HasForeignKey(p => p.ProjectApartmentID)
                .OnDelete(DeleteBehavior.Cascade);


            //RequestApartment
            modelBuilder.Entity<RequestApartment>()
                .HasOne(ra => ra.Accounts)
                .WithMany(a => a.RequestApartments)
                .HasForeignKey(ra => ra.AccountID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RequestApartment>()
                .HasOne(ra => ra.Accounts)
                .WithMany(ac => ac.RequestApartments) // Thêm thuộc tính trong Account nếu cần
                .HasForeignKey(ra => ra.AccountID);

            modelBuilder.Entity<RequestApartment>()
                .HasOne(a => a.Apartments)
                .WithMany(r => r.RequestApartments)
                .HasForeignKey(a => a.ApartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            //VR_Access_Log
            modelBuilder.Entity<VR_Access_Log>()
                .HasOne(v => v.VRExperiences)
                .WithMany(vr => vr.VR_Access_Logs)
                .HasForeignKey(v => v.VRExperienceID)
                .OnDelete(DeleteBehavior.NoAction);

            //VRExperience
            modelBuilder.Entity<VRExperience>()
                .HasOne(vr => vr.Accounts) // Một VRExperience có một Account
                .WithMany(ac => ac.VRExperiences) // Một Account có nhiều VRExperience
                .HasForeignKey(vr => vr.AccountID); // Khóa ngoại là AccountID

            modelBuilder.Entity<VRExperience>()
                .HasOne(a => a.Apartments)
                .WithMany(v => v.VRExperiences)
                .HasForeignKey(a => a.ApartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            /**************************************************/

            /*var hasher = new PasswordHasher<User>();

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
            var apartmentOwnerRoleId = Guid.NewGuid();
            var staffRoleId = Guid.NewGuid();
            var managementRoleId = Guid.NewGuid();
            var projectProviderRoleId = Guid.NewGuid();

            //************************************************

            //AccountRole
            modelBuilder.Entity<AccountRole>().HasData(
                new AccountRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new AccountRole { Id = customerRoleId, Name = "Customer", NormalizedName = "CUSTOMER" },
                new AccountRole { Id = apartmentOwnerRoleId, Name = "Apartment Owner", NormalizedName = "APARTMENT OWNER" },
                new AccountRole { Id = staffRoleId, Name = "Staff", NormalizedName = "STAFF" },
                new AccountRole { Id = managementRoleId, Name = "Management", NormalizedName = "MANAGEMENT" },
                new AccountRole { Id = projectProviderRoleId, Name = "Project Provider", NormalizedName = "PROJECT PROVIDER" }
             );

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid> { UserId = adminId, RoleId = adminRoleId },
                new IdentityUserRole<Guid> { UserId = customerId, RoleId = customerRoleId },
                new IdentityUserRole<Guid> { UserId = apartmentOwnerId, RoleId = apartmentOwnerRoleId },
                new IdentityUserRole<Guid> { UserId = staffId, RoleId = staffRoleId },
                new IdentityUserRole<Guid> { UserId = managementId, RoleId = managementRoleId },
                new IdentityUserRole<Guid> { UserId = apartmentProjectProviderId, RoleId = projectProviderRoleId }

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
                    Name = "Duc Luong", // Management name
                    Avatar = "",
                    UserName = "luong.a11.dbk@gmail.com",
                    NormalizedUserName = "LUONG.A11.DBK@GMAIL.COM",
                    Email = "luong.a11.dbk@gmail.com",
                    NormalizedEmail = "LUONG.A11.DBK@GMAIL.COM",
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


            //ApartmentProjectProvider
            var apartmentProjectProviderId1 = Guid.NewGuid(); // Generate the ApartmentProjectProviderID

            modelBuilder.Entity<ApartmentProjectProvider>().HasData(
                new ApartmentProjectProvider
                {
                    ApartmentProjectProviderID = apartmentProjectProviderId1,
                    ApartmentProjectProviderName = "High-End Apartment Provider",
                    ApartmentProjectDescription = "A provider of luxury high-end apartments.",
                    LegallInfor = "Legal Information",
                    Location = "City Center",
                    DiagramUrl = "https://example.com/diagram.png",
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now,
                    AccountID = apartmentProjectProviderId // Ensure that the AccountID exists in the Account table
                }
            );

            //ProjectApartment
            var projectApartmentID1 = Guid.NewGuid();

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
                    ApartmentProjectProviderID = apartmentProjectProviderId1, // Adjust based on your seed data
                }
            );

            // ProjectAccessLog
            modelBuilder.Entity<ProjectAccessLog>().HasData(
                new ProjectAccessLog
                {
                    ProjectAccessLogID = Guid.NewGuid(),
                    accessDate = DateTimeOffset.Now,
                    ProjectApartmentID = projectApartmentID1 // Reference to first ProjectApartment
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
                    Address = "123 Skyline Road, New City",
                    Area = 150.00M,
                    District = "Central District",  // Provide a valid district name
                    Ward = "Ward 5",  // Provide a valid ward name
                    NumberOfRooms = 3,
                    NumberOfBathrooms = 2,
                    Location = "City Center",
                    Direction = Direction.Dong,
                    PricePerSquareMeter = 70000000M,
                    RecommendedPrice = 10000000000M,
                    ExpiryDate = DateTimeOffset.Now.AddYears(5),
                    ApartmentStatus = ApartmentStatus.Available,
                    ApartmentType = ApartmentType.CanHoTruyenThong,
                    SaleStatus = SaleStatus.DangMoBan,
                    BalconyDirection = BalconyDirection.DongBac,
                    ProjectApartmentID = projectApartmentID1 // Link to ProjectApartment
                },
                new Apartment
                {
                    ApartmentID = apartmentID2,
                    ApartmentName = "Ocean View Apartment",
                    Description = "A luxurious apartment with an ocean view.",
                    CreatedDate = DateTimeOffset.Now,
                    UpdatedDate = DateTimeOffset.Now,
                    Address = "456 Ocean Drive, Coastal City",
                    District = "Coastal District",  // Provide a valid district name
                    Ward = "Ward 2",  // Provide a valid ward name
                    Area = 170.00M,
                    NumberOfRooms = 4,
                    NumberOfBathrooms = 3,
                    Location = "Beachfront",
                    Direction = Direction.Tay,
                    PricePerSquareMeter = 90000000M,
                    RecommendedPrice = 15000000000M,
                    ExpiryDate = DateTimeOffset.Now.AddYears(3),
                    ApartmentStatus = ApartmentStatus.Sold,
                    ApartmentType = ApartmentType.Penthouse,
                    SaleStatus = SaleStatus.DangMoBan,
                    BalconyDirection = BalconyDirection.TayNam,
                    ProjectApartmentID = projectApartmentID1 // Link to ProjectApartment
                }
            );





            *//*//ProjectApartmentApartment

            var projectApartmentApartmentID1 = Guid.NewGuid();
            var projectApartmentApartmentID2 = Guid.NewGuid();

            modelBuilder.Entity<ProjectApartmentApartment>().HasData(
                new ProjectApartmentApartment
                {
                    Id = projectApartmentApartmentID2,
                    ProjectApartmentID = projectApartmentID1, // ID của ProjectApartment
                    ApartmentID = apartmentID2 // ID của Apartment
                }
            );*//*

            //ApartmentOwnerApartment
            modelBuilder.Entity<ApartmentOwnerApartment>().HasData(
                new ApartmentOwnerApartment
                {
                    DocumentID = Guid.NewGuid(),
                    ApartmentID = apartmentID1, // Foreign key reference to the apartment
                    AccountID = apartmentOwnerId // Foreign key reference to the apartment owner's account
                },
                new ApartmentOwnerApartment
                {
                    DocumentID = Guid.NewGuid(),
                    ApartmentID = apartmentID1, // Foreign key reference to the apartment
                    AccountID = apartmentOwnerId // Foreign key reference to the apartment owner's account
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
                    AccountID = staffId // Reference to the staff member who created it
                },
                new VRExperience
                {
                    VRExperienceID = vrExperienceID2,
                    video_url_file = "https://example.com/vr-experience2.mp4",
                    CreateDate = DateTimeOffset.Now,
                    UpdateDate = DateTimeOffset.Now,
                    ApartmentID = apartmentID2, // Reference to the second Apartment
                    AccountID = staffId // Reference to the same staff member
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
                    AccountID = customerAccountIds[0], // Reference to the first Customer
                    ApartmentID = apartmentID1  // Reference to the first Apartment
                },
                new ApartmentInteraction
                {
                    ApartmentInteractionID = Guid.NewGuid(),
                    InteractionDate = DateTimeOffset.Now,
                    InteractionTypes = InteractionType.Inquiry, // Replace with an appropriate InteractionType
                    AccountID = customerAccountIds[1], // Reference to the second Customer
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
                    AccountID = customerAccountIds[1]// Reference to the first Customer
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
                    AccountID = customerAccountIds[0] // Reference to the second Customer
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
                    AppointmentStatus = AppointmentStatus.Confirmed, // Assuming 'Confirmed' exists in AppointmentStatus enum
                    AppointmentTypes = AppointmentTypes.Viewing, // Assuming 'Viewing' exists in AppointmentTypes enum
                    CustomerID = customerAccountIds[4], // Reference to the Customer (must ensure this account exists in the seed)
                    SlotID = slotID1, // Reference to the first Slot (must ensure this slot exists in the seed)
                    ApartmentID = apartmentID1, // Reference to the Apartment (must ensure this apartment exists in the seed)
                    StaffID = staffId, // Ensure StaffID exists in the database
                    ProjectProviderID = apartmentProjectProviderId, // Ensure ProjectProviderID exists in the database
                    ApartmentOwnerID = apartmentOwnerId // Ensure ApartmentOwnerID exists in the database
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
                    AccountID = customerAccountIds[2], // Reference to Customer
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
                    AccountID = managementId, // Reference to Management
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
            );*/

        }

    }
}
