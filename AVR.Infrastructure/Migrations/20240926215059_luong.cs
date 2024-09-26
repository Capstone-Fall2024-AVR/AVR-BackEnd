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
                name: "ApartmentDocument",
                columns: table => new
                {
                    DocumentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentDocument", x => x.DocumentID);
                    table.ForeignKey(
                        name: "FK_ApartmentDocument_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApartmentDocument_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
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
                        principalColumn: "Id");
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
                name: "Deposit",
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
                    table.PrimaryKey("PK_Deposit", x => x.DepositID);
                    table.ForeignKey(
                        name: "FK_Deposit_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID");
                    table.ForeignKey(
                        name: "FK_Deposit_AspNetUsers_AccountID",
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
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectApartments", x => x.ProjectApartmentID);
                    table.ForeignKey(
                        name: "FK_ProjectApartments_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestApartment",
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
                    table.PrimaryKey("PK_RequestApartment", x => x.RequestApartmentID);
                    table.ForeignKey(
                        name: "FK_RequestApartment_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID");
                    table.ForeignKey(
                        name: "FK_RequestApartment_AspNetUsers_AccountID",
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
                name: "ApartmentFacility",
                columns: table => new
                {
                    ApartmentFacilityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacilityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentFacility", x => x.ApartmentFacilityID);
                    table.ForeignKey(
                        name: "FK_ApartmentFacility_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApartmentFacility_Facilities_FacilityID",
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
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_Appointment_AspNetUsers_AccountID",
                        column: x => x.AccountID,
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
                name: "AgreementUpdateRequest",
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
                    table.PrimaryKey("PK_AgreementUpdateRequest", x => x.AgreementUpdateRequestID);
                    table.ForeignKey(
                        name: "FK_AgreementUpdateRequest_ApartmentProjectProvider_ApartmentProjectProviderID",
                        column: x => x.ApartmentProjectProviderID,
                        principalTable: "ApartmentProjectProvider",
                        principalColumn: "ApartmentProjectProviderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgreementUpdateRequest_AspNetUsers_AccountID",
                        column: x => x.AccountID,
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
                        name: "FK_DepositCancel_Deposit_DepositID",
                        column: x => x.DepositID,
                        principalTable: "Deposit",
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
                        name: "FK_Transactions_Deposit_DepositID",
                        column: x => x.DepositID,
                        principalTable: "Deposit",
                        principalColumn: "DepositID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "ProjectApartmentApartment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectApartmentApartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectApartmentApartment_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectApartmentApartment_ProjectApartments_ProjectApartmentID",
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

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "ApartmentName", "ApartmentStatus", "ApartmentType", "CreatedDate", "Description", "UpdatedDate", "address", "area", "direction", "expiryDate", "location", "numberOfRooms", "pricePerSquareMeter", "recommendedPrice" },
                values: new object[,]
                {
                    { new Guid("13234002-73d3-4fc9-ad67-b6e6aa439f8b"), "Skyline Apartment", 0, 1, new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(847), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(849), new TimeSpan(0, 7, 0, 0, 0)), "123 Skyline Road, New City", "1500 sqft", "North-East", new DateTimeOffset(new DateTime(2029, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(852), new TimeSpan(0, 7, 0, 0, 0)), "City Center", "3", "3000 USD", "450,000 USD" },
                    { new Guid("dd3005a3-562f-4b6b-82ed-7c5007e19636"), "Ocean View Apartment", 1, 0, new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(869), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(870), new TimeSpan(0, 7, 0, 0, 0)), "456 Ocean Drive, Coastal City", "1800 sqft", "South-West", new DateTimeOffset(new DateTime(2027, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(872), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", "4", "3500 USD", "650,000 USD" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2ff06712-c4ae-4e32-b48d-ba1c42a73e3b"), null, "Staff", "STAFF" },
                    { new Guid("319218d9-e824-462e-9105-a8ab3ec76af1"), null, "Apartment Owner", "APARTMENT OWNER" },
                    { new Guid("32715c10-4c89-4bb2-b6f9-6ca5409a367b"), null, "Admin", "ADMIN" },
                    { new Guid("3f9f7dde-fe6d-495d-a523-b15c3c7b0ef6"), null, "Customer", "CUSTOMER" },
                    { new Guid("b189886d-bf40-473a-8638-03c99b786a05"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("ce788a3a-49da-41a1-a0b7-76c4ce41a30c"), null, "Management", "MANAGEMENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("02aed624-7f0b-4d24-8d18-ebf1e4bd0884"), 0, 0, null, "8a1a8629-05f2-4a38-ae6d-738995bb5cdd", "diana.prince@example.com", true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKoeGokBLbMtmsKT2scM3Am9aPWWM4J6f2iSNd8yw+1iEYWdGL+dUkmnpupNrqkykA==", "0904567890", true, "eb59fbbe-5923-49fa-963d-9754510cee8f", false, "diana.prince@example.com" },
                    { new Guid("137b4784-8d3e-4de7-a5eb-4784f193dc72"), 0, 0, "", "a06e6568-fc81-486e-b414-8d6889539210", "alice.johnson@example.com", true, false, null, "Alice Johnson", "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN3faEY1vebFMoTQgkPfCkSOQsD8H+jKTjAdZuL8O9v+6Oh5SfRQLlSjrkct1DZ5EQ==", "0987654321", true, "53d0b132-f43c-4686-b485-e8629c1279f8", false, "alice.johnson@example.com" },
                    { new Guid("2abd55c2-afa6-49c4-aa69-9c02a742395c"), 0, 0, "", "9255f456-02f1-44cf-b918-3852265e10da", "quansongngu13@gmail.com", true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", "AQAAAAIAAYagAAAAEDQGBgRq1z05XLpZDb/PwDQ7XKYGEIqOo5xJtbr8c9OWUxjcEN/G+EvyVUiP1KKMrw==", "0949035672", true, "93cb67e7-2238-4479-a34c-8b6c28e3d531", false, "quansongngu13@gmail.com" },
                    { new Guid("2ecdc9a2-5be7-4a97-9814-7ca27b99decd"), 0, 0, "", "02287fc7-0b0f-4512-8c0d-2338c20d720a", "david.brown@example.com", true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBV7uMyGptMuqCSyBMqKfQGHhm3vAaWJBsb135JJHFELc5WTFx21Ta1POCVcahaELA==", "0123456789", true, "1126e325-d6e5-4129-97ca-7cddf63b8e4c", false, "david.brown@example.com" },
                    { new Guid("50d0a7be-5648-45b9-9e44-a7dd125736bc"), 0, 0, "", "b352428a-4328-46e1-a0df-19a17f1f3702", "construction.corp@example.com", true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDNr1rUYdwkut+kzfOC1aSNxEFJKt3bbo4Jdy7QRim3tOYFIYnXEaaC/AJBr8s8xew==", "0987654321", true, "053164be-109e-4736-9420-6e4ec438a340", false, "construction.corp@example.com" },
                    { new Guid("7d122027-610a-417b-b702-ca555f4c4a62"), 0, 0, null, "abd50b11-b635-4842-92f1-0c95b43682a4", "eve.adams@example.com", true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL/1S7S5cAKjb04PS3qtVhTH6pCaOyaN9lE2vnVi0cHeXyKJAvlD4ZyPvLmnRyNxGg==", "0905678901", true, "c5b5fc73-67ae-4149-b279-3d1078840555", false, "eve.adams@example.com" },
                    { new Guid("7dbad114-6bff-4136-bd3a-96482770d3ec"), 0, 0, null, "485a5b26-72fa-4520-9089-dd6c7dc8f4b6", "bob.johnson@example.com", true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAENuDnrUmpKI/vmCHUhfwHerGkqxndVv6BAoXQruRhmadhJU6NV3S/rmp7nQ6jANisw==", "0902345678", true, "5d7ddab0-6c16-4eb2-85cd-57202681cf56", false, "bob.johnson@example.com" },
                    { new Guid("a4144f36-65ee-4ef7-9249-a078312bff12"), 0, 0, "", "8b6fdcbc-e0d1-4521-8009-ab936eab4c5d", "michael.smith@example.com", true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAECMTWtYkNl3kDbZxsGBftb9o6jCrdUH2saCXanjJdbQH2MulmXxd7B0kwGX6wnXp0g==", "0123456789", true, "d9e25a31-058c-40a8-a8b7-b31fe270463b", false, "michael.smith@example.com" },
                    { new Guid("cf5086a7-f403-45fe-b990-f971f0e0580c"), 0, 0, null, "79fa4c9b-8d9d-4a62-a495-a65ecc26e4c8", "charlie.brown@example.com", true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKTwvFVdd2jd2cmO0mp+se56WZw6HCeeV7RkXvbA0wWsYEzuMngtJYBuRpDLQ9xaPw==", "0903456789", true, "0b31a9ef-0aba-4b0e-bf73-0dd2b5355528", false, "charlie.brown@example.com" },
                    { new Guid("fa49ba2c-22cc-4d66-9c5f-1378baf2dd53"), 0, 0, null, "63b164da-159a-4689-ad1f-eed6052d9f13", "johndoe@example.com", true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEqjsqKRzmags+iM0TK1sARqIArO66X/DHDI9CUNLfeFPYtk2lGaxP+Q21hZFIVq+w==", "123456789", true, "5bbc4629-7c0b-4670-a359-29b962a4a480", false, "johndoe@example.com" },
                    { new Guid("fd0b372e-db8b-4798-9953-f99d1452960f"), 0, 0, null, "1f144d54-4344-43b4-8a5a-5a6a2918946d", "alice.smith@example.com", true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEISYIk4wXOMUIkr0rRMv/qHnOH/nRPpxXHVWj5WbWrlFUyyaIHbab+/2PilUADE36g==", "0901234567", true, "471d8d0b-6023-458b-b18b-b0a8c3a52a8d", false, "alice.smith@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("518d722e-87c2-410b-8596-523327b84104"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1681), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1683), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("15ae100c-e805-4176-a68c-398cb13035ef"), "A large outdoor swimming pool.", "Swimming Pool" },
                    { new Guid("6aa45cb3-f4dd-4d65-8d8f-61b80501e511"), "A fully equipped fitness gym.", "Gym" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("70632cf1-222a-4925-8d66-4168511d672f"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("86eb2dc4-0be2-4df5-aa43-28af0856489b"), "11:00 AM", "10:00 AM" },
                    { new Guid("921a8ebe-d137-4381-8ffd-e2fb3f0cf207"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentDocument",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID", "DocumentType", "DocumentUrl" },
                values: new object[,]
                {
                    { new Guid("1bcc73fd-d984-451f-aa5a-824b97986e45"), new Guid("2ecdc9a2-5be7-4a97-9814-7ca27b99decd"), new Guid("13234002-73d3-4fc9-ad67-b6e6aa439f8b"), "Giấy phép xây dựng", "https://example.com/documents/apartment1_permit.pdf" },
                    { new Guid("873d5c65-4b45-4341-9afc-e273b15cb55e"), new Guid("2ecdc9a2-5be7-4a97-9814-7ca27b99decd"), new Guid("13234002-73d3-4fc9-ad67-b6e6aa439f8b"), "Sổ hồng", "https://example.com/documents/apartment1_certificate.pdf" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentFacility",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("d7c2232e-1285-4f93-9785-48ebe8688f75"), new Guid("13234002-73d3-4fc9-ad67-b6e6aa439f8b"), new Guid("15ae100c-e805-4176-a68c-398cb13035ef") },
                    { new Guid("dc1d4a22-b4be-45b5-b333-6c3edd5759d5"), new Guid("dd3005a3-562f-4b6b-82ed-7c5007e19636"), new Guid("6aa45cb3-f4dd-4d65-8d8f-61b80501e511") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("f7cf6e17-73c6-4ebd-aa69-de1c7866a1a5"), new Guid("13234002-73d3-4fc9-ad67-b6e6aa439f8b"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1128), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1142), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("f94ed2a9-d5d1-4019-abdd-52b90d0b7b2d"), new Guid("13234002-73d3-4fc9-ad67-b6e6aa439f8b"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1112), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1119), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("270b3072-1672-4d78-9927-9d72570e69a3"), new Guid("fd0b372e-db8b-4798-9953-f99d1452960f"), new Guid("13234002-73d3-4fc9-ad67-b6e6aa439f8b"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1409), new TimeSpan(0, 7, 0, 0, 0)), 0 },
                    { new Guid("8ed263e3-8f09-4cd6-bb4e-c7d7684f6c3a"), new Guid("7dbad114-6bff-4136-bd3a-96482770d3ec"), new Guid("dd3005a3-562f-4b6b-82ed-7c5007e19636"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1421), new TimeSpan(0, 7, 0, 0, 0)), 1 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("db7845ad-eb8d-44b7-a793-6b830764d940"), new Guid("50d0a7be-5648-45b9-9e44-a7dd125736bc"), "A leading provider of luxury apartment projects.", "Construction Corp", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(104), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information and Compliance Details.", "123 Construction Ave, Citytown, ST 12345", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(105), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "AccountID", "ApartmentID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "Description", "SlotID", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("521083fc-07f9-4ac3-9071-37b5dbf344a7"), new Guid("7d122027-610a-417b-b702-ca555f4c4a62"), new Guid("13234002-73d3-4fc9-ad67-b6e6aa439f8b"), new DateTimeOffset(new DateTime(2024, 9, 28, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1633), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1631), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1628), new TimeSpan(0, 7, 0, 0, 0)), "Schedule a viewing for the Skyline Apartment.", new Guid("921a8ebe-d137-4381-8ffd-e2fb3f0cf207"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1629), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("6f355a20-1fff-4e9d-9395-aa948f29e5a3"), new Guid("02aed624-7f0b-4d24-8d18-ebf1e4bd0884"), new Guid("dd3005a3-562f-4b6b-82ed-7c5007e19636"), new DateTimeOffset(new DateTime(2024, 9, 29, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1644), new TimeSpan(0, 7, 0, 0, 0)), 0, 0, "Admin", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1643), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1642), new TimeSpan(0, 7, 0, 0, 0)), "Discuss details about the Ocean View Apartment.", new Guid("86eb2dc4-0be2-4df5-aa43-28af0856489b"), "Inquiry Appointment for Ocean View Apartment", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1643), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ce788a3a-49da-41a1-a0b7-76c4ce41a30c"), new Guid("137b4784-8d3e-4de7-a5eb-4784f193dc72") },
                    { new Guid("32715c10-4c89-4bb2-b6f9-6ca5409a367b"), new Guid("2abd55c2-afa6-49c4-aa69-9c02a742395c") },
                    { new Guid("319218d9-e824-462e-9105-a8ab3ec76af1"), new Guid("2ecdc9a2-5be7-4a97-9814-7ca27b99decd") },
                    { new Guid("b189886d-bf40-473a-8638-03c99b786a05"), new Guid("50d0a7be-5648-45b9-9e44-a7dd125736bc") },
                    { new Guid("3f9f7dde-fe6d-495d-a523-b15c3c7b0ef6"), new Guid("a4144f36-65ee-4ef7-9249-a078312bff12") },
                    { new Guid("2ff06712-c4ae-4e32-b48d-ba1c42a73e3b"), new Guid("fa49ba2c-22cc-4d66-9c5f-1378baf2dd53") }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("4cdf2afa-dfa5-4bb3-b9dd-4eb2c87a86fd"), new Guid("cf5086a7-f403-45fe-b990-f971f0e0580c"), new Guid("13234002-73d3-4fc9-ad67-b6e6aa439f8b"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1717), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1720), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 10, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1722), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("09a0388b-4c62-4d43-8da6-22eef4460b63"), new Guid("fd0b372e-db8b-4798-9953-f99d1452960f"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1849), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" },
                    { new Guid("7f97af86-eaed-43b1-a422-e5140808013b"), new Guid("7dbad114-6bff-4136-bd3a-96482770d3ec"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1854), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("1665aa78-94bc-43ad-985b-ee7942460e34"), new Guid("cf5086a7-f403-45fe-b990-f971f0e0580c"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1921), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("70632cf1-222a-4925-8d66-4168511d672f"), new Guid("cbee4632-4d1a-46d6-98a2-ed1438897b6e"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1922), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8c707f8f-e24f-4f0c-9f86-9f81b2c9f36e"), new Guid("7dbad114-6bff-4136-bd3a-96482770d3ec"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1927), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("70632cf1-222a-4925-8d66-4168511d672f"), new Guid("49846a09-695b-482f-9a23-130e8b279f9d"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1928), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("9bfdcc16-76bd-4e3a-844f-2e980d9535c6"), new Guid("50d0a7be-5648-45b9-9e44-a7dd125736bc"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(297), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(298), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("c12db5dd-1059-4d57-a49a-6b4c77f5640a"), new Guid("50d0a7be-5648-45b9-9e44-a7dd125736bc"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(302), new TimeSpan(0, 7, 0, 0, 0)), "1,000,000 - 2,000,000 USD", "A luxurious penthouse suite with stunning views.", "Penthouse Suite", 0, new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(303), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "RequestApartment",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("2159710b-5b4c-4d34-ba29-72e6713e5725"), new Guid("fd0b372e-db8b-4798-9953-f99d1452960f"), new Guid("dd3005a3-562f-4b6b-82ed-7c5007e19636"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1551), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 9, 28, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1552), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." },
                    { new Guid("b14e0bdb-095d-469a-a64b-6aa0b0f8ea7b"), new Guid("7dbad114-6bff-4136-bd3a-96482770d3ec"), new Guid("13234002-73d3-4fc9-ad67-b6e6aa439f8b"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 9, 28, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("1817b187-8a36-4b7f-8875-76dd0902bb0e"), new Guid("fa49ba2c-22cc-4d66-9c5f-1378baf2dd53"), new Guid("dd3005a3-562f-4b6b-82ed-7c5007e19636"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1204), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1205), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" },
                    { new Guid("3849c4a4-f921-4eb3-afd8-a6f540ccd3a6"), new Guid("fa49ba2c-22cc-4d66-9c5f-1378baf2dd53"), new Guid("13234002-73d3-4fc9-ad67-b6e6aa439f8b"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1199), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("0c77ba39-2812-4fac-a9ab-af2e9f14056a"), new Guid("137b4784-8d3e-4de7-a5eb-4784f193dc72"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1812), new TimeSpan(0, 7, 0, 0, 0)), new Guid("518d722e-87c2-410b-8596-523327b84104"), new Guid("4cdf2afa-dfa5-4bb3-b9dd-4eb2c87a86fd"), "45000", new DateTimeOffset(new DateTime(2024, 10, 2, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1813), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1815), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[,]
                {
                    { new Guid("5f19cb21-3376-4d58-86f4-3f33bb009b8d"), new Guid("9bfdcc16-76bd-4e3a-844f-2e980d9535c6"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(639), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("ef1ff6df-0717-4c52-adfc-918831d65c18"), new Guid("c12db5dd-1059-4d57-a49a-6b4c77f5640a"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(710), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartmentApartment",
                columns: new[] { "Id", "ApartmentID", "ProjectApartmentID" },
                values: new object[] { new Guid("2a3836bc-69d2-49d9-9132-535fbd5e8c60"), new Guid("dd3005a3-562f-4b6b-82ed-7c5007e19636"), new Guid("9bfdcc16-76bd-4e3a-844f-2e980d9535c6") });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[,]
                {
                    { new Guid("1bc6e1e1-3c08-4466-b442-82e9ef326e49"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(773), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("9bfdcc16-76bd-4e3a-844f-2e980d9535c6"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" },
                    { new Guid("a59dfdcf-bf3a-4b74-ab40-b68529784d19"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(782), new TimeSpan(0, 7, 0, 0, 0)), "Image of the penthouse suite", "Penthouse Suite Image", new Guid("c12db5dd-1059-4d57-a49a-6b4c77f5640a"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(783), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/penthouse-suite.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("0d6c4ae3-9247-4ee9-9678-ea067e37d490"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1783), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4cdf2afa-dfa5-4bb3-b9dd-4eb2c87a86fd"), 0, new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1786), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1784), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("c3a3ce3c-8be3-48e3-8b83-184f65ac49f0"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1250), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1817b187-8a36-4b7f-8875-76dd0902bb0e") },
                    { new Guid("c4a3adbf-5057-4247-a9ed-39e90bd4ada9"), new DateTimeOffset(new DateTime(2024, 9, 27, 4, 50, 58, 736, DateTimeKind.Unspecified).AddTicks(1247), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3849c4a4-f921-4eb3-afd8-a6f540ccd3a6") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgreementUpdateRequest_AccountID",
                table: "AgreementUpdateRequest",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_AgreementUpdateRequest_ApartmentProjectProviderID",
                table: "AgreementUpdateRequest",
                column: "ApartmentProjectProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentDocument_AccountID",
                table: "ApartmentDocument",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentDocument_ApartmentID",
                table: "ApartmentDocument",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentFacility_ApartmentID",
                table: "ApartmentFacility",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentFacility_FacilityID",
                table: "ApartmentFacility",
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
                name: "IX_ApartmentProjectProvider_AccountID",
                table: "ApartmentProjectProvider",
                column: "AccountID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_AccountID",
                table: "Appointment",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ApartmentID",
                table: "Appointment",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_SlotID",
                table: "Appointment",
                column: "SlotID");

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
                name: "IX_Deposit_AccountID",
                table: "Deposit",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_ApartmentID",
                table: "Deposit",
                column: "ApartmentID");

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
                name: "IX_ProjectApartmentApartment_ApartmentID",
                table: "ProjectApartmentApartment",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectApartmentApartment_ProjectApartmentID",
                table: "ProjectApartmentApartment",
                column: "ProjectApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectApartments_AccountID",
                table: "ProjectApartments",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImages_ProjectApartmentID",
                table: "ProjectImages",
                column: "ProjectApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestApartment_AccountID",
                table: "RequestApartment",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestApartment_ApartmentID",
                table: "RequestApartment",
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
                name: "AgreementUpdateRequest");

            migrationBuilder.DropTable(
                name: "ApartmentDocument");

            migrationBuilder.DropTable(
                name: "ApartmentFacility");

            migrationBuilder.DropTable(
                name: "ApartmentImages");

            migrationBuilder.DropTable(
                name: "ApartmentInteractions");

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
                name: "ProjectApartmentApartment");

            migrationBuilder.DropTable(
                name: "ProjectImages");

            migrationBuilder.DropTable(
                name: "RequestApartment");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "VR_Access_Logs");

            migrationBuilder.DropTable(
                name: "ApartmentProjectProvider");

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
                name: "Deposit");

            migrationBuilder.DropTable(
                name: "VRExperiences");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
