using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixApartmentv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("1abf731d-dfd2-45ae-8127-f2a85d6e69d4"));

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("4e0d37dd-81ba-400f-81e2-870f4785680b"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("93a6505f-7b89-48f9-be10-8cb44fd9b248"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("bdfc6ead-ad75-4f63-bbe4-e590642578c9"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("387f8566-f76c-483b-ba4f-a51a8d9f2cf1"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("d21b3d3b-bf55-4018-9251-3073b8c0343e"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("482d40d9-11d7-4244-a1ce-7409dae431fb"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("a730c751-9ec5-401d-8e91-0cf871746ede"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: new Guid("31657a63-57ef-4313-bcba-3c6413966265"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0ad69e5e-18fb-4d34-9c9b-8846ee7122e8"), new Guid("10fbe75e-25f7-467e-a373-76bef4c431cd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("59da2386-a3bd-40f4-94fc-245889b6a1e6"), new Guid("684ffc6c-afc2-4418-810c-302821e54785") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("19d6c740-3f29-4755-832d-23e825e87f0a"), new Guid("7dfce141-6b1a-4a2a-91d2-5d08f095038a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c7fe29eb-a13b-4bb8-8733-8338e10e73a9"), new Guid("a0e569a2-831b-4794-9bf0-ca29a14a80ed") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d08069f8-5a91-44f9-a2c7-baf8956ad4b0"), new Guid("abd11fc5-f01f-409a-893a-a908270e6aa0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b256d882-eedb-447a-a6cf-b70d63a7e73d"), new Guid("b651b57d-e424-490b-b004-62f908b873a1") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fc1dd0c5-52bc-4758-bdd5-b6c1710e057c"));

            migrationBuilder.DeleteData(
                table: "DepositCancel",
                keyColumn: "DepositCancelID",
                keyValue: new Guid("876bf326-6f2b-4382-8cc9-7538126046ab"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("44d2a9e7-2bdd-44ef-baff-98ad5567e7cd"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("9f24c5aa-1891-4313-a7ff-29dca957eb88"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("eaa98fba-c46f-4bcb-9d73-f13ef6e8cf42"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("f547656a-1e12-4230-98ac-d2a353a3430d"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("4816064c-9b02-4f8f-907d-dfa4c526b438"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("c5e356f5-c015-4183-998f-329f642e3449"));

            migrationBuilder.DeleteData(
                table: "ProjectApartmentApartments",
                keyColumn: "Id",
                keyValue: new Guid("4a5548e3-ded2-4d2a-95e7-d03377363716"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("338dcd0c-4cac-41b6-9f6f-345ca93cc1fc"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("731891df-2ac5-4243-813a-b74e4ca044df"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("2b72c15b-965c-42b8-92d0-f3f9f33f0181"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("ca39a785-53f7-4718-af7a-8f847f2e2b20"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("2e7804fc-7da3-49d4-92a2-5da302a139b1"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: new Guid("80fb7e43-29bc-48d9-adca-e1ba71e230e2"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("6c817ce1-a65a-4117-80b0-9219a7f6024a"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("c8496aa8-92fb-49bb-b432-ff270fe73177"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0ad69e5e-18fb-4d34-9c9b-8846ee7122e8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("19d6c740-3f29-4755-832d-23e825e87f0a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("59da2386-a3bd-40f4-94fc-245889b6a1e6"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b256d882-eedb-447a-a6cf-b70d63a7e73d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c7fe29eb-a13b-4bb8-8733-8338e10e73a9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d08069f8-5a91-44f9-a2c7-baf8956ad4b0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("10fbe75e-25f7-467e-a373-76bef4c431cd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("684ffc6c-afc2-4418-810c-302821e54785"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6965d918-15d1-4c8b-938e-a9b9e8b99a29"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7dc2dfef-08c4-41b8-82b0-e5857d7fdb7e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7dfce141-6b1a-4a2a-91d2-5d08f095038a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0e569a2-831b-4794-9bf0-ca29a14a80ed"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2a3aaf4-585b-4537-a5a1-6caccb3b8ffb"));

            migrationBuilder.DeleteData(
                table: "DepositCancelTypes",
                keyColumn: "DepositCancelTypeID",
                keyValue: new Guid("2f029bb1-6038-4665-a9f6-fa2193a9979b"));

            migrationBuilder.DeleteData(
                table: "DepositRequest",
                keyColumn: "DepositID",
                keyValue: new Guid("f0ac06a7-a136-4c88-b44d-024ad23dc7fc"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("8fd3b12d-5cc8-42a3-93da-181fd78993de"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("e63d21df-57b1-4b88-9d15-576f0b9414b0"));

            migrationBuilder.DeleteData(
                table: "NotificationTypes",
                keyColumn: "NotificationTypeID",
                keyValue: new Guid("33f77857-5720-480a-875f-fd002585ae22"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("2a412fbb-0290-4ad6-922d-fa1cf1361d84"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("b75c86fc-1ac5-49de-84cb-a370bbd75c0c"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("4c3ac4ef-eb1e-419c-8e7a-e222583432a0"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("a5d232fb-f550-4408-b3e2-5e1d28f64c6e"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("e1689270-2733-4e1c-894e-a303a942657b"));

            migrationBuilder.DeleteData(
                table: "ApartmentProjectProvider",
                keyColumn: "ApartmentProjectProviderID",
                keyValue: new Guid("880bdc5f-115b-4812-88ac-772aec624508"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("07d04e38-fe89-4a98-82a5-258bd52c52c1"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("38a7497e-0e69-4fdc-bd4f-f4a6db10aca4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("527b6527-65f4-4e5f-a181-3f77e9ab941a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b651b57d-e424-490b-b004-62f908b873a1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("abd11fc5-f01f-409a-893a-a908270e6aa0"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Area",
                table: "Apartments",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfBathrooms",
                table: "Apartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "NumberOfBathrooms",
                table: "Apartments");

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Apartments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "Address", "ApartmentName", "ApartmentStatus", "ApartmentType", "Area", "BalconyDirection", "CreatedDate", "Description", "Direction", "ExpiryDate", "Location", "NumberOfRooms", "PricePerSquareMeter", "RecommendedPrice", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("07d04e38-fe89-4a98-82a5-258bd52c52c1"), "123 Skyline Road, New City", "Skyline Apartment", 0, 1, "150.00 m2", 5, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(2196), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", 1, new DateTimeOffset(new DateTime(2029, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(2205), new TimeSpan(0, 7, 0, 0, 0)), "City Center", 3, 70000000m, 10000000000m, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(2198), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("38a7497e-0e69-4fdc-bd4f-f4a6db10aca4"), "456 Ocean Drive, Coastal City", "Ocean View Apartment", 1, 2, "170.00 m2", 8, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(2241), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", 2, new DateTimeOffset(new DateTime(2027, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4479), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", 4, 90000000m, 15000000000m, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4469), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0ad69e5e-18fb-4d34-9c9b-8846ee7122e8"), null, "Apartment Owner", "APARTMENT OWNER" },
                    { new Guid("19d6c740-3f29-4755-832d-23e825e87f0a"), null, "Customer", "CUSTOMER" },
                    { new Guid("59da2386-a3bd-40f4-94fc-245889b6a1e6"), null, "Admin", "ADMIN" },
                    { new Guid("b256d882-eedb-447a-a6cf-b70d63a7e73d"), null, "Staff", "STAFF" },
                    { new Guid("c7fe29eb-a13b-4bb8-8733-8338e10e73a9"), null, "Management", "MANAGEMENT" },
                    { new Guid("d08069f8-5a91-44f9-a2c7-baf8956ad4b0"), null, "Project Provider", "PROJECT PROVIDER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmationOtp", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OtpExpiryTime", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("10fbe75e-25f7-467e-a373-76bef4c431cd"), 0, 0, "", "e3b5cfcf-444f-43fb-835e-cf393a2c5c83", "david.brown@example.com", null, true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEC/BHX7Jlu7zWG2hiB2dZWC2tyH7B9tyWikwt4fLH9WH/0/ffW344hAnyHEUjIvDLw==", "0123456789", true, "79699b18-f007-4348-8a27-506b95c58cc6", false, "david.brown@example.com" },
                    { new Guid("527b6527-65f4-4e5f-a181-3f77e9ab941a"), 0, 0, null, "b819ec3e-ae50-4a42-963b-da2852cc3a59", "charlie.brown@example.com", null, true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAELFq7W7YRPLwe0V9+JxAdnyr5E8muMHmA08UsN2yLSz/zeb5oDb02ZpieMmAQ7CwmA==", "0903456789", true, "233c893b-9747-4382-af2b-faedff157111", false, "charlie.brown@example.com" },
                    { new Guid("684ffc6c-afc2-4418-810c-302821e54785"), 0, 0, "", "7a09fc4e-2fb1-4f49-a672-c5135a4e034c", "quansongngu13@gmail.com", null, true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", null, "AQAAAAIAAYagAAAAEAQ+LDyPlRHSLWkH+2pygVEZtEnDXcyDwaSuQWLYAOn7/BSAjYUf4RY9wY2syrfn0Q==", "0949035672", true, "56bb6166-8eb5-47ee-a7c2-bcadc8b059aa", false, "quansongngu13@gmail.com" },
                    { new Guid("6965d918-15d1-4c8b-938e-a9b9e8b99a29"), 0, 0, null, "57ca9d46-3f8d-4ea5-85e6-e7900cb19126", "alice.smith@example.com", null, true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEH0khyHcXjQVD4c2PxZAGJl9hVnJK6WPVpEOj7WxgPxIhPevxxoH8wsJbNABEZq6+Q==", "0901234567", true, "4862fc3e-92f5-4eab-a9d1-d67ba1213086", false, "alice.smith@example.com" },
                    { new Guid("7dc2dfef-08c4-41b8-82b0-e5857d7fdb7e"), 0, 0, null, "86ad0b5c-01a7-4774-a780-46782308cdf8", "eve.adams@example.com", null, true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEByA15Ef+J4K7dw3I2BIDwO9PkIECzVul2s7V6LU3nQjOx549EpBKiZcOErIhx9hVQ==", "0905678901", true, "dee8d6f6-7f3e-4703-a021-081b32b05e9b", false, "eve.adams@example.com" },
                    { new Guid("7dfce141-6b1a-4a2a-91d2-5d08f095038a"), 0, 0, "", "c56819b3-c0b8-4ff3-8e0f-7122452b8692", "michael.smith@example.com", null, true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEJDk8fBeU68DCv3SKtmQzzB3slPxDbU7RthJ9UpeaXUfBm5YBOAlUYYSTK6/VVJCLg==", "0123456789", true, "ab140592-db4c-4afb-a7b3-dfc6d9592145", false, "michael.smith@example.com" },
                    { new Guid("a0e569a2-831b-4794-9bf0-ca29a14a80ed"), 0, 0, "", "0dedc27c-9592-4130-adbe-fb5e14582187", "alice.johnson@example.com", null, true, false, null, "Alice Johnson", "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEO7Kj2CiiRag2fNUUZDCRm6W8hqvIt3114n8XQcAlKc9sqLXvfg4BV5G2KbnuTggNg==", "0987654321", true, "5ef75b81-fe62-477c-a844-703cf6d119e1", false, "alice.johnson@example.com" },
                    { new Guid("abd11fc5-f01f-409a-893a-a908270e6aa0"), 0, 0, "", "554e9800-a216-449b-984b-fc25b4e68c64", "construction.corp@example.com", null, true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEI+AajgrkUWbEQ+cNBTMCnPPC2HkjgPYVRtbEMdx50LV73GabZCeLioRCU53iyARlg==", "0987654321", true, "573d3363-b2b5-4878-b2e8-bc973af17c30", false, "construction.corp@example.com" },
                    { new Guid("b651b57d-e424-490b-b004-62f908b873a1"), 0, 0, null, "5b309be0-8e86-4bf7-8da8-6951a10cd576", "johndoe@example.com", null, true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEI7fCkz3Q5FMyuBMIzS7e083IQyf7fPtyJywQ9iP2rjxKbATL36YAv2tIkzJ0Xffhw==", "123456789", true, "3f9bf8aa-5409-410e-9c70-d56e1039f6ab", false, "johndoe@example.com" },
                    { new Guid("e2a3aaf4-585b-4537-a5a1-6caccb3b8ffb"), 0, 0, null, "ad3f0c40-3fe7-44d5-8891-3ed0186b3e10", "bob.johnson@example.com", null, true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEFGTJ9zB/GBE8cw4/jv+LQC1oZMi9R1yBPnY+gJHJJcPLo+M4uzGEVbHx1qLJu/hXQ==", "0902345678", true, "41047095-e79d-4744-acbe-041107cd8498", false, "bob.johnson@example.com" },
                    { new Guid("fc1dd0c5-52bc-4758-bdd5-b6c1710e057c"), 0, 0, null, "766ca634-9ccd-49ed-8e80-953ad518ac0c", "diana.prince@example.com", null, true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAECqdOC9cUX+malfC0gsQIMx0SrFxgblLqk+dz3gNWcbGKtO90w9izCx1cj/38cjjBw==", "0904567890", true, "747561ab-94f6-486d-9cbe-7cbae657c3be", false, "diana.prince@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("2f029bb1-6038-4665-a9f6-fa2193a9979b"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5290), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5291), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("8fd3b12d-5cc8-42a3-93da-181fd78993de"), "A fully equipped fitness gym.", "Gym" },
                    { new Guid("e63d21df-57b1-4b88-9d15-576f0b9414b0"), "A large outdoor swimming pool.", "Swimming Pool" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("33f77857-5720-480a-875f-fd002585ae22"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("2e7804fc-7da3-49d4-92a2-5da302a139b1"), "11:00 AM", "10:00 AM" },
                    { new Guid("4c3ac4ef-eb1e-419c-8e7a-e222583432a0"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("1abf731d-dfd2-45ae-8127-f2a85d6e69d4"), new Guid("07d04e38-fe89-4a98-82a5-258bd52c52c1"), new Guid("e63d21df-57b1-4b88-9d15-576f0b9414b0") },
                    { new Guid("4e0d37dd-81ba-400f-81e2-870f4785680b"), new Guid("38a7497e-0e69-4fdc-bd4f-f4a6db10aca4"), new Guid("8fd3b12d-5cc8-42a3-93da-181fd78993de") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("93a6505f-7b89-48f9-be10-8cb44fd9b248"), new Guid("07d04e38-fe89-4a98-82a5-258bd52c52c1"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4831), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4834), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("bdfc6ead-ad75-4f63-bbe4-e590642578c9"), new Guid("07d04e38-fe89-4a98-82a5-258bd52c52c1"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4839), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4840), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("387f8566-f76c-483b-ba4f-a51a8d9f2cf1"), new Guid("6965d918-15d1-4c8b-938e-a9b9e8b99a29"), new Guid("07d04e38-fe89-4a98-82a5-258bd52c52c1"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4996), new TimeSpan(0, 7, 0, 0, 0)), 0 },
                    { new Guid("d21b3d3b-bf55-4018-9251-3073b8c0343e"), new Guid("e2a3aaf4-585b-4537-a5a1-6caccb3b8ffb"), new Guid("38a7497e-0e69-4fdc-bd4f-f4a6db10aca4"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5003), new TimeSpan(0, 7, 0, 0, 0)), 1 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("482d40d9-11d7-4244-a1ce-7409dae431fb"), new Guid("10fbe75e-25f7-467e-a373-76bef4c431cd"), new Guid("07d04e38-fe89-4a98-82a5-258bd52c52c1") },
                    { new Guid("a730c751-9ec5-401d-8e91-0cf871746ede"), new Guid("10fbe75e-25f7-467e-a373-76bef4c431cd"), new Guid("07d04e38-fe89-4a98-82a5-258bd52c52c1") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("880bdc5f-115b-4812-88ac-772aec624508"), new Guid("abd11fc5-f01f-409a-893a-a908270e6aa0"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(1777), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("31657a63-57ef-4313-bcba-3c6413966265"), new Guid("07d04e38-fe89-4a98-82a5-258bd52c52c1"), new Guid("10fbe75e-25f7-467e-a373-76bef4c431cd"), new DateTimeOffset(new DateTime(2024, 10, 16, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5248), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5210), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5208), new TimeSpan(0, 7, 0, 0, 0)), new Guid("7dc2dfef-08c4-41b8-82b0-e5857d7fdb7e"), "Schedule a viewing for the Skyline Apartment.", new Guid("abd11fc5-f01f-409a-893a-a908270e6aa0"), new Guid("4c3ac4ef-eb1e-419c-8e7a-e222583432a0"), new Guid("b651b57d-e424-490b-b004-62f908b873a1"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0ad69e5e-18fb-4d34-9c9b-8846ee7122e8"), new Guid("10fbe75e-25f7-467e-a373-76bef4c431cd") },
                    { new Guid("59da2386-a3bd-40f4-94fc-245889b6a1e6"), new Guid("684ffc6c-afc2-4418-810c-302821e54785") },
                    { new Guid("19d6c740-3f29-4755-832d-23e825e87f0a"), new Guid("7dfce141-6b1a-4a2a-91d2-5d08f095038a") },
                    { new Guid("c7fe29eb-a13b-4bb8-8733-8338e10e73a9"), new Guid("a0e569a2-831b-4794-9bf0-ca29a14a80ed") },
                    { new Guid("d08069f8-5a91-44f9-a2c7-baf8956ad4b0"), new Guid("abd11fc5-f01f-409a-893a-a908270e6aa0") },
                    { new Guid("b256d882-eedb-447a-a6cf-b70d63a7e73d"), new Guid("b651b57d-e424-490b-b004-62f908b873a1") }
                });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("f0ac06a7-a136-4c88-b44d-024ad23dc7fc"), new Guid("527b6527-65f4-4e5f-a181-3f77e9ab941a"), new Guid("07d04e38-fe89-4a98-82a5-258bd52c52c1"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5325), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5329), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 11, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5331), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("44d2a9e7-2bdd-44ef-baff-98ad5567e7cd"), new Guid("e2a3aaf4-585b-4537-a5a1-6caccb3b8ffb"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5490), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" },
                    { new Guid("9f24c5aa-1891-4313-a7ff-29dca957eb88"), new Guid("6965d918-15d1-4c8b-938e-a9b9e8b99a29"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5484), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("eaa98fba-c46f-4bcb-9d73-f13ef6e8cf42"), new Guid("e2a3aaf4-585b-4537-a5a1-6caccb3b8ffb"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5560), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("33f77857-5720-480a-875f-fd002585ae22"), new Guid("0ca1be25-46f2-4957-85fc-23afb4f1dbf4"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("f547656a-1e12-4230-98ac-d2a353a3430d"), new Guid("527b6527-65f4-4e5f-a181-3f77e9ab941a"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5552), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("33f77857-5720-480a-875f-fd002585ae22"), new Guid("46859210-3a50-4975-960a-b390f8d9c671"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5554), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("2b72c15b-965c-42b8-92d0-f3f9f33f0181"), new Guid("6965d918-15d1-4c8b-938e-a9b9e8b99a29"), new Guid("38a7497e-0e69-4fdc-bd4f-f4a6db10aca4"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5126), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 10, 16, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5127), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." },
                    { new Guid("ca39a785-53f7-4718-af7a-8f847f2e2b20"), new Guid("e2a3aaf4-585b-4537-a5a1-6caccb3b8ffb"), new Guid("07d04e38-fe89-4a98-82a5-258bd52c52c1"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5116), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 10, 16, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5117), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("a5d232fb-f550-4408-b3e2-5e1d28f64c6e"), new Guid("b651b57d-e424-490b-b004-62f908b873a1"), new Guid("38a7497e-0e69-4fdc-bd4f-f4a6db10aca4"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4887), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4888), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" },
                    { new Guid("e1689270-2733-4e1c-894e-a303a942657b"), new Guid("b651b57d-e424-490b-b004-62f908b873a1"), new Guid("07d04e38-fe89-4a98-82a5-258bd52c52c1"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4881), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4882), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("876bf326-6f2b-4382-8cc9-7538126046ab"), new Guid("a0e569a2-831b-4794-9bf0-ca29a14a80ed"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5448), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2f029bb1-6038-4665-a9f6-fa2193a9979b"), new Guid("f0ac06a7-a136-4c88-b44d-024ad23dc7fc"), "45000", new DateTimeOffset(new DateTime(2024, 10, 20, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5449), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5451), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("2a412fbb-0290-4ad6-922d-fa1cf1361d84"), null, new Guid("880bdc5f-115b-4812-88ac-772aec624508"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(1972), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(1975), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("b75c86fc-1ac5-49de-84cb-a370bbd75c0c"), null, new Guid("880bdc5f-115b-4812-88ac-772aec624508"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(1980), new TimeSpan(0, 7, 0, 0, 0)), "1,000,000 - 2,000,000 USD", "A luxurious penthouse suite with stunning views.", "Penthouse Suite", 0, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(1981), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("80fb7e43-29bc-48d9-adca-e1ba71e230e2"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5396), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f0ac06a7-a136-4c88-b44d-024ad23dc7fc"), 0, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5398), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(5398), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("6c817ce1-a65a-4117-80b0-9219a7f6024a"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4954), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e1689270-2733-4e1c-894e-a303a942657b") },
                    { new Guid("c8496aa8-92fb-49bb-b432-ff270fe73177"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(4960), new TimeSpan(0, 7, 0, 0, 0)), new Guid("a5d232fb-f550-4408-b3e2-5e1d28f64c6e") }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[,]
                {
                    { new Guid("4816064c-9b02-4f8f-907d-dfa4c526b438"), new Guid("b75c86fc-1ac5-49de-84cb-a370bbd75c0c"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(2037), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("c5e356f5-c015-4183-998f-329f642e3449"), new Guid("2a412fbb-0290-4ad6-922d-fa1cf1361d84"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(2029), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartmentApartments",
                columns: new[] { "Id", "ApartmentID", "ProjectApartmentID" },
                values: new object[] { new Guid("4a5548e3-ded2-4d2a-95e7-d03377363716"), new Guid("38a7497e-0e69-4fdc-bd4f-f4a6db10aca4"), new Guid("2a412fbb-0290-4ad6-922d-fa1cf1361d84") });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[,]
                {
                    { new Guid("338dcd0c-4cac-41b6-9f6f-345ca93cc1fc"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(2124), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("2a412fbb-0290-4ad6-922d-fa1cf1361d84"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(2125), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" },
                    { new Guid("731891df-2ac5-4243-813a-b74e4ca044df"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(2133), new TimeSpan(0, 7, 0, 0, 0)), "Image of the penthouse suite", "Penthouse Suite Image", new Guid("b75c86fc-1ac5-49de-84cb-a370bbd75c0c"), new DateTimeOffset(new DateTime(2024, 10, 15, 9, 44, 46, 812, DateTimeKind.Unspecified).AddTicks(2134), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/penthouse-suite.jpg" }
                });
        }
    }
}
