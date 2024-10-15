using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixApartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "recommendedPrice",
                table: "Apartments",
                newName: "RecommendedPrice");

            migrationBuilder.RenameColumn(
                name: "pricePerSquareMeter",
                table: "Apartments",
                newName: "PricePerSquareMeter");

            migrationBuilder.RenameColumn(
                name: "numberOfRooms",
                table: "Apartments",
                newName: "NumberOfRooms");

            migrationBuilder.RenameColumn(
                name: "location",
                table: "Apartments",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "expiryDate",
                table: "Apartments",
                newName: "ExpiryDate");

            migrationBuilder.RenameColumn(
                name: "direction",
                table: "Apartments",
                newName: "Direction");

            migrationBuilder.RenameColumn(
                name: "area",
                table: "Apartments",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Apartments",
                newName: "Address");

            migrationBuilder.AlterColumn<decimal>(
                name: "RecommendedPrice",
                table: "Apartments",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerSquareMeter",
                table: "Apartments",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfRooms",
                table: "Apartments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Direction",
                table: "Apartments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "BalconyDirection",
                table: "Apartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BalconyDirection",
                table: "Apartments");

            migrationBuilder.RenameColumn(
                name: "RecommendedPrice",
                table: "Apartments",
                newName: "recommendedPrice");

            migrationBuilder.RenameColumn(
                name: "PricePerSquareMeter",
                table: "Apartments",
                newName: "pricePerSquareMeter");

            migrationBuilder.RenameColumn(
                name: "NumberOfRooms",
                table: "Apartments",
                newName: "numberOfRooms");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Apartments",
                newName: "location");

            migrationBuilder.RenameColumn(
                name: "ExpiryDate",
                table: "Apartments",
                newName: "expiryDate");

            migrationBuilder.RenameColumn(
                name: "Direction",
                table: "Apartments",
                newName: "direction");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Apartments",
                newName: "area");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Apartments",
                newName: "address");

            migrationBuilder.AlterColumn<string>(
                name: "recommendedPrice",
                table: "Apartments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "pricePerSquareMeter",
                table: "Apartments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "numberOfRooms",
                table: "Apartments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "direction",
                table: "Apartments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
