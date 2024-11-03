using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class new1 : Migration
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
                    { new Guid("25dc4dc5-b22e-4080-b180-c74b6fcf4088"), null, "Management", "MANAGEMENT" },
                    { new Guid("33dd1b6f-37aa-41d2-8423-35f28305a310"), null, "Apartment Owner", "APARTMENT OWNER" },
                    { new Guid("634cdda7-cbd0-4734-b330-7ce2555aa3da"), null, "Staff", "STAFF" },
                    { new Guid("65e23c2f-fbbc-44de-9070-85541f65e353"), null, "Customer", "CUSTOMER" },
                    { new Guid("7d02c3be-baf0-4808-80ed-0a84ae2ddcaa"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("e57802a7-d241-4d79-a9e1-a19a9186643e"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmationOtp", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OtpExpiryTime", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1ac2aab6-317d-4077-813b-da057b883a02"), 0, 0, "", "02b68b4b-dc49-408e-8e29-3c0d6259e87d", "luong.a11.dbk@gmail.com", null, true, false, null, "Duc Luong", "LUONG.A11.DBK@GMAIL.COM", "LUONG.A11.DBK@GMAIL.COM", null, "AQAAAAIAAYagAAAAEJ1h2meD/zSaVxo0eN2N9qGohslaXQaAX01et/S1+190Pu9MQB5SxHhTqIgyem2I1Q==", "0987654321", true, "9bca21ee-8d18-4520-bbd0-81c34f16e755", false, "luong.a11.dbk@gmail.com" },
                    { new Guid("3e2c99ce-486a-46ae-b65b-ad88790c3e5d"), 0, 0, "", "4d9f13e7-653f-434a-b14d-9e25c2951fb3", "construction.corp@example.com", null, true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEGpo3T8Yfg7TitOo3lDAG+olyqiA2FBbAEmYkPFjDo4khFKWwzGPfx1ICXKAdqTrBg==", "0987654321", true, "64fe1432-934b-4f64-bdbb-989ce474c700", false, "construction.corp@example.com" },
                    { new Guid("4fb9eff5-7849-48e7-882e-ae7f75ff2f26"), 0, 0, "", "eb2c27c7-b284-4268-aa24-f4daf6801e08", "david.brown@example.com", null, true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEPcjb094G2ZozFvWXywhhoMZWrYceqK15Sg428ifUMgLI28phu746PLdND9qNrvpdw==", "0123456789", true, "68442f8e-946d-41b6-890e-de121dd24838", false, "david.brown@example.com" },
                    { new Guid("57d79b13-b64c-4290-a976-3b851ea13e0b"), 0, 0, null, "8c9cd696-76dc-4948-9b63-84b4d19b0e34", "diana.prince@example.com", null, true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEHRPRGhM8FJDaa+/dgszRDxy7v1B1mjbAJGquoKKNdUrtfvZHWjRIkvkLuZIkPeKRg==", "0904567890", true, "05d00973-d50f-4c88-8ca6-2a894ef07ca1", false, "diana.prince@example.com" },
                    { new Guid("644c2825-875a-4cb1-9d29-6d1e62dc16f5"), 0, 0, null, "cc54d3cc-bf60-46ff-b052-5a6aa385a6ae", "eve.adams@example.com", null, true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEGNTNI0i4i7Rur29fC4JDsF2/kOb0GEHpMGw4Q2+Cq1ejStjSSKFBxUAu1m0FdRe6g==", "0905678901", true, "ec86da5e-577c-43e7-83f4-191d9315e438", false, "eve.adams@example.com" },
                    { new Guid("6f5c2180-f6e1-4efc-b6f5-59c0698152a8"), 0, 0, null, "93899e5a-4c74-4370-89b5-1b80b7bb8866", "johndoe@example.com", null, true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEJRh5pTM8ZaR8X/BiaL/d2KRza164HFrHXl/q6MMtwr+054vsxFtUqwxDOfjsUEjfw==", "123456789", true, "e97e9e9a-69f7-4bb3-b0e6-2b5ab01f5c42", false, "johndoe@example.com" },
                    { new Guid("8cec58df-37ba-4c4f-8bee-259710d18d77"), 0, 0, "", "2512bcc6-63eb-41f6-99b1-9a9331560d51", "michael.smith@example.com", null, true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEF+Cb/UT80tT4633yWzZKhKPxTNV515O/qfIMWeNi0eFpmITDoLQ7ih+Zot0o0rzVw==", "0123456789", true, "ba0afb85-5ecb-4721-ac05-0fb38f8256e5", false, "michael.smith@example.com" },
                    { new Guid("bff4c325-23f7-4c20-8e2e-8e092ce2a4e7"), 0, 0, null, "9c644e55-82ae-42d8-89fd-ee26baff3b75", "charlie.brown@example.com", null, true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEBhOAUcMGFBNb35TQA3tInwuztShR7lLEBRjeooMzGy3Ukk8TgJzG4phm6m6iGx2qA==", "0903456789", true, "65d84665-06be-492e-831a-688c3e0cf6f9", false, "charlie.brown@example.com" },
                    { new Guid("d082577d-5f77-4a27-8b81-9593c59455d8"), 0, 0, null, "9b970072-1b66-462e-9c1a-5b4fe7b44a0a", "bob.johnson@example.com", null, true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAELo6gFXbQ8zGCUhfd9ufpkn1a4mndcOKosXDrUsGtUVpj26was2uuvSh2w4btctScQ==", "0902345678", true, "9e67189b-40e1-4673-ac4c-ace2e44e1399", false, "bob.johnson@example.com" },
                    { new Guid("d9e12a68-66aa-465e-995d-4ed24fd2227b"), 0, 0, null, "7c8ff8ab-0fdc-4d21-b285-5bb667c829e5", "alice.smith@example.com", null, true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAELYQWXXchEHbrqX5Xk4nTKvhCIqKRICDdlvY/Q4fBkTYJcmURJCb21F6cI1ZAM4yjA==", "0901234567", true, "4de6bd57-ee1d-4786-8574-f6309423f31f", false, "alice.smith@example.com" },
                    { new Guid("f1733001-3fa2-415c-8ff9-6081d2db7fb6"), 0, 0, "", "f90f8dcc-7827-4679-b9d6-69f0b1eb0606", "quansongngu13@gmail.com", null, true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", null, "AQAAAAIAAYagAAAAEAd+x25qLsAfJfBKO7tcYTnrNF2YV66tailFJ5996FWTOT+F2AnTPaRa/V0hsG4wWw==", "0949035672", true, "93fe0c01-3765-422f-ba54-c51dd6c3b945", false, "quansongngu13@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("e951ed0e-f801-449a-908f-bb9c7999667e"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5475), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5476), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("d5f6be27-9d82-4b77-905f-b0ddbbe15041"), "A large outdoor swimming pool.", "Swimming Pool" },
                    { new Guid("d667cd5c-048e-4bed-bb09-446784219758"), "A fully equipped fitness gym.", "Gym" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("4e62fd68-4931-4b7e-bcd9-67eea734ad00"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("3504a249-cc62-4ae5-8534-9f82479011cc"), "11:00 AM", "10:00 AM" },
                    { new Guid("da95742c-3eb6-4e16-84a9-925202486270"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("698f47e0-c345-485e-b1d2-6545b1d9018e"), new Guid("3e2c99ce-486a-46ae-b65b-ad88790c3e5d"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(2659), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("25dc4dc5-b22e-4080-b180-c74b6fcf4088"), new Guid("1ac2aab6-317d-4077-813b-da057b883a02") },
                    { new Guid("7d02c3be-baf0-4808-80ed-0a84ae2ddcaa"), new Guid("3e2c99ce-486a-46ae-b65b-ad88790c3e5d") },
                    { new Guid("33dd1b6f-37aa-41d2-8423-35f28305a310"), new Guid("4fb9eff5-7849-48e7-882e-ae7f75ff2f26") },
                    { new Guid("634cdda7-cbd0-4734-b330-7ce2555aa3da"), new Guid("6f5c2180-f6e1-4efc-b6f5-59c0698152a8") },
                    { new Guid("65e23c2f-fbbc-44de-9070-85541f65e353"), new Guid("8cec58df-37ba-4c4f-8bee-259710d18d77") },
                    { new Guid("e57802a7-d241-4d79-a9e1-a19a9186643e"), new Guid("f1733001-3fa2-415c-8ff9-6081d2db7fb6") }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("128e0d1a-c518-4cc5-b17e-80a294dcd308"), new Guid("d9e12a68-66aa-465e-995d-4ed24fd2227b"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5678), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" },
                    { new Guid("b64c7fd0-9635-4c90-a9ac-80cf9dcb4265"), new Guid("d082577d-5f77-4a27-8b81-9593c59455d8"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5683), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("10ee02f3-4482-4552-b6dc-b4f47ca162cd"), new Guid("d082577d-5f77-4a27-8b81-9593c59455d8"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5752), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("4e62fd68-4931-4b7e-bcd9-67eea734ad00"), new Guid("d51d73b5-9939-4c34-8d19-489b7d9a7858"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5753), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("5579586b-dada-4e4b-b3ff-d59ede313b03"), new Guid("bff4c325-23f7-4c20-8e2e-8e092ce2a4e7"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5744), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("4e62fd68-4931-4b7e-bcd9-67eea734ad00"), new Guid("c8afe6ea-71dd-4daa-af22-af1270a5e683"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5746), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[] { new Guid("0ba1807d-9e39-4e0c-bf25-de4663b2a4b0"), null, new Guid("698f47e0-c345-485e-b1d2-6545b1d9018e"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "Address", "ApartmentName", "ApartmentStatus", "ApartmentType", "Area", "BalconyDirection", "CreatedDate", "Description", "Direction", "District", "ExpiryDate", "Location", "NumberOfBathrooms", "NumberOfRooms", "PricePerSquareMeter", "ProjectApartmentID", "RecommendedPrice", "SaleStatus", "UpdatedDate", "VerificationID", "Ward" },
                values: new object[,]
                {
                    { new Guid("1ae7ec1e-cda1-4b96-bbde-7499f8919409"), "123 Skyline Road, New City", "Skyline Apartment", 0, 1, 150.00m, 5, new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(3157), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", 1, "Central District", new DateTimeOffset(new DateTime(2029, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(3169), new TimeSpan(0, 7, 0, 0, 0)), "City Center", 2, 3, 70000000m, new Guid("0ba1807d-9e39-4e0c-bf25-de4663b2a4b0"), 100000000m, 1, new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(3159), new TimeSpan(0, 7, 0, 0, 0)), null, "Ward 5" },
                    { new Guid("4250f817-581f-47d4-a806-50d1324b61e3"), "456 Ocean Drive, Coastal City", "Ocean View Apartment", 1, 2, 170.00m, 8, new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", 2, "Coastal District", new DateTimeOffset(new DateTime(2027, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(3193), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", 3, 4, 90000000m, new Guid("0ba1807d-9e39-4e0c-bf25-de4663b2a4b0"), 15000000000m, 1, new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(3190), new TimeSpan(0, 7, 0, 0, 0)), null, "Ward 2" }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[] { new Guid("0463e0a8-47d6-473a-81de-dd25d51a9507"), new Guid("0ba1807d-9e39-4e0c-bf25-de4663b2a4b0"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(3078), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[] { new Guid("077073a4-2a7f-4643-93e9-24997d2a77e4"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(3114), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("0ba1807d-9e39-4e0c-bf25-de4663b2a4b0"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(3116), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("0e59fa8d-7558-4eb5-9925-c65af20a26a5"), new Guid("1ae7ec1e-cda1-4b96-bbde-7499f8919409"), new Guid("d5f6be27-9d82-4b77-905f-b0ddbbe15041") },
                    { new Guid("281ded0a-3a7a-4b1f-b0b1-75aaf48c3b00"), new Guid("4250f817-581f-47d4-a806-50d1324b61e3"), new Guid("d667cd5c-048e-4bed-bb09-446784219758") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("2f0738b0-636c-423e-aed1-a1007fb68649"), new Guid("1ae7ec1e-cda1-4b96-bbde-7499f8919409"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5030), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5031), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8a12436d-18d9-4293-aad9-e70bf171cc24"), new Guid("1ae7ec1e-cda1-4b96-bbde-7499f8919409"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5018), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5027), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("6db62b5c-7173-4239-b312-965f18294c6f"), new Guid("d9e12a68-66aa-465e-995d-4ed24fd2227b"), new Guid("1ae7ec1e-cda1-4b96-bbde-7499f8919409"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5198), new TimeSpan(0, 7, 0, 0, 0)), 0 },
                    { new Guid("d0f48eb3-a0f6-48f9-8fb6-07222d63379f"), new Guid("d082577d-5f77-4a27-8b81-9593c59455d8"), new Guid("4250f817-581f-47d4-a806-50d1324b61e3"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5210), new TimeSpan(0, 7, 0, 0, 0)), 1 }
                });

           

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("f4077ec4-4308-4e40-be0c-e3968c2a266d"), new Guid("1ae7ec1e-cda1-4b96-bbde-7499f8919409"), new Guid("4fb9eff5-7849-48e7-882e-ae7f75ff2f26"), new DateTimeOffset(new DateTime(2024, 10, 18, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5426), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5424), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5422), new TimeSpan(0, 7, 0, 0, 0)), new Guid("644c2825-875a-4cb1-9d29-6d1e62dc16f5"), "Schedule a viewing for the Skyline Apartment.", new Guid("3e2c99ce-486a-46ae-b65b-ad88790c3e5d"), new Guid("da95742c-3eb6-4e16-84a9-925202486270"), new Guid("6f5c2180-f6e1-4efc-b6f5-59c0698152a8"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5423), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("d8f738c2-34a6-4973-9b52-ee96f5c65a4e"), new Guid("bff4c325-23f7-4c20-8e2e-8e092ce2a4e7"), new Guid("1ae7ec1e-cda1-4b96-bbde-7499f8919409"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5532), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5536), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 11, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5538), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("bbd7aaef-61fb-476b-be5c-6432d2772568"), new Guid("d082577d-5f77-4a27-8b81-9593c59455d8"), new Guid("1ae7ec1e-cda1-4b96-bbde-7499f8919409"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 10, 18, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5251), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." },
                    { new Guid("e1caceec-fde2-416c-9518-64a02d702d51"), new Guid("d9e12a68-66aa-465e-995d-4ed24fd2227b"), new Guid("4250f817-581f-47d4-a806-50d1324b61e3"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5261), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 10, 18, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("60e3ed17-5343-4646-9f4f-70ae78b9d603"), new Guid("6f5c2180-f6e1-4efc-b6f5-59c0698152a8"), new Guid("4250f817-581f-47d4-a806-50d1324b61e3"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5122), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5123), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" },
                    { new Guid("bf0e1c9e-70a8-4453-9343-e809c3c65c9a"), new Guid("6f5c2180-f6e1-4efc-b6f5-59c0698152a8"), new Guid("1ae7ec1e-cda1-4b96-bbde-7499f8919409"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5094), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5099), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("53ea2a9a-0212-4f94-ac2c-fdc8a8326736"), new Guid("1ac2aab6-317d-4077-813b-da057b883a02"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5640), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e951ed0e-f801-449a-908f-bb9c7999667e"), new Guid("d8f738c2-34a6-4973-9b52-ee96f5c65a4e"), "45000", new DateTimeOffset(new DateTime(2024, 10, 22, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5640), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5642), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("5adb39f4-93f8-49e2-bca9-3a77a2bbef15"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5604), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d8f738c2-34a6-4973-9b52-ee96f5c65a4e"), 0, new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5606), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5605), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("4380d1d4-66c1-4ad1-8dc2-dadc47ade499"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 7, 0, 0, 0)), new Guid("60e3ed17-5343-4646-9f4f-70ae78b9d603") },
                    { new Guid("c9d6ede8-584b-481c-b4de-23a7fd37a409"), new DateTimeOffset(new DateTime(2024, 10, 17, 16, 46, 58, 640, DateTimeKind.Unspecified).AddTicks(5163), new TimeSpan(0, 7, 0, 0, 0)), new Guid("bf0e1c9e-70a8-4453-9343-e809c3c65c9a") }
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
