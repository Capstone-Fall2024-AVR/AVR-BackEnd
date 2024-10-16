using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class new2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("075d2c24-68c8-4009-94da-da9365cf5e51"));

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("1dc50feb-3517-4004-bfb6-78222836733a"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("5fdc6f6f-f313-4ef2-8b8b-d55647199e8a"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("bc934192-1fd3-4bb3-b0bd-05178f08d3c2"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("606c1244-6ee0-49d3-9f0d-3e600b49aa75"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("9e9766f6-03a0-473f-8924-c6a7f115460d"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("0237b5f6-d89e-4ef9-b2bf-781ec2663052"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("85d554b0-a84e-45f7-9ccf-710a637b8a7f"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: new Guid("632b0f19-957d-47ad-ae76-03a7bcd872b7"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("11789c78-48f3-44f6-81b4-4c5e0f133161"), new Guid("0c0e7cff-70d0-413c-9882-d6db70b34858") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c0634a9c-81a0-4417-8566-c90d5b395569"), new Guid("70ab5bdb-5c8d-44f6-8834-652bf0af5427") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("67fc29a3-84cb-435f-954d-274df8a4b9da"), new Guid("725d7eba-1b70-43d1-a48e-82656991ef95") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("15a832c3-b547-45b7-b43e-bde1100278bf"), new Guid("a38fecd7-e213-4549-a14a-79c179438401") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("263aaf82-0cf6-406b-a592-35932136fadb"), new Guid("b01af5e0-9cd4-4a93-902d-a207cee93f91") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6aa5ade6-6c00-4194-a9eb-13316851ad43"), new Guid("be7837f4-9990-471a-a1c4-8e1c47f05e02") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c1e3a0f1-a89a-466b-9b77-f3b37f519853"));

            migrationBuilder.DeleteData(
                table: "DepositCancel",
                keyColumn: "DepositCancelID",
                keyValue: new Guid("cdec533b-2a40-46e2-86e2-8dbcd4f4d36a"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("58e757ea-9618-40e6-996e-1194c0d3acd0"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("72f66510-9183-48f6-ba0c-81c0e042119f"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("0ee49060-61c0-4c89-a67f-8319e1ecdc5d"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("e7502c92-9d09-4abb-a860-1179c4aa9fd9"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("677690df-1dc6-4d49-90b7-4e068d047407"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("602ec84d-5a71-431c-a8c4-827ad8f4b9f6"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("025bea0e-2f81-403a-b8cc-6f8cd4ac13fd"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("8ac08d20-3227-4077-8ea7-6baeb113fa3c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("b29b77e6-3bc2-4725-b6be-be2055e0a558"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: new Guid("e1176b91-abc4-4510-9385-547a87d91dac"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("9d5b9488-3dc0-4192-9e7e-861ac1cbfb5b"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("b554fa82-336f-4cef-af7a-959f50994969"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("11789c78-48f3-44f6-81b4-4c5e0f133161"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("15a832c3-b547-45b7-b43e-bde1100278bf"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("263aaf82-0cf6-406b-a592-35932136fadb"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67fc29a3-84cb-435f-954d-274df8a4b9da"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6aa5ade6-6c00-4194-a9eb-13316851ad43"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c0634a9c-81a0-4417-8566-c90d5b395569"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09eda817-dfe5-43e4-9992-2af384e468d0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0c0e7cff-70d0-413c-9882-d6db70b34858"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("725d7eba-1b70-43d1-a48e-82656991ef95"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("81db916c-ff09-4306-a8d7-bdac138a0e0e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b01af5e0-9cd4-4a93-902d-a207cee93f91"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba5804ff-1ca7-4545-a7b4-09f4039da8f3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be7837f4-9990-471a-a1c4-8e1c47f05e02"));

            migrationBuilder.DeleteData(
                table: "DepositCancelTypes",
                keyColumn: "DepositCancelTypeID",
                keyValue: new Guid("d380a78e-2046-4666-be05-27c768bcf3f2"));

            migrationBuilder.DeleteData(
                table: "DepositRequest",
                keyColumn: "DepositID",
                keyValue: new Guid("6fc05dab-148f-416c-9e99-fa4ed227d8ea"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("233ab990-430d-45c8-bbc8-0a32c478c691"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("2a730eff-8dc5-42fb-a2a5-07f880bdb8e8"));

            migrationBuilder.DeleteData(
                table: "NotificationTypes",
                keyColumn: "NotificationTypeID",
                keyValue: new Guid("13c10f30-047a-4d9a-9c07-229bd44234f5"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("ecbae07b-1a0d-4ccf-8ebe-d594e3a87756"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("2b4218b3-4a61-4a95-bcdd-db4d73260e80"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("67daf259-53f1-4e21-b5f4-627c991ab00d"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("6850cdfa-e1b4-446d-aecc-20d006ce15da"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("a04025d0-f385-4993-a1e0-a0ea65c1f989"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("70ab5bdb-5c8d-44f6-8834-652bf0af5427"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dd7759be-09a7-4f50-bd4c-04d5cc6d61ad"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("0e5b0cea-46d8-4624-846d-18660bf2d7d0"));

            migrationBuilder.DeleteData(
                table: "ApartmentProjectProvider",
                keyColumn: "ApartmentProjectProviderID",
                keyValue: new Guid("27279ccb-44bc-4603-bb16-3e1e7771a5eb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a38fecd7-e213-4549-a14a-79c179438401"));

            migrationBuilder.AddColumn<int>(
                name: "SaleStatus",
                table: "Apartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "SaleStatus",
                table: "Apartments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("11789c78-48f3-44f6-81b4-4c5e0f133161"), null, "Management", "MANAGEMENT" },
                    { new Guid("15a832c3-b547-45b7-b43e-bde1100278bf"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("263aaf82-0cf6-406b-a592-35932136fadb"), null, "Customer", "CUSTOMER" },
                    { new Guid("67fc29a3-84cb-435f-954d-274df8a4b9da"), null, "Admin", "ADMIN" },
                    { new Guid("6aa5ade6-6c00-4194-a9eb-13316851ad43"), null, "Apartment Owner", "APARTMENT OWNER" },
                    { new Guid("c0634a9c-81a0-4417-8566-c90d5b395569"), null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmationOtp", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OtpExpiryTime", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("09eda817-dfe5-43e4-9992-2af384e468d0"), 0, 0, null, "9741215c-08e6-4c54-b7d9-29c98a389f25", "bob.johnson@example.com", null, true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEAFrr8yOJMWtrt/FPqoh1s9CwP+YrXOzBaqB8G/orhtdnTaoIN83V3n6lLK3gj4hog==", "0902345678", true, "7730de90-ec0d-4b5f-8956-9b23b72b610c", false, "bob.johnson@example.com" },
                    { new Guid("0c0e7cff-70d0-413c-9882-d6db70b34858"), 0, 0, "", "ecfc0dc8-7efd-43a6-bb9b-d397806feadf", "luong.a11.dbk@gmail.com", null, true, false, null, "Duc Luong", "LUONG.A11.DBK@GMAIL.COM", "LUONG.A11.DBK@GMAIL.COM", null, "AQAAAAIAAYagAAAAEOE46c9gmE3B948nURikJ7LMwh0F938Onp8xjX6Y5SqYBiuSLA+4/9jOiAoeCqUt4A==", "0987654321", true, "88f5b884-6720-4a27-bcac-18339fc6f30c", false, "luong.a11.dbk@gmail.com" },
                    { new Guid("70ab5bdb-5c8d-44f6-8834-652bf0af5427"), 0, 0, null, "e347cd88-86f1-4bcd-8595-c4041ab4fa77", "johndoe@example.com", null, true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEIbDRWWDdlTyIHIiViMsT0xZotAX7oINdRaEcFj9sEOViAl/hfVDGhdNfWWheshtZA==", "123456789", true, "bbd1c2b6-5445-43e3-bc8f-ce70bac48dc4", false, "johndoe@example.com" },
                    { new Guid("725d7eba-1b70-43d1-a48e-82656991ef95"), 0, 0, "", "b056adcc-b5c1-4102-a9ac-caa4acb809c7", "quansongngu13@gmail.com", null, true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", null, "AQAAAAIAAYagAAAAEElhkkTUB4WBiQm6rxxWv7f77mEAyuRxiPYEnBZ7L560yzhDMzB4xWLBDhhsdYkltw==", "0949035672", true, "816f5625-712d-4cbe-8d47-1beb22b35b65", false, "quansongngu13@gmail.com" },
                    { new Guid("81db916c-ff09-4306-a8d7-bdac138a0e0e"), 0, 0, null, "3dce6d72-a1f4-4007-8589-c672d0c93c52", "alice.smith@example.com", null, true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEA3r5cKcEZqp2/1uTmsq/NuTys3A8D5QjGZY6Ccf+E2x9HtwbMUk4W1a973mcbzGvg==", "0901234567", true, "0ab32540-bde8-4e02-b914-9d3f7cfc1d66", false, "alice.smith@example.com" },
                    { new Guid("a38fecd7-e213-4549-a14a-79c179438401"), 0, 0, "", "23005ddd-505f-4177-9b64-042a76934991", "construction.corp@example.com", null, true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEGX9qoizjoQGWqLZd5HvJ/OsRr7ZLJN6+5hvsZguc6r55je69xaBWzC4YvrgOQQc3g==", "0987654321", true, "6ba7e377-296e-4e64-8144-1f9d48e17473", false, "construction.corp@example.com" },
                    { new Guid("b01af5e0-9cd4-4a93-902d-a207cee93f91"), 0, 0, "", "8e9ccb9a-f11f-4424-816d-23d508cb56ad", "michael.smith@example.com", null, true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEEo25uQeaWKAwVuWracXYL+JV10zriiV7QqIPINwRMbgrEuVDCqU7TAwCOlDyOGnMg==", "0123456789", true, "6ada9e26-a06d-4361-b418-55a58a77ab6a", false, "michael.smith@example.com" },
                    { new Guid("ba5804ff-1ca7-4545-a7b4-09f4039da8f3"), 0, 0, null, "58e58421-74e5-4a62-a5ab-4cea9cc8caa9", "eve.adams@example.com", null, true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEMaqkV2ZTZ7OAXRfGjjjP8J9vdMPTzfQ9KCrR1WRh91dDbt+9h0Te45cuSbC/jJFhA==", "0905678901", true, "2c92b89f-ae80-43d4-9242-5fd46c8f4c3a", false, "eve.adams@example.com" },
                    { new Guid("be7837f4-9990-471a-a1c4-8e1c47f05e02"), 0, 0, "", "aab5095e-6324-42a6-a192-138285b50d21", "david.brown@example.com", null, true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAECl2RTPDax1Zpe9pcb+0yZnk/lDYo6jqBAG+slwLJmu2v7vo+ra4zzM723404Vmnbw==", "0123456789", true, "b8a0d1c9-36d3-4cba-8574-859a541d156c", false, "david.brown@example.com" },
                    { new Guid("c1e3a0f1-a89a-466b-9b77-f3b37f519853"), 0, 0, null, "387c755b-9ded-4c71-9a14-16ea294fc233", "diana.prince@example.com", null, true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEIweotDzlhfoGnIEY9L/IPlkuPhSjnyOqrt06/oT3jBmV+BpglN40HY6c87iCAmL3g==", "0904567890", true, "f74c2722-c7b2-4809-8de4-e618b34aafc5", false, "diana.prince@example.com" },
                    { new Guid("dd7759be-09a7-4f50-bd4c-04d5cc6d61ad"), 0, 0, null, "d80ee631-d25e-47c2-9e30-530021da3751", "charlie.brown@example.com", null, true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAECHcI9N/EgvbIXKJ23LAeI64uOxl3o9/n8pb87usFlDMXrFjC+WL//ITbiE25ZqWbw==", "0903456789", true, "d9dabeb8-5634-459e-a063-847caf5e129f", false, "charlie.brown@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("d380a78e-2046-4666-be05-27c768bcf3f2"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(75), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(76), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("233ab990-430d-45c8-bbc8-0a32c478c691"), "A large outdoor swimming pool.", "Swimming Pool" },
                    { new Guid("2a730eff-8dc5-42fb-a2a5-07f880bdb8e8"), "A fully equipped fitness gym.", "Gym" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("13c10f30-047a-4d9a-9c07-229bd44234f5"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("b29b77e6-3bc2-4725-b6be-be2055e0a558"), "11:00 AM", "10:00 AM" },
                    { new Guid("ecbae07b-1a0d-4ccf-8ebe-d594e3a87756"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("27279ccb-44bc-4603-bb16-3e1e7771a5eb"), new Guid("a38fecd7-e213-4549-a14a-79c179438401"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(8352), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(8352), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("11789c78-48f3-44f6-81b4-4c5e0f133161"), new Guid("0c0e7cff-70d0-413c-9882-d6db70b34858") },
                    { new Guid("c0634a9c-81a0-4417-8566-c90d5b395569"), new Guid("70ab5bdb-5c8d-44f6-8834-652bf0af5427") },
                    { new Guid("67fc29a3-84cb-435f-954d-274df8a4b9da"), new Guid("725d7eba-1b70-43d1-a48e-82656991ef95") },
                    { new Guid("15a832c3-b547-45b7-b43e-bde1100278bf"), new Guid("a38fecd7-e213-4549-a14a-79c179438401") },
                    { new Guid("263aaf82-0cf6-406b-a592-35932136fadb"), new Guid("b01af5e0-9cd4-4a93-902d-a207cee93f91") },
                    { new Guid("6aa5ade6-6c00-4194-a9eb-13316851ad43"), new Guid("be7837f4-9990-471a-a1c4-8e1c47f05e02") }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("58e757ea-9618-40e6-996e-1194c0d3acd0"), new Guid("81db916c-ff09-4306-a8d7-bdac138a0e0e"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" },
                    { new Guid("72f66510-9183-48f6-ba0c-81c0e042119f"), new Guid("09eda817-dfe5-43e4-9992-2af384e468d0"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(269), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("0ee49060-61c0-4c89-a67f-8319e1ecdc5d"), new Guid("dd7759be-09a7-4f50-bd4c-04d5cc6d61ad"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(338), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("13c10f30-047a-4d9a-9c07-229bd44234f5"), new Guid("36791dba-b9d5-460b-84fb-36b2a031015a"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(340), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("e7502c92-9d09-4abb-a860-1179c4aa9fd9"), new Guid("09eda817-dfe5-43e4-9992-2af384e468d0"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(348), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("13c10f30-047a-4d9a-9c07-229bd44234f5"), new Guid("e53937ff-a1a0-4ccb-be39-272d1aa36fdb"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(349), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[] { new Guid("0e5b0cea-46d8-4624-846d-18660bf2d7d0"), null, new Guid("27279ccb-44bc-4603-bb16-3e1e7771a5eb"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(8505), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "Address", "ApartmentName", "ApartmentStatus", "ApartmentType", "Area", "BalconyDirection", "CreatedDate", "Description", "Direction", "District", "ExpiryDate", "Location", "NumberOfBathrooms", "NumberOfRooms", "PricePerSquareMeter", "ProjectApartmentID", "RecommendedPrice", "UpdatedDate", "Ward" },
                values: new object[,]
                {
                    { new Guid("6850cdfa-e1b4-446d-aecc-20d006ce15da"), "123 Skyline Road, New City", "Skyline Apartment", 0, 1, 150.00m, 5, new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9272), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", 1, "", new DateTimeOffset(new DateTime(2029, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9285), new TimeSpan(0, 7, 0, 0, 0)), "City Center", 2, 3, 70000000m, new Guid("0e5b0cea-46d8-4624-846d-18660bf2d7d0"), 10000000000m, new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9273), new TimeSpan(0, 7, 0, 0, 0)), "" },
                    { new Guid("a04025d0-f385-4993-a1e0-a0ea65c1f989"), "456 Ocean Drive, Coastal City", "Ocean View Apartment", 2, 2, 170.00m, 8, new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9304), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", 2, "", new DateTimeOffset(new DateTime(2027, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9307), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", 3, 4, 90000000m, new Guid("0e5b0cea-46d8-4624-846d-18660bf2d7d0"), 15000000000m, new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9304), new TimeSpan(0, 7, 0, 0, 0)), "" }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[] { new Guid("677690df-1dc6-4d49-90b7-4e068d047407"), new Guid("0e5b0cea-46d8-4624-846d-18660bf2d7d0"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9167), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[] { new Guid("602ec84d-5a71-431c-a8c4-827ad8f4b9f6"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9223), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("0e5b0cea-46d8-4624-846d-18660bf2d7d0"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9224), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("075d2c24-68c8-4009-94da-da9365cf5e51"), new Guid("6850cdfa-e1b4-446d-aecc-20d006ce15da"), new Guid("233ab990-430d-45c8-bbc8-0a32c478c691") },
                    { new Guid("1dc50feb-3517-4004-bfb6-78222836733a"), new Guid("a04025d0-f385-4993-a1e0-a0ea65c1f989"), new Guid("2a730eff-8dc5-42fb-a2a5-07f880bdb8e8") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("5fdc6f6f-f313-4ef2-8b8b-d55647199e8a"), new Guid("6850cdfa-e1b4-446d-aecc-20d006ce15da"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9578), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9578), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("bc934192-1fd3-4bb3-b0bd-05178f08d3c2"), new Guid("6850cdfa-e1b4-446d-aecc-20d006ce15da"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9573), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9575), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("606c1244-6ee0-49d3-9f0d-3e600b49aa75"), new Guid("09eda817-dfe5-43e4-9992-2af384e468d0"), new Guid("a04025d0-f385-4993-a1e0-a0ea65c1f989"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9761), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { new Guid("9e9766f6-03a0-473f-8924-c6a7f115460d"), new Guid("81db916c-ff09-4306-a8d7-bdac138a0e0e"), new Guid("6850cdfa-e1b4-446d-aecc-20d006ce15da"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9751), new TimeSpan(0, 7, 0, 0, 0)), 0 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("0237b5f6-d89e-4ef9-b2bf-781ec2663052"), new Guid("be7837f4-9990-471a-a1c4-8e1c47f05e02"), new Guid("6850cdfa-e1b4-446d-aecc-20d006ce15da") },
                    { new Guid("85d554b0-a84e-45f7-9ccf-710a637b8a7f"), new Guid("be7837f4-9990-471a-a1c4-8e1c47f05e02"), new Guid("6850cdfa-e1b4-446d-aecc-20d006ce15da") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("632b0f19-957d-47ad-ae76-03a7bcd872b7"), new Guid("6850cdfa-e1b4-446d-aecc-20d006ce15da"), new Guid("be7837f4-9990-471a-a1c4-8e1c47f05e02"), new DateTimeOffset(new DateTime(2024, 10, 17, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(31), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9992), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9990), new TimeSpan(0, 7, 0, 0, 0)), new Guid("ba5804ff-1ca7-4545-a7b4-09f4039da8f3"), "Schedule a viewing for the Skyline Apartment.", new Guid("a38fecd7-e213-4549-a14a-79c179438401"), new Guid("ecbae07b-1a0d-4ccf-8ebe-d594e3a87756"), new Guid("70ab5bdb-5c8d-44f6-8834-652bf0af5427"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9991), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("6fc05dab-148f-416c-9e99-fa4ed227d8ea"), new Guid("dd7759be-09a7-4f50-bd4c-04d5cc6d61ad"), new Guid("6850cdfa-e1b4-446d-aecc-20d006ce15da"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(109), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(113), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 11, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(114), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("025bea0e-2f81-403a-b8cc-6f8cd4ac13fd"), new Guid("81db916c-ff09-4306-a8d7-bdac138a0e0e"), new Guid("a04025d0-f385-4993-a1e0-a0ea65c1f989"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9825), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 10, 17, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9826), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." },
                    { new Guid("8ac08d20-3227-4077-8ea7-6baeb113fa3c"), new Guid("09eda817-dfe5-43e4-9992-2af384e468d0"), new Guid("6850cdfa-e1b4-446d-aecc-20d006ce15da"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9816), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 10, 17, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("2b4218b3-4a61-4a95-bcdd-db4d73260e80"), new Guid("70ab5bdb-5c8d-44f6-8834-652bf0af5427"), new Guid("a04025d0-f385-4993-a1e0-a0ea65c1f989"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9671), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9672), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" },
                    { new Guid("67daf259-53f1-4e21-b5f4-627c991ab00d"), new Guid("70ab5bdb-5c8d-44f6-8834-652bf0af5427"), new Guid("6850cdfa-e1b4-446d-aecc-20d006ce15da"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9640), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9648), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("cdec533b-2a40-46e2-86e2-8dbcd4f4d36a"), new Guid("0c0e7cff-70d0-413c-9882-d6db70b34858"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(226), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d380a78e-2046-4666-be05-27c768bcf3f2"), new Guid("6fc05dab-148f-416c-9e99-fa4ed227d8ea"), "45000", new DateTimeOffset(new DateTime(2024, 10, 21, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(228), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("e1176b91-abc4-4510-9385-547a87d91dac"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(182), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6fc05dab-148f-416c-9e99-fa4ed227d8ea"), 0, new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(184), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 369, DateTimeKind.Unspecified).AddTicks(184), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("9d5b9488-3dc0-4192-9e7e-861ac1cbfb5b"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9714), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2b4218b3-4a61-4a95-bcdd-db4d73260e80") },
                    { new Guid("b554fa82-336f-4cef-af7a-959f50994969"), new DateTimeOffset(new DateTime(2024, 10, 16, 14, 38, 41, 368, DateTimeKind.Unspecified).AddTicks(9711), new TimeSpan(0, 7, 0, 0, 0)), new Guid("67daf259-53f1-4e21-b5f4-627c991ab00d") }
                });
        }
    }
}
