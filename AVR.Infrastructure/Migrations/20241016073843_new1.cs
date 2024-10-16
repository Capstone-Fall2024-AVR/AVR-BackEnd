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
            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("a7c32e22-c8d1-4200-b721-1f0ca5d4dc86"));

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("fb079f5d-8237-41cf-9792-8f64d182ca18"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("240c1ee2-aa6d-4b47-a84f-837c64d7da81"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("4fe22094-b047-4105-b886-5af7c698cef6"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("55bba41c-e7d1-43c3-830f-a03ea0825e84"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("a2b60397-78b4-4954-bc93-6fb60baadd2a"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("2c3519ec-a6e2-484b-93c3-8f88bad367a1"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("9f67396c-a8e9-4203-8a37-60d32045359b"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: new Guid("9e581a15-367e-4ea1-9ceb-b8bd66e3a797"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("03c54f06-4619-4e5c-b9d6-d03d976e5b9c"), new Guid("03a35819-2c89-4da1-b52f-cd08bb26632c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5d2468bb-5b8d-4318-854f-ba5bfc093259"), new Guid("1254f6cf-1b42-49f9-b0a0-0fc00e70fb98") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("876bd4a0-7eda-44d6-8d08-1d2cb9d748f0"), new Guid("4139e5a6-aa80-4ab7-b729-10e3b67a4b64") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d98ee50f-8ae2-4f85-913f-4ce482eec305"), new Guid("76e7138a-9b41-40cf-b291-2b6309346c40") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3a5122be-2720-4cd2-825f-40671b614447"), new Guid("c5a60b81-4c14-4bb1-8750-804d7c2c8f42") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("983c15bc-e7d8-41c0-b875-bffb87e5b095"), new Guid("cd1131e8-2699-4599-a824-1140dd09d512") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("16862768-c0a5-4360-a0db-8d736d1b3c51"));

            migrationBuilder.DeleteData(
                table: "DepositCancel",
                keyColumn: "DepositCancelID",
                keyValue: new Guid("fa651074-d6d1-416a-b026-01a70602cd31"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("9ea4b80f-b1b4-447d-8175-56979818888a"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("bf0ac04e-6859-42a0-8f5f-8f277fbf10df"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("6be968dd-ae23-4553-9828-d3147b78dc9f"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("a512726f-72fb-4b96-8f8f-87591f6ffc34"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("17702548-1900-487e-a41d-cd8baaa67df9"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("25ec51ca-b494-4a3b-a2d2-655733306a55"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("08a27172-9070-4111-806b-b9468d734901"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("90b62055-5bbb-4396-a2fc-878929dafa56"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("c0293b1e-e0f7-4bfa-8b77-baac564874aa"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: new Guid("82d0e010-325f-4f9f-ac31-b8f0d0ed86e2"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("b46d2cec-0202-43ab-8f51-efc48a6b2540"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("d50e2cbc-fc36-497f-987f-ad356071e0a6"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("03c54f06-4619-4e5c-b9d6-d03d976e5b9c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3a5122be-2720-4cd2-825f-40671b614447"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d2468bb-5b8d-4318-854f-ba5bfc093259"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("876bd4a0-7eda-44d6-8d08-1d2cb9d748f0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("983c15bc-e7d8-41c0-b875-bffb87e5b095"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d98ee50f-8ae2-4f85-913f-4ce482eec305"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("03a35819-2c89-4da1-b52f-cd08bb26632c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1254f6cf-1b42-49f9-b0a0-0fc00e70fb98"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("347718d9-4999-4228-abf0-e1997a8b0f1c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c355129-aca9-4431-80d0-c5af5542219e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c430addd-3ab8-4d82-a292-fa606b6d6b07"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c5a60b81-4c14-4bb1-8750-804d7c2c8f42"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cd1131e8-2699-4599-a824-1140dd09d512"));

            migrationBuilder.DeleteData(
                table: "DepositCancelTypes",
                keyColumn: "DepositCancelTypeID",
                keyValue: new Guid("b61c49ae-252f-446b-acf7-d264ffe54b3c"));

            migrationBuilder.DeleteData(
                table: "DepositRequest",
                keyColumn: "DepositID",
                keyValue: new Guid("53a0a06a-7839-444e-b97f-dd5923e7ada1"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("1dc04591-d84a-4d60-9458-95a77b649729"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("7da8570b-6910-4040-bbe2-9efd7599667d"));

            migrationBuilder.DeleteData(
                table: "NotificationTypes",
                keyColumn: "NotificationTypeID",
                keyValue: new Guid("f1c13d9d-c2d4-4e96-b710-d9b15019c0e0"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("e7bd0bf8-25da-4c59-8f74-58fc6de9428d"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("4c8274d3-b31e-4308-bab9-203a09e42f49"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("ce00596d-7890-44b0-b4a0-58d7d7138663"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("25739b1a-7ea7-4f61-a74f-5ec25d190f88"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("7d66d7aa-6f25-4d40-91a0-d935a54d5215"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4139e5a6-aa80-4ab7-b729-10e3b67a4b64"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4cb264ec-7d0f-460c-9752-7cfc8daea97e"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("0ec34e30-e467-47fb-b8bb-1d650b98c8c8"));

            migrationBuilder.DeleteData(
                table: "ApartmentProjectProvider",
                keyColumn: "ApartmentProjectProviderID",
                keyValue: new Guid("e23bc340-f1b2-48c7-9483-ea89bf470123"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("76e7138a-9b41-40cf-b291-2b6309346c40"));

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Apartments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ward",
                table: "Apartments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "District",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "Ward",
                table: "Apartments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("03c54f06-4619-4e5c-b9d6-d03d976e5b9c"), null, "Management", "MANAGEMENT" },
                    { new Guid("3a5122be-2720-4cd2-825f-40671b614447"), null, "Customer", "CUSTOMER" },
                    { new Guid("5d2468bb-5b8d-4318-854f-ba5bfc093259"), null, "Apartment Owner", "APARTMENT OWNER" },
                    { new Guid("876bd4a0-7eda-44d6-8d08-1d2cb9d748f0"), null, "Staff", "STAFF" },
                    { new Guid("983c15bc-e7d8-41c0-b875-bffb87e5b095"), null, "Admin", "ADMIN" },
                    { new Guid("d98ee50f-8ae2-4f85-913f-4ce482eec305"), null, "Project Provider", "PROJECT PROVIDER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmationOtp", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OtpExpiryTime", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("03a35819-2c89-4da1-b52f-cd08bb26632c"), 0, 0, "", "0e452659-3306-4dfa-895e-7ea230f7df73", "luong.a11.dbk@gmail.com", null, true, false, null, "Duc Luong", "LUONG.A11.DBK@GMAIL.COM", "LUONG.A11.DBK@GMAIL.COM", null, "AQAAAAIAAYagAAAAEPEA5o2OZLHFuZJis0giUxg3R3hQoFCVhb36EqfeBD12nUs5d+t4R0CQpvddjIlljg==", "0987654321", true, "307c408d-5f20-468c-aa83-8cc79439bb8f", false, "luong.a11.dbk@gmail.com" },
                    { new Guid("1254f6cf-1b42-49f9-b0a0-0fc00e70fb98"), 0, 0, "", "770d1c30-b705-4147-9104-3492f1a99ccf", "david.brown@example.com", null, true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEFiucsTedRmvWdHoH2CT8m8YV8Th6XyQOimvirEKnwBR2E3mGyv/4Y0sZGWOqAivgw==", "0123456789", true, "a1e1466e-a3cc-4755-88d8-e1c9701638ba", false, "david.brown@example.com" },
                    { new Guid("16862768-c0a5-4360-a0db-8d736d1b3c51"), 0, 0, null, "8abec38b-a0a3-487e-8891-2800e1cc9636", "diana.prince@example.com", null, true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAED2JaVdldjblCwYd9Fd4RN5hqNan54JtmSl9qXVwRoqBoyWaeFMpXXvtJjJpwilO1w==", "0904567890", true, "1bd1b3c1-8ab1-446a-97c0-01fbec182bcd", false, "diana.prince@example.com" },
                    { new Guid("347718d9-4999-4228-abf0-e1997a8b0f1c"), 0, 0, null, "838d4984-1688-437c-88ea-9b621d13801d", "alice.smith@example.com", null, true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEIykAqsSAd9O3glixQfMDYwfiPgRUF7RsaSX5+Ulfi0iOZf56nU0OcfBcHxa/FkvFQ==", "0901234567", true, "9125f527-b972-4460-811e-d25292dd42cb", false, "alice.smith@example.com" },
                    { new Guid("4139e5a6-aa80-4ab7-b729-10e3b67a4b64"), 0, 0, null, "b9c069e8-bddc-433c-b816-bcf30aedd3d9", "johndoe@example.com", null, true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEBDyEC7xbCO8zD8cY0LczqMoSnMNzjD1RpuuCP7r5DIQtMrsHa9/+aG8O2b3oTJqqA==", "123456789", true, "353e9d32-c4e4-40d2-b9a5-23d49bc398ef", false, "johndoe@example.com" },
                    { new Guid("4cb264ec-7d0f-460c-9752-7cfc8daea97e"), 0, 0, null, "7bfc1fc6-1f02-4a38-bae9-88996cb646bf", "charlie.brown@example.com", null, true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEG2Xa172wTrvD1TGsh2or6VQVhey4H3HN7bcZgaTv4nt9ywtUEYQlVyeRwoBSy0ddw==", "0903456789", true, "8aa50fcb-08c8-447a-a4a1-dbd71468ec82", false, "charlie.brown@example.com" },
                    { new Guid("76e7138a-9b41-40cf-b291-2b6309346c40"), 0, 0, "", "089ce74a-95d4-4f29-9a44-7974ab1d9136", "construction.corp@example.com", null, true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEId+qPqlASwFBO9LfOHJ1eNoQIwMX6HE7ZJvxMDp5VrXKRV0yhousBYP0yl2SvjSDA==", "0987654321", true, "32319a8d-37f7-4cc1-a024-3b9d36761ae3", false, "construction.corp@example.com" },
                    { new Guid("9c355129-aca9-4431-80d0-c5af5542219e"), 0, 0, null, "c3096163-4d5b-4317-88ae-4b08ca07f4d3", "bob.johnson@example.com", null, true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEDq0rpuJMspMd8SP/HWW3RlLhaD7k+blIYnAG6UWOOjmjxS8tciw6WUVSOKsOAm0RA==", "0902345678", true, "adbac19c-01f0-4b6a-ad5b-bd6df3946cc4", false, "bob.johnson@example.com" },
                    { new Guid("c430addd-3ab8-4d82-a292-fa606b6d6b07"), 0, 0, null, "e4169fc9-35c5-4143-96e1-a863960d4bf4", "eve.adams@example.com", null, true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAENQGgUyatZHpL7ufJFMCdH4qDUnwsHgTCnQl78DqWNKHD+yxVPizpDTfc2N/8KSGGQ==", "0905678901", true, "92f08e3a-8382-424d-8640-1b584ad8f319", false, "eve.adams@example.com" },
                    { new Guid("c5a60b81-4c14-4bb1-8750-804d7c2c8f42"), 0, 0, "", "802f9687-7ba0-4d2e-86d5-c8699eb75f64", "michael.smith@example.com", null, true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAENWxFvc5bm6g/E3SL+GbMH6W3FLJfu85wWRIJC19qt5WKggdVBHpwVt2JsDgEQGGUg==", "0123456789", true, "1a32874f-e318-4b23-9f9e-068c02bcb9e0", false, "michael.smith@example.com" },
                    { new Guid("cd1131e8-2699-4599-a824-1140dd09d512"), 0, 0, "", "fc0c23c9-ba30-4f71-9701-0099f74791c8", "quansongngu13@gmail.com", null, true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", null, "AQAAAAIAAYagAAAAEBdQzGHBjtjW3NF0Nb+KnO2T4Uv1OnIJq3W6yDMaRk48LgJJE4lge9rV9tT8QnfuNA==", "0949035672", true, "69c329bd-52df-4439-ad63-3c3c8b34d00c", false, "quansongngu13@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("b61c49ae-252f-446b-acf7-d264ffe54b3c"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9412), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9413), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("1dc04591-d84a-4d60-9458-95a77b649729"), "A fully equipped fitness gym.", "Gym" },
                    { new Guid("7da8570b-6910-4040-bbe2-9efd7599667d"), "A large outdoor swimming pool.", "Swimming Pool" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("f1c13d9d-c2d4-4e96-b710-d9b15019c0e0"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("c0293b1e-e0f7-4bfa-8b77-baac564874aa"), "11:00 AM", "10:00 AM" },
                    { new Guid("e7bd0bf8-25da-4c59-8f74-58fc6de9428d"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("e23bc340-f1b2-48c7-9483-ea89bf470123"), new Guid("76e7138a-9b41-40cf-b291-2b6309346c40"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7072), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7073), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("03c54f06-4619-4e5c-b9d6-d03d976e5b9c"), new Guid("03a35819-2c89-4da1-b52f-cd08bb26632c") },
                    { new Guid("5d2468bb-5b8d-4318-854f-ba5bfc093259"), new Guid("1254f6cf-1b42-49f9-b0a0-0fc00e70fb98") },
                    { new Guid("876bd4a0-7eda-44d6-8d08-1d2cb9d748f0"), new Guid("4139e5a6-aa80-4ab7-b729-10e3b67a4b64") },
                    { new Guid("d98ee50f-8ae2-4f85-913f-4ce482eec305"), new Guid("76e7138a-9b41-40cf-b291-2b6309346c40") },
                    { new Guid("3a5122be-2720-4cd2-825f-40671b614447"), new Guid("c5a60b81-4c14-4bb1-8750-804d7c2c8f42") },
                    { new Guid("983c15bc-e7d8-41c0-b875-bffb87e5b095"), new Guid("cd1131e8-2699-4599-a824-1140dd09d512") }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("9ea4b80f-b1b4-447d-8175-56979818888a"), new Guid("347718d9-4999-4228-abf0-e1997a8b0f1c"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9692), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" },
                    { new Guid("bf0ac04e-6859-42a0-8f5f-8f277fbf10df"), new Guid("9c355129-aca9-4431-80d0-c5af5542219e"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("6be968dd-ae23-4553-9828-d3147b78dc9f"), new Guid("4cb264ec-7d0f-460c-9752-7cfc8daea97e"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9993), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("f1c13d9d-c2d4-4e96-b710-d9b15019c0e0"), new Guid("94e4e54c-61d5-4ede-a038-74d267f6f3f1"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9996), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a512726f-72fb-4b96-8f8f-87591f6ffc34"), new Guid("9c355129-aca9-4431-80d0-c5af5542219e"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 632, DateTimeKind.Unspecified).AddTicks(11), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("f1c13d9d-c2d4-4e96-b710-d9b15019c0e0"), new Guid("b58ca3ec-1823-4974-8c53-9656dc880e0a"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 632, DateTimeKind.Unspecified).AddTicks(12), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[] { new Guid("0ec34e30-e467-47fb-b8bb-1d650b98c8c8"), null, new Guid("e23bc340-f1b2-48c7-9483-ea89bf470123"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7124), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7125), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "Address", "ApartmentName", "ApartmentStatus", "ApartmentType", "Area", "BalconyDirection", "CreatedDate", "Description", "Direction", "ExpiryDate", "Location", "NumberOfBathrooms", "NumberOfRooms", "PricePerSquareMeter", "ProjectApartmentID", "RecommendedPrice", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("25739b1a-7ea7-4f61-a74f-5ec25d190f88"), "123 Skyline Road, New City", "Skyline Apartment", 0, 1, 150.00m, 5, new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7329), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", 1, new DateTimeOffset(new DateTime(2029, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7341), new TimeSpan(0, 7, 0, 0, 0)), "City Center", 2, 3, 70000000m, new Guid("0ec34e30-e467-47fb-b8bb-1d650b98c8c8"), 10000000000m, new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7330), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("7d66d7aa-6f25-4d40-91a0-d935a54d5215"), "456 Ocean Drive, Coastal City", "Ocean View Apartment", 2, 2, 170.00m, 8, new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7452), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", 2, new DateTimeOffset(new DateTime(2027, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7456), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", 3, 4, 90000000m, new Guid("0ec34e30-e467-47fb-b8bb-1d650b98c8c8"), 15000000000m, new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7453), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[] { new Guid("17702548-1900-487e-a41d-cd8baaa67df9"), new Guid("0ec34e30-e467-47fb-b8bb-1d650b98c8c8"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[] { new Guid("25ec51ca-b494-4a3b-a2d2-655733306a55"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("0ec34e30-e467-47fb-b8bb-1d650b98c8c8"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7300), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("a7c32e22-c8d1-4200-b721-1f0ca5d4dc86"), new Guid("7d66d7aa-6f25-4d40-91a0-d935a54d5215"), new Guid("1dc04591-d84a-4d60-9458-95a77b649729") },
                    { new Guid("fb079f5d-8237-41cf-9792-8f64d182ca18"), new Guid("25739b1a-7ea7-4f61-a74f-5ec25d190f88"), new Guid("7da8570b-6910-4040-bbe2-9efd7599667d") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("240c1ee2-aa6d-4b47-a84f-837c64d7da81"), new Guid("25739b1a-7ea7-4f61-a74f-5ec25d190f88"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7588), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("4fe22094-b047-4105-b886-5af7c698cef6"), new Guid("25739b1a-7ea7-4f61-a74f-5ec25d190f88"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7583), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7584), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("55bba41c-e7d1-43c3-830f-a03ea0825e84"), new Guid("347718d9-4999-4228-abf0-e1997a8b0f1c"), new Guid("25739b1a-7ea7-4f61-a74f-5ec25d190f88"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9097), new TimeSpan(0, 7, 0, 0, 0)), 0 },
                    { new Guid("a2b60397-78b4-4954-bc93-6fb60baadd2a"), new Guid("9c355129-aca9-4431-80d0-c5af5542219e"), new Guid("7d66d7aa-6f25-4d40-91a0-d935a54d5215"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9131), new TimeSpan(0, 7, 0, 0, 0)), 1 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("2c3519ec-a6e2-484b-93c3-8f88bad367a1"), new Guid("1254f6cf-1b42-49f9-b0a0-0fc00e70fb98"), new Guid("25739b1a-7ea7-4f61-a74f-5ec25d190f88") },
                    { new Guid("9f67396c-a8e9-4203-8a37-60d32045359b"), new Guid("1254f6cf-1b42-49f9-b0a0-0fc00e70fb98"), new Guid("25739b1a-7ea7-4f61-a74f-5ec25d190f88") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("9e581a15-367e-4ea1-9ceb-b8bd66e3a797"), new Guid("25739b1a-7ea7-4f61-a74f-5ec25d190f88"), new Guid("1254f6cf-1b42-49f9-b0a0-0fc00e70fb98"), new DateTimeOffset(new DateTime(2024, 10, 17, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9347), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9344), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9341), new TimeSpan(0, 7, 0, 0, 0)), new Guid("c430addd-3ab8-4d82-a292-fa606b6d6b07"), "Schedule a viewing for the Skyline Apartment.", new Guid("76e7138a-9b41-40cf-b291-2b6309346c40"), new Guid("e7bd0bf8-25da-4c59-8f74-58fc6de9428d"), new Guid("4139e5a6-aa80-4ab7-b729-10e3b67a4b64"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9343), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("53a0a06a-7839-444e-b97f-dd5923e7ada1"), new Guid("4cb264ec-7d0f-460c-9752-7cfc8daea97e"), new Guid("25739b1a-7ea7-4f61-a74f-5ec25d190f88"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9455), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9465), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 11, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9469), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("08a27172-9070-4111-806b-b9468d734901"), new Guid("347718d9-4999-4228-abf0-e1997a8b0f1c"), new Guid("7d66d7aa-6f25-4d40-91a0-d935a54d5215"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9234), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 10, 17, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9236), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." },
                    { new Guid("90b62055-5bbb-4396-a2fc-878929dafa56"), new Guid("9c355129-aca9-4431-80d0-c5af5542219e"), new Guid("25739b1a-7ea7-4f61-a74f-5ec25d190f88"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9208), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 10, 17, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9210), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("4c8274d3-b31e-4308-bab9-203a09e42f49"), new Guid("4139e5a6-aa80-4ab7-b729-10e3b67a4b64"), new Guid("7d66d7aa-6f25-4d40-91a0-d935a54d5215"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7669), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" },
                    { new Guid("ce00596d-7890-44b0-b4a0-58d7d7138663"), new Guid("4139e5a6-aa80-4ab7-b729-10e3b67a4b64"), new Guid("25739b1a-7ea7-4f61-a74f-5ec25d190f88"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7638), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7647), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("fa651074-d6d1-416a-b026-01a70602cd31"), new Guid("03a35819-2c89-4da1-b52f-cd08bb26632c"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9624), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b61c49ae-252f-446b-acf7-d264ffe54b3c"), new Guid("53a0a06a-7839-444e-b97f-dd5923e7ada1"), "45000", new DateTimeOffset(new DateTime(2024, 10, 21, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9625), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9629), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("82d0e010-325f-4f9f-ac31-b8f0d0ed86e2"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9573), new TimeSpan(0, 7, 0, 0, 0)), new Guid("53a0a06a-7839-444e-b97f-dd5923e7ada1"), 0, new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9577), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("b46d2cec-0202-43ab-8f51-efc48a6b2540"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7703), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4c8274d3-b31e-4308-bab9-203a09e42f49") },
                    { new Guid("d50e2cbc-fc36-497f-987f-ad356071e0a6"), new DateTimeOffset(new DateTime(2024, 10, 16, 12, 17, 49, 631, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, 7, 0, 0, 0)), new Guid("ce00596d-7890-44b0-b4a0-58d7d7138663") }
                });
        }
    }
}
