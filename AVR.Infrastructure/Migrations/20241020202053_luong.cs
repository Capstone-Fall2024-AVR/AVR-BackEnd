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
                    EmailConfirmationOtp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtpExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "PropertyRequest",
                columns: table => new
                {
                    RequestID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RequestStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyRequest", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK_PropertyRequest_AspNetUsers_OwnerID",
                        column: x => x.OwnerID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PropertyRequest_AspNetUsers_StaffID",
                        column: x => x.StaffID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "PropertyVerification",
                columns: table => new
                {
                    VerificationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyRequestID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    VerificationStatus = table.Column<int>(type: "int", nullable: false),
                    LegalDocumentsURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyVerification", x => x.VerificationID);
                    table.ForeignKey(
                        name: "FK_PropertyVerification_PropertyRequest_VerificationID",
                        column: x => x.VerificationID,
                        principalTable: "PropertyRequest",
                        principalColumn: "RequestID");
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
                name: "Apartments",
                columns: table => new
                {
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: false),
                    NumberOfBathrooms = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direction = table.Column<int>(type: "int", nullable: false),
                    PricePerSquareMeter = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecommendedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpiryDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ApartmentStatus = table.Column<int>(type: "int", nullable: false),
                    ApartmentType = table.Column<int>(type: "int", nullable: false),
                    SaleStatus = table.Column<int>(type: "int", nullable: false),
                    BalconyDirection = table.Column<int>(type: "int", nullable: false),
                    ProjectApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VerificationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.ApartmentID);
                    table.ForeignKey(
                        name: "FK_Apartments_ProjectApartments_ProjectApartmentID",
                        column: x => x.ProjectApartmentID,
                        principalTable: "ProjectApartments",
                        principalColumn: "ProjectApartmentID");
                    table.ForeignKey(
                        name: "FK_Apartments_PropertyVerification_VerificationID",
                        column: x => x.VerificationID,
                        principalTable: "PropertyVerification",
                        principalColumn: "VerificationID");
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
                name: "Appointment",
                columns: table => new
                {
                    AppointmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AssignedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    AppointmentDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AppointmentStatus = table.Column<int>(type: "int", nullable: false),
                    AppointmentTypes = table.Column<int>(type: "int", nullable: false),
                    SlotID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                name: "DepositRequest",
                columns: table => new
                {
                    DepositID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    depositPercentage = table.Column<double>(type: "float", nullable: false),
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
                name: "DepositProfile",
                columns: table => new
                {
                    ProfileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityCardFrontImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityCardBackImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepositID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositProfile", x => x.ProfileID);
                    table.ForeignKey(
                        name: "FK_DepositProfile_DepositRequest_DepositID",
                        column: x => x.DepositID,
                        principalTable: "DepositRequest",
                        principalColumn: "DepositID",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("028b7139-bd53-40a2-a8ed-54f515982e3d"), null, "Admin", "ADMIN" },
                    { new Guid("90c98ddb-5448-4c2c-9a3d-56897dc7b4d4"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("944c47b4-f57b-4ed1-8363-c55dbf2c6240"), null, "Staff", "STAFF" },
                    { new Guid("ab3a167d-07e8-4cc9-a5e8-52165eec3c98"), null, "Management", "MANAGEMENT" },
                    { new Guid("ee37da00-fce5-44a0-8801-44bf41a89d3b"), null, "Apartment Owner", "APARTMENT OWNER" },
                    { new Guid("ffec015f-5186-43ad-ac29-ebf4b3e222eb"), null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmationOtp", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OtpExpiryTime", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("31b40c33-0f43-4e3a-b023-e40b0786333d"), 0, 0, "", "b9a24ee5-bd37-412e-8b94-e144dc4331d5", "quansongngu13@gmail.com", null, true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", null, "AQAAAAIAAYagAAAAEFFz6WGftAz9Gl1OtdHWqmQU0x8uTLVk8DWZg3wa22V8GphHfdgWF5jYnrQbTbbRXw==", "0949035672", true, "2ea7c8bb-026d-4e3c-bddb-6df3885ce6bb", false, "quansongngu13@gmail.com" },
                    { new Guid("43b5b5c3-4990-4e3e-950a-84bb69bd8d09"), 0, 0, null, "de58bd48-2619-452f-bcd8-bb4d01891e98", "johndoe@example.com", null, true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEHJ13Ygir+mgalk2pYZuCaiTele4pcJOv5I3bi3WUf7bjxG2U62NN9Y8DG/HPujmCw==", "123456789", true, "3d7ea1b6-b294-42c1-9b14-f42e300abe04", false, "johndoe@example.com" },
                    { new Guid("45d7934b-6379-4f1a-9020-e48695bc5946"), 0, 0, null, "7c05a0b9-9e7b-4781-ada0-e81679ea9f5f", "eve.adams@example.com", null, true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEEkZsvFnqZCEK/HWNUScRpbfXmhtCsg8+usx21piyyPj6yQ7i6oKBIBa+GE5LiC11g==", "0905678901", true, "45662397-aa15-44a8-b922-cb5eff2cbb0c", false, "eve.adams@example.com" },
                    { new Guid("568eb78c-49b9-4353-bc72-655e4fa5b9bb"), 0, 0, null, "18aaee8e-42b8-483a-aca3-28447fb011c8", "charlie.brown@example.com", null, true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEGGxVomLTznXsEQu8fCPBoAOCNGYzhsIQS745ESDwAGymzaahzjIg8nLlRuoUoq6zQ==", "0903456789", true, "8a92f8d1-f32f-455a-8ae1-a69e848bcea5", false, "charlie.brown@example.com" },
                    { new Guid("59cb4505-af70-4177-9cf6-a141a4eb75da"), 0, 0, "", "35219e50-be53-4f8d-88d5-2dfe69518fec", "michael.smith@example.com", null, true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEFfi3DVKtILTVVajabILLFd7oZZ2+jum0bL94G9wNbXjhyL7AIGneCEkJqofR549zQ==", "0123456789", true, "a8220d58-1590-41df-b5a5-ce4ed086e636", false, "michael.smith@example.com" },
                    { new Guid("6c76b0c7-31ff-4b6b-ac5c-6f6da1bd9ce6"), 0, 0, "", "7fdcf3ee-48fe-4634-8615-121ab8daaa6c", "luong.a11.dbk@gmail.com", null, true, false, null, "Duc Luong", "LUONG.A11.DBK@GMAIL.COM", "LUONG.A11.DBK@GMAIL.COM", null, "AQAAAAIAAYagAAAAEMi6mry1POCH37DhBh/Yudw2797S6PxgHtwS+lg1t+GywWf+DaE76+pvlLWf9GiaVA==", "0987654321", true, "c75c1a69-09b6-4a3d-96bb-1955be43a917", false, "luong.a11.dbk@gmail.com" },
                    { new Guid("940383a5-db52-4d47-9943-e66c2c613582"), 0, 0, null, "3f60dd1a-a31e-44e5-897c-670fb2f2af5d", "diana.prince@example.com", null, true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEJ0fjdwzfgm4sAVoYqgkPiwdpSI3e8OXvIG+fBEnp7x37eXemoAqclSGSY3iupjdyw==", "0904567890", true, "f19c2a08-f64b-49d8-a53f-285af37b1565", false, "diana.prince@example.com" },
                    { new Guid("95ed4fe9-e656-4ac6-ac6d-ea2470eae533"), 0, 0, "", "9997af5b-72ce-497a-bcfb-2bfa841db5c1", "david.brown@example.com", null, true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEDas3YB3EZLgONyIKMriHBROjxFZdh2hCThd1zdxRcxobYMtYQt//zKLV9GEj0jvaA==", "0123456789", true, "3ec6324b-048c-40dc-b644-f6f26b0c5fe9", false, "david.brown@example.com" },
                    { new Guid("b92e55dc-52f2-43a2-9a4c-f79ba9ec2685"), 0, 0, null, "4bc796d5-69db-4797-86aa-7f22df52e5d9", "alice.smith@example.com", null, true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEL+twS7hypByMmg+EGmhZhnqBM3UM0y14Ff6s0BxDgmCwrcrJNB2BvDGEmwRl5teqw==", "0901234567", true, "03d2a69f-2d1b-455e-a231-12fb54096192", false, "alice.smith@example.com" },
                    { new Guid("cf235f53-d722-4392-85fe-c0d00e1198c6"), 0, 0, null, "d3c28bb7-da5f-4e17-964d-eabedbfebe7a", "bob.johnson@example.com", null, true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEE88Wh5WbXnR59AlUmiJAMPffGZk3LfDm8+lnEEx2WJtNbAyWdSjJ/cJ+x626uSZDw==", "0902345678", true, "46f0aa54-dd07-4c8b-b8ff-d41e22f6d0ad", false, "bob.johnson@example.com" },
                    { new Guid("dca3eceb-fc8f-4fb0-910a-ac35d340e315"), 0, 0, "", "2a50733d-451d-49f2-af0c-7218e03ddf8d", "construction.corp@example.com", null, true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEDZfI90WgaVmlJvYEcJq0PgmozVKzivoLMNjXyg+D5bkKQsfMiubrJZytqRK1/5HMQ==", "0987654321", true, "0ebf5ccf-284d-48b4-9634-20f96e551ada", false, "construction.corp@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("5864ccda-7d49-44b3-9f30-c4128b029fed"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7227), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("82495b83-dbbf-40db-8294-49d0ee2caa0c"), "A large outdoor swimming pool.", "Swimming Pool" },
                    { new Guid("eb1c97bc-26ba-4cc7-9d54-e6c5bbbdc350"), "A fully equipped fitness gym.", "Gym" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("b9d4baa5-df5c-4d5d-aad2-22a6578c7a66"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("78a868ba-83b0-4b30-9d57-e3fbfde4f203"), "11:00 AM", "10:00 AM" },
                    { new Guid("fa47ef11-9147-4ef2-9110-2b9e4493514f"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("981a1490-f773-4943-a2b5-4ff2af9dfce4"), new Guid("dca3eceb-fc8f-4fb0-910a-ac35d340e315"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(5780), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(5781), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("028b7139-bd53-40a2-a8ed-54f515982e3d"), new Guid("31b40c33-0f43-4e3a-b023-e40b0786333d") },
                    { new Guid("944c47b4-f57b-4ed1-8363-c55dbf2c6240"), new Guid("43b5b5c3-4990-4e3e-950a-84bb69bd8d09") },
                    { new Guid("ffec015f-5186-43ad-ac29-ebf4b3e222eb"), new Guid("59cb4505-af70-4177-9cf6-a141a4eb75da") },
                    { new Guid("ab3a167d-07e8-4cc9-a5e8-52165eec3c98"), new Guid("6c76b0c7-31ff-4b6b-ac5c-6f6da1bd9ce6") },
                    { new Guid("ee37da00-fce5-44a0-8801-44bf41a89d3b"), new Guid("95ed4fe9-e656-4ac6-ac6d-ea2470eae533") },
                    { new Guid("90c98ddb-5448-4c2c-9a3d-56897dc7b4d4"), new Guid("dca3eceb-fc8f-4fb0-910a-ac35d340e315") }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("d930fe54-1076-4d2e-9ba0-e6266be6689f"), new Guid("b92e55dc-52f2-43a2-9a4c-f79ba9ec2685"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7414), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" },
                    { new Guid("db091eef-744f-4297-8ae8-369879b2948e"), new Guid("cf235f53-d722-4392-85fe-c0d00e1198c6"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7419), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("8a77a6d4-6f6a-4f26-94d2-cb4406594f48"), new Guid("568eb78c-49b9-4353-bc72-655e4fa5b9bb"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("b9d4baa5-df5c-4d5d-aad2-22a6578c7a66"), new Guid("6299bf75-8689-4030-be23-caff959a4afe"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7489), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8c3ffa19-a5c2-4bcb-93c7-0da7cc4f2583"), new Guid("cf235f53-d722-4392-85fe-c0d00e1198c6"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7496), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("b9d4baa5-df5c-4d5d-aad2-22a6578c7a66"), new Guid("1badf5bb-3103-4f0b-91c3-f186f3c30f12"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7497), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[] { new Guid("727ac392-a132-48fd-8b30-41a744b473f8"), null, new Guid("981a1490-f773-4943-a2b5-4ff2af9dfce4"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(5924), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(5925), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "Address", "ApartmentName", "ApartmentStatus", "ApartmentType", "Area", "BalconyDirection", "CreatedDate", "Description", "Direction", "District", "ExpiryDate", "Location", "NumberOfBathrooms", "NumberOfRooms", "PricePerSquareMeter", "ProjectApartmentID", "RecommendedPrice", "SaleStatus", "UpdatedDate", "VerificationID", "Ward" },
                values: new object[,]
                {
                    { new Guid("65a80e24-71ef-4e80-ba24-6f50afe58978"), "123 Skyline Road, New City", "Skyline Apartment", 0, 1, 150.00m, 5, new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6408), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", 1, "Central District", new DateTimeOffset(new DateTime(2029, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6417), new TimeSpan(0, 7, 0, 0, 0)), "City Center", 2, 3, 70000000m, new Guid("727ac392-a132-48fd-8b30-41a744b473f8"), 10000000000m, 1, new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6409), new TimeSpan(0, 7, 0, 0, 0)), null, "Ward 5" },
                    { new Guid("6df042cf-84ea-4178-8c19-590e009b603f"), "456 Ocean Drive, Coastal City", "Ocean View Apartment", 2, 2, 170.00m, 8, new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6437), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", 2, "Coastal District", new DateTimeOffset(new DateTime(2027, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6441), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", 3, 4, 90000000m, new Guid("727ac392-a132-48fd-8b30-41a744b473f8"), 15000000000m, 1, new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6438), new TimeSpan(0, 7, 0, 0, 0)), null, "Ward 2" }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[] { new Guid("cb4933b3-4b69-4f80-bb10-beb648b78117"), new Guid("727ac392-a132-48fd-8b30-41a744b473f8"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6308), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[] { new Guid("2009f0b9-113d-4f57-8faf-6225aa9a743f"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6367), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("727ac392-a132-48fd-8b30-41a744b473f8"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6367), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("57c8e2c7-e550-45c0-832f-2388b3972738"), new Guid("6df042cf-84ea-4178-8c19-590e009b603f"), new Guid("eb1c97bc-26ba-4cc7-9d54-e6c5bbbdc350") },
                    { new Guid("61c773d6-477f-4267-9db2-964a50665fcf"), new Guid("65a80e24-71ef-4e80-ba24-6f50afe58978"), new Guid("82495b83-dbbf-40db-8294-49d0ee2caa0c") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1969297f-1cec-42d0-b050-ff51b358a269"), new Guid("65a80e24-71ef-4e80-ba24-6f50afe58978"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6797), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6797), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("4b7e5790-4620-49ed-91cf-d7791d4c3e3f"), new Guid("65a80e24-71ef-4e80-ba24-6f50afe58978"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6791), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6794), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("95482dc9-930e-4490-9fc6-242967db2527"), new Guid("cf235f53-d722-4392-85fe-c0d00e1198c6"), new Guid("6df042cf-84ea-4178-8c19-590e009b603f"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { new Guid("eb31ee45-9c69-49f5-b432-e57dcacb42a0"), new Guid("b92e55dc-52f2-43a2-9a4c-f79ba9ec2685"), new Guid("65a80e24-71ef-4e80-ba24-6f50afe58978"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6967), new TimeSpan(0, 7, 0, 0, 0)), 0 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("25db8043-abcc-4018-96ee-d26fc581de4c"), new Guid("95ed4fe9-e656-4ac6-ac6d-ea2470eae533"), new Guid("65a80e24-71ef-4e80-ba24-6f50afe58978") },
                    { new Guid("f62b2767-9d27-4c8b-afb4-730f7376a0a3"), new Guid("95ed4fe9-e656-4ac6-ac6d-ea2470eae533"), new Guid("65a80e24-71ef-4e80-ba24-6f50afe58978") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("e8eb6973-bbb3-4ddb-8eb0-d8d1a134d274"), new Guid("65a80e24-71ef-4e80-ba24-6f50afe58978"), new Guid("95ed4fe9-e656-4ac6-ac6d-ea2470eae533"), new DateTimeOffset(new DateTime(2024, 10, 22, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7185), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7183), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7181), new TimeSpan(0, 7, 0, 0, 0)), new Guid("45d7934b-6379-4f1a-9020-e48695bc5946"), "Schedule a viewing for the Skyline Apartment.", new Guid("dca3eceb-fc8f-4fb0-910a-ac35d340e315"), new Guid("fa47ef11-9147-4ef2-9110-2b9e4493514f"), new Guid("43b5b5c3-4990-4e3e-950a-84bb69bd8d09"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7182), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("4eb954a9-64bb-4ce5-9417-1a33acc92d2f"), new Guid("568eb78c-49b9-4353-bc72-655e4fa5b9bb"), new Guid("65a80e24-71ef-4e80-ba24-6f50afe58978"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7257), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 11, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7261), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("882d8fc4-59e6-4073-8d76-9496497f2e51"), new Guid("b92e55dc-52f2-43a2-9a4c-f79ba9ec2685"), new Guid("6df042cf-84ea-4178-8c19-590e009b603f"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 10, 22, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7033), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." },
                    { new Guid("dbeab9a9-8e3f-4b8b-a2c4-ffe9cdaf1842"), new Guid("cf235f53-d722-4392-85fe-c0d00e1198c6"), new Guid("65a80e24-71ef-4e80-ba24-6f50afe58978"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7023), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 10, 22, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7024), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("7ce1badc-3b18-4efa-b8e6-8812dd256475"), new Guid("43b5b5c3-4990-4e3e-950a-84bb69bd8d09"), new Guid("65a80e24-71ef-4e80-ba24-6f50afe58978"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6852), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6864), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" },
                    { new Guid("e8ada7ad-fdbd-4681-92e0-1e0b0fcee4a1"), new Guid("43b5b5c3-4990-4e3e-950a-84bb69bd8d09"), new Guid("6df042cf-84ea-4178-8c19-590e009b603f"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6891), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("a93a1dae-fe78-4270-97d8-3d3d8f2ec97e"), new Guid("6c76b0c7-31ff-4b6b-ac5c-6f6da1bd9ce6"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 7, 0, 0, 0)), new Guid("5864ccda-7d49-44b3-9f30-c4128b029fed"), new Guid("4eb954a9-64bb-4ce5-9417-1a33acc92d2f"), "45000", new DateTimeOffset(new DateTime(2024, 10, 26, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7379), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("9ceb79c5-2519-4b1b-b7cb-7953329f6920"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7331), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4eb954a9-64bb-4ce5-9417-1a33acc92d2f"), 0, new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7333), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(7332), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("e4df1eed-de8d-40b0-8694-be5a6c4f6277"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6932), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7ce1badc-3b18-4efa-b8e6-8812dd256475") },
                    { new Guid("eee6a46c-f15e-4029-a23e-2a24fb1ef173"), new DateTimeOffset(new DateTime(2024, 10, 21, 3, 20, 52, 679, DateTimeKind.Unspecified).AddTicks(6936), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e8ada7ad-fdbd-4681-92e0-1e0b0fcee4a1") }
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
                name: "IX_Apartments_ProjectApartmentID",
                table: "Apartments",
                column: "ProjectApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_VerificationID",
                table: "Apartments",
                column: "VerificationID");

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
                name: "IX_DepositProfile_DepositID",
                table: "DepositProfile",
                column: "DepositID",
                unique: true);

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
                name: "IX_PropertyRequest_OwnerID",
                table: "PropertyRequest",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRequest_StaffID",
                table: "PropertyRequest",
                column: "StaffID");

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
                name: "DepositProfile");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "ProjectAccessLogs");

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
                name: "DepositRequest");

            migrationBuilder.DropTable(
                name: "VRExperiences");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "ProjectApartments");

            migrationBuilder.DropTable(
                name: "PropertyVerification");

            migrationBuilder.DropTable(
                name: "ApartmentProjectProvider");

            migrationBuilder.DropTable(
                name: "PropertyRequest");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
