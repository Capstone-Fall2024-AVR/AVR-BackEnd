using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertyRequestAndVerification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("2d1e572b-3554-4c9d-ab74-9b22813700a0"));

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("5ac0e3ea-ac4c-4a06-a416-79d6800305ff"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("4adc5fcf-09ec-4688-93ab-dc0bb26924a1"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("694694cf-d0af-45db-b312-06441203f450"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("50777acf-2783-409a-882b-2dea347dbd7b"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("bae66ff0-ea19-41c8-a451-7f54799565cb"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("66e1e536-4449-4f24-bd79-71d008614b0e"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("87c6127c-746b-4e74-b73a-a3f2f85e661a"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: new Guid("3cf6343f-0eaa-4b8d-9974-6471b22262fb"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c2cad16a-7530-4f11-9d94-c1448e0dce1b"), new Guid("3b2b4b9f-b54e-4935-b307-c03f879c7313") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4c3acba7-211a-4008-9b12-6a93a08bca25"), new Guid("4877b9c7-0a3f-4d2d-b82e-4cdb0c59bb41") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6b478eae-7703-4040-8882-f1c04015cb88"), new Guid("651d145f-9391-4236-90a0-fd3500e333fe") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("bc84f6d6-4edc-4d1e-b7ce-bca1073dd7c8"), new Guid("988b1f14-19a4-462c-9f0b-e7e98af53d0e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("018f4eb5-b5b8-4e51-9785-1eba172d0f5b"), new Guid("d7c44b24-9814-4152-bd65-7df9df1e7384") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("11c86abd-dde7-46d1-b321-b4f841793428"), new Guid("fd4062a8-ed8a-4625-b531-5244086523d0") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("63823dab-3d15-44c7-8011-7972e9fe6f0b"));

            migrationBuilder.DeleteData(
                table: "DepositCancel",
                keyColumn: "DepositCancelID",
                keyValue: new Guid("99d3eedd-0885-4002-92d3-d0fe57aa8f8c"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("04789439-b477-4449-936c-42d34335e3d2"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("e04c00e9-691c-471d-9d55-849cd8111eff"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("2893bbd4-faae-4e6f-9235-ec87699ce8eb"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("6af6f14b-7254-417c-be1a-e00b200821f0"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("3e5a30da-c12d-4475-9451-e0e0330b7865"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("f4c522e3-8914-4dd0-a150-49ec5b125a8d"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("1fe7df18-0d9d-4a96-8ef3-ab2ca1a3975b"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("98c1caf3-2000-46cc-ab73-24f401d41ae6"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("40c731dc-573d-4235-8b8d-f7b876150ec8"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: new Guid("e87db829-5b32-4a61-ab75-caee2d3a9fbf"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("6e6aabef-121a-409b-bd10-d38ea2e671fd"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("a3b534b2-3b70-430b-a74d-b1a150302d22"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("018f4eb5-b5b8-4e51-9785-1eba172d0f5b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("11c86abd-dde7-46d1-b321-b4f841793428"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4c3acba7-211a-4008-9b12-6a93a08bca25"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6b478eae-7703-4040-8882-f1c04015cb88"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bc84f6d6-4edc-4d1e-b7ce-bca1073dd7c8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c2cad16a-7530-4f11-9d94-c1448e0dce1b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceda51-0ee2-464e-902d-8bd632c4b32b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b2b4b9f-b54e-4935-b307-c03f879c7313"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4877b9c7-0a3f-4d2d-b82e-4cdb0c59bb41"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("651d145f-9391-4236-90a0-fd3500e333fe"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("988b1f14-19a4-462c-9f0b-e7e98af53d0e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("99e8b13a-4cc3-4a7e-92a7-8fd7783b491e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae20b4c3-2d22-42c4-89c0-d11d9099c017"));

            migrationBuilder.DeleteData(
                table: "DepositCancelTypes",
                keyColumn: "DepositCancelTypeID",
                keyValue: new Guid("6c457ceb-a87d-4a3c-ad06-1b2781b0acdd"));

            migrationBuilder.DeleteData(
                table: "DepositRequest",
                keyColumn: "DepositID",
                keyValue: new Guid("aedf6722-2c3e-4220-9433-1a16187c2659"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("c342d5a1-5fda-41a1-b578-4e12a0940cb4"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("ed203546-99fe-4eb4-a672-cd0e83df4531"));

            migrationBuilder.DeleteData(
                table: "NotificationTypes",
                keyColumn: "NotificationTypeID",
                keyValue: new Guid("caed398c-2fae-4f5a-9755-0b7e62048630"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("9e6e5119-9e2f-402f-9dbb-640b1b925df3"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("4f123b58-252f-4cd9-b50b-469c27120bf8"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("9ac1bd56-526c-44d5-aaff-8babe52b5a6c"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("4ed699b7-f187-448e-a4d4-cb3fc45e03f5"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("6db4c1ba-911a-4576-9943-13215ad34fc1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e9d98c5-eeb0-454c-b849-00172029e62e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd4062a8-ed8a-4625-b531-5244086523d0"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("4a7ffb49-a7f2-4dcf-8934-e4a22b80ebd6"));

            migrationBuilder.DeleteData(
                table: "ApartmentProjectProvider",
                keyColumn: "ApartmentProjectProviderID",
                keyValue: new Guid("26334acc-1e32-436d-840b-6b2b2e51429c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7c44b24-9814-4152-bd65-7df9df1e7384"));

            migrationBuilder.AddColumn<Guid>(
                name: "VerificationID",
                table: "Apartments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PropertyRequest",
                columns: table => new
                {
                    RequestID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RequestStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyRequest", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK_PropertyRequest_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyVerification",
                columns: table => new
                {
                    VerificationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyRequestID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VerificationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    VerifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VerificationStatus = table.Column<int>(type: "int", nullable: false),
                    LegalDocumentsURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyVerification", x => x.VerificationID);
                    table.ForeignKey(
                        name: "FK_PropertyVerification_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyVerification_PropertyRequest_PropertyRequestID",
                        column: x => x.PropertyRequestID,
                        principalTable: "PropertyRequest",
                        principalColumn: "RequestID");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1552bf49-902b-47c9-9723-24b71ddf3c26"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("16ca1bb3-f071-4c06-aaff-29eeaaca968f"), null, "Staff", "STAFF" },
                    { new Guid("17d41519-2cfe-4521-bc00-751893adb261"), null, "Customer", "CUSTOMER" },
                    { new Guid("38ffbc55-71cb-448c-b83c-d884e6cf83b0"), null, "Admin", "ADMIN" },
                    { new Guid("5103e453-05fc-4f9e-b0a8-c17840f8e4b8"), null, "Management", "MANAGEMENT" },
                    { new Guid("64f5b477-6cc7-4281-8c35-1eabc4166812"), null, "Apartment Owner", "APARTMENT OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmationOtp", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OtpExpiryTime", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4ec310c0-17e6-409d-ad86-c262f2a49a55"), 0, 0, null, "eeeda6f2-b8a2-44c4-9255-b3a65b0037cb", "eve.adams@example.com", null, true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEN8huNjEU0nVh7AVHa5Zk111751i6B6UVoxJ2LhvGaDR56nOW0WKJdYl00HDRqhXzQ==", "0905678901", true, "a97fc8b1-8bfa-4083-a4b7-8c1d1d2ffeaf", false, "eve.adams@example.com" },
                    { new Guid("570c0fe8-5fe4-4c83-aba0-2345fce70a94"), 0, 0, "", "ade3142b-9d3c-4bc0-9815-318c18ef13c3", "construction.corp@example.com", null, true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEPdPwc2Jle6/SIiXoWE7MAlFXJRKMJVfEeYbKNIodwkwcXQFuEgfVfTRYLlltKMmqw==", "0987654321", true, "4713b49f-46d3-4393-8357-748103a415a1", false, "construction.corp@example.com" },
                    { new Guid("60e40435-ce2a-4e64-bc18-b6dfd0a4a066"), 0, 0, "", "eed5c4b5-b16d-4561-a79e-24d35a089403", "david.brown@example.com", null, true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAENyXRE1gu0F0yDfwQrz7I7aQcdHcY+rOc9NVia5nRDuTo0+p2zfQc4ZmKnKtb0Z1hA==", "0123456789", true, "b5569ac3-8a68-4793-baff-3e792800cfd9", false, "david.brown@example.com" },
                    { new Guid("771a7ae6-ac31-4405-98c1-013b1314bb7b"), 0, 0, null, "3b8b7d36-5aab-4800-894e-aef75d729b64", "alice.smith@example.com", null, true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEMFEbNQHF7ykBVxp/iNNBSFUaob5P1eGocTqEJv/lcgZp7OsBiHlg6xjXKiQGsSRbg==", "0901234567", true, "aae6b080-eb10-4df2-942c-33cba55d4a17", false, "alice.smith@example.com" },
                    { new Guid("a25e3e86-531a-4d24-8d48-7bfa7ec54187"), 0, 0, null, "64189813-7acf-4dc7-83a2-9f1cb510d5aa", "diana.prince@example.com", null, true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAELUrprYeBMjBKdhBSa21Ks2wuzb5zVxJBOKVmK1GVx1ErKM4+EA1eTkjvn/ay0vEiQ==", "0904567890", true, "cab2ce86-b91e-4114-8d78-48f60e75383f", false, "diana.prince@example.com" },
                    { new Guid("a7856551-d3c7-4605-8301-0f399ceb9013"), 0, 0, "", "3e738c8f-5404-497f-b800-4ba5510199a0", "michael.smith@example.com", null, true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAENULO4lpcoNaGnku7ki4SsyQq5f8BHr6StjTiKKPfjxOhmFVjuguTumf7gFySC0fyw==", "0123456789", true, "cce06953-c9f3-4bad-b693-6add5472a26c", false, "michael.smith@example.com" },
                    { new Guid("a8d6c6ca-91d7-4d96-b5d9-fb69de3d5b97"), 0, 0, "", "0afeeeda-3ff7-41ce-91f4-e9b398a3bc5b", "quansongngu13@gmail.com", null, true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", null, "AQAAAAIAAYagAAAAEIwRWDnI1r+219FoBFftR0XWolFR/D5KTgjylpimuSl9zQs/VuPMlsq3DoIUNZXN4g==", "0949035672", true, "214e0cb1-1655-4794-be78-fcd9f44145b9", false, "quansongngu13@gmail.com" },
                    { new Guid("c8499604-b1a5-4bab-b916-e6b17fe3a851"), 0, 0, null, "2193d67a-c6d8-44f4-85b8-99e8a23608bf", "bob.johnson@example.com", null, true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEAgY1QRermKWRVVlW8y0dLFoxkpyQBQy0R+bmax0yTB380+g5iZ8W+ws2xBQQaLUtQ==", "0902345678", true, "3bcacd93-3c17-4dc0-a1e5-5839d4aadc0d", false, "bob.johnson@example.com" },
                    { new Guid("cf0b870b-c3ba-4866-a129-45ede28415b2"), 0, 0, null, "33e7a20f-bf97-454f-80e5-645f8f9c9201", "charlie.brown@example.com", null, true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEIognllbToS39MBHoMA+Ylvj/Zh6RDrx2XSZN5tkYk/50MGscGHhY9A332mZUELjnA==", "0903456789", true, "f402b57b-d277-473b-ae7b-0f5f351ea287", false, "charlie.brown@example.com" },
                    { new Guid("d04c0421-0fb6-488c-9d20-3bccdc23a0d2"), 0, 0, "", "7c370d3c-d897-4db3-b657-9f7c4b4a2d96", "luong.a11.dbk@gmail.com", null, true, false, null, "Duc Luong", "LUONG.A11.DBK@GMAIL.COM", "LUONG.A11.DBK@GMAIL.COM", null, "AQAAAAIAAYagAAAAEGCgFkx6P8qLyGqevSTTsQ/A1euai1y8FtW/zkRwoV5FTQJOaAq5kRlDCZtv6DlY9Q==", "0987654321", true, "a875e7b3-1f0d-4b07-a164-d9075a85ad5d", false, "luong.a11.dbk@gmail.com" },
                    { new Guid("d23aace5-d6fa-46af-bb85-7a7cd82c7213"), 0, 0, null, "84315d8c-e738-4a61-82f3-5e9c23bc6ca2", "johndoe@example.com", null, true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEJGqUHimjIEd/MzzxX8+OLTD3Mw8GERq3rT7ZXXbKwEawtVxcptLs3bQGyZ9sYx6ZA==", "123456789", true, "aaf779e2-54cc-43aa-89ae-d01f94eb4879", false, "johndoe@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("9e81b5d8-b2aa-4566-8ff6-181fb96431a8"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8800), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8801), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("12de9070-94b1-4b94-893b-6b0cfdfa8922"), "A fully equipped fitness gym.", "Gym" },
                    { new Guid("66ed0b78-6bef-4622-ab65-dfca6d28cb7e"), "A large outdoor swimming pool.", "Swimming Pool" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("d928a118-afa9-4c4e-84c8-b6535f814117"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("0574b02a-4392-4136-907e-0f2807ba723e"), "10:00 AM", "09:00 AM" },
                    { new Guid("86f0f346-025d-482c-9720-71d3bfca7b2a"), "11:00 AM", "10:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("4d3af162-3326-4dca-9743-eefbdb775bf2"), new Guid("570c0fe8-5fe4-4c83-aba0-2345fce70a94"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6248), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1552bf49-902b-47c9-9723-24b71ddf3c26"), new Guid("570c0fe8-5fe4-4c83-aba0-2345fce70a94") },
                    { new Guid("64f5b477-6cc7-4281-8c35-1eabc4166812"), new Guid("60e40435-ce2a-4e64-bc18-b6dfd0a4a066") },
                    { new Guid("17d41519-2cfe-4521-bc00-751893adb261"), new Guid("a7856551-d3c7-4605-8301-0f399ceb9013") },
                    { new Guid("38ffbc55-71cb-448c-b83c-d884e6cf83b0"), new Guid("a8d6c6ca-91d7-4d96-b5d9-fb69de3d5b97") },
                    { new Guid("5103e453-05fc-4f9e-b0a8-c17840f8e4b8"), new Guid("d04c0421-0fb6-488c-9d20-3bccdc23a0d2") },
                    { new Guid("16ca1bb3-f071-4c06-aaff-29eeaaca968f"), new Guid("d23aace5-d6fa-46af-bb85-7a7cd82c7213") }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("a465ea01-1214-48a4-a32b-b404d31b0231"), new Guid("c8499604-b1a5-4bab-b916-e6b17fe3a851"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8971), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" },
                    { new Guid("d5a39830-464b-4231-8eea-d78d70dfc906"), new Guid("771a7ae6-ac31-4405-98c1-013b1314bb7b"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8964), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("9724d918-fbbf-493f-8160-522969ec78f6"), new Guid("c8499604-b1a5-4bab-b916-e6b17fe3a851"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(9041), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("d928a118-afa9-4c4e-84c8-b6535f814117"), new Guid("790619a1-3417-455b-825e-3acd9388b589"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(9042), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("9fb7ea73-c8e1-48bf-b197-836ca1d18e9e"), new Guid("cf0b870b-c3ba-4866-a129-45ede28415b2"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(9031), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("d928a118-afa9-4c4e-84c8-b6535f814117"), new Guid("a511947c-a0f2-45ef-a6bb-1fb8201d7ae2"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(9032), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[] { new Guid("da506838-f652-4ed7-a772-d124547ff4a7"), null, new Guid("4d3af162-3326-4dca-9743-eefbdb775bf2"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6607), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6607), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "Address", "ApartmentName", "ApartmentStatus", "ApartmentType", "Area", "BalconyDirection", "CreatedDate", "Description", "Direction", "District", "ExpiryDate", "Location", "NumberOfBathrooms", "NumberOfRooms", "PricePerSquareMeter", "ProjectApartmentID", "RecommendedPrice", "SaleStatus", "UpdatedDate", "VerificationID", "Ward" },
                values: new object[,]
                {
                    { new Guid("2b13e7c7-f862-4c4d-86f9-b0a46e64e69b"), "123 Skyline Road, New City", "Skyline Apartment", 0, 1, 150.00m, 5, new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6761), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", 1, "Central District", new DateTimeOffset(new DateTime(2029, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6772), new TimeSpan(0, 7, 0, 0, 0)), "City Center", 2, 3, 70000000m, new Guid("da506838-f652-4ed7-a772-d124547ff4a7"), 10000000000m, 1, new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6762), new TimeSpan(0, 7, 0, 0, 0)), null, "Ward 5" },
                    { new Guid("ed661831-52c7-46a5-8ea0-e2e8d60897ec"), "456 Ocean Drive, Coastal City", "Ocean View Apartment", 2, 2, 170.00m, 8, new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", 2, "Coastal District", new DateTimeOffset(new DateTime(2027, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6793), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", 3, 4, 90000000m, new Guid("da506838-f652-4ed7-a772-d124547ff4a7"), 15000000000m, 1, new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6791), new TimeSpan(0, 7, 0, 0, 0)), null, "Ward 2" }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[] { new Guid("92f9c113-070c-499a-aee8-70bf69e9246c"), new Guid("da506838-f652-4ed7-a772-d124547ff4a7"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6683), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[] { new Guid("8a8fd16f-50a2-4c6a-a3d6-4641829f6714"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6717), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("da506838-f652-4ed7-a772-d124547ff4a7"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(6718), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("4d8f996d-ef6d-494d-999a-0c115ef8f425"), new Guid("ed661831-52c7-46a5-8ea0-e2e8d60897ec"), new Guid("12de9070-94b1-4b94-893b-6b0cfdfa8922") },
                    { new Guid("f28eec89-8616-4b71-89a1-8e3e12df3355"), new Guid("2b13e7c7-f862-4c4d-86f9-b0a46e64e69b"), new Guid("66ed0b78-6bef-4622-ab65-dfca6d28cb7e") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("49b861a6-abff-42de-9789-169a95e5642f"), new Guid("2b13e7c7-f862-4c4d-86f9-b0a46e64e69b"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8207), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8208), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a68c06d7-ed53-4d1f-ad3c-ac25a2d859af"), new Guid("2b13e7c7-f862-4c4d-86f9-b0a46e64e69b"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8194), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8205), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("57bb3f72-e878-48f1-abb9-09052a48b5a1"), new Guid("c8499604-b1a5-4bab-b916-e6b17fe3a851"), new Guid("ed661831-52c7-46a5-8ea0-e2e8d60897ec"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8561), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { new Guid("b6f66808-f8ca-40a8-b23e-8a79ab1ed042"), new Guid("771a7ae6-ac31-4405-98c1-013b1314bb7b"), new Guid("2b13e7c7-f862-4c4d-86f9-b0a46e64e69b"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8550), new TimeSpan(0, 7, 0, 0, 0)), 0 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("2d55646b-648b-42f6-af2c-abfda7ddcc8b"), new Guid("60e40435-ce2a-4e64-bc18-b6dfd0a4a066"), new Guid("2b13e7c7-f862-4c4d-86f9-b0a46e64e69b") },
                    { new Guid("8ef63ecf-a83c-411b-8940-abcbcddadefb"), new Guid("60e40435-ce2a-4e64-bc18-b6dfd0a4a066"), new Guid("2b13e7c7-f862-4c4d-86f9-b0a46e64e69b") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("c085ddcd-9826-444a-9f60-16d4ea056e2e"), new Guid("2b13e7c7-f862-4c4d-86f9-b0a46e64e69b"), new Guid("60e40435-ce2a-4e64-bc18-b6dfd0a4a066"), new DateTimeOffset(new DateTime(2024, 10, 18, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8768), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8767), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8765), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4ec310c0-17e6-409d-ad86-c262f2a49a55"), "Schedule a viewing for the Skyline Apartment.", new Guid("570c0fe8-5fe4-4c83-aba0-2345fce70a94"), new Guid("0574b02a-4392-4136-907e-0f2807ba723e"), new Guid("d23aace5-d6fa-46af-bb85-7a7cd82c7213"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8765), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("90f8eb61-73b9-4f50-8919-db5202f36223"), new Guid("cf0b870b-c3ba-4866-a129-45ede28415b2"), new Guid("2b13e7c7-f862-4c4d-86f9-b0a46e64e69b"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8833), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8836), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 11, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8837), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("789f6190-ad0b-4eec-9b4c-965a41a2e2aa"), new Guid("c8499604-b1a5-4bab-b916-e6b17fe3a851"), new Guid("2b13e7c7-f862-4c4d-86f9-b0a46e64e69b"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 10, 18, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8599), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." },
                    { new Guid("edcccc36-2a97-423f-a81e-0d8aae470d2b"), new Guid("771a7ae6-ac31-4405-98c1-013b1314bb7b"), new Guid("ed661831-52c7-46a5-8ea0-e2e8d60897ec"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8611), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 10, 18, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8611), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("869c2583-9246-4fee-afab-757b4fac238b"), new Guid("d23aace5-d6fa-46af-bb85-7a7cd82c7213"), new Guid("2b13e7c7-f862-4c4d-86f9-b0a46e64e69b"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8261), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8267), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" },
                    { new Guid("c7e8ca74-c089-4132-9752-34533f4abf54"), new Guid("d23aace5-d6fa-46af-bb85-7a7cd82c7213"), new Guid("ed661831-52c7-46a5-8ea0-e2e8d60897ec"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8289), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8371), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("ed72a843-1635-447e-b38d-4bfa73aa0193"), new Guid("d04c0421-0fb6-488c-9d20-3bccdc23a0d2"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8931), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9e81b5d8-b2aa-4566-8ff6-181fb96431a8"), new Guid("90f8eb61-73b9-4f50-8919-db5202f36223"), "45000", new DateTimeOffset(new DateTime(2024, 10, 22, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8932), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8933), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("6e698a15-b1e9-4453-815c-a0171fe23419"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8895), new TimeSpan(0, 7, 0, 0, 0)), new Guid("90f8eb61-73b9-4f50-8919-db5202f36223"), 0, new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8897), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8896), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("20703c70-b7e1-4909-a32c-f4ba37f0b8d0"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8417), new TimeSpan(0, 7, 0, 0, 0)), new Guid("c7e8ca74-c089-4132-9752-34533f4abf54") },
                    { new Guid("745d3309-6fcb-406b-a5c4-4e8388681708"), new DateTimeOffset(new DateTime(2024, 10, 17, 9, 51, 6, 577, DateTimeKind.Unspecified).AddTicks(8411), new TimeSpan(0, 7, 0, 0, 0)), new Guid("869c2583-9246-4fee-afab-757b4fac238b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_VerificationID",
                table: "Apartments",
                column: "VerificationID");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRequest_AccountID",
                table: "PropertyRequest",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyVerification_AccountId",
                table: "PropertyVerification",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyVerification_PropertyRequestID",
                table: "PropertyVerification",
                column: "PropertyRequestID");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_PropertyVerification_VerificationID",
                table: "Apartments",
                column: "VerificationID",
                principalTable: "PropertyVerification",
                principalColumn: "VerificationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_PropertyVerification_VerificationID",
                table: "Apartments");

            migrationBuilder.DropTable(
                name: "PropertyVerification");

            migrationBuilder.DropTable(
                name: "PropertyRequest");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_VerificationID",
                table: "Apartments");

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("4d8f996d-ef6d-494d-999a-0c115ef8f425"));

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("f28eec89-8616-4b71-89a1-8e3e12df3355"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("49b861a6-abff-42de-9789-169a95e5642f"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("a68c06d7-ed53-4d1f-ad3c-ac25a2d859af"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("57bb3f72-e878-48f1-abb9-09052a48b5a1"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("b6f66808-f8ca-40a8-b23e-8a79ab1ed042"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("2d55646b-648b-42f6-af2c-abfda7ddcc8b"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("8ef63ecf-a83c-411b-8940-abcbcddadefb"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: new Guid("c085ddcd-9826-444a-9f60-16d4ea056e2e"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1552bf49-902b-47c9-9723-24b71ddf3c26"), new Guid("570c0fe8-5fe4-4c83-aba0-2345fce70a94") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("64f5b477-6cc7-4281-8c35-1eabc4166812"), new Guid("60e40435-ce2a-4e64-bc18-b6dfd0a4a066") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("17d41519-2cfe-4521-bc00-751893adb261"), new Guid("a7856551-d3c7-4605-8301-0f399ceb9013") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("38ffbc55-71cb-448c-b83c-d884e6cf83b0"), new Guid("a8d6c6ca-91d7-4d96-b5d9-fb69de3d5b97") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5103e453-05fc-4f9e-b0a8-c17840f8e4b8"), new Guid("d04c0421-0fb6-488c-9d20-3bccdc23a0d2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("16ca1bb3-f071-4c06-aaff-29eeaaca968f"), new Guid("d23aace5-d6fa-46af-bb85-7a7cd82c7213") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a25e3e86-531a-4d24-8d48-7bfa7ec54187"));

            migrationBuilder.DeleteData(
                table: "DepositCancel",
                keyColumn: "DepositCancelID",
                keyValue: new Guid("ed72a843-1635-447e-b38d-4bfa73aa0193"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("a465ea01-1214-48a4-a32b-b404d31b0231"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("d5a39830-464b-4231-8eea-d78d70dfc906"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("9724d918-fbbf-493f-8160-522969ec78f6"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("9fb7ea73-c8e1-48bf-b197-836ca1d18e9e"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("92f9c113-070c-499a-aee8-70bf69e9246c"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("8a8fd16f-50a2-4c6a-a3d6-4641829f6714"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("789f6190-ad0b-4eec-9b4c-965a41a2e2aa"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("edcccc36-2a97-423f-a81e-0d8aae470d2b"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("86f0f346-025d-482c-9720-71d3bfca7b2a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: new Guid("6e698a15-b1e9-4453-815c-a0171fe23419"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("20703c70-b7e1-4909-a32c-f4ba37f0b8d0"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("745d3309-6fcb-406b-a5c4-4e8388681708"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1552bf49-902b-47c9-9723-24b71ddf3c26"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ca1bb3-f071-4c06-aaff-29eeaaca968f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d41519-2cfe-4521-bc00-751893adb261"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("38ffbc55-71cb-448c-b83c-d884e6cf83b0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5103e453-05fc-4f9e-b0a8-c17840f8e4b8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("64f5b477-6cc7-4281-8c35-1eabc4166812"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4ec310c0-17e6-409d-ad86-c262f2a49a55"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("60e40435-ce2a-4e64-bc18-b6dfd0a4a066"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("771a7ae6-ac31-4405-98c1-013b1314bb7b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a7856551-d3c7-4605-8301-0f399ceb9013"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a8d6c6ca-91d7-4d96-b5d9-fb69de3d5b97"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8499604-b1a5-4bab-b916-e6b17fe3a851"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d04c0421-0fb6-488c-9d20-3bccdc23a0d2"));

            migrationBuilder.DeleteData(
                table: "DepositCancelTypes",
                keyColumn: "DepositCancelTypeID",
                keyValue: new Guid("9e81b5d8-b2aa-4566-8ff6-181fb96431a8"));

            migrationBuilder.DeleteData(
                table: "DepositRequest",
                keyColumn: "DepositID",
                keyValue: new Guid("90f8eb61-73b9-4f50-8919-db5202f36223"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("12de9070-94b1-4b94-893b-6b0cfdfa8922"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("66ed0b78-6bef-4622-ab65-dfca6d28cb7e"));

            migrationBuilder.DeleteData(
                table: "NotificationTypes",
                keyColumn: "NotificationTypeID",
                keyValue: new Guid("d928a118-afa9-4c4e-84c8-b6535f814117"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("0574b02a-4392-4136-907e-0f2807ba723e"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("869c2583-9246-4fee-afab-757b4fac238b"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("c7e8ca74-c089-4132-9752-34533f4abf54"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("2b13e7c7-f862-4c4d-86f9-b0a46e64e69b"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("ed661831-52c7-46a5-8ea0-e2e8d60897ec"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf0b870b-c3ba-4866-a129-45ede28415b2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d23aace5-d6fa-46af-bb85-7a7cd82c7213"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("da506838-f652-4ed7-a772-d124547ff4a7"));

            migrationBuilder.DeleteData(
                table: "ApartmentProjectProvider",
                keyColumn: "ApartmentProjectProviderID",
                keyValue: new Guid("4d3af162-3326-4dca-9743-eefbdb775bf2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("570c0fe8-5fe4-4c83-aba0-2345fce70a94"));

            migrationBuilder.DropColumn(
                name: "VerificationID",
                table: "Apartments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("018f4eb5-b5b8-4e51-9785-1eba172d0f5b"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("11c86abd-dde7-46d1-b321-b4f841793428"), null, "Staff", "STAFF" },
                    { new Guid("4c3acba7-211a-4008-9b12-6a93a08bca25"), null, "Management", "MANAGEMENT" },
                    { new Guid("6b478eae-7703-4040-8882-f1c04015cb88"), null, "Customer", "CUSTOMER" },
                    { new Guid("bc84f6d6-4edc-4d1e-b7ce-bca1073dd7c8"), null, "Apartment Owner", "APARTMENT OWNER" },
                    { new Guid("c2cad16a-7530-4f11-9d94-c1448e0dce1b"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmationOtp", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OtpExpiryTime", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1e9d98c5-eeb0-454c-b849-00172029e62e"), 0, 0, null, "6de29e7a-d7c1-4341-84ea-28d7a8ff6df3", "charlie.brown@example.com", null, true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEP9PpQOPIw50yjLWE6V+qHVCg7mVcUb8OFMCW8Ev9do3R+4zSLSk7mFDdTSp6N0YNA==", "0903456789", true, "6d5112de-24c8-4df9-a7dc-2eb26fdf6f36", false, "charlie.brown@example.com" },
                    { new Guid("2fceda51-0ee2-464e-902d-8bd632c4b32b"), 0, 0, null, "05159274-a60d-41f1-ab60-b31c7a2c4e09", "eve.adams@example.com", null, true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEKEm9uUiSb4J5JgWGla/2sk1rqHDnFjShkXD1cW+0tS5kXueu/Uf+nk/xkA4VT38gg==", "0905678901", true, "a9453ca1-5ff8-48fc-b13f-f7dfd99ef7f5", false, "eve.adams@example.com" },
                    { new Guid("3b2b4b9f-b54e-4935-b307-c03f879c7313"), 0, 0, "", "7c9c3be2-3663-485c-b657-6f4d7b05a443", "quansongngu13@gmail.com", null, true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", null, "AQAAAAIAAYagAAAAEFPV26mdGOHJRM5YReY2Y6EpA9r9q+Y3FbFGvi8mYWyNPp7Y1cGLHmP3s4hPGUSGjQ==", "0949035672", true, "964b4e89-537b-4b1e-9ef0-7202de3ab849", false, "quansongngu13@gmail.com" },
                    { new Guid("4877b9c7-0a3f-4d2d-b82e-4cdb0c59bb41"), 0, 0, "", "7a559166-39ad-4e08-bd15-ec042b3fbfed", "luong.a11.dbk@gmail.com", null, true, false, null, "Duc Luong", "LUONG.A11.DBK@GMAIL.COM", "LUONG.A11.DBK@GMAIL.COM", null, "AQAAAAIAAYagAAAAEMUaj0YbjwKC2JpBGyTM6iJdOLv05gAK7SiZQqem+N6C2obaYOctw2/8Y/41fU7qqQ==", "0987654321", true, "122be8ab-8640-49a9-87d3-d4f69f452e60", false, "luong.a11.dbk@gmail.com" },
                    { new Guid("63823dab-3d15-44c7-8011-7972e9fe6f0b"), 0, 0, null, "b420f05f-d97c-4b88-9383-6057168f4279", "diana.prince@example.com", null, true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEL/jm5iBTeVgzYbh+/aRjotqThClLp3pbe+ciIYpMeb5x4ZMexDuqEI0Ra7HRpLNwQ==", "0904567890", true, "6962c0e2-77a4-47cd-977d-a12b50d91e4c", false, "diana.prince@example.com" },
                    { new Guid("651d145f-9391-4236-90a0-fd3500e333fe"), 0, 0, "", "80d7052d-3805-4d5f-8b42-ad9de54dd4eb", "michael.smith@example.com", null, true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEBxheGjoYRv00AB+nJaiqgbhdMwYlikro1ai4JNGLRteHM5E6mdxs0X/SOggkxiWBg==", "0123456789", true, "5494d29c-b62f-40dc-ac7b-9d11ad75fc38", false, "michael.smith@example.com" },
                    { new Guid("988b1f14-19a4-462c-9f0b-e7e98af53d0e"), 0, 0, "", "066c1568-ad29-4a2f-b962-40484626e41b", "david.brown@example.com", null, true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEHy2PkWvlkAo+PiBHWhgVWa6rARNkAeeme87ao13BDk/BomlkUhuK/vm/b2VfJBwpA==", "0123456789", true, "ef7f1a33-61f9-4b57-bd7c-6d59be8e38c6", false, "david.brown@example.com" },
                    { new Guid("99e8b13a-4cc3-4a7e-92a7-8fd7783b491e"), 0, 0, null, "a15a3214-0e60-4084-9aac-f41624f32af9", "alice.smith@example.com", null, true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEBjULOSRxP03IhZufIptUK0mgeGPUdUwQcjXSJiklevxiBuCm6PpKJ4qj4Zmq92W4Q==", "0901234567", true, "6acbc546-04a6-4741-aa8a-412b00c09538", false, "alice.smith@example.com" },
                    { new Guid("ae20b4c3-2d22-42c4-89c0-d11d9099c017"), 0, 0, null, "579a733c-ca40-4eac-b08b-3b8920829e11", "bob.johnson@example.com", null, true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEMYzq0eUfWda7YOT03ShYend6DJynOpts6BCXkjkKihe/yCp/SCM2dfkyowYPFeGXQ==", "0902345678", true, "23a084df-56fc-4d76-a5fc-ff004507deff", false, "bob.johnson@example.com" },
                    { new Guid("d7c44b24-9814-4152-bd65-7df9df1e7384"), 0, 0, "", "01a2b204-260c-42e1-9938-b20fb589cc8b", "construction.corp@example.com", null, true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEAzW8jc7PILFT0TRA7ukdEaYJnR45D+5eqBi4JHY2EmkeCvJyyZS3g7V35nAR9zalg==", "0987654321", true, "9b473c9e-f04c-4999-8de9-ecb21250fd7c", false, "construction.corp@example.com" },
                    { new Guid("fd4062a8-ed8a-4625-b531-5244086523d0"), 0, 0, null, "021503a3-191e-4a26-962a-12d171c0e5b9", "johndoe@example.com", null, true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEICsBQjALxZO0CpGrs1sRrmaAtQT7DJPZlZw4jvDqdqc7XXir73xd2Gfej6sj8zpdA==", "123456789", true, "09db58f3-b359-42de-950d-ebfaa53362d2", false, "johndoe@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("6c457ceb-a87d-4a3c-ad06-1b2781b0acdd"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9763), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9765), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("c342d5a1-5fda-41a1-b578-4e12a0940cb4"), "A fully equipped fitness gym.", "Gym" },
                    { new Guid("ed203546-99fe-4eb4-a672-cd0e83df4531"), "A large outdoor swimming pool.", "Swimming Pool" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("caed398c-2fae-4f5a-9755-0b7e62048630"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("40c731dc-573d-4235-8b8d-f7b876150ec8"), "11:00 AM", "10:00 AM" },
                    { new Guid("9e6e5119-9e2f-402f-9dbb-640b1b925df3"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("26334acc-1e32-436d-840b-6b2b2e51429c"), new Guid("d7c44b24-9814-4152-bd65-7df9df1e7384"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7476), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7478), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c2cad16a-7530-4f11-9d94-c1448e0dce1b"), new Guid("3b2b4b9f-b54e-4935-b307-c03f879c7313") },
                    { new Guid("4c3acba7-211a-4008-9b12-6a93a08bca25"), new Guid("4877b9c7-0a3f-4d2d-b82e-4cdb0c59bb41") },
                    { new Guid("6b478eae-7703-4040-8882-f1c04015cb88"), new Guid("651d145f-9391-4236-90a0-fd3500e333fe") },
                    { new Guid("bc84f6d6-4edc-4d1e-b7ce-bca1073dd7c8"), new Guid("988b1f14-19a4-462c-9f0b-e7e98af53d0e") },
                    { new Guid("018f4eb5-b5b8-4e51-9785-1eba172d0f5b"), new Guid("d7c44b24-9814-4152-bd65-7df9df1e7384") },
                    { new Guid("11c86abd-dde7-46d1-b321-b4f841793428"), new Guid("fd4062a8-ed8a-4625-b531-5244086523d0") }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("04789439-b477-4449-936c-42d34335e3d2"), new Guid("ae20b4c3-2d22-42c4-89c0-d11d9099c017"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9942), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" },
                    { new Guid("e04c00e9-691c-471d-9d55-849cd8111eff"), new Guid("99e8b13a-4cc3-4a7e-92a7-8fd7783b491e"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9939), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("2893bbd4-faae-4e6f-9235-ec87699ce8eb"), new Guid("ae20b4c3-2d22-42c4-89c0-d11d9099c017"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 451, DateTimeKind.Unspecified).AddTicks(57), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("caed398c-2fae-4f5a-9755-0b7e62048630"), new Guid("be0c2281-187b-4645-b48a-0e1d3d92c07c"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 451, DateTimeKind.Unspecified).AddTicks(57), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("6af6f14b-7254-417c-be1a-e00b200821f0"), new Guid("1e9d98c5-eeb0-454c-b849-00172029e62e"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 451, DateTimeKind.Unspecified).AddTicks(49), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("caed398c-2fae-4f5a-9755-0b7e62048630"), new Guid("605ef69d-de35-4edb-a26b-c6de4809a65b"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 451, DateTimeKind.Unspecified).AddTicks(50), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[] { new Guid("4a7ffb49-a7f2-4dcf-8934-e4a22b80ebd6"), null, new Guid("26334acc-1e32-436d-840b-6b2b2e51429c"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7602), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7604), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "Address", "ApartmentName", "ApartmentStatus", "ApartmentType", "Area", "BalconyDirection", "CreatedDate", "Description", "Direction", "District", "ExpiryDate", "Location", "NumberOfBathrooms", "NumberOfRooms", "PricePerSquareMeter", "ProjectApartmentID", "RecommendedPrice", "SaleStatus", "UpdatedDate", "Ward" },
                values: new object[,]
                {
                    { new Guid("4ed699b7-f187-448e-a4d4-cb3fc45e03f5"), "123 Skyline Road, New City", "Skyline Apartment", 0, 1, 150.00m, 5, new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7786), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", 1, "", new DateTimeOffset(new DateTime(2029, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7798), new TimeSpan(0, 7, 0, 0, 0)), "City Center", 2, 3, 70000000m, new Guid("4a7ffb49-a7f2-4dcf-8934-e4a22b80ebd6"), 10000000000m, 1, new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7787), new TimeSpan(0, 7, 0, 0, 0)), "" },
                    { new Guid("6db4c1ba-911a-4576-9943-13215ad34fc1"), "456 Ocean Drive, Coastal City", "Ocean View Apartment", 2, 2, 170.00m, 8, new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7846), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", 2, "", new DateTimeOffset(new DateTime(2027, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7851), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", 3, 4, 90000000m, new Guid("4a7ffb49-a7f2-4dcf-8934-e4a22b80ebd6"), 15000000000m, 1, new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7847), new TimeSpan(0, 7, 0, 0, 0)), "" }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[] { new Guid("3e5a30da-c12d-4475-9451-e0e0330b7865"), new Guid("4a7ffb49-a7f2-4dcf-8934-e4a22b80ebd6"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[] { new Guid("f4c522e3-8914-4dd0-a150-49ec5b125a8d"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7743), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("4a7ffb49-a7f2-4dcf-8934-e4a22b80ebd6"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(7744), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("2d1e572b-3554-4c9d-ab74-9b22813700a0"), new Guid("6db4c1ba-911a-4576-9943-13215ad34fc1"), new Guid("c342d5a1-5fda-41a1-b578-4e12a0940cb4") },
                    { new Guid("5ac0e3ea-ac4c-4a06-a416-79d6800305ff"), new Guid("4ed699b7-f187-448e-a4d4-cb3fc45e03f5"), new Guid("ed203546-99fe-4eb4-a672-cd0e83df4531") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("4adc5fcf-09ec-4688-93ab-dc0bb26924a1"), new Guid("4ed699b7-f187-448e-a4d4-cb3fc45e03f5"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9318), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9324), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("694694cf-d0af-45db-b312-06441203f450"), new Guid("4ed699b7-f187-448e-a4d4-cb3fc45e03f5"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9327), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9327), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("50777acf-2783-409a-882b-2dea347dbd7b"), new Guid("99e8b13a-4cc3-4a7e-92a7-8fd7783b491e"), new Guid("4ed699b7-f187-448e-a4d4-cb3fc45e03f5"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9507), new TimeSpan(0, 7, 0, 0, 0)), 0 },
                    { new Guid("bae66ff0-ea19-41c8-a451-7f54799565cb"), new Guid("ae20b4c3-2d22-42c4-89c0-d11d9099c017"), new Guid("6db4c1ba-911a-4576-9943-13215ad34fc1"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9517), new TimeSpan(0, 7, 0, 0, 0)), 1 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("66e1e536-4449-4f24-bd79-71d008614b0e"), new Guid("988b1f14-19a4-462c-9f0b-e7e98af53d0e"), new Guid("4ed699b7-f187-448e-a4d4-cb3fc45e03f5") },
                    { new Guid("87c6127c-746b-4e74-b73a-a3f2f85e661a"), new Guid("988b1f14-19a4-462c-9f0b-e7e98af53d0e"), new Guid("4ed699b7-f187-448e-a4d4-cb3fc45e03f5") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("3cf6343f-0eaa-4b8d-9974-6471b22262fb"), new Guid("4ed699b7-f187-448e-a4d4-cb3fc45e03f5"), new Guid("988b1f14-19a4-462c-9f0b-e7e98af53d0e"), new DateTimeOffset(new DateTime(2024, 10, 17, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9726), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9724), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9721), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2fceda51-0ee2-464e-902d-8bd632c4b32b"), "Schedule a viewing for the Skyline Apartment.", new Guid("d7c44b24-9814-4152-bd65-7df9df1e7384"), new Guid("9e6e5119-9e2f-402f-9dbb-640b1b925df3"), new Guid("fd4062a8-ed8a-4625-b531-5244086523d0"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9722), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("aedf6722-2c3e-4220-9433-1a16187c2659"), new Guid("1e9d98c5-eeb0-454c-b849-00172029e62e"), new Guid("4ed699b7-f187-448e-a4d4-cb3fc45e03f5"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9795), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9799), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 11, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9800), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("1fe7df18-0d9d-4a96-8ef3-ab2ca1a3975b"), new Guid("99e8b13a-4cc3-4a7e-92a7-8fd7783b491e"), new Guid("6db4c1ba-911a-4576-9943-13215ad34fc1"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9577), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 10, 17, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9578), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." },
                    { new Guid("98c1caf3-2000-46cc-ab73-24f401d41ae6"), new Guid("ae20b4c3-2d22-42c4-89c0-d11d9099c017"), new Guid("4ed699b7-f187-448e-a4d4-cb3fc45e03f5"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9564), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 10, 17, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9565), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("4f123b58-252f-4cd9-b50b-469c27120bf8"), new Guid("fd4062a8-ed8a-4625-b531-5244086523d0"), new Guid("6db4c1ba-911a-4576-9943-13215ad34fc1"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9424), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9425), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" },
                    { new Guid("9ac1bd56-526c-44d5-aaff-8babe52b5a6c"), new Guid("fd4062a8-ed8a-4625-b531-5244086523d0"), new Guid("4ed699b7-f187-448e-a4d4-cb3fc45e03f5"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9391), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9403), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("99d3eedd-0885-4002-92d3-d0fe57aa8f8c"), new Guid("4877b9c7-0a3f-4d2d-b82e-4cdb0c59bb41"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9902), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6c457ceb-a87d-4a3c-ad06-1b2781b0acdd"), new Guid("aedf6722-2c3e-4220-9433-1a16187c2659"), "45000", new DateTimeOffset(new DateTime(2024, 10, 21, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9903), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9904), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("e87db829-5b32-4a61-ab75-caee2d3a9fbf"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9861), new TimeSpan(0, 7, 0, 0, 0)), new Guid("aedf6722-2c3e-4220-9433-1a16187c2659"), 0, new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9864), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9863), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("6e6aabef-121a-409b-bd10-d38ea2e671fd"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9466), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9ac1bd56-526c-44d5-aaff-8babe52b5a6c") },
                    { new Guid("a3b534b2-3b70-430b-a74d-b1a150302d22"), new DateTimeOffset(new DateTime(2024, 10, 16, 15, 37, 10, 450, DateTimeKind.Unspecified).AddTicks(9469), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4f123b58-252f-4cd9-b50b-469c27120bf8") }
                });
        }
    }
}
