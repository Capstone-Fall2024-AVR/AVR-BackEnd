using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fill_data : Migration
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
                name: "ApartmentOwners",
                columns: table => new
                {
                    ApartmentOwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerShipCertificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandUserRightCertificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstructionPermit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherDocuments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentOwners", x => x.ApartmentOwnerID);
                    table.ForeignKey(
                        name: "FK_ApartmentOwners_AspNetUsers_AccountID",
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
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customer_AspNetUsers_AccountID",
                        column: x => x.AccountID,
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
                name: "Managements",
                columns: table => new
                {
                    ManagementID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ManagementName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagementPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagementEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managements", x => x.ManagementID);
                    table.ForeignKey(
                        name: "FK_Managements_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_Staffs_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
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
                name: "AgreementUpdateRequest",
                columns: table => new
                {
                    AgreementUpdateRequestID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ApartmentProjectProviderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ManagementID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_AgreementUpdateRequest_Managements_ManagementID",
                        column: x => x.ManagementID,
                        principalTable: "Managements",
                        principalColumn: "ManagementID",
                        onDelete: ReferentialAction.Cascade);
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
                    ManagementID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectApartments", x => x.ProjectApartmentID);
                    table.ForeignKey(
                        name: "FK_ProjectApartments_Managements_ManagementID",
                        column: x => x.ManagementID,
                        principalTable: "Managements",
                        principalColumn: "ManagementID");
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
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberOfRooms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pricePerSquareMeter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recommendedPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    expiryDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ApartmentStatus = table.Column<int>(type: "int", nullable: false),
                    ApartmentType = table.Column<int>(type: "int", nullable: false),
                    ProjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentOwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.ApartmentID);
                    table.ForeignKey(
                        name: "FK_Apartments_ApartmentOwners_ApartmentOwnerID",
                        column: x => x.ApartmentOwnerID,
                        principalTable: "ApartmentOwners",
                        principalColumn: "ApartmentOwnerID");
                    table.ForeignKey(
                        name: "FK_Apartments_ProjectApartments_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "ProjectApartments",
                        principalColumn: "ProjectApartmentID");
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
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_ApartmentInteractions_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
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
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SlotID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_Appointment_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_Appointment_Slots_SlotID",
                        column: x => x.SlotID,
                        principalTable: "Slots",
                        principalColumn: "SlotID");
                    table.ForeignKey(
                        name: "FK_Appointment_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "StaffID");
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
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_Deposit_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
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
                    ManagementID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_RequestApartment_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_RequestApartment_Managements_ManagementID",
                        column: x => x.ManagementID,
                        principalTable: "Managements",
                        principalColumn: "ManagementID");
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
                    StaffID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_VRExperiences_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "StaffID");
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
                    ManagementID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositCancelTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositCancel", x => x.DepositCancelID);
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
                    table.ForeignKey(
                        name: "FK_DepositCancel_Managements_ManagementID",
                        column: x => x.ManagementID,
                        principalTable: "Managements",
                        principalColumn: "ManagementID");
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
                    { new Guid("309f4a92-3119-41e2-997b-d1a80b674001"), null, "Apartment Onwer", "APARTMENT ONWER" },
                    { new Guid("50f1b6db-77a2-4e73-8c9e-704993cd046c"), null, "Management", "MANAGEMENT" },
                    { new Guid("540e800e-1b7f-414b-8119-97c7b61e7017"), null, "Admin", "ADMIN" },
                    { new Guid("691fbe17-b873-4c5d-9f0d-815623ca3b85"), null, "Customer", "CUSTOMER" },
                    { new Guid("873d14ee-adeb-4599-b27d-a6641b50a99d"), null, "Staff", "STAFF" },
                    { new Guid("f24b77f2-662a-4855-98b7-cb71c3ee9b5e"), null, "Project Provider", "PROJECT PROVIDER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("04f92cb7-f83a-49e7-866c-a1db6bd7464e"), 0, 0, "", "b2c5aac3-825c-47fe-860a-4537a20a637b", "construction.corp@example.com", true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJyOzBWB892X4KqFfyyrONWKS+P3KmKdB2y7BpWXeJq4XvCPg3TdN+Nltp86NnwvmA==", "0987654321", true, "1651d661-b919-4549-8ac6-a3abe3cca744", false, "construction.corp@example.com" },
                    { new Guid("0a12fd75-96cd-4852-a285-e42477f0a773"), 0, 0, "", "e82646ca-1bb3-4512-adb8-e2d3e5042d84", "alice.johnson@example.com", true, false, null, "Alice Johnson", "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAELKZ/we6EiqypBZ+JjkjQTi4m130WIgpMNXG7QC1psn9qXRs4wpsxMmdeU/xX/STuA==", "0987654321", true, "56bc16ac-99b2-4c21-baeb-d6487e061441", false, "alice.johnson@example.com" },
                    { new Guid("13497ebd-2d52-4ce2-abb5-fef96e671bb4"), 0, 0, null, "5cc64e92-4165-4c53-ae82-7b8e04a3e231", "diana.prince@example.com", true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPE4YLDxUWEErdFhOMF1ic6pQU/1NYGZSNXOU/Ff0GyvJcVnr5vd88zw/NVIA74NRA==", "0904567890", true, "908ea31b-5992-4d0b-9c5e-396f74ebfc70", false, "diana.prince@example.com" },
                    { new Guid("4316f2e0-2323-45ab-bd1b-f25b98541220"), 0, 0, null, "be6fcced-834b-4185-acc6-f007b1a3c6cf", "eve.adams@example.com", true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEcIiK2wBPukOqWFYSsbqMtnOjplTBIjnLUetAlTvaYYKk6bInRLU2tKTcgWTS9JfQ==", "0905678901", true, "f4ba2219-377d-429c-92d7-5d0d16e26bfc", false, "eve.adams@example.com" },
                    { new Guid("8c45ebfd-a570-4f10-8107-891e0384bebc"), 0, 0, "", "9b53bb10-79d1-4325-b919-579c37d8c6fa", "quansongngu13@gmail.com", true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", "AQAAAAIAAYagAAAAEI+Nl7UwkP/AyiL3r+A8JcJ45/nRYgOunE/QWCUl4Fb32O4Aek22EcJTZlLWlp/HjQ==", "0949035672", true, "6ee9a946-3aac-40c3-8084-91f70c0217db", false, "quansongngu13@gmail.com" },
                    { new Guid("8ebf917a-0287-43c4-ae27-45154f09870c"), 0, 0, "", "750e113e-ccf2-4048-a775-52c2920913d4", "david.brown@example.com", true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEU/XubjgJ+eQFh5onNqGN19OBc6MKmGHLqpg2h5elpK/p9fqMjh9kxuhWTQIXH6nw==", "0123456789", true, "a706b58f-7d21-497b-8914-237dd16e46ae", false, "david.brown@example.com" },
                    { new Guid("c350d996-961f-4e34-b24d-32f7489db530"), 0, 0, null, "4b63016d-97a1-48ae-954d-d54978e0a13b", "johndoe@example.com", true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIYSWwGF23co8G/PDKrKppxb1EhMfJUIYhdGwOXwxDKSlz0eswLF26zBMZpasUbcKw==", "123456789", true, "414e3def-6dae-4ded-a3c1-36daaeb300d2", false, "johndoe@example.com" },
                    { new Guid("df2fae78-6160-40f2-a57d-246502250073"), 0, 0, null, "31006bcf-d767-44bf-8652-ef635be8e65b", "alice.smith@example.com", true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGcHOTknbMO941fYzK1ZxnvLYp9UpeyGURlpvSL1PcujqnWrcCd8tCymWaKdM6AQKg==", "0901234567", true, "6f5fde90-5b39-4cd9-ad47-d77dff482a98", false, "alice.smith@example.com" },
                    { new Guid("ed2ca936-c957-4c44-8a5a-4cda0010fd09"), 0, 0, null, "0adc56b4-0c8f-480d-b621-e6d0a753f812", "bob.johnson@example.com", true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJg9aOBtBqlMduncPQpf7FtMaxRtGBFlYQtX9LrCU0Se5rG1RrzvNV8VizWD+BK6hw==", "0902345678", true, "24cb6f17-8cce-4cc7-9839-c5e9e3993e9a", false, "bob.johnson@example.com" },
                    { new Guid("ee5c5364-3e7e-4665-8ac1-d8415e5f5050"), 0, 0, "", "ca2dbe37-65e6-4208-a763-f774933fcb53", "michael.smith@example.com", true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAELIAnMjuqLNOHnG8rjYp9WgEZcggCtvVNkhOf2Xx2HoUmv43EVszDs0oBQvKbD8F7Q==", "0123456789", true, "0a214aba-ad3a-4a8f-b88c-25941b8de263", false, "michael.smith@example.com" },
                    { new Guid("f3a42ab3-4d1e-409f-84aa-8e8204699d39"), 0, 0, null, "fec879ed-c6e0-462e-b94d-f5e36b4f878a", "charlie.brown@example.com", true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI/3i/JqzWtIoox4DPdxRqhnvk2vOmAXGKtc2AtTVUPkn/T/6B2wPPnCQT90cvddJQ==", "0903456789", true, "707215aa-0e85-488c-bc28-aa1d5904c8af", false, "charlie.brown@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("bfe08a1f-0951-40fa-854d-842c20fda622"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2437), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2439), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("18f4d4dc-eafd-4d85-89e3-ccfbad0c67d7"), "A large outdoor swimming pool.", "Swimming Pool" },
                    { new Guid("b4f59341-4d53-440d-b32e-fe6dc71b9dac"), "A fully equipped fitness gym.", "Gym" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("3be71375-b38f-4336-8fc5-8e6faa7a6452"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("06e748d7-aefb-4b2f-9dfe-cf2835ec52ac"), "11:00 AM", "10:00 AM" },
                    { new Guid("c1b8e261-bed7-40a1-8eb6-f047e8334c2e"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwners",
                columns: new[] { "ApartmentOwnerID", "AccountID", "ConstructionPermit", "LandUserRightCertificate", "OtherDocuments", "OwnerShipCertificate" },
                values: new object[] { new Guid("349b4455-e509-4cdc-949d-b65470522118"), new Guid("8ebf917a-0287-43c4-ae27-45154f09870c"), "Construction_Permit_001.pdf", "Land_User_Right_Certificate_001.pdf", "Other_Documents_001.pdf", "Ownership_Certificate_001.pdf" });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("290fd4c4-6dcd-49b6-9367-30028da581ba"), new Guid("04f92cb7-f83a-49e7-866c-a1db6bd7464e"), "A leading provider of luxury apartment projects.", "Construction Corp", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1560), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information and Compliance Details.", "123 Construction Ave, Citytown, ST 12345", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1561), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("540e800e-1b7f-414b-8119-97c7b61e7017"), new Guid("8c45ebfd-a570-4f10-8107-891e0384bebc") });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "AccountID", "CreateAt", "CustomerAddress", "CustomerEmail", "CustomerName", "CustomerPhone", "UpdateAt", "imageUrl" },
                values: new object[,]
                {
                    { new Guid("289c6b44-09d9-4753-b3c3-0fe08778eab1"), new Guid("df2fae78-6160-40f2-a57d-246502250073"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 7, 0, 0, 0)), "123 Maple St, Cityville", "alice.smith@example.com", "Alice Smith", "0901234567", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1175), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/images/alice.jpg" },
                    { new Guid("5ab2ea48-e5ac-408b-9325-4fcd4c4f0495"), new Guid("13497ebd-2d52-4ce2-abb5-fef96e671bb4"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1260), new TimeSpan(0, 7, 0, 0, 0)), "101 Elm St, Hamlet", "diana.prince@example.com", "Diana Prince", "0904567890", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1261), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/images/diana.jpg" },
                    { new Guid("7b9fc10f-c592-4833-8dab-12916228b619"), new Guid("f3a42ab3-4d1e-409f-84aa-8e8204699d39"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1256), new TimeSpan(0, 7, 0, 0, 0)), "789 Pine St, Villagetown", "charlie.brown@example.com", "Charlie Brown", "0903456789", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1257), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/images/charlie.jpg" },
                    { new Guid("b7a79b22-00b4-44b3-a304-68a522b40059"), new Guid("4316f2e0-2323-45ab-bd1b-f25b98541220"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1264), new TimeSpan(0, 7, 0, 0, 0)), "202 Birch St, Metropolis", "eve.adams@example.com", "Eve Adams", "0905678901", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1265), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/images/eve.jpg" },
                    { new Guid("b7cc731d-def1-485b-b828-102804fa1961"), new Guid("ed2ca936-c957-4c44-8a5a-4cda0010fd09"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1250), new TimeSpan(0, 7, 0, 0, 0)), "456 Oak St, Townsville", "bob.johnson@example.com", "Bob Johnson", "0902345678", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1251), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/images/bob.jpg" },
                    { new Guid("f88c39a1-5f39-4f46-bb70-4aba748933c9"), new Guid("ee5c5364-3e7e-4665-8ac1-d8415e5f5050"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 342, DateTimeKind.Unspecified).AddTicks(7105), new TimeSpan(0, 7, 0, 0, 0)), "123 Main St, Example City", "michael.smith@example.com", "Michael Smith", "0123456789", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 342, DateTimeKind.Unspecified).AddTicks(7107), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/profile.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("b6a2b2a9-8fc6-4b81-881c-72d30f332cd9"), new Guid("df2fae78-6160-40f2-a57d-246502250073"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2700), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" },
                    { new Guid("d28483f0-e786-4423-be62-e155b3ccdb5e"), new Guid("ed2ca936-c957-4c44-8a5a-4cda0010fd09"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2707), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" }
                });

            migrationBuilder.InsertData(
                table: "Managements",
                columns: new[] { "ManagementID", "AccountID", "CreateAt", "ManagementEmail", "ManagementName", "ManagementPhone", "UpdateAt", "imageUrl" },
                values: new object[] { new Guid("5b7ccc3e-7a99-441d-8af4-7d5e81067686"), new Guid("0a12fd75-96cd-4852-a285-e42477f0a773"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1328), new TimeSpan(0, 7, 0, 0, 0)), "alice.johnson@example.com", "Alice Johnson", "0987654321", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1330), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/profile.jpg" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("69c54816-05af-439c-bdbe-be98a08e4ec4"), new Guid("f3a42ab3-4d1e-409f-84aa-8e8204699d39"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2802), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("3be71375-b38f-4336-8fc5-8e6faa7a6452"), new Guid("0b84fc57-981d-4c9e-a8b7-42e8adf4b43d"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2803), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("80324bac-bd9c-4575-8714-e3f8b223c0c5"), new Guid("ed2ca936-c957-4c44-8a5a-4cda0010fd09"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2809), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("3be71375-b38f-4336-8fc5-8e6faa7a6452"), new Guid("3c8faf9e-d846-42f6-be57-3c7f1a22431c"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffID", "AccountID", "CreateAt", "StaffEmail", "StaffName", "StaffPhone", "UpdateAt", "imageUrl" },
                values: new object[] { new Guid("141f7248-ac0a-4f35-9a1a-121eb536e3d7"), new Guid("c350d996-961f-4e34-b24d-32f7489db530"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 342, DateTimeKind.Unspecified).AddTicks(7061), new TimeSpan(0, 7, 0, 0, 0)), "johndoe@example.com", "John Doe", "123456789", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 342, DateTimeKind.Unspecified).AddTicks(7062), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/images/johndoe.png" });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "CreateDate", "ManagementID", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("43c9369d-0b37-4c4f-9866-0dad80a2921c"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1612), new TimeSpan(0, 7, 0, 0, 0)), new Guid("5b7ccc3e-7a99-441d-8af4-7d5e81067686"), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1621), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("ddcfb763-8062-4d84-b316-d30abb667184"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1644), new TimeSpan(0, 7, 0, 0, 0)), new Guid("5b7ccc3e-7a99-441d-8af4-7d5e81067686"), "1,000,000 - 2,000,000 USD", "A luxurious penthouse suite with stunning views.", "Penthouse Suite", 0, new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1645), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "ApartmentName", "ApartmentOwnerID", "ApartmentStatus", "ApartmentType", "CreatedDate", "Description", "ProjectID", "UpdatedDate", "address", "area", "direction", "expiryDate", "location", "numberOfRooms", "pricePerSquareMeter", "recommendedPrice" },
                values: new object[,]
                {
                    { new Guid("a69f0940-5d61-4d76-be88-db7e96a028f1"), "Ocean View Apartment", new Guid("349b4455-e509-4cdc-949d-b65470522118"), 1, 0, new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1863), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", new Guid("43c9369d-0b37-4c4f-9866-0dad80a2921c"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1864), new TimeSpan(0, 7, 0, 0, 0)), "456 Ocean Drive, Coastal City", "1800 sqft", "South-West", new DateTimeOffset(new DateTime(2027, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1866), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", "4", "3500 USD", "650,000 USD" },
                    { new Guid("fc1155f3-c9b9-43df-ac33-5e16821745cd"), "Skyline Apartment", new Guid("349b4455-e509-4cdc-949d-b65470522118"), 0, 1, new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1835), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", new Guid("43c9369d-0b37-4c4f-9866-0dad80a2921c"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1836), new TimeSpan(0, 7, 0, 0, 0)), "123 Skyline Road, New City", "1500 sqft", "North-East", new DateTimeOffset(new DateTime(2029, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1842), new TimeSpan(0, 7, 0, 0, 0)), "City Center", "3", "3000 USD", "450,000 USD" }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[,]
                {
                    { new Guid("1f7d9c7a-e60b-4157-982c-05b367df3526"), new Guid("43c9369d-0b37-4c4f-9866-0dad80a2921c"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1683), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("edec8574-a85b-4eaa-86d0-6cc4359a8889"), new Guid("ddcfb763-8062-4d84-b316-d30abb667184"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1687), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[,]
                {
                    { new Guid("98064f53-c98f-4bab-b078-a0f4f3d7148a"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1748), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("43c9369d-0b37-4c4f-9866-0dad80a2921c"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1749), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" },
                    { new Guid("fe077241-a8c2-4be7-b1b6-3fdc34ce2a00"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1753), new TimeSpan(0, 7, 0, 0, 0)), "Image of the penthouse suite", "Penthouse Suite Image", new Guid("ddcfb763-8062-4d84-b316-d30abb667184"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1754), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/penthouse-suite.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentFacility",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("3e9d4c5a-4d59-42d3-a7f9-1b605c44e41b"), new Guid("fc1155f3-c9b9-43df-ac33-5e16821745cd"), new Guid("18f4d4dc-eafd-4d85-89e3-ccfbad0c67d7") },
                    { new Guid("9e3b48b2-f00e-48c0-80db-2284af5e19d1"), new Guid("a69f0940-5d61-4d76-be88-db7e96a028f1"), new Guid("b4f59341-4d53-440d-b32e-fe6dc71b9dac") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("93697014-e353-443d-9c61-aa24bba89e3a"), new Guid("fc1155f3-c9b9-43df-ac33-5e16821745cd"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1982), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1984), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("ae3bd526-11b4-44e5-bad0-ed88a99aeef6"), new Guid("fc1155f3-c9b9-43df-ac33-5e16821745cd"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1979), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(1980), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "ApartmentID", "CustomerID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("3670fbeb-d901-4dd7-9624-a452c1adaaa0"), new Guid("fc1155f3-c9b9-43df-ac33-5e16821745cd"), new Guid("289c6b44-09d9-4753-b3c3-0fe08778eab1"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2166), new TimeSpan(0, 7, 0, 0, 0)), 0 },
                    { new Guid("fbbbf8ef-ef0c-4582-91c0-2a90b6e2548f"), new Guid("a69f0940-5d61-4d76-be88-db7e96a028f1"), new Guid("289c6b44-09d9-4753-b3c3-0fe08778eab1"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2172), new TimeSpan(0, 7, 0, 0, 0)), 1 }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0597c341-dedd-42c2-a3d8-7c326f2f65de"), new Guid("fc1155f3-c9b9-43df-ac33-5e16821745cd"), new DateTimeOffset(new DateTime(2024, 9, 25, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2326), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2324), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2321), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b7a79b22-00b4-44b3-a304-68a522b40059"), "Schedule a viewing for the Skyline Apartment.", new Guid("c1b8e261-bed7-40a1-8eb6-f047e8334c2e"), new Guid("141f7248-ac0a-4f35-9a1a-121eb536e3d7"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2323), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("18ad193f-be8a-4a20-98c5-69b948a11bf8"), new Guid("a69f0940-5d61-4d76-be88-db7e96a028f1"), new DateTimeOffset(new DateTime(2024, 9, 26, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2345), new TimeSpan(0, 7, 0, 0, 0)), 0, 0, "Admin", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2340), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2337), new TimeSpan(0, 7, 0, 0, 0)), new Guid("5ab2ea48-e5ac-408b-9325-4fcd4c4f0495"), "Discuss details about the Ocean View Apartment.", new Guid("06e748d7-aefb-4b2f-9dfe-cf2835ec52ac"), new Guid("141f7248-ac0a-4f35-9a1a-121eb536e3d7"), "Inquiry Appointment for Ocean View Apartment", new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2338), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Deposit",
                columns: new[] { "DepositID", "ApartmentID", "CreateDate", "CustomerID", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("6289489c-eec5-4a20-9e33-481e5ca7237b"), new Guid("fc1155f3-c9b9-43df-ac33-5e16821745cd"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2491), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7b9fc10f-c592-4833-8dab-12916228b619"), 0, new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2496), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 10, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2497), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "RequestApartment",
                columns: new[] { "RequestApartmentID", "ApartmentID", "CreateDate", "CustomerID", "ManagementID", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("42901199-7a37-4225-8002-4c8d1bceccd3"), new Guid("a69f0940-5d61-4d76-be88-db7e96a028f1"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2229), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b7cc731d-def1-485b-b828-102804fa1961"), new Guid("5b7ccc3e-7a99-441d-8af4-7d5e81067686"), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 9, 25, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." },
                    { new Guid("e4900aa8-2798-41d7-9cd5-1751f9140b4d"), new Guid("fc1155f3-c9b9-43df-ac33-5e16821745cd"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2213), new TimeSpan(0, 7, 0, 0, 0)), new Guid("289c6b44-09d9-4753-b3c3-0fe08778eab1"), new Guid("5b7ccc3e-7a99-441d-8af4-7d5e81067686"), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 9, 25, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2214), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "ApartmentID", "CreateDate", "StaffID", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("a46ad41f-a58d-4f9a-963c-3078ff38c242"), new Guid("fc1155f3-c9b9-43df-ac33-5e16821745cd"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2093), new TimeSpan(0, 7, 0, 0, 0)), new Guid("141f7248-ac0a-4f35-9a1a-121eb536e3d7"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2094), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" },
                    { new Guid("d37d6ef3-ccb0-4072-8152-c0122ff22aaf"), new Guid("a69f0940-5d61-4d76-be88-db7e96a028f1"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2103), new TimeSpan(0, 7, 0, 0, 0)), new Guid("141f7248-ac0a-4f35-9a1a-121eb536e3d7"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2103), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "CancelDate", "DepositCancelTypeID", "DepositID", "ManagementID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("81656127-acb0-4659-b755-d2e00f8c3cb9"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2641), new TimeSpan(0, 7, 0, 0, 0)), new Guid("bfe08a1f-0951-40fa-854d-842c20fda622"), new Guid("6289489c-eec5-4a20-9e33-481e5ca7237b"), new Guid("5b7ccc3e-7a99-441d-8af4-7d5e81067686"), "45000", new DateTimeOffset(new DateTime(2024, 9, 29, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2645), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2649), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("8d1bba7d-b101-45e2-8031-dc6c59f66f0e"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6289489c-eec5-4a20-9e33-481e5ca7237b"), 0, new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2587), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("618ee490-73b8-4d69-bcb6-e51649c7efc6"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2134), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a46ad41f-a58d-4f9a-963c-3078ff38c242") },
                    { new Guid("97ce8575-9818-4e0f-94f8-aad19b75abc5"), new DateTimeOffset(new DateTime(2024, 9, 24, 1, 38, 49, 716, DateTimeKind.Unspecified).AddTicks(2138), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d37d6ef3-ccb0-4072-8152-c0122ff22aaf") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgreementUpdateRequest_ApartmentProjectProviderID",
                table: "AgreementUpdateRequest",
                column: "ApartmentProjectProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_AgreementUpdateRequest_ManagementID",
                table: "AgreementUpdateRequest",
                column: "ManagementID");

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
                name: "IX_ApartmentInteractions_ApartmentID",
                table: "ApartmentInteractions",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentInteractions_CustomerID",
                table: "ApartmentInteractions",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwners_AccountID",
                table: "ApartmentOwners",
                column: "AccountID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentProjectProvider_AccountID",
                table: "ApartmentProjectProvider",
                column: "AccountID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ApartmentOwnerID",
                table: "Apartments",
                column: "ApartmentOwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ProjectID",
                table: "Apartments",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ApartmentID",
                table: "Appointment",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_CustomerID",
                table: "Appointment",
                column: "CustomerID");

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
                name: "IX_Customer_AccountID",
                table: "Customer",
                column: "AccountID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_ApartmentID",
                table: "Deposit",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_CustomerID",
                table: "Deposit",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_DepositCancel_DepositCancelTypeID",
                table: "DepositCancel",
                column: "DepositCancelTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DepositCancel_DepositID",
                table: "DepositCancel",
                column: "DepositID");

            migrationBuilder.CreateIndex(
                name: "IX_DepositCancel_ManagementID",
                table: "DepositCancel",
                column: "ManagementID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_AccountID",
                table: "Feedbacks",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Managements_AccountID",
                table: "Managements",
                column: "AccountID",
                unique: true);

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
                name: "IX_ProjectApartments_ManagementID",
                table: "ProjectApartments",
                column: "ManagementID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImages_ProjectApartmentID",
                table: "ProjectImages",
                column: "ProjectApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestApartment_ApartmentID",
                table: "RequestApartment",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestApartment_CustomerID",
                table: "RequestApartment",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestApartment_ManagementID",
                table: "RequestApartment",
                column: "ManagementID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_AccountID",
                table: "Staffs",
                column: "AccountID",
                unique: true);

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
                name: "IX_VRExperiences_ApartmentID",
                table: "VRExperiences",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_VRExperiences_StaffID",
                table: "VRExperiences",
                column: "StaffID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgreementUpdateRequest");

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
                name: "Deposit");

            migrationBuilder.DropTable(
                name: "VRExperiences");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "ApartmentOwners");

            migrationBuilder.DropTable(
                name: "ProjectApartments");

            migrationBuilder.DropTable(
                name: "Managements");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
