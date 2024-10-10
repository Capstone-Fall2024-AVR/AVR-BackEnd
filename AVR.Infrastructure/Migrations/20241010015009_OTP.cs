using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OTP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("9af2d63d-c337-42f8-b5b6-7887ed62bdd3"));

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("e6588613-4e56-4383-aec5-967c01834fd4"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("48efe462-2ed7-47fc-9d98-455b3055bf42"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("8119810e-507a-4351-852d-cf3a65f3e814"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("9c0516d9-a843-4167-bb9b-d9a74f72acb5"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("bdfeb4d9-98ab-40ed-b496-4ec4580b42aa"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("05f9ffe9-33df-4da0-aab7-90dbed0d7373"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("e7f102a8-6c8a-4d81-b64f-5ba505423617"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: new Guid("b398a733-de6a-4659-9a87-d27f37c17098"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("17837217-f1b8-4b52-b906-044ab60198a8"), new Guid("65890ffc-2a1c-4eab-994c-88de6f34323b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("bc65d853-de55-4084-be18-cdba48130b5c"), new Guid("7fda1553-cfc4-49de-97b2-b8f12c018435") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d43aa731-0cf1-47b5-86f5-ffadd1deae95"), new Guid("cb479253-ad6d-40ea-8791-d6c8900b9cc5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4020efa4-830b-47ac-b09a-9f3081aa4b30"), new Guid("cff98ac2-3659-4f8f-b140-859b39712e39") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4730e6d5-153e-40ea-a147-d6466f81f2e7"), new Guid("fb16403c-b362-41cf-ba5f-ffe9f6d4954e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d83231cb-bb0b-444d-a59f-d35b4e4d74f1"), new Guid("fe266334-e991-462b-aa3c-8f4360b0fbbc") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("24c65aeb-d5a0-490f-81d7-54d23ea4cf89"));

            migrationBuilder.DeleteData(
                table: "DepositCancel",
                keyColumn: "DepositCancelID",
                keyValue: new Guid("8718b02d-fbe2-42dc-a3fa-c0e5519409b5"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("5b9e6fb5-05b9-4ee6-a2bf-7108f0b473ef"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("6a8d5cad-e597-4247-bc13-a3cf7fed7838"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("00f36679-c457-44ad-961f-2949c6ba7f59"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("a4303a9b-0d62-4ebf-a53c-8092f9922dc3"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("206811fd-0df5-47f1-96fa-7b4ccc52a8f3"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("20a486e1-2255-4877-b750-72a904118d83"));

            migrationBuilder.DeleteData(
                table: "ProjectApartmentApartments",
                keyColumn: "Id",
                keyValue: new Guid("8fdb77d1-af13-4563-b5d8-d86caa3899dc"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("9a257c03-6e7e-4197-87c1-d5556f77fc6e"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("c2eae197-9dc5-4e93-979f-1989a9684f02"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("bebd7b70-72c4-4e56-b258-6e961e6ab6ca"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("c40a880b-4c76-4450-9c56-a358c68226f1"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("028bda33-7f28-4d13-b283-79ecfa825eab"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: new Guid("a878602c-2b53-4d07-a4cc-006d62f9df30"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("6244511a-4fa5-49a6-8621-e8562230fb3e"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("dfdfa929-615d-4646-93a8-7d83fb1620dd"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("17837217-f1b8-4b52-b906-044ab60198a8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4020efa4-830b-47ac-b09a-9f3081aa4b30"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4730e6d5-153e-40ea-a147-d6466f81f2e7"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bc65d853-de55-4084-be18-cdba48130b5c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d43aa731-0cf1-47b5-86f5-ffadd1deae95"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d83231cb-bb0b-444d-a59f-d35b4e4d74f1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7fda1553-cfc4-49de-97b2-b8f12c018435"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89039655-c3ab-49e1-aa74-c174432ce194"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb3c19e9-3cf0-4249-bf6a-8f09f32e44d4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb479253-ad6d-40ea-8791-d6c8900b9cc5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cfb31713-8315-402e-8f8d-35b3bb12db40"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb16403c-b362-41cf-ba5f-ffe9f6d4954e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fe266334-e991-462b-aa3c-8f4360b0fbbc"));

            migrationBuilder.DeleteData(
                table: "DepositCancelTypes",
                keyColumn: "DepositCancelTypeID",
                keyValue: new Guid("c1f68006-b9c2-4ac3-91fc-ed349ec8259d"));

            migrationBuilder.DeleteData(
                table: "DepositRequest",
                keyColumn: "DepositID",
                keyValue: new Guid("2633dc4d-30d6-4b0e-9eff-197a80c77aaa"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("263f651d-6d3d-4785-8028-e282e351f03b"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("8150b2e3-e29d-461c-abdd-61f9d4b5ed66"));

            migrationBuilder.DeleteData(
                table: "NotificationTypes",
                keyColumn: "NotificationTypeID",
                keyValue: new Guid("c2e80438-ac50-4281-a7a2-502479c94ded"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("658285a7-3c69-4261-9e67-a39753ec07ce"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("f30507c5-c3e8-4e64-af60-976c35872cdd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("246c7696-2bc7-4269-908b-a78b4ef2d3de"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("575da0ed-4681-4f44-b5a8-5908375d4194"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("5ece773e-bda6-40ca-9f81-c93aee949a27"));

            migrationBuilder.DeleteData(
                table: "ApartmentProjectProvider",
                keyColumn: "ApartmentProjectProviderID",
                keyValue: new Guid("e3474303-4d9b-42c3-bf2b-41dd19676528"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("5e21ee98-0a9b-4a35-99cc-d11345de8ace"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("ae2025dc-07f1-4320-948b-0349dc5c8f4f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("65890ffc-2a1c-4eab-994c-88de6f34323b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("68ea9396-2bf9-4229-9a41-957bace62427"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cff98ac2-3659-4f8f-b140-859b39712e39"));

            migrationBuilder.AddColumn<string>(
                name: "EmailConfirmationOtp",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OtpExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "ApartmentName", "ApartmentStatus", "ApartmentType", "CreatedDate", "Description", "UpdatedDate", "address", "area", "direction", "expiryDate", "location", "numberOfRooms", "pricePerSquareMeter", "recommendedPrice" },
                values: new object[,]
                {
                    { new Guid("c33b0228-0a47-484b-84a0-4a74e7813fa2"), "Ocean View Apartment", 1, 0, new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3487), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3504), new TimeSpan(0, 7, 0, 0, 0)), "456 Ocean Drive, Coastal City", "1800 sqft", "South-West", new DateTimeOffset(new DateTime(2027, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", "4", "3500 USD", "650,000 USD" },
                    { new Guid("e8b3a5f9-ac10-4ea1-b712-07d54ab3a440"), "Skyline Apartment", 0, 1, new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3449), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3450), new TimeSpan(0, 7, 0, 0, 0)), "123 Skyline Road, New City", "1500 sqft", "North-East", new DateTimeOffset(new DateTime(2029, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3452), new TimeSpan(0, 7, 0, 0, 0)), "City Center", "3", "3000 USD", "450,000 USD" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0ac58a97-d635-4bba-9595-bedf1ac080b6"), null, "Customer", "CUSTOMER" },
                    { new Guid("123ec8b6-69c2-488c-9084-d938bec2d562"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("8ac9c214-a87a-4468-9a62-b2a6a81eb648"), null, "Apartment Owner", "APARTMENT OWNER" },
                    { new Guid("f6f64fa4-c777-4f1b-9062-bc9387390f66"), null, "Admin", "ADMIN" },
                    { new Guid("faeaf865-4f97-4699-b6e1-9dee37aaeb55"), null, "Management", "MANAGEMENT" },
                    { new Guid("fd05348b-d4b8-4ac8-b03e-2977df942409"), null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmationOtp", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OtpExpiryTime", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("12badf9e-9231-4c65-912e-6b24a4c9f5d9"), 0, 0, null, "9c66eed1-64ee-48e7-a623-e5a2a936c89d", "bob.johnson@example.com", null, true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAECDuOAjZLpaih1Iuacqc/g7CjqmJddZbDABwRXLxgnx3VI/lmyN0xg5tjGt6Gzx1ug==", "0902345678", true, "d2d626d7-7786-47b8-b341-fe76f1568172", false, "bob.johnson@example.com" },
                    { new Guid("3a7670d9-6c4f-4f31-80a6-dd0bc888840b"), 0, 0, null, "5c7f48f8-9797-4286-8f6a-7d09ed23df9f", "diana.prince@example.com", null, true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEHo58ByplXhZFaR4x5uk8dPbrZffX4G6Cjl78dgue2RONXa0lmPPF1JCHmw1+tIC7w==", "0904567890", true, "0d923072-e1c5-4270-8181-7c8fd9afb9e6", false, "diana.prince@example.com" },
                    { new Guid("3f4f8db1-1192-4aa2-85ef-c2e8e835732b"), 0, 0, null, "3fd83eb5-ff9e-484c-9bd9-d180423b5f41", "johndoe@example.com", null, true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAENyekhKUC2OfulJffgkvNECkWs2KFfF7b3Z54j/OquA+EuU0cL5+loFVa2p2FexBow==", "123456789", true, "d038c6a9-8471-4843-a830-9a8fd184aaa4", false, "johndoe@example.com" },
                    { new Guid("43141c91-7b8b-4c2d-a22a-98af102c69e1"), 0, 0, null, "a426263a-1fdb-40c5-a353-e7e0701b96d5", "charlie.brown@example.com", null, true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAENthESxP9SB+w/AWhJXTYy7Af9Jn1hX5cZ6Rwg//z2ZtzZSlWoFwm/E8ac+r3s9sjQ==", "0903456789", true, "fe442ecc-c579-4b6b-8fbb-d772edc9c6be", false, "charlie.brown@example.com" },
                    { new Guid("824ca70b-d2fa-4635-aa84-81cb8f5e297d"), 0, 0, "", "92ebb7da-15f8-4152-9b15-87c133f08b88", "alice.johnson@example.com", null, true, false, null, "Alice Johnson", "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAELYQihJQBiL+oGLCPZlTFUA3NCwfh7CWCKDTZyEvH52qchXyVQfEcEBZAB9ypCSBug==", "0987654321", true, "f69ee9cf-6770-46c3-bbcb-e329a48b5332", false, "alice.johnson@example.com" },
                    { new Guid("9319f7ec-0a85-4169-8704-068fb6dfe99c"), 0, 0, "", "18397eaf-62ef-4de4-b527-23ef94b5aaab", "quansongngu13@gmail.com", null, true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", null, "AQAAAAIAAYagAAAAEDJ0ohW/N3h+nkrovpfHADiV34MzJbNancuUNoXMw7sCWmsrL3pzTlVsGjmle/1n6w==", "0949035672", true, "88a0c010-b545-4f86-afd7-d6a7f66b9c3c", false, "quansongngu13@gmail.com" },
                    { new Guid("a75d0e8d-c293-4778-a22b-54c3476cf529"), 0, 0, "", "f06af967-624f-400f-b7c7-d141c618c444", "construction.corp@example.com", null, true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEOeVqGk8gB3w0edr6g+ieQRaExjKNUfn7PVUs1Z3gCq2G50oEw0h584WYAk9F4bc3A==", "0987654321", true, "0403fba7-7d15-43f5-9276-87f0938304c8", false, "construction.corp@example.com" },
                    { new Guid("aa107af0-163f-420c-8d6e-0fb92c5a171a"), 0, 0, null, "d1dfa2e7-a504-4ee5-b46b-56d35078c713", "eve.adams@example.com", null, true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAENgVPp5TMJdDof5XG42OoZG9XlGfhkoFuWw3dmuh0FN1jp4AWmcVIxnUirZkuL/MgQ==", "0905678901", true, "8025a398-cdd3-4cdf-a39d-5404701a6cbc", false, "eve.adams@example.com" },
                    { new Guid("aaffc554-13f9-4fc1-9ca7-6d77c2c722ca"), 0, 0, "", "826c6e7a-4ea5-42ea-bf5a-4a78ea9e0d95", "michael.smith@example.com", null, true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEIeTpf4PyFWuu1c2+75bBV+5UUanlnxPk6FB+qcVK7VzB2IPFMm7jge39UvEKO8aNQ==", "0123456789", true, "d7729ef7-0a11-42d1-9cc7-9346f7e408ce", false, "michael.smith@example.com" },
                    { new Guid("b00b4699-03a9-4a14-be65-5d3628982ad0"), 0, 0, null, "ce4f0a0f-f809-4e00-8554-172f9d138a38", "alice.smith@example.com", null, true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEPkfxV5fnqod8irk+sSWLXRiP84pa9PPnIJ0b4m8KpzGZtw/B/VTLFIYOZCS+T9UFA==", "0901234567", true, "c07f91cd-fe0a-4f6d-883e-3d7ed0d8d6e2", false, "alice.smith@example.com" },
                    { new Guid("d914a8aa-0f42-4154-af66-1fb3d6b5e0ea"), 0, 0, "", "444299e6-2fc6-4bef-8f26-851fe05093ac", "david.brown@example.com", null, true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEFkQgZjjngz8RURD4+zKUsGFzUUehKRXrTa7YfaA5UdLS+kA30xs/mAartoAM96UIQ==", "0123456789", true, "f2c2c4f0-1575-4476-8b24-1e70e0a08941", false, "david.brown@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("1dc235c7-50bb-4b64-b438-e652a7511102"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5993), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5995), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("897d5aeb-1e88-431d-9eda-2d3753e6be3e"), "A fully equipped fitness gym.", "Gym" },
                    { new Guid("c3a302b1-48f6-41e9-9a75-632d38820ff6"), "A large outdoor swimming pool.", "Swimming Pool" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("080948bc-d801-4372-8323-57ad08c53be5"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("5e94f9c6-3a60-49a5-b19f-c581e0df3e17"), "11:00 AM", "10:00 AM" },
                    { new Guid("6f9d59b6-25b4-4fd8-abae-df1b36ee9566"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("2c57eb93-cad3-4d95-8214-0a5278efc5a2"), new Guid("c33b0228-0a47-484b-84a0-4a74e7813fa2"), new Guid("897d5aeb-1e88-431d-9eda-2d3753e6be3e") },
                    { new Guid("c0f79ab6-b30e-42ab-bedb-1e8c2f5684a1"), new Guid("e8b3a5f9-ac10-4ea1-b712-07d54ab3a440"), new Guid("c3a302b1-48f6-41e9-9a75-632d38820ff6") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0b37215c-04ae-4479-8c31-c345524ce832"), new Guid("e8b3a5f9-ac10-4ea1-b712-07d54ab3a440"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5591), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("95b6f76a-d8c6-4c22-a126-4617a0486692"), new Guid("e8b3a5f9-ac10-4ea1-b712-07d54ab3a440"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5562), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5572), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("31ee6e87-beac-4e9f-8123-ddac2b19d0a1"), new Guid("b00b4699-03a9-4a14-be65-5d3628982ad0"), new Guid("e8b3a5f9-ac10-4ea1-b712-07d54ab3a440"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5749), new TimeSpan(0, 7, 0, 0, 0)), 0 },
                    { new Guid("9b61b4ff-227a-43c8-956d-849a5f7b8583"), new Guid("12badf9e-9231-4c65-912e-6b24a4c9f5d9"), new Guid("c33b0228-0a47-484b-84a0-4a74e7813fa2"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 7, 0, 0, 0)), 1 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("9a1c0422-adf7-48c4-b198-a29972de2cf2"), new Guid("d914a8aa-0f42-4154-af66-1fb3d6b5e0ea"), new Guid("e8b3a5f9-ac10-4ea1-b712-07d54ab3a440") },
                    { new Guid("cc80ba19-fa51-4744-a218-86b698d04809"), new Guid("d914a8aa-0f42-4154-af66-1fb3d6b5e0ea"), new Guid("e8b3a5f9-ac10-4ea1-b712-07d54ab3a440") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("c6ea3e1b-8a6b-4422-9ba9-cfe1f6174761"), new Guid("a75d0e8d-c293-4778-a22b-54c3476cf529"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3055), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3056), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("89bff93c-6fe1-40e4-ac39-2984053210ad"), new Guid("e8b3a5f9-ac10-4ea1-b712-07d54ab3a440"), new Guid("d914a8aa-0f42-4154-af66-1fb3d6b5e0ea"), new DateTimeOffset(new DateTime(2024, 10, 11, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5957), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5955), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5953), new TimeSpan(0, 7, 0, 0, 0)), new Guid("aa107af0-163f-420c-8d6e-0fb92c5a171a"), "Schedule a viewing for the Skyline Apartment.", new Guid("a75d0e8d-c293-4778-a22b-54c3476cf529"), new Guid("6f9d59b6-25b4-4fd8-abae-df1b36ee9566"), new Guid("3f4f8db1-1192-4aa2-85ef-c2e8e835732b"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5955), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("fd05348b-d4b8-4ac8-b03e-2977df942409"), new Guid("3f4f8db1-1192-4aa2-85ef-c2e8e835732b") },
                    { new Guid("faeaf865-4f97-4699-b6e1-9dee37aaeb55"), new Guid("824ca70b-d2fa-4635-aa84-81cb8f5e297d") },
                    { new Guid("f6f64fa4-c777-4f1b-9062-bc9387390f66"), new Guid("9319f7ec-0a85-4169-8704-068fb6dfe99c") },
                    { new Guid("123ec8b6-69c2-488c-9084-d938bec2d562"), new Guid("a75d0e8d-c293-4778-a22b-54c3476cf529") },
                    { new Guid("0ac58a97-d635-4bba-9595-bedf1ac080b6"), new Guid("aaffc554-13f9-4fc1-9ca7-6d77c2c722ca") },
                    { new Guid("8ac9c214-a87a-4468-9a62-b2a6a81eb648"), new Guid("d914a8aa-0f42-4154-af66-1fb3d6b5e0ea") }
                });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("7ad76cf4-38f0-44ee-8d85-32f623621995"), new Guid("43141c91-7b8b-4c2d-a22a-98af102c69e1"), new Guid("e8b3a5f9-ac10-4ea1-b712-07d54ab3a440"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6026), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6029), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 11, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6030), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("07ba2812-ad2d-4963-8098-008d51ea9b1f"), new Guid("b00b4699-03a9-4a14-be65-5d3628982ad0"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6167), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" },
                    { new Guid("502b8991-2994-44b7-ba8e-4498288257b1"), new Guid("12badf9e-9231-4c65-912e-6b24a4c9f5d9"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6174), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("16fe60cf-8d2a-473d-987e-63470cb2a287"), new Guid("12badf9e-9231-4c65-912e-6b24a4c9f5d9"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6250), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("080948bc-d801-4372-8323-57ad08c53be5"), new Guid("c25ca796-67e1-460c-8e30-c28036abe42e"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("f54c70de-21f2-4bb1-912c-0a0272bd9135"), new Guid("43141c91-7b8b-4c2d-a22a-98af102c69e1"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6241), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("080948bc-d801-4372-8323-57ad08c53be5"), new Guid("3411d126-bca2-4b17-9389-e87d776afca1"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6241), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("3e571709-1809-40d2-adb3-3d2993df37ce"), new Guid("12badf9e-9231-4c65-912e-6b24a4c9f5d9"), new Guid("e8b3a5f9-ac10-4ea1-b712-07d54ab3a440"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5863), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 10, 11, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5863), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." },
                    { new Guid("cbbdea5a-537b-42e0-b30b-ed836b5368d8"), new Guid("b00b4699-03a9-4a14-be65-5d3628982ad0"), new Guid("c33b0228-0a47-484b-84a0-4a74e7813fa2"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5874), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 10, 11, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5875), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("6b91cfe3-6545-4840-b4fe-c3a85f86ee8b"), new Guid("3f4f8db1-1192-4aa2-85ef-c2e8e835732b"), new Guid("c33b0228-0a47-484b-84a0-4a74e7813fa2"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5656), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5657), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" },
                    { new Guid("99a13a98-14a0-47c8-8e4a-797370b59598"), new Guid("3f4f8db1-1192-4aa2-85ef-c2e8e835732b"), new Guid("e8b3a5f9-ac10-4ea1-b712-07d54ab3a440"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5650), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5651), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("d1d5c65e-9518-4960-b30c-90afc4b3d159"), new Guid("824ca70b-d2fa-4635-aa84-81cb8f5e297d"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6134), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1dc235c7-50bb-4b64-b438-e652a7511102"), new Guid("7ad76cf4-38f0-44ee-8d85-32f623621995"), "45000", new DateTimeOffset(new DateTime(2024, 10, 15, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6135), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6136), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("9a04f9cd-d0ce-4ab8-9a61-f382c9e4688d"), null, new Guid("c6ea3e1b-8a6b-4422-9ba9-cfe1f6174761"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3241), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3242), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("c1171e81-2bfa-46c0-bed1-dd921fd2e978"), null, new Guid("c6ea3e1b-8a6b-4422-9ba9-cfe1f6174761"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3247), new TimeSpan(0, 7, 0, 0, 0)), "1,000,000 - 2,000,000 USD", "A luxurious penthouse suite with stunning views.", "Penthouse Suite", 0, new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("761c360c-2f20-492a-a071-59b89a4959ea"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6096), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7ad76cf4-38f0-44ee-8d85-32f623621995"), 0, new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6098), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(6097), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("334a8289-d663-4cb3-af14-d25931328a27"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5710), new TimeSpan(0, 7, 0, 0, 0)), new Guid("99a13a98-14a0-47c8-8e4a-797370b59598") },
                    { new Guid("9b503816-fd05-4496-a1be-73d1d00f1910"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(5716), new TimeSpan(0, 7, 0, 0, 0)), new Guid("6b91cfe3-6545-4840-b4fe-c3a85f86ee8b") }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[,]
                {
                    { new Guid("24d563d4-155c-4098-8994-30e3f5636832"), new Guid("9a04f9cd-d0ce-4ab8-9a61-f382c9e4688d"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3317), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("4cb96fbd-f373-4af9-969a-63ae2876dc6c"), new Guid("c1171e81-2bfa-46c0-bed1-dd921fd2e978"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3321), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartmentApartments",
                columns: new[] { "Id", "ApartmentID", "ProjectApartmentID" },
                values: new object[] { new Guid("2eb08730-7015-4d71-8a8a-a19a325e7193"), new Guid("c33b0228-0a47-484b-84a0-4a74e7813fa2"), new Guid("9a04f9cd-d0ce-4ab8-9a61-f382c9e4688d") });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[,]
                {
                    { new Guid("902c5403-56be-4a13-bc52-3cb7c4d3f202"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3383), new TimeSpan(0, 7, 0, 0, 0)), "Image of the penthouse suite", "Penthouse Suite Image", new Guid("c1171e81-2bfa-46c0-bed1-dd921fd2e978"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3384), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/penthouse-suite.jpg" },
                    { new Guid("9fd7d874-1160-427f-8aff-cfa8b4b58ea0"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3378), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("9a04f9cd-d0ce-4ab8-9a61-f382c9e4688d"), new DateTimeOffset(new DateTime(2024, 10, 10, 8, 50, 7, 471, DateTimeKind.Unspecified).AddTicks(3380), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("2c57eb93-cad3-4d95-8214-0a5278efc5a2"));

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("c0f79ab6-b30e-42ab-bedb-1e8c2f5684a1"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("0b37215c-04ae-4479-8c31-c345524ce832"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("95b6f76a-d8c6-4c22-a126-4617a0486692"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("31ee6e87-beac-4e9f-8123-ddac2b19d0a1"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("9b61b4ff-227a-43c8-956d-849a5f7b8583"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("9a1c0422-adf7-48c4-b198-a29972de2cf2"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("cc80ba19-fa51-4744-a218-86b698d04809"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: new Guid("89bff93c-6fe1-40e4-ac39-2984053210ad"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fd05348b-d4b8-4ac8-b03e-2977df942409"), new Guid("3f4f8db1-1192-4aa2-85ef-c2e8e835732b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("faeaf865-4f97-4699-b6e1-9dee37aaeb55"), new Guid("824ca70b-d2fa-4635-aa84-81cb8f5e297d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f6f64fa4-c777-4f1b-9062-bc9387390f66"), new Guid("9319f7ec-0a85-4169-8704-068fb6dfe99c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("123ec8b6-69c2-488c-9084-d938bec2d562"), new Guid("a75d0e8d-c293-4778-a22b-54c3476cf529") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0ac58a97-d635-4bba-9595-bedf1ac080b6"), new Guid("aaffc554-13f9-4fc1-9ca7-6d77c2c722ca") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8ac9c214-a87a-4468-9a62-b2a6a81eb648"), new Guid("d914a8aa-0f42-4154-af66-1fb3d6b5e0ea") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a7670d9-6c4f-4f31-80a6-dd0bc888840b"));

            migrationBuilder.DeleteData(
                table: "DepositCancel",
                keyColumn: "DepositCancelID",
                keyValue: new Guid("d1d5c65e-9518-4960-b30c-90afc4b3d159"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("07ba2812-ad2d-4963-8098-008d51ea9b1f"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("502b8991-2994-44b7-ba8e-4498288257b1"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("16fe60cf-8d2a-473d-987e-63470cb2a287"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("f54c70de-21f2-4bb1-912c-0a0272bd9135"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("24d563d4-155c-4098-8994-30e3f5636832"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("4cb96fbd-f373-4af9-969a-63ae2876dc6c"));

            migrationBuilder.DeleteData(
                table: "ProjectApartmentApartments",
                keyColumn: "Id",
                keyValue: new Guid("2eb08730-7015-4d71-8a8a-a19a325e7193"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("902c5403-56be-4a13-bc52-3cb7c4d3f202"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("9fd7d874-1160-427f-8aff-cfa8b4b58ea0"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("3e571709-1809-40d2-adb3-3d2993df37ce"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("cbbdea5a-537b-42e0-b30b-ed836b5368d8"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("5e94f9c6-3a60-49a5-b19f-c581e0df3e17"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: new Guid("761c360c-2f20-492a-a071-59b89a4959ea"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("334a8289-d663-4cb3-af14-d25931328a27"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("9b503816-fd05-4496-a1be-73d1d00f1910"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0ac58a97-d635-4bba-9595-bedf1ac080b6"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("123ec8b6-69c2-488c-9084-d938bec2d562"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8ac9c214-a87a-4468-9a62-b2a6a81eb648"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f6f64fa4-c777-4f1b-9062-bc9387390f66"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("faeaf865-4f97-4699-b6e1-9dee37aaeb55"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fd05348b-d4b8-4ac8-b03e-2977df942409"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12badf9e-9231-4c65-912e-6b24a4c9f5d9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("824ca70b-d2fa-4635-aa84-81cb8f5e297d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9319f7ec-0a85-4169-8704-068fb6dfe99c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa107af0-163f-420c-8d6e-0fb92c5a171a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aaffc554-13f9-4fc1-9ca7-6d77c2c722ca"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b00b4699-03a9-4a14-be65-5d3628982ad0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d914a8aa-0f42-4154-af66-1fb3d6b5e0ea"));

            migrationBuilder.DeleteData(
                table: "DepositCancelTypes",
                keyColumn: "DepositCancelTypeID",
                keyValue: new Guid("1dc235c7-50bb-4b64-b438-e652a7511102"));

            migrationBuilder.DeleteData(
                table: "DepositRequest",
                keyColumn: "DepositID",
                keyValue: new Guid("7ad76cf4-38f0-44ee-8d85-32f623621995"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("897d5aeb-1e88-431d-9eda-2d3753e6be3e"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("c3a302b1-48f6-41e9-9a75-632d38820ff6"));

            migrationBuilder.DeleteData(
                table: "NotificationTypes",
                keyColumn: "NotificationTypeID",
                keyValue: new Guid("080948bc-d801-4372-8323-57ad08c53be5"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("9a04f9cd-d0ce-4ab8-9a61-f382c9e4688d"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("c1171e81-2bfa-46c0-bed1-dd921fd2e978"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("6f9d59b6-25b4-4fd8-abae-df1b36ee9566"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("6b91cfe3-6545-4840-b4fe-c3a85f86ee8b"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("99a13a98-14a0-47c8-8e4a-797370b59598"));

            migrationBuilder.DeleteData(
                table: "ApartmentProjectProvider",
                keyColumn: "ApartmentProjectProviderID",
                keyValue: new Guid("c6ea3e1b-8a6b-4422-9ba9-cfe1f6174761"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("c33b0228-0a47-484b-84a0-4a74e7813fa2"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("e8b3a5f9-ac10-4ea1-b712-07d54ab3a440"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3f4f8db1-1192-4aa2-85ef-c2e8e835732b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("43141c91-7b8b-4c2d-a22a-98af102c69e1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a75d0e8d-c293-4778-a22b-54c3476cf529"));

            migrationBuilder.DropColumn(
                name: "EmailConfirmationOtp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OtpExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "ApartmentName", "ApartmentStatus", "ApartmentType", "CreatedDate", "Description", "UpdatedDate", "address", "area", "direction", "expiryDate", "location", "numberOfRooms", "pricePerSquareMeter", "recommendedPrice" },
                values: new object[,]
                {
                    { new Guid("5e21ee98-0a9b-4a35-99cc-d11345de8ace"), "Ocean View Apartment", 1, 0, new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4461), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4481), new TimeSpan(0, 7, 0, 0, 0)), "456 Ocean Drive, Coastal City", "1800 sqft", "South-West", new DateTimeOffset(new DateTime(2027, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4483), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", "4", "3500 USD", "650,000 USD" },
                    { new Guid("ae2025dc-07f1-4320-948b-0349dc5c8f4f"), "Skyline Apartment", 0, 1, new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4424), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4425), new TimeSpan(0, 7, 0, 0, 0)), "123 Skyline Road, New City", "1500 sqft", "North-East", new DateTimeOffset(new DateTime(2029, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4429), new TimeSpan(0, 7, 0, 0, 0)), "City Center", "3", "3000 USD", "450,000 USD" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("17837217-f1b8-4b52-b906-044ab60198a8"), null, "Staff", "STAFF" },
                    { new Guid("4020efa4-830b-47ac-b09a-9f3081aa4b30"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("4730e6d5-153e-40ea-a147-d6466f81f2e7"), null, "Admin", "ADMIN" },
                    { new Guid("bc65d853-de55-4084-be18-cdba48130b5c"), null, "Management", "MANAGEMENT" },
                    { new Guid("d43aa731-0cf1-47b5-86f5-ffadd1deae95"), null, "Customer", "CUSTOMER" },
                    { new Guid("d83231cb-bb0b-444d-a59f-d35b4e4d74f1"), null, "Apartment Owner", "APARTMENT OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("24c65aeb-d5a0-490f-81d7-54d23ea4cf89"), 0, 0, null, "ceda9182-6f1b-435c-a533-28d0cd00e9d0", "diana.prince@example.com", true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBxqeCvB9lJ7CpzEzcu16wx3OKC16Q/zQ09S5eXcYX0a449TF4XkHRhUNB2HYycyuA==", "0904567890", true, "3937aeb4-6ba4-4960-b20e-5305e31e578e", false, "diana.prince@example.com" },
                    { new Guid("65890ffc-2a1c-4eab-994c-88de6f34323b"), 0, 0, null, "7072598b-3d63-479d-9606-6c304e0ed7f6", "johndoe@example.com", true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDZVtrw7hQkXGI6nYRP/Albct73/LbLuwYlJqNYxc/RemTwtSwm85AXtS1yuyDCVLQ==", "123456789", true, "9ef97a5d-750f-4f5e-b923-6b126927d1c5", false, "johndoe@example.com" },
                    { new Guid("68ea9396-2bf9-4229-9a41-957bace62427"), 0, 0, null, "886e1327-25c6-4841-af4b-267582f279cb", "charlie.brown@example.com", true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHbmM+pSoVJPNKIOHlFmFqhC0MinyzLKI9H8lJjPLPyEJCPeH7zASxAI0fKzaNE3mQ==", "0903456789", true, "38d2dd4b-8bff-492e-bc27-8f6528647ad8", false, "charlie.brown@example.com" },
                    { new Guid("7fda1553-cfc4-49de-97b2-b8f12c018435"), 0, 0, "", "33c12acc-a98d-467b-811a-a622d3d78692", "alice.johnson@example.com", true, false, null, "Alice Johnson", "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJWYmDMuA/bscEDim2gUN9PIhRGhaVQ18cUcnC7lydeiEpT5HhHXJ+7Qbmc5sQTB2A==", "0987654321", true, "9a31c8bf-3d38-4685-b12b-0c6dc042f85a", false, "alice.johnson@example.com" },
                    { new Guid("89039655-c3ab-49e1-aa74-c174432ce194"), 0, 0, null, "130c9049-e446-4417-bb06-fe22a6bc5330", "alice.smith@example.com", true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGZOJc6ZYPVesXRlwW/MSSkD57uVhvAaiqx5d7I64xx4KlE2EWP/v12J/0qPrrkHDg==", "0901234567", true, "bbc71e0a-6a9b-4ae6-96ca-de7131cb7d1e", false, "alice.smith@example.com" },
                    { new Guid("cb3c19e9-3cf0-4249-bf6a-8f09f32e44d4"), 0, 0, null, "a9459788-d6af-4cda-add6-9d46c150e1c5", "eve.adams@example.com", true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFe9UKIzwy5rpiwjQ2fudqEwLoJjZq4FudRyV/h5Ztb1/siEfsz0Ky7ljQ7VTv5cOA==", "0905678901", true, "1ca416df-4ff0-42e5-8133-b9053ad6fee5", false, "eve.adams@example.com" },
                    { new Guid("cb479253-ad6d-40ea-8791-d6c8900b9cc5"), 0, 0, "", "15d79eee-1cc2-4c81-9276-260df1f4e96e", "michael.smith@example.com", true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJg+A8CcnMJI8YXqWNczTnBep9KGN31p501akLA0ThoePlsIGIshIUFNOSWqT8ewDQ==", "0123456789", true, "23ccd7e3-61e0-46b3-b08c-1db3f60ccf09", false, "michael.smith@example.com" },
                    { new Guid("cfb31713-8315-402e-8f8d-35b3bb12db40"), 0, 0, null, "9c8443e6-8a4f-4667-a7a5-4b4325dfa48b", "bob.johnson@example.com", true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEErSEA38CpwygfF7ppC/kK6hqKmw6RT+bOkS9kCNchwtZOaa2KQLE2yW71pNrbHjw==", "0902345678", true, "ea5ab181-bef5-44ea-bcce-614d07742b02", false, "bob.johnson@example.com" },
                    { new Guid("cff98ac2-3659-4f8f-b140-859b39712e39"), 0, 0, "", "78b32004-3059-4f4c-a04a-75770e52db75", "construction.corp@example.com", true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMzPAfJsG+IAzwn2I7oyZRRkAH7XFF1kb1RRld8lxdZxGRr1bhjfCB25WpxfZu/ZsQ==", "0987654321", true, "151b9d1a-2638-4572-bd35-419acd5ec1ab", false, "construction.corp@example.com" },
                    { new Guid("fb16403c-b362-41cf-ba5f-ffe9f6d4954e"), 0, 0, "", "f8e98791-95ae-4f30-a107-027a6ce9da85", "quansongngu13@gmail.com", true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", "AQAAAAIAAYagAAAAEN2xsJo/4RSKemVI3ugDrCqCh2Cth+Lf2q6cH5E/3rzsLZv6TE8eZI51c6+n+zCsKg==", "0949035672", true, "5193c33c-fba8-40b0-8904-f4fef8d7bbcb", false, "quansongngu13@gmail.com" },
                    { new Guid("fe266334-e991-462b-aa3c-8f4360b0fbbc"), 0, 0, "", "47dfed54-2df2-4e2f-8902-c9525353cda0", "david.brown@example.com", true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEON0HuFhqKzkFfVM1FRSNH64KeeEFtN+RrAnG8pf3Yr4LVI/fsXzhSnQkyVmQZelsA==", "0123456789", true, "a59a1ad2-ee96-4782-82f5-ba1c531800d8", false, "david.brown@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("c1f68006-b9c2-4ac3-91fc-ed349ec8259d"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7472), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("263f651d-6d3d-4785-8028-e282e351f03b"), "A fully equipped fitness gym.", "Gym" },
                    { new Guid("8150b2e3-e29d-461c-abdd-61f9d4b5ed66"), "A large outdoor swimming pool.", "Swimming Pool" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("c2e80438-ac50-4281-a7a2-502479c94ded"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("028bda33-7f28-4d13-b283-79ecfa825eab"), "11:00 AM", "10:00 AM" },
                    { new Guid("246c7696-2bc7-4269-908b-a78b4ef2d3de"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("9af2d63d-c337-42f8-b5b6-7887ed62bdd3"), new Guid("ae2025dc-07f1-4320-948b-0349dc5c8f4f"), new Guid("8150b2e3-e29d-461c-abdd-61f9d4b5ed66") },
                    { new Guid("e6588613-4e56-4383-aec5-967c01834fd4"), new Guid("5e21ee98-0a9b-4a35-99cc-d11345de8ace"), new Guid("263f651d-6d3d-4785-8028-e282e351f03b") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("48efe462-2ed7-47fc-9d98-455b3055bf42"), new Guid("ae2025dc-07f1-4320-948b-0349dc5c8f4f"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(6988), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(6996), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("8119810e-507a-4351-852d-cf3a65f3e814"), new Guid("ae2025dc-07f1-4320-948b-0349dc5c8f4f"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("9c0516d9-a843-4167-bb9b-d9a74f72acb5"), new Guid("89039655-c3ab-49e1-aa74-c174432ce194"), new Guid("ae2025dc-07f1-4320-948b-0349dc5c8f4f"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7161), new TimeSpan(0, 7, 0, 0, 0)), 0 },
                    { new Guid("bdfeb4d9-98ab-40ed-b496-4ec4580b42aa"), new Guid("cfb31713-8315-402e-8f8d-35b3bb12db40"), new Guid("5e21ee98-0a9b-4a35-99cc-d11345de8ace"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7172), new TimeSpan(0, 7, 0, 0, 0)), 1 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("05f9ffe9-33df-4da0-aab7-90dbed0d7373"), new Guid("fe266334-e991-462b-aa3c-8f4360b0fbbc"), new Guid("ae2025dc-07f1-4320-948b-0349dc5c8f4f") },
                    { new Guid("e7f102a8-6c8a-4d81-b64f-5ba505423617"), new Guid("fe266334-e991-462b-aa3c-8f4360b0fbbc"), new Guid("ae2025dc-07f1-4320-948b-0349dc5c8f4f") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("e3474303-4d9b-42c3-bf2b-41dd19676528"), new Guid("cff98ac2-3659-4f8f-b140-859b39712e39"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4025), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4026), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("b398a733-de6a-4659-9a87-d27f37c17098"), new Guid("ae2025dc-07f1-4320-948b-0349dc5c8f4f"), new Guid("fe266334-e991-462b-aa3c-8f4360b0fbbc"), new DateTimeOffset(new DateTime(2024, 10, 2, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7427), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7424), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7422), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cb3c19e9-3cf0-4249-bf6a-8f09f32e44d4"), "Schedule a viewing for the Skyline Apartment.", new Guid("cff98ac2-3659-4f8f-b140-859b39712e39"), new Guid("246c7696-2bc7-4269-908b-a78b4ef2d3de"), new Guid("65890ffc-2a1c-4eab-994c-88de6f34323b"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7423), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("17837217-f1b8-4b52-b906-044ab60198a8"), new Guid("65890ffc-2a1c-4eab-994c-88de6f34323b") },
                    { new Guid("bc65d853-de55-4084-be18-cdba48130b5c"), new Guid("7fda1553-cfc4-49de-97b2-b8f12c018435") },
                    { new Guid("d43aa731-0cf1-47b5-86f5-ffadd1deae95"), new Guid("cb479253-ad6d-40ea-8791-d6c8900b9cc5") },
                    { new Guid("4020efa4-830b-47ac-b09a-9f3081aa4b30"), new Guid("cff98ac2-3659-4f8f-b140-859b39712e39") },
                    { new Guid("4730e6d5-153e-40ea-a147-d6466f81f2e7"), new Guid("fb16403c-b362-41cf-ba5f-ffe9f6d4954e") },
                    { new Guid("d83231cb-bb0b-444d-a59f-d35b4e4d74f1"), new Guid("fe266334-e991-462b-aa3c-8f4360b0fbbc") }
                });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("2633dc4d-30d6-4b0e-9eff-197a80c77aaa"), new Guid("68ea9396-2bf9-4229-9a41-957bace62427"), new Guid("ae2025dc-07f1-4320-948b-0349dc5c8f4f"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7532), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7536), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 11, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("5b9e6fb5-05b9-4ee6-a2bf-7108f0b473ef"), new Guid("cfb31713-8315-402e-8f8d-35b3bb12db40"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7696), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" },
                    { new Guid("6a8d5cad-e597-4247-bc13-a3cf7fed7838"), new Guid("89039655-c3ab-49e1-aa74-c174432ce194"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7692), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("00f36679-c457-44ad-961f-2949c6ba7f59"), new Guid("cfb31713-8315-402e-8f8d-35b3bb12db40"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7781), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("c2e80438-ac50-4281-a7a2-502479c94ded"), new Guid("4563af06-145a-44fa-bc63-6d99e84e2f5d"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7782), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a4303a9b-0d62-4ebf-a53c-8092f9922dc3"), new Guid("68ea9396-2bf9-4229-9a41-957bace62427"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7773), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("c2e80438-ac50-4281-a7a2-502479c94ded"), new Guid("537c1374-307b-48a1-87a8-2dbae0745117"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7774), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("bebd7b70-72c4-4e56-b258-6e961e6ab6ca"), new Guid("89039655-c3ab-49e1-aa74-c174432ce194"), new Guid("5e21ee98-0a9b-4a35-99cc-d11345de8ace"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7305), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 10, 2, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7305), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." },
                    { new Guid("c40a880b-4c76-4450-9c56-a358c68226f1"), new Guid("cfb31713-8315-402e-8f8d-35b3bb12db40"), new Guid("ae2025dc-07f1-4320-948b-0349dc5c8f4f"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7293), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 10, 2, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7294), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("575da0ed-4681-4f44-b5a8-5908375d4194"), new Guid("65890ffc-2a1c-4eab-994c-88de6f34323b"), new Guid("ae2025dc-07f1-4320-948b-0349dc5c8f4f"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" },
                    { new Guid("5ece773e-bda6-40ca-9f81-c93aee949a27"), new Guid("65890ffc-2a1c-4eab-994c-88de6f34323b"), new Guid("5e21ee98-0a9b-4a35-99cc-d11345de8ace"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7077), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7078), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("8718b02d-fbe2-42dc-a3fa-c0e5519409b5"), new Guid("7fda1553-cfc4-49de-97b2-b8f12c018435"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 7, 0, 0, 0)), new Guid("c1f68006-b9c2-4ac3-91fc-ed349ec8259d"), new Guid("2633dc4d-30d6-4b0e-9eff-197a80c77aaa"), "45000", new DateTimeOffset(new DateTime(2024, 10, 6, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7655), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7656), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("658285a7-3c69-4261-9e67-a39753ec07ce"), null, new Guid("e3474303-4d9b-42c3-bf2b-41dd19676528"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4242), new TimeSpan(0, 7, 0, 0, 0)), "1,000,000 - 2,000,000 USD", "A luxurious penthouse suite with stunning views.", "Penthouse Suite", 0, new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4243), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("f30507c5-c3e8-4e64-af60-976c35872cdd"), null, new Guid("e3474303-4d9b-42c3-bf2b-41dd19676528"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4226), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4227), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("a878602c-2b53-4d07-a4cc-006d62f9df30"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7607), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2633dc4d-30d6-4b0e-9eff-197a80c77aaa"), 0, new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7610), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7609), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("6244511a-4fa5-49a6-8621-e8562230fb3e"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7124), new TimeSpan(0, 7, 0, 0, 0)), new Guid("575da0ed-4681-4f44-b5a8-5908375d4194") },
                    { new Guid("dfdfa929-615d-4646-93a8-7d83fb1620dd"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(7127), new TimeSpan(0, 7, 0, 0, 0)), new Guid("5ece773e-bda6-40ca-9f81-c93aee949a27") }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[,]
                {
                    { new Guid("206811fd-0df5-47f1-96fa-7b4ccc52a8f3"), new Guid("f30507c5-c3e8-4e64-af60-976c35872cdd"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("20a486e1-2255-4877-b750-72a904118d83"), new Guid("658285a7-3c69-4261-9e67-a39753ec07ce"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4299), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartmentApartments",
                columns: new[] { "Id", "ApartmentID", "ProjectApartmentID" },
                values: new object[] { new Guid("8fdb77d1-af13-4563-b5d8-d86caa3899dc"), new Guid("5e21ee98-0a9b-4a35-99cc-d11345de8ace"), new Guid("f30507c5-c3e8-4e64-af60-976c35872cdd") });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[,]
                {
                    { new Guid("9a257c03-6e7e-4197-87c1-d5556f77fc6e"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("f30507c5-c3e8-4e64-af60-976c35872cdd"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4356), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" },
                    { new Guid("c2eae197-9dc5-4e93-979f-1989a9684f02"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4360), new TimeSpan(0, 7, 0, 0, 0)), "Image of the penthouse suite", "Penthouse Suite Image", new Guid("658285a7-3c69-4261-9e67-a39753ec07ce"), new DateTimeOffset(new DateTime(2024, 10, 1, 19, 26, 9, 905, DateTimeKind.Unspecified).AddTicks(4361), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/penthouse-suite.jpg" }
                });
        }
    }
}
