using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class luong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberOfRooms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pricePerSquareMeter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recommendedPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    expiryDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ApartmentStatus = table.Column<int>(type: "int", nullable: false),
                    ApartmentType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.ApartmentID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountStatus = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepositCancelTypes",
                columns: table => new
                {
                    DepositCancelTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositCancelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositCancelTypes", x => x.DepositCancelTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    FacilitiesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacilitiesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacilitiesDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.FacilitiesID);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTypes",
                columns: table => new
                {
                    NotificationTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotificationTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTypes", x => x.NotificationTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    SlotID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.SlotID);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentImages",
                columns: table => new
                {
                    ApartmentImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentImages", x => x.ApartmentImageID);
                    table.ForeignKey(
                        name: "FK_ApartmentImages_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentInteractions",
                columns: table => new
                {
                    ApartmentInteractionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InteractionDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    InteractionTypes = table.Column<int>(type: "int", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentInteractions", x => x.ApartmentInteractionID);
                    table.ForeignKey(
                        name: "FK_ApartmentInteractions_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID");
                    table.ForeignKey(
                        name: "FK_ApartmentInteractions_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentOwnerApartment",
                columns: table => new
                {
                    DocumentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentOwnerApartment", x => x.DocumentID);
                    table.ForeignKey(
                        name: "FK_ApartmentOwnerApartment_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApartmentOwnerApartment_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentProjectProvider",
                columns: table => new
                {
                    ApartmentProjectProviderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentProjectProviderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApartmentProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegallInfor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentProjectProvider", x => x.ApartmentProjectProviderID);
                    table.ForeignKey(
                        name: "FK_ApartmentProjectProvider_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepositRequest",
                columns: table => new
                {
                    DepositID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    depositPercentage = table.Column<double>(type: "float", nullable: false),
                    constractNumber = table.Column<double>(type: "float", nullable: false),
                    depositAmount = table.Column<double>(type: "float", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    expiryDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DepositStatus = table.Column<int>(type: "int", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositRequest", x => x.DepositID);
                    table.ForeignKey(
                        name: "FK_DepositRequest_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID");
                    table.ForeignKey(
                        name: "FK_DepositRequest_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    FeedbackID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    FeedbackStatus = table.Column<int>(type: "int", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.FeedbackID);
                    table.ForeignKey(
                        name: "FK_Feedbacks_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestApartments",
                columns: table => new
                {
                    RequestApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResponseMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ResponseDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestApartments", x => x.RequestApartmentID);
                    table.ForeignKey(
                        name: "FK_RequestApartments_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID");
                    table.ForeignKey(
                        name: "FK_RequestApartments_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VRExperiences",
                columns: table => new
                {
                    VRExperienceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    video_url_file = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VRExperiences", x => x.VRExperienceID);
                    table.ForeignKey(
                        name: "FK_VRExperiences_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID");
                    table.ForeignKey(
                        name: "FK_VRExperiences_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentFacilitys",
                columns: table => new
                {
                    ApartmentFacilityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacilityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentFacilitys", x => x.ApartmentFacilityID);
                    table.ForeignKey(
                        name: "FK_ApartmentFacilitys_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApartmentFacilitys_Facilities_FacilityID",
                        column: x => x.FacilityID,
                        principalTable: "Facilities",
                        principalColumn: "FacilitiesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    NotificationStatus = table.Column<int>(type: "int", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    NotificationTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReferenceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationID);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_NotificationTypes_NotificationTypeID",
                        column: x => x.NotificationTypeID,
                        principalTable: "NotificationTypes",
                        principalColumn: "NotificationTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AppointmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AssignedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AppointmentDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AppointmentStatus = table.Column<int>(type: "int", nullable: false),
                    AppointmentTypes = table.Column<int>(type: "int", nullable: false),
                    SlotID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectProviderID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApartmentOwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AppointmentID);
                    table.ForeignKey(
                        name: "FK_Appointment_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID");
                    table.ForeignKey(
                        name: "FK_Appointment_AspNetUsers_ApartmentOwnerID",
                        column: x => x.ApartmentOwnerID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointment_AspNetUsers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_AspNetUsers_ProjectProviderID",
                        column: x => x.ProjectProviderID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_AspNetUsers_StaffID",
                        column: x => x.StaffID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_Slots_SlotID",
                        column: x => x.SlotID,
                        principalTable: "Slots",
                        principalColumn: "SlotID");
                });

            migrationBuilder.CreateTable(
                name: "AgreementUpdateRequests",
                columns: table => new
                {
                    AgreementUpdateRequestID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ApartmentProjectProviderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreementUpdateRequests", x => x.AgreementUpdateRequestID);
                    table.ForeignKey(
                        name: "FK_AgreementUpdateRequests_ApartmentProjectProvider_ApartmentProjectProviderID",
                        column: x => x.ApartmentProjectProviderID,
                        principalTable: "ApartmentProjectProvider",
                        principalColumn: "ApartmentProjectProviderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgreementUpdateRequests_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectApartments",
                columns: table => new
                {
                    ProjectApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectApartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectApartmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price_range = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ProjectApartmentStatus = table.Column<int>(type: "int", nullable: false),
                    ApartmentProjectProviderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectApartments", x => x.ProjectApartmentID);
                    table.ForeignKey(
                        name: "FK_ProjectApartments_ApartmentProjectProvider_ApartmentProjectProviderID",
                        column: x => x.ApartmentProjectProviderID,
                        principalTable: "ApartmentProjectProvider",
                        principalColumn: "ApartmentProjectProviderID");
                    table.ForeignKey(
                        name: "FK_ProjectApartments_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DepositCancel",
                columns: table => new
                {
                    DepositCancelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecoveryPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CancelDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RefundDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    updateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DepositID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositCancelTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositCancel", x => x.DepositCancelID);
                    table.ForeignKey(
                        name: "FK_DepositCancel_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DepositCancel_DepositCancelTypes_DepositCancelTypeID",
                        column: x => x.DepositCancelTypeID,
                        principalTable: "DepositCancelTypes",
                        principalColumn: "DepositCancelTypeID");
                    table.ForeignKey(
                        name: "FK_DepositCancel_DepositRequest_DepositID",
                        column: x => x.DepositID,
                        principalTable: "DepositRequest",
                        principalColumn: "DepositID");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ammount = table.Column<double>(type: "float", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TransactionDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TransactionStatus = table.Column<int>(type: "int", nullable: false),
                    PaymentMethods = table.Column<int>(type: "int", nullable: false),
                    DepositID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transactions_DepositRequest_DepositID",
                        column: x => x.DepositID,
                        principalTable: "DepositRequest",
                        principalColumn: "DepositID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VR_Access_Logs",
                columns: table => new
                {
                    VR_Access_LogID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    VRExperienceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VR_Access_Logs", x => x.VR_Access_LogID);
                    table.ForeignKey(
                        name: "FK_VR_Access_Logs_VRExperiences_VRExperienceID",
                        column: x => x.VRExperienceID,
                        principalTable: "VRExperiences",
                        principalColumn: "VRExperienceID");
                });

            migrationBuilder.CreateTable(
                name: "ProjectAccessLogs",
                columns: table => new
                {
                    ProjectAccessLogID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    accessDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ProjectApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectAccessLogs", x => x.ProjectAccessLogID);
                    table.ForeignKey(
                        name: "FK_ProjectAccessLogs_ProjectApartments_ProjectApartmentID",
                        column: x => x.ProjectApartmentID,
                        principalTable: "ProjectApartments",
                        principalColumn: "ProjectApartmentID");
                });

            migrationBuilder.CreateTable(
                name: "ProjectApartmentApartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectApartmentApartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectApartmentApartments_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectApartmentApartments_ProjectApartments_ProjectApartmentID",
                        column: x => x.ProjectApartmentID,
                        principalTable: "ProjectApartments",
                        principalColumn: "ProjectApartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectImages",
                columns: table => new
                {
                    ProjectImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ProjectApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectImages", x => x.ProjectImageID);
                    table.ForeignKey(
                        name: "FK_ProjectImages_ProjectApartments_ProjectApartmentID",
                        column: x => x.ProjectApartmentID,
                        principalTable: "ProjectApartments",
                        principalColumn: "ProjectApartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "ApartmentName", "ApartmentStatus", "ApartmentType", "CreatedDate", "Description", "UpdatedDate", "address", "area", "direction", "expiryDate", "location", "numberOfRooms", "pricePerSquareMeter", "recommendedPrice" },
                values: new object[,]
                {
                    { new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), "Skyline Apartment", 0, 1, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5379), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5380), new TimeSpan(0, 7, 0, 0, 0)), "123 Skyline Road, New City", "1500 sqft", "North-East", new DateTimeOffset(new DateTime(2029, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5386), new TimeSpan(0, 7, 0, 0, 0)), "City Center", "3", "3000 USD", "450,000 USD" },
                    { new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"), "Ocean View Apartment", 1, 0, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5402), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5403), new TimeSpan(0, 7, 0, 0, 0)), "456 Ocean Drive, Coastal City", "1800 sqft", "South-West", new DateTimeOffset(new DateTime(2027, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5404), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", "4", "3500 USD", "650,000 USD" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("097a1b34-0631-4927-8aa8-b73f7bbfd3cf"), null, "Apartment Owner", "APARTMENT OWNER" },
                    { new Guid("28d1d9c4-5494-4a44-a498-f707059beebd"), null, "Staff", "STAFF" },
                    { new Guid("c9387730-b4b9-4826-9e3e-5d2a8f19164f"), null, "Management", "MANAGEMENT" },
                    { new Guid("d178a45e-39bb-45b2-a187-d9610cc7b0e0"), null, "Admin", "ADMIN" },
                    { new Guid("eb3397f0-a597-4349-8644-cce880e97a26"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("efbe96c4-208e-478a-bbb2-b90abcf71046"), null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0806bf44-b0f6-41cf-8c81-7507752daabd"), 0, 0, null, "c69cda7a-3882-4a84-8a57-96072b1a7bdd", "alice.smith@example.com", true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAENRecLu8dgnaFAcIByJPryoI9hXvlX+7YJanmC3gJI12SAnQbk8zoi3H2VA5sYGJmw==", "0901234567", true, "7fe95f4c-cd5b-4608-83a7-fc8a27e8227a", false, "alice.smith@example.com" },
                    { new Guid("3bae2bac-b3d8-46bc-bc60-59aa6c908aaa"), 0, 0, "", "a0c23820-caf9-4593-aa86-1486e4c45239", "construction.corp@example.com", true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", "AQAAAAIAAYagAAAAENCYpOeb+4nGX7Pwuh1sjXodFzEvvMmzlrqWcZQLOfpc0y2DxC6WKfjoNOj7GzWcxw==", "0987654321", true, "1dc5a0fd-64fa-4eb9-95ca-ea690e7fc5d7", false, "construction.corp@example.com" },
                    { new Guid("461453f7-a527-4df3-bac5-7394fa8f0691"), 0, 0, "", "2c48383d-c50e-42dd-8907-89a2adceb2a3", "alice.johnson@example.com", true, false, null, "Alice Johnson", "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHd+iRVMmCyVnwseYLh7TCReVHBUIBCglmsmiVnUbfLrYW2i5ISuQ5r0nH+HUJTeSA==", "0987654321", true, "6abd4fc0-efec-47c0-9993-61e87e450562", false, "alice.johnson@example.com" },
                    { new Guid("60039256-f860-480d-8b8c-22587e7fb6fd"), 0, 0, "", "247e195f-cd94-44fc-8183-f3b32634e114", "david.brown@example.com", true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPlPpz4P8jBKUx43kE5z9XH2zNeHxgduRkxoq8AbyY3Z2SQoFu2odlaNhUwnGgEprw==", "0123456789", true, "6e4cd709-78cc-4e23-965b-699b0124d26a", false, "david.brown@example.com" },
                    { new Guid("693ea210-9a93-4a18-aa8a-30c011ef778c"), 0, 0, "", "7d513f34-c42a-4e00-a151-49ef52f783c1", "michael.smith@example.com", true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHqlATY/vlBEKQl52hMZTuKBF5eGa85o9V2Q0lKMmwo0doiYHOWk9KGpe+KrPCUT7g==", "0123456789", true, "58ba3567-e105-4dd0-a37d-2e933e0a636d", false, "michael.smith@example.com" },
                    { new Guid("88496895-d698-4903-b154-840d3c5adce2"), 0, 0, "", "593f4792-40c2-455e-a3ed-d448cf34f8fd", "quansongngu13@gmail.com", true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", "AQAAAAIAAYagAAAAEMIFoyOyCxHoZ5+K7amQif+6hV5GkQvT0XAn8YcIzaBmKIWSKPhSe+P20ktF0OajNQ==", "0949035672", true, "f102216f-f391-4e92-aa50-128d36a62945", false, "quansongngu13@gmail.com" },
                    { new Guid("8adf7591-c138-4a97-b890-4cc778f2b1a6"), 0, 0, null, "9fab25cd-396b-49c3-9e0d-d7c87d93e81e", "bob.johnson@example.com", true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOsQwGdYp+QDQZoTwbjWkOTxVgp/hAb7ad0bTQ3d72mJRolLjQ20cquUKZnqZK7LWw==", "0902345678", true, "892cf3b0-3920-455e-8675-1eca2d7e2375", false, "bob.johnson@example.com" },
                    { new Guid("a31405f3-f989-409f-ace7-639ca1224b33"), 0, 0, null, "69adcd0a-cb5b-4288-8f1b-3febae976ecb", "charlie.brown@example.com", true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDarHG8AdTxBqEGLe3McORI0wgLuW4t8DJy8eP4uuDQZA1ltlqFeklwbtdlAmo0fKA==", "0903456789", true, "e2f607fa-0754-4327-8f3d-e606e95848ef", false, "charlie.brown@example.com" },
                    { new Guid("bb41f6af-3812-4601-9e84-e08501b164e7"), 0, 0, null, "45aa99ca-a910-42bb-86b9-5e027caae018", "diana.prince@example.com", true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKgtpbiY0qRS2atBGD8NEN8+0qTLwUz+lyfsd6mTCJn8bSswaQSHZ1qk0fTCYkqfQQ==", "0904567890", true, "c320c1e1-600f-4bae-9dc5-ee2a5a7ffedd", false, "diana.prince@example.com" },
                    { new Guid("cfd6d61e-2946-4b27-a81e-dedce672b921"), 0, 0, null, "3da2f3f2-35ac-41eb-860d-150edb90bdf8", "eve.adams@example.com", true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIaPcS17z3sfNp+hN4h+2f8oPX4FavO1zECm7JTOfn5snbW6UNbSpvix10erIeIMLQ==", "0905678901", true, "c933ce27-687f-4575-bc85-ef6fcb421e44", false, "eve.adams@example.com" },
                    { new Guid("e6831c1c-ed9e-44c9-851d-52451fda6c51"), 0, 0, null, "5169245a-a020-4fa6-be55-496b3fcb1477", "johndoe@example.com", true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAECNzw82D/2WRj4imUD0iurY0VFqJ1BjfDOQuiVZj+tzhjI5dpDSvrklzPiRjHuUkzw==", "123456789", true, "579c22c6-953b-44e7-9901-abb63469bfa5", false, "johndoe@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("fc9d149d-34d5-480d-9ce5-a8f46941dc5b"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6133), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6134), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("33a7ab03-069f-4bd3-861f-74f69d78911b"), "A large outdoor swimming pool.", "Swimming Pool" },
                    { new Guid("e8aec68e-627d-41fc-8ee8-1fef017c4e29"), "A fully equipped fitness gym.", "Gym" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("728c6518-6fd6-4b15-8a08-b41b84706c7a"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("15429fdd-b613-4312-b593-413de71568ae"), "11:00 AM", "10:00 AM" },
                    { new Guid("5ef2fa8a-a7a3-4942-a753-af17d405caaf"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("55e0ee81-e58a-4e4a-9431-f72575f53689"), new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"), new Guid("e8aec68e-627d-41fc-8ee8-1fef017c4e29") },
                    { new Guid("dd063c7f-7bb7-4aea-aaef-1df0e07585ee"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new Guid("33a7ab03-069f-4bd3-861f-74f69d78911b") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("42b4c801-5355-49d4-a34c-47c9baaf0264"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5643), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("feeaa0de-b08b-456a-b748-25d67f30566d"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5654), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("4bba8a95-b267-4193-9cde-ab249794e8ec"), new Guid("8adf7591-c138-4a97-b890-4cc778f2b1a6"), new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5831), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { new Guid("8be95c4c-a2de-4ebb-a64d-5bad0f01958c"), new Guid("0806bf44-b0f6-41cf-8c81-7507752daabd"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5819), new TimeSpan(0, 7, 0, 0, 0)), 0 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("c6c42f8b-8424-4a0e-92d5-519b13211309"), new Guid("60039256-f860-480d-8b8c-22587e7fb6fd"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c") },
                    { new Guid("e583a5f3-fde3-410a-beac-802b423aa27c"), new Guid("60039256-f860-480d-8b8c-22587e7fb6fd"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("8746b54f-3968-43b1-9b29-81e0a2ad14f0"), new Guid("3bae2bac-b3d8-46bc-bc60-59aa6c908aaa"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(4693), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(4695), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("6975db10-66c2-46a8-b8b7-3a99ad777082"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new Guid("60039256-f860-480d-8b8c-22587e7fb6fd"), new DateTimeOffset(new DateTime(2024, 9, 29, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6091), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6090), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6088), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cfd6d61e-2946-4b27-a81e-dedce672b921"), "Schedule a viewing for the Skyline Apartment.", new Guid("3bae2bac-b3d8-46bc-bc60-59aa6c908aaa"), new Guid("5ef2fa8a-a7a3-4942-a753-af17d405caaf"), new Guid("e6831c1c-ed9e-44c9-851d-52451fda6c51"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6089), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("eb3397f0-a597-4349-8644-cce880e97a26"), new Guid("3bae2bac-b3d8-46bc-bc60-59aa6c908aaa") },
                    { new Guid("c9387730-b4b9-4826-9e3e-5d2a8f19164f"), new Guid("461453f7-a527-4df3-bac5-7394fa8f0691") },
                    { new Guid("097a1b34-0631-4927-8aa8-b73f7bbfd3cf"), new Guid("60039256-f860-480d-8b8c-22587e7fb6fd") },
                    { new Guid("efbe96c4-208e-478a-bbb2-b90abcf71046"), new Guid("693ea210-9a93-4a18-aa8a-30c011ef778c") },
                    { new Guid("d178a45e-39bb-45b2-a187-d9610cc7b0e0"), new Guid("88496895-d698-4903-b154-840d3c5adce2") },
                    { new Guid("28d1d9c4-5494-4a44-a498-f707059beebd"), new Guid("e6831c1c-ed9e-44c9-851d-52451fda6c51") }
                });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("579fe412-44da-4086-a8bc-631d60e8d68b"), new Guid("a31405f3-f989-409f-ace7-639ca1224b33"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6169), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6172), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 10, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6174), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("6b9935ad-c4eb-43d1-b2ca-93c92e071f90"), new Guid("8adf7591-c138-4a97-b890-4cc778f2b1a6"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6328), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" },
                    { new Guid("85703689-9854-4156-8c41-cf7373490ad9"), new Guid("0806bf44-b0f6-41cf-8c81-7507752daabd"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6324), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("0109df04-49ac-486e-84d1-892fec4b3166"), new Guid("a31405f3-f989-409f-ace7-639ca1224b33"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6396), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("728c6518-6fd6-4b15-8a08-b41b84706c7a"), new Guid("9f5adbb6-e8ae-4c58-8f6d-bfef6944504a"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6397), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("85ec1cc8-1b9e-4f16-b21e-399458924d9a"), new Guid("8adf7591-c138-4a97-b890-4cc778f2b1a6"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6402), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("728c6518-6fd6-4b15-8a08-b41b84706c7a"), new Guid("cc702a42-ce0e-4ed3-81ca-e850d69f5a4a"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6403), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("197b8a44-5321-4c22-b9d5-ff6d4aecb1e1"), new Guid("0806bf44-b0f6-41cf-8c81-7507752daabd"), new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5935), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 9, 29, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5936), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." },
                    { new Guid("b99dddb1-e1a1-4b2d-96a2-57414202cede"), new Guid("8adf7591-c138-4a97-b890-4cc778f2b1a6"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5924), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 9, 29, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5925), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("9050603b-375d-40f2-abd3-45937f53641e"), new Guid("e6831c1c-ed9e-44c9-851d-52451fda6c51"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5736), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" },
                    { new Guid("d12c972d-0a6a-4ef5-8583-323465b9cabe"), new Guid("e6831c1c-ed9e-44c9-851d-52451fda6c51"), new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5741), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5743), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("89cca6d0-51d4-42d5-975c-3ffcf2dc7fe3"), new Guid("461453f7-a527-4df3-bac5-7394fa8f0691"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6289), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fc9d149d-34d5-480d-9ce5-a8f46941dc5b"), new Guid("579fe412-44da-4086-a8bc-631d60e8d68b"), "45000", new DateTimeOffset(new DateTime(2024, 10, 3, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6290), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6294), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("32855b2d-41b3-4d91-b077-9e3f2e9330d5"), null, new Guid("8746b54f-3968-43b1-9b29-81e0a2ad14f0"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5157), new TimeSpan(0, 7, 0, 0, 0)), "1,000,000 - 2,000,000 USD", "A luxurious penthouse suite with stunning views.", "Penthouse Suite", 0, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5158), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a2c7e609-7c85-41d4-b218-2f70c741fdbd"), null, new Guid("8746b54f-3968-43b1-9b29-81e0a2ad14f0"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(4878), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(4879), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("9d2c2d5a-86bc-429e-8c4d-4dd91357ed03"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6250), new TimeSpan(0, 7, 0, 0, 0)), new Guid("579fe412-44da-4086-a8bc-631d60e8d68b"), 0, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6253), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("cd6eac7c-019b-4c7c-9fc7-7d6b37b91f06"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9050603b-375d-40f2-abd3-45937f53641e") },
                    { new Guid("fe25189e-0f70-43f1-8c36-e5432de01e35"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5786), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d12c972d-0a6a-4ef5-8583-323465b9cabe") }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[,]
                {
                    { new Guid("4093fd29-162e-46c3-b8ba-e3a6dea16f49"), new Guid("a2c7e609-7c85-41d4-b218-2f70c741fdbd"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5242), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("64e5ad4c-feff-4c10-9c61-d58b798ce4da"), new Guid("32855b2d-41b3-4d91-b077-9e3f2e9330d5"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5245), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartmentApartments",
                columns: new[] { "Id", "ApartmentID", "ProjectApartmentID" },
                values: new object[] { new Guid("d44a9003-a2a4-49a8-8fed-3e1673918d8b"), new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"), new Guid("a2c7e609-7c85-41d4-b218-2f70c741fdbd") });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[,]
                {
                    { new Guid("2ea80b11-b32f-4994-b444-f649b48bb73c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5312), new TimeSpan(0, 7, 0, 0, 0)), "Image of the penthouse suite", "Penthouse Suite Image", new Guid("32855b2d-41b3-4d91-b077-9e3f2e9330d5"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5313), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/penthouse-suite.jpg" },
                    { new Guid("92b9eace-c3f9-46c6-ae6c-8a7729edf6f7"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5308), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("a2c7e609-7c85-41d4-b218-2f70c741fdbd"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5309), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgreementUpdateRequests_AccountID",
                table: "AgreementUpdateRequests",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_AgreementUpdateRequests_ApartmentProjectProviderID",
                table: "AgreementUpdateRequests",
                column: "ApartmentProjectProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentFacilitys_ApartmentID",
                table: "ApartmentFacilitys",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentFacilitys_FacilityID",
                table: "ApartmentFacilitys",
                column: "FacilityID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentImages_ApartmentID",
                table: "ApartmentImages",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentInteractions_AccountID",
                table: "ApartmentInteractions",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentInteractions_ApartmentID",
                table: "ApartmentInteractions",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwnerApartment_AccountID",
                table: "ApartmentOwnerApartment",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwnerApartment_ApartmentID",
                table: "ApartmentOwnerApartment",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentProjectProvider_AccountID",
                table: "ApartmentProjectProvider",
                column: "AccountID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ApartmentID",
                table: "Appointment",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ApartmentOwnerID",
                table: "Appointment",
                column: "ApartmentOwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_CustomerID",
                table: "Appointment",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ProjectProviderID",
                table: "Appointment",
                column: "ProjectProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_SlotID",
                table: "Appointment",
                column: "SlotID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_StaffID",
                table: "Appointment",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DepositCancel_AccountID",
                table: "DepositCancel",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_DepositCancel_DepositCancelTypeID",
                table: "DepositCancel",
                column: "DepositCancelTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DepositCancel_DepositID",
                table: "DepositCancel",
                column: "DepositID");

            migrationBuilder.CreateIndex(
                name: "IX_DepositRequest_AccountID",
                table: "DepositRequest",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_DepositRequest_ApartmentID",
                table: "DepositRequest",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_AccountID",
                table: "Feedbacks",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_AccountID",
                table: "Notifications",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationTypeID",
                table: "Notifications",
                column: "NotificationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAccessLogs_ProjectApartmentID",
                table: "ProjectAccessLogs",
                column: "ProjectApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectApartmentApartments_ApartmentID",
                table: "ProjectApartmentApartments",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectApartmentApartments_ProjectApartmentID",
                table: "ProjectApartmentApartments",
                column: "ProjectApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectApartments_AccountId",
                table: "ProjectApartments",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectApartments_ApartmentProjectProviderID",
                table: "ProjectApartments",
                column: "ApartmentProjectProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImages_ProjectApartmentID",
                table: "ProjectImages",
                column: "ProjectApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestApartments_AccountID",
                table: "RequestApartments",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestApartments_ApartmentID",
                table: "RequestApartments",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_DepositID",
                table: "Transactions",
                column: "DepositID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VR_Access_Logs_VRExperienceID",
                table: "VR_Access_Logs",
                column: "VRExperienceID");

            migrationBuilder.CreateIndex(
                name: "IX_VRExperiences_AccountID",
                table: "VRExperiences",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_VRExperiences_ApartmentID",
                table: "VRExperiences",
                column: "ApartmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgreementUpdateRequests");

            migrationBuilder.DropTable(
                name: "ApartmentFacilitys");

            migrationBuilder.DropTable(
                name: "ApartmentImages");

            migrationBuilder.DropTable(
                name: "ApartmentInteractions");

            migrationBuilder.DropTable(
                name: "ApartmentOwnerApartment");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DepositCancel");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "ProjectAccessLogs");

            migrationBuilder.DropTable(
                name: "ProjectApartmentApartments");

            migrationBuilder.DropTable(
                name: "ProjectImages");

            migrationBuilder.DropTable(
                name: "RequestApartments");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "VR_Access_Logs");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "DepositCancelTypes");

            migrationBuilder.DropTable(
                name: "NotificationTypes");

            migrationBuilder.DropTable(
                name: "ProjectApartments");

            migrationBuilder.DropTable(
                name: "DepositRequest");

            migrationBuilder.DropTable(
                name: "VRExperiences");

            migrationBuilder.DropTable(
                name: "ApartmentProjectProvider");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
