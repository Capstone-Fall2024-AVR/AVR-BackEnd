using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixApartmentv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectApartmentApartments");

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("491fd7c5-785a-47a2-847c-68e9304fb68c"));

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("976f4d7c-8fb9-482e-9f6a-a791f3a95b51"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("03eb4876-daa2-412a-b96b-2c26f09f41e5"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("e4b41e98-e236-427e-9609-e3e71bf80bc1"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("48fea201-92ea-4df8-86f5-cc155723b9e5"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("52038528-1f87-4d88-9dc1-267a14874899"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("84cf57bb-a54c-4f37-9f3f-3e75894fcf6a"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("ac36dde2-5015-41ef-b187-cc0ea795016c"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: new Guid("5fbb8986-1a3c-4d22-8b38-7c6b5ca4d67a"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("750f1b1b-391f-4350-9213-8d800fbb52ca"), new Guid("1de769f5-986a-4158-a05f-ee82ee3607de") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("af01b0c9-50b7-429e-a34e-24e5d21fda70"), new Guid("23ec4579-ae03-4f2b-aa48-19bf88ba5d2a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e70a8d79-567b-4e14-920f-f066f100d1c3"), new Guid("4a0f911f-d62f-4b36-8903-ecab22af2040") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1974beca-b455-4000-82d0-3d62477b9746"), new Guid("4d2b3c33-8cf9-473c-b427-f3c0f291c407") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fa82bb09-cb8e-4f8e-ab1e-f06125ec2b1b"), new Guid("6741ea0a-ca09-4c8d-ba34-d5b7f7eb738d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ae847f98-a394-4dae-9125-0cf73b34428a"), new Guid("abcda63f-3c2a-45f8-90ab-659b5e863d82") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("92181cd3-6cc8-4d35-8f74-cb5b2de4ed8c"));

            migrationBuilder.DeleteData(
                table: "DepositCancel",
                keyColumn: "DepositCancelID",
                keyValue: new Guid("5f1fcd4e-7e44-40be-9920-5cf21055e33e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("6e82b502-40d9-499c-9d85-dc45b8e4c9d5"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("a223e6e6-6eb8-44d6-b32d-8dfd1a709138"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("19f0542a-9bc7-4d76-8c69-e77839b1103f"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("b5c5fde3-c32c-407e-995b-4888b9fef508"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("a57c10b8-1a87-457d-a4f7-9f6c0a864959"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("41f1cccd-a777-4dc5-b468-54cbbf22d511"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("8c8af83f-5a61-480d-96b4-f8a64fd5202d"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("9efa29ba-18a3-4a93-947a-641895da9d99"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("029ff706-b97f-4350-a58a-068da85537d1"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: new Guid("15bc1b77-ed91-42f9-b23b-278c0575a0f3"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("8e46f4ed-4ddd-436a-919e-29a7aebc247f"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("8e8e3573-56a1-4431-b963-e21b1b12cfaa"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1974beca-b455-4000-82d0-3d62477b9746"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("750f1b1b-391f-4350-9213-8d800fbb52ca"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ae847f98-a394-4dae-9125-0cf73b34428a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("af01b0c9-50b7-429e-a34e-24e5d21fda70"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e70a8d79-567b-4e14-920f-f066f100d1c3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fa82bb09-cb8e-4f8e-ab1e-f06125ec2b1b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("104d6b4e-afbc-4a44-b907-d31d16325afa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1de769f5-986a-4158-a05f-ee82ee3607de"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a0e9663-d0ed-441e-91f8-2e0e32033bfe"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4d2b3c33-8cf9-473c-b427-f3c0f291c407"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6741ea0a-ca09-4c8d-ba34-d5b7f7eb738d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abcda63f-3c2a-45f8-90ab-659b5e863d82"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d586ba3e-ce95-4d39-89c4-553ac4b08fe8"));

            migrationBuilder.DeleteData(
                table: "DepositCancelTypes",
                keyColumn: "DepositCancelTypeID",
                keyValue: new Guid("ec79ebcf-5ba5-4ede-b744-230594513ace"));

            migrationBuilder.DeleteData(
                table: "DepositRequest",
                keyColumn: "DepositID",
                keyValue: new Guid("3450eb59-1c9e-4307-b769-a8b45297bb53"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("3fe6daa7-b415-4f7b-8650-eb47cb6bb721"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("ba796b2e-e802-4859-8165-42e00660a702"));

            migrationBuilder.DeleteData(
                table: "NotificationTypes",
                keyColumn: "NotificationTypeID",
                keyValue: new Guid("d9b60fb0-9eb0-4d25-9202-bca8eb92fb2f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("de8cd175-5fa8-4935-a8a9-9629db85b6c2"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("b0ca0860-ffe5-45dd-ab22-36b0f48abda4"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("eeba5701-7abf-4e63-9715-1e7f10d7f002"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("a2bff192-cf6c-4a22-9b09-ab6e25824f3d"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("b5808261-a113-4cb7-b5e6-c2824f4eae65"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0aad200d-282d-414f-8b97-e4244d01d425"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4a0f911f-d62f-4b36-8903-ecab22af2040"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("189f216f-c675-4170-977f-373054c1c272"));

            migrationBuilder.DeleteData(
                table: "ApartmentProjectProvider",
                keyColumn: "ApartmentProjectProviderID",
                keyValue: new Guid("8618b741-5505-4fe4-bd9c-39c8853bddef"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23ec4579-ae03-4f2b-aa48-19bf88ba5d2a"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ProjectApartmentApartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1974beca-b455-4000-82d0-3d62477b9746"), null, "Management", "MANAGEMENT" },
                    { new Guid("750f1b1b-391f-4350-9213-8d800fbb52ca"), null, "Admin", "ADMIN" },
                    { new Guid("ae847f98-a394-4dae-9125-0cf73b34428a"), null, "Customer", "CUSTOMER" },
                    { new Guid("af01b0c9-50b7-429e-a34e-24e5d21fda70"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("e70a8d79-567b-4e14-920f-f066f100d1c3"), null, "Staff", "STAFF" },
                    { new Guid("fa82bb09-cb8e-4f8e-ab1e-f06125ec2b1b"), null, "Apartment Owner", "APARTMENT OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmationOtp", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OtpExpiryTime", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0aad200d-282d-414f-8b97-e4244d01d425"), 0, 0, null, "25a48eae-efb0-46a7-95a5-3cf2c9f7608d", "charlie.brown@example.com", null, true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEFRvEk0KUioLf2NSvMIhHaZ3f6Pmk2J00JuHgV0sBoSqH85rhK39AiXW1JAf/5pFDw==", "0903456789", true, "29de081c-64e4-40f9-87ea-1bc9524d080d", false, "charlie.brown@example.com" },
                    { new Guid("104d6b4e-afbc-4a44-b907-d31d16325afa"), 0, 0, null, "02e5d98f-d880-42e6-a947-346795be658e", "eve.adams@example.com", null, true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEFp5qRJhe5/LXvuCbfjvscF2qEtcpkWfQ6ctryOE38360NsFT727D3Pi9z2sgKOrnA==", "0905678901", true, "5d0bcc6f-60fe-4470-bbd2-b3fca43a6603", false, "eve.adams@example.com" },
                    { new Guid("1de769f5-986a-4158-a05f-ee82ee3607de"), 0, 0, "", "cad362ae-8cd8-4fba-8e83-5aa4da17bebc", "quansongngu13@gmail.com", null, true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", null, "AQAAAAIAAYagAAAAEAE2R2XcS0cx+wCOcOruGQMgbyLjP5mDwWt4d+r8sLHglzjldkQgYtK4+NTOV6VkOg==", "0949035672", true, "9dd163e0-3166-41b8-88fd-113a9b8fa4d2", false, "quansongngu13@gmail.com" },
                    { new Guid("23ec4579-ae03-4f2b-aa48-19bf88ba5d2a"), 0, 0, "", "2281279f-e340-40fc-82ad-bbf1f40894d2", "construction.corp@example.com", null, true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAECP5Q0ciSNZ1OMGE4cie12pZ+CXu53SrtmMV4ibKV+UghHNS6PbzcZ5udy6fcijD7A==", "0987654321", true, "0e296256-c5b4-4c5e-aa0a-40b979b5f51a", false, "construction.corp@example.com" },
                    { new Guid("3a0e9663-d0ed-441e-91f8-2e0e32033bfe"), 0, 0, null, "e20768cd-1de4-4732-9778-eaa6dcb9d329", "alice.smith@example.com", null, true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAELNio8c38Fn5NIynMh5lIbIqN28KpKmWJtjXdmXPmV4HwTpbfTTZMvSVxd+lmxq77g==", "0901234567", true, "ed78b3d5-5f56-4c2f-960f-56904c9dacb3", false, "alice.smith@example.com" },
                    { new Guid("4a0f911f-d62f-4b36-8903-ecab22af2040"), 0, 0, null, "4107601a-8817-404a-aeef-4fc946f9f967", "johndoe@example.com", null, true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEMdtVXOgikByf1PbeF+cZD4q7etsBrEdBg4+I6/vi5hPmq0jP5tpxmIajcLxi1yaxw==", "123456789", true, "755fb2c0-62f2-4ebb-995f-889dfe51a8dd", false, "johndoe@example.com" },
                    { new Guid("4d2b3c33-8cf9-473c-b427-f3c0f291c407"), 0, 0, "", "d2c65c68-6404-4aae-aa07-4e0bfcb3c094", "luong.a11.dbk@gmail.com", null, true, false, null, "Duc Luong", "LUONG.A11.DBK@GMAIL.COM", "LUONG.A11.DBK@GMAIL.COM", null, "AQAAAAIAAYagAAAAEO7UBAmebJQCV2Dr5tFYxl9dPPBb09uFEF0hLwrGZTVOgSh/5xbN5MqclkuXYexoWQ==", "0987654321", true, "71a687e8-f2c7-4bbf-9455-34edc42a2023", false, "luong.a11.dbk@gmail.com" },
                    { new Guid("6741ea0a-ca09-4c8d-ba34-d5b7f7eb738d"), 0, 0, "", "419ec0f9-d3c1-4013-aa94-eb1f0e5981a9", "david.brown@example.com", null, true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEAFtL5638g095wAbnJJeWXt06pxPM0eSv7yu0FdD9M+fGUVZrWm9JRgdQ22hqjt79A==", "0123456789", true, "c8d590e7-44e9-4da4-b94e-61b9952088eb", false, "david.brown@example.com" },
                    { new Guid("92181cd3-6cc8-4d35-8f74-cb5b2de4ed8c"), 0, 0, null, "4e063b9b-8a5a-4d49-8cb4-657299e2d3cf", "diana.prince@example.com", null, true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEL2ePM2UdKOCJbbdQKLL+YwuFlok316NYPIgnBrvoC5e7pHqoDu7Q3B23F5dhiyzbQ==", "0904567890", true, "b1a0aeae-716c-4305-860d-57367ec38088", false, "diana.prince@example.com" },
                    { new Guid("abcda63f-3c2a-45f8-90ab-659b5e863d82"), 0, 0, "", "ac2a25be-f355-4e47-b24e-3712dec2a65e", "michael.smith@example.com", null, true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEAOKutWtPLEBx5o53yABmo98FpAU2bkowLVYDo1ttCgVD+fAiUEIuVgFuPAZr1+v4A==", "0123456789", true, "f2908942-2894-4008-87b8-015beb1dbd4f", false, "michael.smith@example.com" },
                    { new Guid("d586ba3e-ce95-4d39-89c4-553ac4b08fe8"), 0, 0, null, "20e3d0fc-3123-48b8-9959-07c7beae14f6", "bob.johnson@example.com", null, true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEGv5+vP9Ey7lz0iIIZvrT/aDwtps5OmEuJyLu6vbxfgo9SgBCKI3g4/1VJQet34cRA==", "0902345678", true, "a97a683b-1a5e-41f5-9775-2df34ef20806", false, "bob.johnson@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("ec79ebcf-5ba5-4ede-b744-230594513ace"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5304), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5305), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("3fe6daa7-b415-4f7b-8650-eb47cb6bb721"), "A large outdoor swimming pool.", "Swimming Pool" },
                    { new Guid("ba796b2e-e802-4859-8165-42e00660a702"), "A fully equipped fitness gym.", "Gym" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("d9b60fb0-9eb0-4d25-9202-bca8eb92fb2f"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("029ff706-b97f-4350-a58a-068da85537d1"), "11:00 AM", "10:00 AM" },
                    { new Guid("de8cd175-5fa8-4935-a8a9-9629db85b6c2"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("8618b741-5505-4fe4-bd9c-39c8853bddef"), new Guid("23ec4579-ae03-4f2b-aa48-19bf88ba5d2a"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(3777), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(3778), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("750f1b1b-391f-4350-9213-8d800fbb52ca"), new Guid("1de769f5-986a-4158-a05f-ee82ee3607de") },
                    { new Guid("af01b0c9-50b7-429e-a34e-24e5d21fda70"), new Guid("23ec4579-ae03-4f2b-aa48-19bf88ba5d2a") },
                    { new Guid("e70a8d79-567b-4e14-920f-f066f100d1c3"), new Guid("4a0f911f-d62f-4b36-8903-ecab22af2040") },
                    { new Guid("1974beca-b455-4000-82d0-3d62477b9746"), new Guid("4d2b3c33-8cf9-473c-b427-f3c0f291c407") },
                    { new Guid("fa82bb09-cb8e-4f8e-ab1e-f06125ec2b1b"), new Guid("6741ea0a-ca09-4c8d-ba34-d5b7f7eb738d") },
                    { new Guid("ae847f98-a394-4dae-9125-0cf73b34428a"), new Guid("abcda63f-3c2a-45f8-90ab-659b5e863d82") }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("6e82b502-40d9-499c-9d85-dc45b8e4c9d5"), new Guid("3a0e9663-d0ed-441e-91f8-2e0e32033bfe"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5435), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" },
                    { new Guid("a223e6e6-6eb8-44d6-b32d-8dfd1a709138"), new Guid("d586ba3e-ce95-4d39-89c4-553ac4b08fe8"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5440), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("19f0542a-9bc7-4d76-8c69-e77839b1103f"), new Guid("0aad200d-282d-414f-8b97-e4244d01d425"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5493), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("d9b60fb0-9eb0-4d25-9202-bca8eb92fb2f"), new Guid("81e8297c-ad41-4fde-8008-4919ba9d4502"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5493), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("b5c5fde3-c32c-407e-995b-4888b9fef508"), new Guid("d586ba3e-ce95-4d39-89c4-553ac4b08fe8"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5502), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("d9b60fb0-9eb0-4d25-9202-bca8eb92fb2f"), new Guid("e3420a1b-48d0-4b17-b436-8ff86f8884e2"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5502), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[] { new Guid("189f216f-c675-4170-977f-373054c1c272"), null, new Guid("8618b741-5505-4fe4-bd9c-39c8853bddef"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(3822), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(3823), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "Address", "ApartmentName", "ApartmentStatus", "ApartmentType", "Area", "BalconyDirection", "CreatedDate", "Description", "Direction", "ExpiryDate", "Location", "NumberOfBathrooms", "NumberOfRooms", "PricePerSquareMeter", "ProjectApartmentID", "RecommendedPrice", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("a2bff192-cf6c-4a22-9b09-ab6e25824f3d"), "456 Ocean Drive, Coastal City", "Ocean View Apartment", 2, 2, 170.00m, 8, new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", 2, new DateTimeOffset(new DateTime(2027, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(4012), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", 3, 4, 90000000m, new Guid("189f216f-c675-4170-977f-373054c1c272"), 15000000000m, new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(4010), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("b5808261-a113-4cb7-b5e6-c2824f4eae65"), "123 Skyline Road, New City", "Skyline Apartment", 0, 1, 150.00m, 5, new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(3983), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", 1, new DateTimeOffset(new DateTime(2029, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(3994), new TimeSpan(0, 7, 0, 0, 0)), "City Center", 2, 3, 70000000m, new Guid("189f216f-c675-4170-977f-373054c1c272"), 10000000000m, new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(3984), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[] { new Guid("a57c10b8-1a87-457d-a4f7-9f6c0a864959"), new Guid("189f216f-c675-4170-977f-373054c1c272"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(3918), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[] { new Guid("41f1cccd-a777-4dc5-b468-54cbbf22d511"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(3951), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("189f216f-c675-4170-977f-373054c1c272"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(3952), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("491fd7c5-785a-47a2-847c-68e9304fb68c"), new Guid("a2bff192-cf6c-4a22-9b09-ab6e25824f3d"), new Guid("ba796b2e-e802-4859-8165-42e00660a702") },
                    { new Guid("976f4d7c-8fb9-482e-9f6a-a791f3a95b51"), new Guid("b5808261-a113-4cb7-b5e6-c2824f4eae65"), new Guid("3fe6daa7-b415-4f7b-8650-eb47cb6bb721") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("03eb4876-daa2-412a-b96b-2c26f09f41e5"), new Guid("b5808261-a113-4cb7-b5e6-c2824f4eae65"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(4208), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(4209), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("e4b41e98-e236-427e-9609-e3e71bf80bc1"), new Guid("b5808261-a113-4cb7-b5e6-c2824f4eae65"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(4203), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(4205), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("48fea201-92ea-4df8-86f5-cc155723b9e5"), new Guid("3a0e9663-d0ed-441e-91f8-2e0e32033bfe"), new Guid("b5808261-a113-4cb7-b5e6-c2824f4eae65"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5162), new TimeSpan(0, 7, 0, 0, 0)), 0 },
                    { new Guid("52038528-1f87-4d88-9dc1-267a14874899"), new Guid("d586ba3e-ce95-4d39-89c4-553ac4b08fe8"), new Guid("a2bff192-cf6c-4a22-9b09-ab6e25824f3d"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5168), new TimeSpan(0, 7, 0, 0, 0)), 1 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("84cf57bb-a54c-4f37-9f3f-3e75894fcf6a"), new Guid("6741ea0a-ca09-4c8d-ba34-d5b7f7eb738d"), new Guid("b5808261-a113-4cb7-b5e6-c2824f4eae65") },
                    { new Guid("ac36dde2-5015-41ef-b187-cc0ea795016c"), new Guid("6741ea0a-ca09-4c8d-ba34-d5b7f7eb738d"), new Guid("b5808261-a113-4cb7-b5e6-c2824f4eae65") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("5fbb8986-1a3c-4d22-8b38-7c6b5ca4d67a"), new Guid("b5808261-a113-4cb7-b5e6-c2824f4eae65"), new Guid("6741ea0a-ca09-4c8d-ba34-d5b7f7eb738d"), new DateTimeOffset(new DateTime(2024, 10, 17, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5272), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5271), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5269), new TimeSpan(0, 7, 0, 0, 0)), new Guid("104d6b4e-afbc-4a44-b907-d31d16325afa"), "Schedule a viewing for the Skyline Apartment.", new Guid("23ec4579-ae03-4f2b-aa48-19bf88ba5d2a"), new Guid("de8cd175-5fa8-4935-a8a9-9629db85b6c2"), new Guid("4a0f911f-d62f-4b36-8903-ecab22af2040"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5270), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("3450eb59-1c9e-4307-b769-a8b45297bb53"), new Guid("0aad200d-282d-414f-8b97-e4244d01d425"), new Guid("b5808261-a113-4cb7-b5e6-c2824f4eae65"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5328), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5332), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 11, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5333), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("8c8af83f-5a61-480d-96b4-f8a64fd5202d"), new Guid("d586ba3e-ce95-4d39-89c4-553ac4b08fe8"), new Guid("b5808261-a113-4cb7-b5e6-c2824f4eae65"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5199), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 10, 17, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5200), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." },
                    { new Guid("9efa29ba-18a3-4a93-947a-641895da9d99"), new Guid("3a0e9663-d0ed-441e-91f8-2e0e32033bfe"), new Guid("a2bff192-cf6c-4a22-9b09-ab6e25824f3d"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 10, 17, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5210), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("b0ca0860-ffe5-45dd-ab22-36b0f48abda4"), new Guid("4a0f911f-d62f-4b36-8903-ecab22af2040"), new Guid("a2bff192-cf6c-4a22-9b09-ab6e25824f3d"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5033), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5034), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" },
                    { new Guid("eeba5701-7abf-4e63-9715-1e7f10d7f002"), new Guid("4a0f911f-d62f-4b36-8903-ecab22af2040"), new Guid("b5808261-a113-4cb7-b5e6-c2824f4eae65"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(4249), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(4255), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("5f1fcd4e-7e44-40be-9920-5cf21055e33e"), new Guid("4d2b3c33-8cf9-473c-b427-f3c0f291c407"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5407), new TimeSpan(0, 7, 0, 0, 0)), new Guid("ec79ebcf-5ba5-4ede-b744-230594513ace"), new Guid("3450eb59-1c9e-4307-b769-a8b45297bb53"), "45000", new DateTimeOffset(new DateTime(2024, 10, 21, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5408), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5409), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("15bc1b77-ed91-42f9-b23b-278c0575a0f3"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5379), new TimeSpan(0, 7, 0, 0, 0)), new Guid("3450eb59-1c9e-4307-b769-a8b45297bb53"), 0, new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5382), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5381), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("8e46f4ed-4ddd-436a-919e-29a7aebc247f"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5126), new TimeSpan(0, 7, 0, 0, 0)), new Guid("eeba5701-7abf-4e63-9715-1e7f10d7f002") },
                    { new Guid("8e8e3573-56a1-4431-b963-e21b1b12cfaa"), new DateTimeOffset(new DateTime(2024, 10, 16, 11, 12, 47, 64, DateTimeKind.Unspecified).AddTicks(5130), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b0ca0860-ffe5-45dd-ab22-36b0f48abda4") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectApartmentApartments_ApartmentID",
                table: "ProjectApartmentApartments",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectApartmentApartments_ProjectApartmentID",
                table: "ProjectApartmentApartments",
                column: "ProjectApartmentID");
        }
    }
}
