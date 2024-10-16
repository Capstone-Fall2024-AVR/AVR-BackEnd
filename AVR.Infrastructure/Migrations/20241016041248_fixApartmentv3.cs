using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixApartmentv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("9158be0f-ea93-40d1-bbda-2a5e4e68f6ea"));

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("e32aac0e-24e5-4352-ac38-3ca8b03f3e30"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("210cf84c-f9a0-4011-bb42-f5529c661c04"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("79533f4e-98ae-488b-9754-739c589fd313"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("1ee794c3-ddda-46dd-8d04-3efd78ca5a1c"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("5a825e13-a6f8-4f53-9f7d-60cb03ec9786"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("0ecf4731-7e2a-4305-9cb9-c380aca26825"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("51205e4b-48d2-4d45-a828-12222bbf9bc8"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: new Guid("301287ca-6e67-41cb-98ed-f46b07c91480"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("63cf5f4f-37cd-4736-97a7-0bdced20659d"), new Guid("5a22a69d-3e11-4768-9990-ac1ff1829bee") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("dea4a5d0-c96c-4d21-bfca-83714fa6f8d2"), new Guid("8a9deecf-3dd9-407a-b639-61de4446bae8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7961d588-4c71-4d31-9abe-b3b4375470f6"), new Guid("a9555aed-59ed-4f25-870e-db1caa876b50") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("faa78e71-a1ef-43fc-88ec-3be895c6ed44"), new Guid("e24f84c0-d805-4b4a-8d7a-28d342e22ea4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b2646ddb-9709-4f97-acda-cfed6f8dd16f"), new Guid("e4bc3421-4356-4d5c-aaf3-b1f34e9b81fc") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b5a87e3e-111b-4d95-9b38-dd7e6744f94d"), new Guid("e98635ee-d89f-4f4d-8cee-bdca30bdce62") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1f1cc96a-0114-4b0a-92fe-8c88a7dfe05d"));

            migrationBuilder.DeleteData(
                table: "DepositCancel",
                keyColumn: "DepositCancelID",
                keyValue: new Guid("12269042-8dd5-4a70-b2bc-415e94605275"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("938f62d5-3ca4-43de-9dfb-84ce38e00dcf"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("db406a26-ed84-4526-b58e-a8fb2f456838"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("86833efa-ef9e-47fa-ae00-3425d161172d"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("8e5275a6-c433-4ef7-a849-f740ad116e20"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("3fd0da6b-735e-4a29-ae5a-cf28b0b324b0"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("bc5a4788-d870-46c8-9dfd-3f15f33ce958"));

            migrationBuilder.DeleteData(
                table: "ProjectApartmentApartments",
                keyColumn: "Id",
                keyValue: new Guid("30d859f8-c8bb-455b-a7bd-c567a3486756"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("94e82338-5f2a-47ad-8002-82951d2d4d88"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("fa2c399e-d979-4c5b-a883-74667e630157"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("932fa4cd-3768-4b1f-9598-8b49e6b8cc00"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("b1ab6dc4-3b6a-4d34-961a-4c410f340c0c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("e9b153de-bb90-4ee2-a9af-2f45541d8e09"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: new Guid("b22ab0e0-c57a-46ca-bbb4-473195508756"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("0fb0918a-e598-4868-8c26-fe6cebbaa9a4"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("8facae31-c132-4535-a28b-00ac386e39f2"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("63cf5f4f-37cd-4736-97a7-0bdced20659d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7961d588-4c71-4d31-9abe-b3b4375470f6"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b2646ddb-9709-4f97-acda-cfed6f8dd16f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b5a87e3e-111b-4d95-9b38-dd7e6744f94d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dea4a5d0-c96c-4d21-bfca-83714fa6f8d2"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("faa78e71-a1ef-43fc-88ec-3be895c6ed44"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("26b297e6-3a4f-42d2-9ab4-88e9a804b5c0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5a22a69d-3e11-4768-9990-ac1ff1829bee"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6b71e14b-5519-4aac-b2c9-93a6e5206e38"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a9deecf-3dd9-407a-b639-61de4446bae8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce48a334-ec95-4256-b2f8-edde8eb26bbc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e24f84c0-d805-4b4a-8d7a-28d342e22ea4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e4bc3421-4356-4d5c-aaf3-b1f34e9b81fc"));

            migrationBuilder.DeleteData(
                table: "DepositCancelTypes",
                keyColumn: "DepositCancelTypeID",
                keyValue: new Guid("0601e7b3-7711-44df-9119-f8d26c8a1773"));

            migrationBuilder.DeleteData(
                table: "DepositRequest",
                keyColumn: "DepositID",
                keyValue: new Guid("d3ce2bea-cd37-4646-b919-e405b110deb9"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("75fd2436-c201-4169-b7d1-571d13dc06b9"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("78f83da2-25f9-4e4e-8438-618a04367008"));

            migrationBuilder.DeleteData(
                table: "NotificationTypes",
                keyColumn: "NotificationTypeID",
                keyValue: new Guid("b5491537-1df8-4f57-86a9-00a4dd58c7e4"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("12d57081-26a6-46a8-ad94-dbaf047c5fb2"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("bb82e18d-14fe-4c49-bbd6-68ca0a4a29da"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("b66dfa05-d555-447c-bf9f-744c9c736b66"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("58d609f6-31a9-4599-a031-5d8ee45856ac"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("d9cb4196-871f-430f-8a37-6b6bcbb805bd"));

            migrationBuilder.DeleteData(
                table: "ApartmentProjectProvider",
                keyColumn: "ApartmentProjectProviderID",
                keyValue: new Guid("42964de0-40be-4386-bbde-8fddc40c81e0"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("55f95996-4456-4e16-b93c-adbf4e8c9de1"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("de6006a4-e92a-4f62-b8cf-31e3936696cc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13507c1e-ca9b-4baa-8663-15c2082861ee"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e98635ee-d89f-4f4d-8cee-bdca30bdce62"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a9555aed-59ed-4f25-870e-db1caa876b50"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectApartmentID",
                table: "Apartments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "IX_Apartments_ProjectApartmentID",
                table: "Apartments",
                column: "ProjectApartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_ProjectApartments_ProjectApartmentID",
                table: "Apartments",
                column: "ProjectApartmentID",
                principalTable: "ProjectApartments",
                principalColumn: "ProjectApartmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_ProjectApartments_ProjectApartmentID",
                table: "Apartments");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_ProjectApartmentID",
                table: "Apartments");

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

            migrationBuilder.DropColumn(
                name: "ProjectApartmentID",
                table: "Apartments");

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "Address", "ApartmentName", "ApartmentStatus", "ApartmentType", "Area", "BalconyDirection", "CreatedDate", "Description", "Direction", "ExpiryDate", "Location", "NumberOfBathrooms", "NumberOfRooms", "PricePerSquareMeter", "RecommendedPrice", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("55f95996-4456-4e16-b93c-adbf4e8c9de1"), "456 Ocean Drive, Coastal City", "Ocean View Apartment", 1, 2, 170.00m, 8, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(1089), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", 2, new DateTimeOffset(new DateTime(2027, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(1109), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", 3, 4, 90000000m, 15000000000m, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(1106), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("de6006a4-e92a-4f62-b8cf-31e3936696cc"), "123 Skyline Road, New City", "Skyline Apartment", 0, 1, 150.00m, 5, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(1045), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", 1, new DateTimeOffset(new DateTime(2029, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(1055), new TimeSpan(0, 7, 0, 0, 0)), "City Center", 2, 3, 70000000m, 10000000000m, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(1045), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("63cf5f4f-37cd-4736-97a7-0bdced20659d"), null, "Apartment Owner", "APARTMENT OWNER" },
                    { new Guid("7961d588-4c71-4d31-9abe-b3b4375470f6"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("b2646ddb-9709-4f97-acda-cfed6f8dd16f"), null, "Admin", "ADMIN" },
                    { new Guid("b5a87e3e-111b-4d95-9b38-dd7e6744f94d"), null, "Staff", "STAFF" },
                    { new Guid("dea4a5d0-c96c-4d21-bfca-83714fa6f8d2"), null, "Management", "MANAGEMENT" },
                    { new Guid("faa78e71-a1ef-43fc-88ec-3be895c6ed44"), null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmationOtp", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OtpExpiryTime", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("13507c1e-ca9b-4baa-8663-15c2082861ee"), 0, 0, null, "1eac20e3-6468-4144-ac53-37436ada121e", "charlie.brown@example.com", null, true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAECqBRlrjs6kZrI0VUdUYdbFhU7+Zc7f7tbBRqEj8AQLisxn+wHf8XXiai40m5AagQg==", "0903456789", true, "dd16c2e9-e248-4389-933e-00cb2013b65d", false, "charlie.brown@example.com" },
                    { new Guid("1f1cc96a-0114-4b0a-92fe-8c88a7dfe05d"), 0, 0, null, "8481277f-c73b-4bff-b2cd-5713da491e6b", "diana.prince@example.com", null, true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEDAiqrrCVBSuSi3t0LAFd0LHeBcNovUyaY6MRfWdxyPcr0xy6musrCBKXOygmeE6nQ==", "0904567890", true, "7249c59c-736e-4da2-a30f-910916ea494a", false, "diana.prince@example.com" },
                    { new Guid("26b297e6-3a4f-42d2-9ab4-88e9a804b5c0"), 0, 0, null, "92101782-4e90-4626-8e98-2b2706c49aa4", "alice.smith@example.com", null, true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEFuApGDa5HpZSaq3Js4sj05vOogCR7zArTeRUaEOBVGecW0xk0AXXB2kwdZaqXGCYQ==", "0901234567", true, "94d9f2a6-1a38-4753-aaf8-93a391088212", false, "alice.smith@example.com" },
                    { new Guid("5a22a69d-3e11-4768-9990-ac1ff1829bee"), 0, 0, "", "2bc9e1dd-2400-4a15-8fb4-2332430fd2aa", "david.brown@example.com", null, true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEGMpZrN/raSuMjE1WIX2tYZLAg8MQ22qUF6APJCrBL75sap/nChGJTLl5AE297h6HA==", "0123456789", true, "83e0b629-530d-414e-8c85-0e37bb3dd2f1", false, "david.brown@example.com" },
                    { new Guid("6b71e14b-5519-4aac-b2c9-93a6e5206e38"), 0, 0, null, "2ef54198-6b1b-48d2-8490-2902ab31648f", "eve.adams@example.com", null, true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAENj7dmW1IguGJcO1ItGdqRcUyMpc9HGNxTXlSrffdppoobkuT25PK2nYQXdL2u1rsQ==", "0905678901", true, "9b6d2117-54fe-49dd-8f1a-3b52dfb51a06", false, "eve.adams@example.com" },
                    { new Guid("8a9deecf-3dd9-407a-b639-61de4446bae8"), 0, 0, "", "334f3299-f8a2-4f05-9213-2dfaa3259d90", "alice.johnson@example.com", null, true, false, null, "Alice Johnson", "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEDyx5wwA3PswUM7O34tHZ9jD/ZOD85S0gpF5aFk3PINTtzb8nlXfFqSRv6wNrxgRtg==", "0987654321", true, "a600239d-0124-42a0-a0dc-038b99c66e82", false, "alice.johnson@example.com" },
                    { new Guid("a9555aed-59ed-4f25-870e-db1caa876b50"), 0, 0, "", "5808851f-a4fa-45ce-a7dd-0c71cb44c698", "construction.corp@example.com", null, true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEHmglvOsish3koR2u3C7J5Xxt9SJNL4miUjRhVrNMfvRCwEMCuxg2Iq91c6tpdMSCQ==", "0987654321", true, "df54f553-42b0-4954-bd3b-357ceb9c08e5", false, "construction.corp@example.com" },
                    { new Guid("ce48a334-ec95-4256-b2f8-edde8eb26bbc"), 0, 0, null, "453c21fc-6fd4-4a49-98c5-8cc1576535d6", "bob.johnson@example.com", null, true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAECET47IbDrDZSdLRURNd855sPzzxbfpPX16pTVV+uc6+aws//c+OBK8VYplpEo70JA==", "0902345678", true, "f0d7af4c-e6bf-45ec-bc2c-90da205679a4", false, "bob.johnson@example.com" },
                    { new Guid("e24f84c0-d805-4b4a-8d7a-28d342e22ea4"), 0, 0, "", "7334f1ab-4a12-4ffb-9209-5eb9726e0cdb", "michael.smith@example.com", null, true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEGgQsTqvDzHab8CXAuHX7xxBvg5TDR8s0Cdw/Utmd1m63vtT7V9UV6HH5puJGvPzMw==", "0123456789", true, "73badc57-4df6-48bf-b84c-5a2cdec9fbf8", false, "michael.smith@example.com" },
                    { new Guid("e4bc3421-4356-4d5c-aaf3-b1f34e9b81fc"), 0, 0, "", "f5014470-c473-4923-8709-bbf457ee5df1", "quansongngu13@gmail.com", null, true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", null, "AQAAAAIAAYagAAAAEH7/LySKSMGSplH8ht3r07IcDz9Dg/m85GHqCgRs+2v63JUys6j56PfxyRfx3fvNOQ==", "0949035672", true, "0168bb3a-edf1-4541-bd31-ed6a1ded7312", false, "quansongngu13@gmail.com" },
                    { new Guid("e98635ee-d89f-4f4d-8cee-bdca30bdce62"), 0, 0, null, "69af9c6f-bbdc-4a94-a157-a7b97aa98a44", "johndoe@example.com", null, true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEDOCf8jVlY3QSvd74PKEvVUMsGeiFk9QidVWiq53Zx0YY2blYMYjPE1zYlTCtzPPSg==", "123456789", true, "05067b1e-5323-48c3-a8a0-6a8924fd780a", false, "johndoe@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("0601e7b3-7711-44df-9119-f8d26c8a1773"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3384), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3385), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("75fd2436-c201-4169-b7d1-571d13dc06b9"), "A large outdoor swimming pool.", "Swimming Pool" },
                    { new Guid("78f83da2-25f9-4e4e-8438-618a04367008"), "A fully equipped fitness gym.", "Gym" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("b5491537-1df8-4f57-86a9-00a4dd58c7e4"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("b66dfa05-d555-447c-bf9f-744c9c736b66"), "10:00 AM", "09:00 AM" },
                    { new Guid("e9b153de-bb90-4ee2-a9af-2f45541d8e09"), "11:00 AM", "10:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("9158be0f-ea93-40d1-bbda-2a5e4e68f6ea"), new Guid("55f95996-4456-4e16-b93c-adbf4e8c9de1"), new Guid("78f83da2-25f9-4e4e-8438-618a04367008") },
                    { new Guid("e32aac0e-24e5-4352-ac38-3ca8b03f3e30"), new Guid("de6006a4-e92a-4f62-b8cf-31e3936696cc"), new Guid("75fd2436-c201-4169-b7d1-571d13dc06b9") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("210cf84c-f9a0-4011-bb42-f5529c661c04"), new Guid("de6006a4-e92a-4f62-b8cf-31e3936696cc"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(2989), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("79533f4e-98ae-488b-9754-739c589fd313"), new Guid("de6006a4-e92a-4f62-b8cf-31e3936696cc"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(2986), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("1ee794c3-ddda-46dd-8d04-3efd78ca5a1c"), new Guid("ce48a334-ec95-4256-b2f8-edde8eb26bbc"), new Guid("55f95996-4456-4e16-b93c-adbf4e8c9de1"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3114), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { new Guid("5a825e13-a6f8-4f53-9f7d-60cb03ec9786"), new Guid("26b297e6-3a4f-42d2-9ab4-88e9a804b5c0"), new Guid("de6006a4-e92a-4f62-b8cf-31e3936696cc"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3105), new TimeSpan(0, 7, 0, 0, 0)), 0 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("0ecf4731-7e2a-4305-9cb9-c380aca26825"), new Guid("5a22a69d-3e11-4768-9990-ac1ff1829bee"), new Guid("de6006a4-e92a-4f62-b8cf-31e3936696cc") },
                    { new Guid("51205e4b-48d2-4d45-a828-12222bbf9bc8"), new Guid("5a22a69d-3e11-4768-9990-ac1ff1829bee"), new Guid("de6006a4-e92a-4f62-b8cf-31e3936696cc") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("42964de0-40be-4386-bbde-8fddc40c81e0"), new Guid("a9555aed-59ed-4f25-870e-db1caa876b50"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(711), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(712), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("301287ca-6e67-41cb-98ed-f46b07c91480"), new Guid("de6006a4-e92a-4f62-b8cf-31e3936696cc"), new Guid("5a22a69d-3e11-4768-9990-ac1ff1829bee"), new DateTimeOffset(new DateTime(2024, 10, 16, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3344), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3342), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3340), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6b71e14b-5519-4aac-b2c9-93a6e5206e38"), "Schedule a viewing for the Skyline Apartment.", new Guid("a9555aed-59ed-4f25-870e-db1caa876b50"), new Guid("b66dfa05-d555-447c-bf9f-744c9c736b66"), new Guid("e98635ee-d89f-4f4d-8cee-bdca30bdce62"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3341), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("63cf5f4f-37cd-4736-97a7-0bdced20659d"), new Guid("5a22a69d-3e11-4768-9990-ac1ff1829bee") },
                    { new Guid("dea4a5d0-c96c-4d21-bfca-83714fa6f8d2"), new Guid("8a9deecf-3dd9-407a-b639-61de4446bae8") },
                    { new Guid("7961d588-4c71-4d31-9abe-b3b4375470f6"), new Guid("a9555aed-59ed-4f25-870e-db1caa876b50") },
                    { new Guid("faa78e71-a1ef-43fc-88ec-3be895c6ed44"), new Guid("e24f84c0-d805-4b4a-8d7a-28d342e22ea4") },
                    { new Guid("b2646ddb-9709-4f97-acda-cfed6f8dd16f"), new Guid("e4bc3421-4356-4d5c-aaf3-b1f34e9b81fc") },
                    { new Guid("b5a87e3e-111b-4d95-9b38-dd7e6744f94d"), new Guid("e98635ee-d89f-4f4d-8cee-bdca30bdce62") }
                });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("d3ce2bea-cd37-4646-b919-e405b110deb9"), new Guid("13507c1e-ca9b-4baa-8663-15c2082861ee"), new Guid("de6006a4-e92a-4f62-b8cf-31e3936696cc"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3431), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3434), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 11, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3435), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("938f62d5-3ca4-43de-9dfb-84ce38e00dcf"), new Guid("26b297e6-3a4f-42d2-9ab4-88e9a804b5c0"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" },
                    { new Guid("db406a26-ed84-4526-b58e-a8fb2f456838"), new Guid("ce48a334-ec95-4256-b2f8-edde8eb26bbc"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3567), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("86833efa-ef9e-47fa-ae00-3425d161172d"), new Guid("13507c1e-ca9b-4baa-8663-15c2082861ee"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3628), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("b5491537-1df8-4f57-86a9-00a4dd58c7e4"), new Guid("2cfb511f-a944-44ef-99da-ccd7247ad02b"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3629), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8e5275a6-c433-4ef7-a849-f740ad116e20"), new Guid("ce48a334-ec95-4256-b2f8-edde8eb26bbc"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3638), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("b5491537-1df8-4f57-86a9-00a4dd58c7e4"), new Guid("e12f0fb5-5b6d-4099-b621-0e5c2b2e07d5"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3639), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("932fa4cd-3768-4b1f-9598-8b49e6b8cc00"), new Guid("ce48a334-ec95-4256-b2f8-edde8eb26bbc"), new Guid("de6006a4-e92a-4f62-b8cf-31e3936696cc"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3210), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 10, 16, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." },
                    { new Guid("b1ab6dc4-3b6a-4d34-961a-4c410f340c0c"), new Guid("26b297e6-3a4f-42d2-9ab4-88e9a804b5c0"), new Guid("55f95996-4456-4e16-b93c-adbf4e8c9de1"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3224), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 10, 16, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3225), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("58d609f6-31a9-4599-a031-5d8ee45856ac"), new Guid("e98635ee-d89f-4f4d-8cee-bdca30bdce62"), new Guid("de6006a4-e92a-4f62-b8cf-31e3936696cc"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3035), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" },
                    { new Guid("d9cb4196-871f-430f-8a37-6b6bcbb805bd"), new Guid("e98635ee-d89f-4f4d-8cee-bdca30bdce62"), new Guid("55f95996-4456-4e16-b93c-adbf4e8c9de1"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3039), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("12269042-8dd5-4a70-b2bc-415e94605275"), new Guid("8a9deecf-3dd9-407a-b639-61de4446bae8"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3528), new TimeSpan(0, 7, 0, 0, 0)), new Guid("0601e7b3-7711-44df-9119-f8d26c8a1773"), new Guid("d3ce2bea-cd37-4646-b919-e405b110deb9"), "45000", new DateTimeOffset(new DateTime(2024, 10, 20, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3529), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3531), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("12d57081-26a6-46a8-ad94-dbaf047c5fb2"), null, new Guid("42964de0-40be-4386-bbde-8fddc40c81e0"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(891), new TimeSpan(0, 7, 0, 0, 0)), "1,000,000 - 2,000,000 USD", "A luxurious penthouse suite with stunning views.", "Penthouse Suite", 0, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("bb82e18d-14fe-4c49-bbd6-68ca0a4a29da"), null, new Guid("42964de0-40be-4386-bbde-8fddc40c81e0"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(882), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(887), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("b22ab0e0-c57a-46ca-bbb4-473195508756"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3496), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d3ce2bea-cd37-4646-b919-e405b110deb9"), 0, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3498), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3497), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("0fb0918a-e598-4868-8c26-fe6cebbaa9a4"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3079), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d9cb4196-871f-430f-8a37-6b6bcbb805bd") },
                    { new Guid("8facae31-c132-4535-a28b-00ac386e39f2"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(3076), new TimeSpan(0, 7, 0, 0, 0)), new Guid("58d609f6-31a9-4599-a031-5d8ee45856ac") }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[,]
                {
                    { new Guid("3fd0da6b-735e-4a29-ae5a-cf28b0b324b0"), new Guid("bb82e18d-14fe-4c49-bbd6-68ca0a4a29da"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(938), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("bc5a4788-d870-46c8-9dfd-3f15f33ce958"), new Guid("12d57081-26a6-46a8-ad94-dbaf047c5fb2"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(944), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartmentApartments",
                columns: new[] { "Id", "ApartmentID", "ProjectApartmentID" },
                values: new object[] { new Guid("30d859f8-c8bb-455b-a7bd-c567a3486756"), new Guid("55f95996-4456-4e16-b93c-adbf4e8c9de1"), new Guid("bb82e18d-14fe-4c49-bbd6-68ca0a4a29da") });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[,]
                {
                    { new Guid("94e82338-5f2a-47ad-8002-82951d2d4d88"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(989), new TimeSpan(0, 7, 0, 0, 0)), "Image of the penthouse suite", "Penthouse Suite Image", new Guid("12d57081-26a6-46a8-ad94-dbaf047c5fb2"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(991), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/penthouse-suite.jpg" },
                    { new Guid("fa2c399e-d979-4c5b-a883-74667e630157"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(984), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("bb82e18d-14fe-4c49-bbd6-68ca0a4a29da"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 58, 13, 926, DateTimeKind.Unspecified).AddTicks(985), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" }
                });
        }
    }
}
