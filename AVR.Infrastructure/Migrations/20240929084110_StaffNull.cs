using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class StaffNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("55e0ee81-e58a-4e4a-9431-f72575f53689"));

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("dd063c7f-7bb7-4aea-aaef-1df0e07585ee"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("42b4c801-5355-49d4-a34c-47c9baaf0264"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("feeaa0de-b08b-456a-b748-25d67f30566d"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("4bba8a95-b267-4193-9cde-ab249794e8ec"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("8be95c4c-a2de-4ebb-a64d-5bad0f01958c"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("c6c42f8b-8424-4a0e-92d5-519b13211309"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("e583a5f3-fde3-410a-beac-802b423aa27c"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: new Guid("6975db10-66c2-46a8-b8b7-3a99ad777082"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("eb3397f0-a597-4349-8644-cce880e97a26"), new Guid("3bae2bac-b3d8-46bc-bc60-59aa6c908aaa") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c9387730-b4b9-4826-9e3e-5d2a8f19164f"), new Guid("461453f7-a527-4df3-bac5-7394fa8f0691") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("097a1b34-0631-4927-8aa8-b73f7bbfd3cf"), new Guid("60039256-f860-480d-8b8c-22587e7fb6fd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("efbe96c4-208e-478a-bbb2-b90abcf71046"), new Guid("693ea210-9a93-4a18-aa8a-30c011ef778c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d178a45e-39bb-45b2-a187-d9610cc7b0e0"), new Guid("88496895-d698-4903-b154-840d3c5adce2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("28d1d9c4-5494-4a44-a498-f707059beebd"), new Guid("e6831c1c-ed9e-44c9-851d-52451fda6c51") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bb41f6af-3812-4601-9e84-e08501b164e7"));

            migrationBuilder.DeleteData(
                table: "DepositCancel",
                keyColumn: "DepositCancelID",
                keyValue: new Guid("89cca6d0-51d4-42d5-975c-3ffcf2dc7fe3"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("6b9935ad-c4eb-43d1-b2ca-93c92e071f90"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("85703689-9854-4156-8c41-cf7373490ad9"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("0109df04-49ac-486e-84d1-892fec4b3166"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("85ec1cc8-1b9e-4f16-b21e-399458924d9a"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("4093fd29-162e-46c3-b8ba-e3a6dea16f49"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("64e5ad4c-feff-4c10-9c61-d58b798ce4da"));

            migrationBuilder.DeleteData(
                table: "ProjectApartmentApartments",
                keyColumn: "Id",
                keyValue: new Guid("d44a9003-a2a4-49a8-8fed-3e1673918d8b"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("2ea80b11-b32f-4994-b444-f649b48bb73c"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("92b9eace-c3f9-46c6-ae6c-8a7729edf6f7"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("197b8a44-5321-4c22-b9d5-ff6d4aecb1e1"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("b99dddb1-e1a1-4b2d-96a2-57414202cede"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("15429fdd-b613-4312-b593-413de71568ae"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: new Guid("9d2c2d5a-86bc-429e-8c4d-4dd91357ed03"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("cd6eac7c-019b-4c7c-9fc7-7d6b37b91f06"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("fe25189e-0f70-43f1-8c36-e5432de01e35"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("097a1b34-0631-4927-8aa8-b73f7bbfd3cf"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("28d1d9c4-5494-4a44-a498-f707059beebd"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c9387730-b4b9-4826-9e3e-5d2a8f19164f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d178a45e-39bb-45b2-a187-d9610cc7b0e0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eb3397f0-a597-4349-8644-cce880e97a26"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("efbe96c4-208e-478a-bbb2-b90abcf71046"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0806bf44-b0f6-41cf-8c81-7507752daabd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("461453f7-a527-4df3-bac5-7394fa8f0691"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("60039256-f860-480d-8b8c-22587e7fb6fd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("693ea210-9a93-4a18-aa8a-30c011ef778c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88496895-d698-4903-b154-840d3c5adce2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8adf7591-c138-4a97-b890-4cc778f2b1a6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cfd6d61e-2946-4b27-a81e-dedce672b921"));

            migrationBuilder.DeleteData(
                table: "DepositCancelTypes",
                keyColumn: "DepositCancelTypeID",
                keyValue: new Guid("fc9d149d-34d5-480d-9ce5-a8f46941dc5b"));

            migrationBuilder.DeleteData(
                table: "DepositRequest",
                keyColumn: "DepositID",
                keyValue: new Guid("579fe412-44da-4086-a8bc-631d60e8d68b"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("33a7ab03-069f-4bd3-861f-74f69d78911b"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("e8aec68e-627d-41fc-8ee8-1fef017c4e29"));

            migrationBuilder.DeleteData(
                table: "NotificationTypes",
                keyColumn: "NotificationTypeID",
                keyValue: new Guid("728c6518-6fd6-4b15-8a08-b41b84706c7a"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("32855b2d-41b3-4d91-b077-9e3f2e9330d5"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("a2c7e609-7c85-41d4-b218-2f70c741fdbd"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("5ef2fa8a-a7a3-4942-a753-af17d405caaf"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("9050603b-375d-40f2-abd3-45937f53641e"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("d12c972d-0a6a-4ef5-8583-323465b9cabe"));

            migrationBuilder.DeleteData(
                table: "ApartmentProjectProvider",
                keyColumn: "ApartmentProjectProviderID",
                keyValue: new Guid("8746b54f-3968-43b1-9b29-81e0a2ad14f0"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a31405f3-f989-409f-ace7-639ca1224b33"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e6831c1c-ed9e-44c9-851d-52451fda6c51"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bae2bac-b3d8-46bc-bc60-59aa6c908aaa"));

            migrationBuilder.AlterColumn<Guid>(
                name: "StaffID",
                table: "Appointment",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "ApartmentName", "ApartmentStatus", "ApartmentType", "CreatedDate", "Description", "UpdatedDate", "address", "area", "direction", "expiryDate", "location", "numberOfRooms", "pricePerSquareMeter", "recommendedPrice" },
                values: new object[,]
                {
                    { new Guid("5a2290b4-2033-443e-89e0-8487e4bb0594"), "Skyline Apartment", 0, 1, new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9513), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9514), new TimeSpan(0, 7, 0, 0, 0)), "123 Skyline Road, New City", "1500 sqft", "North-East", new DateTimeOffset(new DateTime(2029, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9518), new TimeSpan(0, 7, 0, 0, 0)), "City Center", "3", "3000 USD", "450,000 USD" },
                    { new Guid("8843be9c-916c-4db3-a784-140c4d16b898"), "Ocean View Apartment", 1, 0, new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9533), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9534), new TimeSpan(0, 7, 0, 0, 0)), "456 Ocean Drive, Coastal City", "1800 sqft", "South-West", new DateTimeOffset(new DateTime(2027, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9536), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", "4", "3500 USD", "650,000 USD" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("33207d82-ebd8-4955-9602-53cf78b68d7f"), null, "Customer", "CUSTOMER" },
                    { new Guid("3d6cd365-9cb8-4720-821b-8de795c355af"), null, "Management", "MANAGEMENT" },
                    { new Guid("87cf6d74-334c-45ff-9595-f32e7227395a"), null, "Apartment Owner", "APARTMENT OWNER" },
                    { new Guid("c2263c88-c39e-448b-8c16-d700e368e230"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("d0b53c13-b662-452a-9b77-206bd835785d"), null, "Staff", "STAFF" },
                    { new Guid("f5dbba1a-2b37-455c-bd3b-41b18e4d6d9f"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1a37a147-aea6-4a14-ac9d-e0c47f3bcb7f"), 0, 0, "", "13d6de73-f604-43c4-8cb6-c82ca4fa2883", "alice.johnson@example.com", true, false, null, "Alice Johnson", "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAECy53M74qm3WIZtYL9cP3A3gTJOBUFQXdiTmRpqU34N4Jhiz3Nmi8StpPObxM7cR0w==", "0987654321", true, "f181a36c-08e9-4260-9984-a48bab7c0857", false, "alice.johnson@example.com" },
                    { new Guid("323b4631-bbc8-43de-8ece-707615044e63"), 0, 0, "", "6e0dc94c-8d94-4493-bc0d-32e32c7fdf99", "michael.smith@example.com", true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI5h/2oTOCSupHmGqBFHeXZcuXfJzCDXoxDI//pLi0hj85Tuk2hqul1/bNaaZ/7GBg==", "0123456789", true, "07087057-ca71-48ec-a5c0-2a02722b1569", false, "michael.smith@example.com" },
                    { new Guid("44e64650-7868-4aed-812f-a364961aefa3"), 0, 0, null, "32e0ec5f-02ac-42cb-a675-b60ff7dd8675", "bob.johnson@example.com", true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHE5tYzHQgFOkBg0LLNbMSzZsH9Mx5XYMj3NJSTShsD49qT9oIvzarzGvJu8XuuSvA==", "0902345678", true, "04873cf1-9e9b-4547-9207-bd36429bd217", false, "bob.johnson@example.com" },
                    { new Guid("46f47ae7-c7af-4396-9aa2-2af178cca030"), 0, 0, null, "931cda3e-6a44-41f9-8f1c-2f32e09f8195", "diana.prince@example.com", true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK+QQ1dZFfjuzNnswvvzlYbIYeu50NDsouh7rhl7KN1k6zjsW5k4ISa4k1xYUoebXw==", "0904567890", true, "3369ff48-a945-49c4-8b3b-9dd21fa60539", false, "diana.prince@example.com" },
                    { new Guid("5cfce0fe-8131-4d2a-9d0f-909bd49c5c0f"), 0, 0, null, "fd00a4a6-38fd-4ce2-86a3-8fafc0f46da5", "alice.smith@example.com", true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAUvujY/KosmKqqo/9uVMaaPjOWV2kxDbkBqVH7Y+ySFyMXK/7ZwVsenZVsT8QZHOQ==", "0901234567", true, "e3686e3a-a4fa-4a09-a808-0cdf884ae517", false, "alice.smith@example.com" },
                    { new Guid("6b8075e1-932f-45f1-8695-ea0fce9c3bf4"), 0, 0, "", "a40492fe-9704-418f-8a5e-b664e333b091", "quansongngu13@gmail.com", true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", "AQAAAAIAAYagAAAAEKE/qvHIJqXegImKtSoCS8ndtwFTfSRuA75DMDcm+ObeTRc8nrWkNWJ2IC6NjSQ9nw==", "0949035672", true, "645442d5-a044-4f85-980c-3214411bfc2c", false, "quansongngu13@gmail.com" },
                    { new Guid("9c94427d-ca08-41bd-a9c2-72e33f8dcc7c"), 0, 0, null, "a0bd178b-41ec-42e1-ac4d-c144e803cf2a", "charlie.brown@example.com", true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHLbh4feMnfyxqpWhip9MgoMfYKzjXOXFQ9VVIHm1ZXiABXZlTtoSnVtA4wUi+Qp5w==", "0903456789", true, "ba5811ea-3e0e-4294-8f56-a5d2503e14fe", false, "charlie.brown@example.com" },
                    { new Guid("b75acca2-1ea7-4e02-8a48-90a9036580fd"), 0, 0, null, "ec9d7f9b-3f15-48db-9db1-8ea2cdd0dff4", "eve.adams@example.com", true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEKyAeL5wxQxUAFZKBF1NoDjFJfERBCrzBHxlaUCVD6mPcVndszyYIJGDkCUHFstdg==", "0905678901", true, "e9089689-8e07-418e-92c5-31d378a89d5d", false, "eve.adams@example.com" },
                    { new Guid("e4ddb5f9-74a0-465c-ace1-dcb165102493"), 0, 0, "", "2123f08b-fc5c-4b53-84ae-39c9684a14a4", "david.brown@example.com", true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFjp8CGCimz+ABqwWwTPtwClCXpTl71vFReQgXg42sXfp9yXJsBfeJYE6ihkbJFJtw==", "0123456789", true, "c4aae66e-81e8-4bd6-8bb1-96c20ff45bda", false, "david.brown@example.com" },
                    { new Guid("f08486a8-4b73-4fae-8a6b-22c625293940"), 0, 0, "", "41c35df7-c8f3-4625-81d4-fc6529eb7a14", "construction.corp@example.com", true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAOCAkPAdL8U7C4nc/9hzBWb1cr16YqS7alZcY/FwzuK59yOwVTsCfToAHEmVEA6yg==", "0987654321", true, "40d093b8-bd23-4b49-bc50-83a85914e524", false, "construction.corp@example.com" },
                    { new Guid("f1232116-948a-4537-85d4-26840a865ff4"), 0, 0, null, "f2210b34-f032-4643-806c-7a7c547518d7", "johndoe@example.com", true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJI3+DqhsIsnMMon5ze8bekCMTfea+lGQ+B1M9Y0vreu72Baw0j8YUbK2OinPjtfHA==", "123456789", true, "48da7e46-3c6f-46a9-81ed-31b2f410219a", false, "johndoe@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("4ae90d70-52ce-44f7-be78-84ac00fd4784"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(258), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(259), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("60da62df-3910-45d3-9e93-5dae82d8f89d"), "A large outdoor swimming pool.", "Swimming Pool" },
                    { new Guid("b13a78cc-0738-4c0d-9259-fa0db1da1e3e"), "A fully equipped fitness gym.", "Gym" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("38c6ebad-4f9b-4de3-b369-82812678e844"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("0c1c5524-a9df-4a89-a841-3cd0383a4004"), "11:00 AM", "10:00 AM" },
                    { new Guid("e428964f-e789-434c-bd06-c282c9fdf22b"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("ed803ea0-e3be-41bc-9a33-97e1a8e419c9"), new Guid("8843be9c-916c-4db3-a784-140c4d16b898"), new Guid("b13a78cc-0738-4c0d-9259-fa0db1da1e3e") },
                    { new Guid("fa999df3-5fd4-4db0-9ea0-11023135d546"), new Guid("5a2290b4-2033-443e-89e0-8487e4bb0594"), new Guid("60da62df-3910-45d3-9e93-5dae82d8f89d") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("73d9041b-ec3c-46b6-ba4d-727db0090c68"), new Guid("5a2290b4-2033-443e-89e0-8487e4bb0594"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9795), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9812), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("e4420ddb-9ff2-48d3-8990-481d3edb50b4"), new Guid("5a2290b4-2033-443e-89e0-8487e4bb0594"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9780), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9788), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("56b8ece4-278b-43b9-8105-ef495b2c9cbc"), new Guid("44e64650-7868-4aed-812f-a364961aefa3"), new Guid("8843be9c-916c-4db3-a784-140c4d16b898"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { new Guid("97ec3ae8-47a4-468e-97fe-d22d06c6c39e"), new Guid("5cfce0fe-8131-4d2a-9d0f-909bd49c5c0f"), new Guid("5a2290b4-2033-443e-89e0-8487e4bb0594"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9957), new TimeSpan(0, 7, 0, 0, 0)), 0 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("cc3d1853-be0b-4691-b1ec-b5133cc0726b"), new Guid("e4ddb5f9-74a0-465c-ace1-dcb165102493"), new Guid("5a2290b4-2033-443e-89e0-8487e4bb0594") },
                    { new Guid("d32b19ef-991f-493f-a9fd-e8e43273aa36"), new Guid("e4ddb5f9-74a0-465c-ace1-dcb165102493"), new Guid("5a2290b4-2033-443e-89e0-8487e4bb0594") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("2fa06327-5e92-4ca7-a728-f0319887024f"), new Guid("f08486a8-4b73-4fae-8a6b-22c625293940"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(8727), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(8728), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("e614f796-c285-42db-a927-3924816fefa1"), new Guid("5a2290b4-2033-443e-89e0-8487e4bb0594"), new Guid("e4ddb5f9-74a0-465c-ace1-dcb165102493"), new DateTimeOffset(new DateTime(2024, 9, 30, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(222), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(220), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(218), new TimeSpan(0, 7, 0, 0, 0)), new Guid("b75acca2-1ea7-4e02-8a48-90a9036580fd"), "Schedule a viewing for the Skyline Apartment.", new Guid("f08486a8-4b73-4fae-8a6b-22c625293940"), new Guid("e428964f-e789-434c-bd06-c282c9fdf22b"), new Guid("f1232116-948a-4537-85d4-26840a865ff4"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(219), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3d6cd365-9cb8-4720-821b-8de795c355af"), new Guid("1a37a147-aea6-4a14-ac9d-e0c47f3bcb7f") },
                    { new Guid("33207d82-ebd8-4955-9602-53cf78b68d7f"), new Guid("323b4631-bbc8-43de-8ece-707615044e63") },
                    { new Guid("f5dbba1a-2b37-455c-bd3b-41b18e4d6d9f"), new Guid("6b8075e1-932f-45f1-8695-ea0fce9c3bf4") },
                    { new Guid("87cf6d74-334c-45ff-9595-f32e7227395a"), new Guid("e4ddb5f9-74a0-465c-ace1-dcb165102493") },
                    { new Guid("c2263c88-c39e-448b-8c16-d700e368e230"), new Guid("f08486a8-4b73-4fae-8a6b-22c625293940") },
                    { new Guid("d0b53c13-b662-452a-9b77-206bd835785d"), new Guid("f1232116-948a-4537-85d4-26840a865ff4") }
                });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("99caa2e3-3d0b-4c45-819f-fb7163d26823"), new Guid("9c94427d-ca08-41bd-a9c2-72e33f8dcc7c"), new Guid("5a2290b4-2033-443e-89e0-8487e4bb0594"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(290), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(293), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 10, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(293), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("400ea120-c37c-4446-a780-9998a4913f84"), new Guid("5cfce0fe-8131-4d2a-9d0f-909bd49c5c0f"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(430), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" },
                    { new Guid("fb8ea77e-febb-4d20-b7cf-e930e76de5df"), new Guid("44e64650-7868-4aed-812f-a364961aefa3"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(436), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("412a57ab-a6b0-4ba3-bbb5-442c8a2e0b5e"), new Guid("44e64650-7868-4aed-812f-a364961aefa3"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(511), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("38c6ebad-4f9b-4de3-b369-82812678e844"), new Guid("e637ce01-bafc-466d-b7bd-1c77f5f70a36"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(512), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("edf2e5c3-1634-479c-a6e8-8ab0c1e5b2aa"), new Guid("9c94427d-ca08-41bd-a9c2-72e33f8dcc7c"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(505), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("38c6ebad-4f9b-4de3-b369-82812678e844"), new Guid("9d636ba6-a125-4015-8b20-11f95288a0f2"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(506), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("21e2b748-0a1a-4741-a100-b49b1857dab8"), new Guid("5cfce0fe-8131-4d2a-9d0f-909bd49c5c0f"), new Guid("8843be9c-916c-4db3-a784-140c4d16b898"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(132), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 9, 30, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(133), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." },
                    { new Guid("369843ab-c85d-417e-981d-931228a8b3bf"), new Guid("44e64650-7868-4aed-812f-a364961aefa3"), new Guid("5a2290b4-2033-443e-89e0-8487e4bb0594"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(117), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 9, 30, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(118), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("aacd9b0a-a566-41d0-befa-6c5e01113c3b"), new Guid("f1232116-948a-4537-85d4-26840a865ff4"), new Guid("5a2290b4-2033-443e-89e0-8487e4bb0594"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9863), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9864), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" },
                    { new Guid("dd3a4a0b-fa26-4269-aff9-3ad3d07076d4"), new Guid("f1232116-948a-4537-85d4-26840a865ff4"), new Guid("8843be9c-916c-4db3-a784-140c4d16b898"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9872), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9872), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("93a01c78-e399-44f9-88f2-c6ac7e5b9943"), new Guid("1a37a147-aea6-4a14-ac9d-e0c47f3bcb7f"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(396), new TimeSpan(0, 7, 0, 0, 0)), new Guid("4ae90d70-52ce-44f7-be78-84ac00fd4784"), new Guid("99caa2e3-3d0b-4c45-819f-fb7163d26823"), "45000", new DateTimeOffset(new DateTime(2024, 10, 4, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(397), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(398), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("89404a09-70f2-4f1c-92b3-fcc92c0d24bc"), null, new Guid("2fa06327-5e92-4ca7-a728-f0319887024f"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 7, 0, 0, 0)), "1,000,000 - 2,000,000 USD", "A luxurious penthouse suite with stunning views.", "Penthouse Suite", 0, new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9217), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("ac140d76-689b-4496-8638-f6b2c48e1b1f"), null, new Guid("2fa06327-5e92-4ca7-a728-f0319887024f"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9204), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9207), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("a0d1e705-5d09-4f83-b0de-03021e28bf70"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(353), new TimeSpan(0, 7, 0, 0, 0)), new Guid("99caa2e3-3d0b-4c45-819f-fb7163d26823"), 0, new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(358), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 384, DateTimeKind.Unspecified).AddTicks(357), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("755e8f55-7ed7-4f3f-8ba3-213e300039f1"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9924), new TimeSpan(0, 7, 0, 0, 0)), new Guid("dd3a4a0b-fa26-4269-aff9-3ad3d07076d4") },
                    { new Guid("813925d4-451e-4ee3-b3e9-86dcca4eb4ec"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9920), new TimeSpan(0, 7, 0, 0, 0)), new Guid("aacd9b0a-a566-41d0-befa-6c5e01113c3b") }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[,]
                {
                    { new Guid("57da35f2-63a7-45bd-92a3-ac34b59b8c51"), new Guid("89404a09-70f2-4f1c-92b3-fcc92c0d24bc"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9365), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("69f6aa38-73ae-4f35-a3a8-b9f6716f3af0"), new Guid("ac140d76-689b-4496-8638-f6b2c48e1b1f"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9361), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartmentApartments",
                columns: new[] { "Id", "ApartmentID", "ProjectApartmentID" },
                values: new object[] { new Guid("e6aeb5aa-59f9-435f-82da-50d445066e63"), new Guid("8843be9c-916c-4db3-a784-140c4d16b898"), new Guid("ac140d76-689b-4496-8638-f6b2c48e1b1f") });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[,]
                {
                    { new Guid("0a08b60f-d072-45da-af15-9742b7efd47f"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9430), new TimeSpan(0, 7, 0, 0, 0)), "Image of the penthouse suite", "Penthouse Suite Image", new Guid("89404a09-70f2-4f1c-92b3-fcc92c0d24bc"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9431), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/penthouse-suite.jpg" },
                    { new Guid("128b7535-e11e-46a9-9d25-70207a7072de"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9425), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("ac140d76-689b-4496-8638-f6b2c48e1b1f"), new DateTimeOffset(new DateTime(2024, 9, 29, 15, 41, 8, 383, DateTimeKind.Unspecified).AddTicks(9426), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("ed803ea0-e3be-41bc-9a33-97e1a8e419c9"));

            migrationBuilder.DeleteData(
                table: "ApartmentFacilitys",
                keyColumn: "ApartmentFacilityID",
                keyValue: new Guid("fa999df3-5fd4-4db0-9ea0-11023135d546"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("73d9041b-ec3c-46b6-ba4d-727db0090c68"));

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "ApartmentImageID",
                keyValue: new Guid("e4420ddb-9ff2-48d3-8990-481d3edb50b4"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("56b8ece4-278b-43b9-8105-ef495b2c9cbc"));

            migrationBuilder.DeleteData(
                table: "ApartmentInteractions",
                keyColumn: "ApartmentInteractionID",
                keyValue: new Guid("97ec3ae8-47a4-468e-97fe-d22d06c6c39e"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("cc3d1853-be0b-4691-b1ec-b5133cc0726b"));

            migrationBuilder.DeleteData(
                table: "ApartmentOwnerApartment",
                keyColumn: "DocumentID",
                keyValue: new Guid("d32b19ef-991f-493f-a9fd-e8e43273aa36"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: new Guid("e614f796-c285-42db-a927-3924816fefa1"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3d6cd365-9cb8-4720-821b-8de795c355af"), new Guid("1a37a147-aea6-4a14-ac9d-e0c47f3bcb7f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("33207d82-ebd8-4955-9602-53cf78b68d7f"), new Guid("323b4631-bbc8-43de-8ece-707615044e63") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f5dbba1a-2b37-455c-bd3b-41b18e4d6d9f"), new Guid("6b8075e1-932f-45f1-8695-ea0fce9c3bf4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("87cf6d74-334c-45ff-9595-f32e7227395a"), new Guid("e4ddb5f9-74a0-465c-ace1-dcb165102493") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c2263c88-c39e-448b-8c16-d700e368e230"), new Guid("f08486a8-4b73-4fae-8a6b-22c625293940") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d0b53c13-b662-452a-9b77-206bd835785d"), new Guid("f1232116-948a-4537-85d4-26840a865ff4") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("46f47ae7-c7af-4396-9aa2-2af178cca030"));

            migrationBuilder.DeleteData(
                table: "DepositCancel",
                keyColumn: "DepositCancelID",
                keyValue: new Guid("93a01c78-e399-44f9-88f2-c6ac7e5b9943"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("400ea120-c37c-4446-a780-9998a4913f84"));

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackID",
                keyValue: new Guid("fb8ea77e-febb-4d20-b7cf-e930e76de5df"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("412a57ab-a6b0-4ba3-bbb5-442c8a2e0b5e"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: new Guid("edf2e5c3-1634-479c-a6e8-8ab0c1e5b2aa"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("57da35f2-63a7-45bd-92a3-ac34b59b8c51"));

            migrationBuilder.DeleteData(
                table: "ProjectAccessLogs",
                keyColumn: "ProjectAccessLogID",
                keyValue: new Guid("69f6aa38-73ae-4f35-a3a8-b9f6716f3af0"));

            migrationBuilder.DeleteData(
                table: "ProjectApartmentApartments",
                keyColumn: "Id",
                keyValue: new Guid("e6aeb5aa-59f9-435f-82da-50d445066e63"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("0a08b60f-d072-45da-af15-9742b7efd47f"));

            migrationBuilder.DeleteData(
                table: "ProjectImages",
                keyColumn: "ProjectImageID",
                keyValue: new Guid("128b7535-e11e-46a9-9d25-70207a7072de"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("21e2b748-0a1a-4741-a100-b49b1857dab8"));

            migrationBuilder.DeleteData(
                table: "RequestApartments",
                keyColumn: "RequestApartmentID",
                keyValue: new Guid("369843ab-c85d-417e-981d-931228a8b3bf"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("0c1c5524-a9df-4a89-a841-3cd0383a4004"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: new Guid("a0d1e705-5d09-4f83-b0de-03021e28bf70"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("755e8f55-7ed7-4f3f-8ba3-213e300039f1"));

            migrationBuilder.DeleteData(
                table: "VR_Access_Logs",
                keyColumn: "VR_Access_LogID",
                keyValue: new Guid("813925d4-451e-4ee3-b3e9-86dcca4eb4ec"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("33207d82-ebd8-4955-9602-53cf78b68d7f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3d6cd365-9cb8-4720-821b-8de795c355af"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("87cf6d74-334c-45ff-9595-f32e7227395a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c2263c88-c39e-448b-8c16-d700e368e230"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d0b53c13-b662-452a-9b77-206bd835785d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5dbba1a-2b37-455c-bd3b-41b18e4d6d9f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a37a147-aea6-4a14-ac9d-e0c47f3bcb7f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("323b4631-bbc8-43de-8ece-707615044e63"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("44e64650-7868-4aed-812f-a364961aefa3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5cfce0fe-8131-4d2a-9d0f-909bd49c5c0f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6b8075e1-932f-45f1-8695-ea0fce9c3bf4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b75acca2-1ea7-4e02-8a48-90a9036580fd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e4ddb5f9-74a0-465c-ace1-dcb165102493"));

            migrationBuilder.DeleteData(
                table: "DepositCancelTypes",
                keyColumn: "DepositCancelTypeID",
                keyValue: new Guid("4ae90d70-52ce-44f7-be78-84ac00fd4784"));

            migrationBuilder.DeleteData(
                table: "DepositRequest",
                keyColumn: "DepositID",
                keyValue: new Guid("99caa2e3-3d0b-4c45-819f-fb7163d26823"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("60da62df-3910-45d3-9e93-5dae82d8f89d"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilitiesID",
                keyValue: new Guid("b13a78cc-0738-4c0d-9259-fa0db1da1e3e"));

            migrationBuilder.DeleteData(
                table: "NotificationTypes",
                keyColumn: "NotificationTypeID",
                keyValue: new Guid("38c6ebad-4f9b-4de3-b369-82812678e844"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("89404a09-70f2-4f1c-92b3-fcc92c0d24bc"));

            migrationBuilder.DeleteData(
                table: "ProjectApartments",
                keyColumn: "ProjectApartmentID",
                keyValue: new Guid("ac140d76-689b-4496-8638-f6b2c48e1b1f"));

            migrationBuilder.DeleteData(
                table: "Slots",
                keyColumn: "SlotID",
                keyValue: new Guid("e428964f-e789-434c-bd06-c282c9fdf22b"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("aacd9b0a-a566-41d0-befa-6c5e01113c3b"));

            migrationBuilder.DeleteData(
                table: "VRExperiences",
                keyColumn: "VRExperienceID",
                keyValue: new Guid("dd3a4a0b-fa26-4269-aff9-3ad3d07076d4"));

            migrationBuilder.DeleteData(
                table: "ApartmentProjectProvider",
                keyColumn: "ApartmentProjectProviderID",
                keyValue: new Guid("2fa06327-5e92-4ca7-a728-f0319887024f"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("5a2290b4-2033-443e-89e0-8487e4bb0594"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("8843be9c-916c-4db3-a784-140c4d16b898"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c94427d-ca08-41bd-a9c2-72e33f8dcc7c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f1232116-948a-4537-85d4-26840a865ff4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f08486a8-4b73-4fae-8a6b-22c625293940"));

            migrationBuilder.AlterColumn<Guid>(
                name: "StaffID",
                table: "Appointment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentID", "ApartmentName", "ApartmentStatus", "ApartmentType", "CreatedDate", "Description", "UpdatedDate", "address", "area", "direction", "expiryDate", "location", "numberOfRooms", "pricePerSquareMeter", "recommendedPrice" },
                values: new object[,]
                {
                    { new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), "Skyline Apartment", 0, 1, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5379), new TimeSpan(0, 7, 0, 0, 0)), "A modern apartment with a skyline view.", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5380), new TimeSpan(0, 7, 0, 0, 0)), "123 Skyline Road, New City", "1500 sqft", "North-East", new DateTimeOffset(new DateTime(2029, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5386), new TimeSpan(0, 7, 0, 0, 0)), "City Center", "3", "3000 USD", "450,000 USD" },
                    { new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"), "Ocean View Apartment", 1, 0, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5402), new TimeSpan(0, 7, 0, 0, 0)), "A luxurious apartment with an ocean view.", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5403), new TimeSpan(0, 7, 0, 0, 0)), "456 Ocean Drive, Coastal City", "1800 sqft", "South-West", new DateTimeOffset(new DateTime(2027, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5404), new TimeSpan(0, 7, 0, 0, 0)), "Beachfront", "4", "3500 USD", "650,000 USD" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("097a1b34-0631-4927-8aa8-b73f7bbfd3cf"), null, "Apartment Owner", "APARTMENT OWNER" },
                    { new Guid("28d1d9c4-5494-4a44-a498-f707059beebd"), null, "Staff", "STAFF" },
                    { new Guid("c9387730-b4b9-4826-9e3e-5d2a8f19164f"), null, "Management", "MANAGEMENT" },
                    { new Guid("d178a45e-39bb-45b2-a187-d9610cc7b0e0"), null, "Admin", "ADMIN" },
                    { new Guid("eb3397f0-a597-4349-8644-cce880e97a26"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("efbe96c4-208e-478a-bbb2-b90abcf71046"), null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0806bf44-b0f6-41cf-8c81-7507752daabd"), 0, 0, null, "c69cda7a-3882-4a84-8a57-96072b1a7bdd", "alice.smith@example.com", true, false, null, "Alice Smith", "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAENRecLu8dgnaFAcIByJPryoI9hXvlX+7YJanmC3gJI12SAnQbk8zoi3H2VA5sYGJmw==", "0901234567", true, "7fe95f4c-cd5b-4608-83a7-fc8a27e8227a", false, "alice.smith@example.com" },
                    { new Guid("3bae2bac-b3d8-46bc-bc60-59aa6c908aaa"), 0, 0, "", "a0c23820-caf9-4593-aa86-1486e4c45239", "construction.corp@example.com", true, false, null, "Construction Corp", "CONSTRUCTION.CORP@EXAMPLE.COM", "CONSTRUCTION.CORP@EXAMPLE.COM", "AQAAAAIAAYagAAAAENCYpOeb+4nGX7Pwuh1sjXodFzEvvMmzlrqWcZQLOfpc0y2DxC6WKfjoNOj7GzWcxw==", "0987654321", true, "1dc5a0fd-64fa-4eb9-95ca-ea690e7fc5d7", false, "construction.corp@example.com" },
                    { new Guid("461453f7-a527-4df3-bac5-7394fa8f0691"), 0, 0, "", "2c48383d-c50e-42dd-8907-89a2adceb2a3", "alice.johnson@example.com", true, false, null, "Alice Johnson", "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHd+iRVMmCyVnwseYLh7TCReVHBUIBCglmsmiVnUbfLrYW2i5ISuQ5r0nH+HUJTeSA==", "0987654321", true, "6abd4fc0-efec-47c0-9993-61e87e450562", false, "alice.johnson@example.com" },
                    { new Guid("60039256-f860-480d-8b8c-22587e7fb6fd"), 0, 0, "", "247e195f-cd94-44fc-8183-f3b32634e114", "david.brown@example.com", true, false, null, "David Brown", "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPlPpz4P8jBKUx43kE5z9XH2zNeHxgduRkxoq8AbyY3Z2SQoFu2odlaNhUwnGgEprw==", "0123456789", true, "6e4cd709-78cc-4e23-965b-699b0124d26a", false, "david.brown@example.com" },
                    { new Guid("693ea210-9a93-4a18-aa8a-30c011ef778c"), 0, 0, "", "7d513f34-c42a-4e00-a151-49ef52f783c1", "michael.smith@example.com", true, false, null, "Michael Smith", "MICHAEL.SMITH@EXAMPLE.COM", "MICHAEL.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHqlATY/vlBEKQl52hMZTuKBF5eGa85o9V2Q0lKMmwo0doiYHOWk9KGpe+KrPCUT7g==", "0123456789", true, "58ba3567-e105-4dd0-a37d-2e933e0a636d", false, "michael.smith@example.com" },
                    { new Guid("88496895-d698-4903-b154-840d3c5adce2"), 0, 0, "", "593f4792-40c2-455e-a3ed-d448cf34f8fd", "quansongngu13@gmail.com", true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", "AQAAAAIAAYagAAAAEMIFoyOyCxHoZ5+K7amQif+6hV5GkQvT0XAn8YcIzaBmKIWSKPhSe+P20ktF0OajNQ==", "0949035672", true, "f102216f-f391-4e92-aa50-128d36a62945", false, "quansongngu13@gmail.com" },
                    { new Guid("8adf7591-c138-4a97-b890-4cc778f2b1a6"), 0, 0, null, "9fab25cd-396b-49c3-9e0d-d7c87d93e81e", "bob.johnson@example.com", true, false, null, "Bob Johnson", "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOsQwGdYp+QDQZoTwbjWkOTxVgp/hAb7ad0bTQ3d72mJRolLjQ20cquUKZnqZK7LWw==", "0902345678", true, "892cf3b0-3920-455e-8675-1eca2d7e2375", false, "bob.johnson@example.com" },
                    { new Guid("a31405f3-f989-409f-ace7-639ca1224b33"), 0, 0, null, "69adcd0a-cb5b-4288-8f1b-3febae976ecb", "charlie.brown@example.com", true, false, null, "Charlie Brown", "CHARLIE.BROWN@EXAMPLE.COM", "CHARLIE.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDarHG8AdTxBqEGLe3McORI0wgLuW4t8DJy8eP4uuDQZA1ltlqFeklwbtdlAmo0fKA==", "0903456789", true, "e2f607fa-0754-4327-8f3d-e606e95848ef", false, "charlie.brown@example.com" },
                    { new Guid("bb41f6af-3812-4601-9e84-e08501b164e7"), 0, 0, null, "45aa99ca-a910-42bb-86b9-5e027caae018", "diana.prince@example.com", true, false, null, "Diana Prince", "DIANA.PRINCE@EXAMPLE.COM", "DIANA.PRINCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKgtpbiY0qRS2atBGD8NEN8+0qTLwUz+lyfsd6mTCJn8bSswaQSHZ1qk0fTCYkqfQQ==", "0904567890", true, "c320c1e1-600f-4bae-9dc5-ee2a5a7ffedd", false, "diana.prince@example.com" },
                    { new Guid("cfd6d61e-2946-4b27-a81e-dedce672b921"), 0, 0, null, "3da2f3f2-35ac-41eb-860d-150edb90bdf8", "eve.adams@example.com", true, false, null, "Eve Adams", "EVE.ADAMS@EXAMPLE.COM", "EVE.ADAMS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIaPcS17z3sfNp+hN4h+2f8oPX4FavO1zECm7JTOfn5snbW6UNbSpvix10erIeIMLQ==", "0905678901", true, "c933ce27-687f-4575-bc85-ef6fcb421e44", false, "eve.adams@example.com" },
                    { new Guid("e6831c1c-ed9e-44c9-851d-52451fda6c51"), 0, 0, null, "5169245a-a020-4fa6-be55-496b3fcb1477", "johndoe@example.com", true, false, null, "John Doe", "JOHNDOE@EXAMPLE.COM", "JOHNDOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAECNzw82D/2WRj4imUD0iurY0VFqJ1BjfDOQuiVZj+tzhjI5dpDSvrklzPiRjHuUkzw==", "123456789", true, "579c22c6-953b-44e7-9901-abb63469bfa5", false, "johndoe@example.com" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancelTypes",
                columns: new[] { "DepositCancelTypeID", "CreateDate", "DepositCancelName", "UpdateDate" },
                values: new object[] { new Guid("fc9d149d-34d5-480d-9ce5-a8f46941dc5b"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6133), new TimeSpan(0, 7, 0, 0, 0)), "Customer Request", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6134), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilitiesID", "FacilitiesDescription", "FacilitiesName" },
                values: new object[,]
                {
                    { new Guid("33a7ab03-069f-4bd3-861f-74f69d78911b"), "A large outdoor swimming pool.", "Swimming Pool" },
                    { new Guid("e8aec68e-627d-41fc-8ee8-1fef017c4e29"), "A fully equipped fitness gym.", "Gym" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "NotificationTypeDescription", "NotificationTypeName" },
                values: new object[] { new Guid("728c6518-6fd6-4b15-8a08-b41b84706c7a"), "General notifications for users.", "General" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "SlotID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("15429fdd-b613-4312-b593-413de71568ae"), "11:00 AM", "10:00 AM" },
                    { new Guid("5ef2fa8a-a7a3-4942-a753-af17d405caaf"), "10:00 AM", "09:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentFacilitys",
                columns: new[] { "ApartmentFacilityID", "ApartmentID", "FacilityID" },
                values: new object[,]
                {
                    { new Guid("55e0ee81-e58a-4e4a-9431-f72575f53689"), new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"), new Guid("e8aec68e-627d-41fc-8ee8-1fef017c4e29") },
                    { new Guid("dd063c7f-7bb7-4aea-aaef-1df0e07585ee"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new Guid("33a7ab03-069f-4bd3-861f-74f69d78911b") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "ApartmentImageID", "ApartmentID", "CreateDate", "Description", "ImageUrl", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("42b4c801-5355-49d4-a34c-47c9baaf0264"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 7, 0, 0, 0)), "Living Room View", "https://example.com/apartment1-livingroom.jpg", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5643), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("feeaa0de-b08b-456a-b748-25d67f30566d"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5654), new TimeSpan(0, 7, 0, 0, 0)), "Bedroom View", "https://example.com/apartment1-bedroom.jpg", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ApartmentInteractions",
                columns: new[] { "ApartmentInteractionID", "AccountID", "ApartmentID", "InteractionDate", "InteractionTypes" },
                values: new object[,]
                {
                    { new Guid("4bba8a95-b267-4193-9cde-ab249794e8ec"), new Guid("8adf7591-c138-4a97-b890-4cc778f2b1a6"), new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5831), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { new Guid("8be95c4c-a2de-4ebb-a64d-5bad0f01958c"), new Guid("0806bf44-b0f6-41cf-8c81-7507752daabd"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5819), new TimeSpan(0, 7, 0, 0, 0)), 0 }
                });

            migrationBuilder.InsertData(
                table: "ApartmentOwnerApartment",
                columns: new[] { "DocumentID", "AccountID", "ApartmentID" },
                values: new object[,]
                {
                    { new Guid("c6c42f8b-8424-4a0e-92d5-519b13211309"), new Guid("60039256-f860-480d-8b8c-22587e7fb6fd"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c") },
                    { new Guid("e583a5f3-fde3-410a-beac-802b423aa27c"), new Guid("60039256-f860-480d-8b8c-22587e7fb6fd"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c") }
                });

            migrationBuilder.InsertData(
                table: "ApartmentProjectProvider",
                columns: new[] { "ApartmentProjectProviderID", "AccountID", "ApartmentProjectDescription", "ApartmentProjectProviderName", "CreateDate", "DiagramUrl", "LegallInfor", "Location", "UpdateDate" },
                values: new object[] { new Guid("8746b54f-3968-43b1-9b29-81e0a2ad14f0"), new Guid("3bae2bac-b3d8-46bc-bc60-59aa6c908aaa"), "A provider of luxury high-end apartments.", "High-End Apartment Provider", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(4693), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/diagram.png", "Legal Information", "City Center", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(4695), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "ApartmentID", "ApartmentOwnerID", "AppointmentDate", "AppointmentStatus", "AppointmentTypes", "AssignedBy", "AssignedDate", "CreateDate", "CustomerID", "Description", "ProjectProviderID", "SlotID", "StaffID", "Title", "UpdatedDate" },
                values: new object[] { new Guid("6975db10-66c2-46a8-b8b7-3a99ad777082"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new Guid("60039256-f860-480d-8b8c-22587e7fb6fd"), new DateTimeOffset(new DateTime(2024, 9, 29, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6091), new TimeSpan(0, 7, 0, 0, 0)), 1, 1, "Admin", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6090), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6088), new TimeSpan(0, 7, 0, 0, 0)), new Guid("cfd6d61e-2946-4b27-a81e-dedce672b921"), "Schedule a viewing for the Skyline Apartment.", new Guid("3bae2bac-b3d8-46bc-bc60-59aa6c908aaa"), new Guid("5ef2fa8a-a7a3-4942-a753-af17d405caaf"), new Guid("e6831c1c-ed9e-44c9-851d-52451fda6c51"), "Viewing Appointment for Skyline Apartment", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6089), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("eb3397f0-a597-4349-8644-cce880e97a26"), new Guid("3bae2bac-b3d8-46bc-bc60-59aa6c908aaa") },
                    { new Guid("c9387730-b4b9-4826-9e3e-5d2a8f19164f"), new Guid("461453f7-a527-4df3-bac5-7394fa8f0691") },
                    { new Guid("097a1b34-0631-4927-8aa8-b73f7bbfd3cf"), new Guid("60039256-f860-480d-8b8c-22587e7fb6fd") },
                    { new Guid("efbe96c4-208e-478a-bbb2-b90abcf71046"), new Guid("693ea210-9a93-4a18-aa8a-30c011ef778c") },
                    { new Guid("d178a45e-39bb-45b2-a187-d9610cc7b0e0"), new Guid("88496895-d698-4903-b154-840d3c5adce2") },
                    { new Guid("28d1d9c4-5494-4a44-a498-f707059beebd"), new Guid("e6831c1c-ed9e-44c9-851d-52451fda6c51") }
                });

            migrationBuilder.InsertData(
                table: "DepositRequest",
                columns: new[] { "DepositID", "AccountID", "ApartmentID", "CreateDate", "DepositStatus", "UpdateDate", "constractNumber", "depositAmount", "depositPercentage", "description", "expiryDate", "note" },
                values: new object[] { new Guid("579fe412-44da-4086-a8bc-631d60e8d68b"), new Guid("a31405f3-f989-409f-ace7-639ca1224b33"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6169), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6172), new TimeSpan(0, 7, 0, 0, 0)), 12345.0, 50000.0, 20.0, "Deposit for Skyline Apartment.", new DateTimeOffset(new DateTime(2024, 10, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6174), new TimeSpan(0, 7, 0, 0, 0)), "Initial deposit for apartment" });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackID", "AccountID", "CreateDate", "Description", "FeedbackStatus", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("6b9935ad-c4eb-43d1-b2ca-93c92e071f90"), new Guid("8adf7591-c138-4a97-b890-4cc778f2b1a6"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6328), new TimeSpan(0, 7, 0, 0, 0)), "The service was okay, but there's room for improvement.", 0, 3.5f, "Could be better" },
                    { new Guid("85703689-9854-4156-8c41-cf7373490ad9"), new Guid("0806bf44-b0f6-41cf-8c81-7507752daabd"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6324), new TimeSpan(0, 7, 0, 0, 0)), "I really enjoyed the experience. Highly recommend!", 0, 5f, "Great Service!" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "AccountID", "Created", "Description", "IsRead", "NotificationStatus", "NotificationTypeID", "ReferenceID", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("0109df04-49ac-486e-84d1-892fec4b3166"), new Guid("a31405f3-f989-409f-ace7-639ca1224b33"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6396), new TimeSpan(0, 7, 0, 0, 0)), "Thank you for joining us! We hope you enjoy your experience.", false, 0, new Guid("728c6518-6fd6-4b15-8a08-b41b84706c7a"), new Guid("9f5adbb6-e8ae-4c58-8f6d-bfef6944504a"), "Welcome to Our Service", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6397), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("85ec1cc8-1b9e-4f16-b21e-399458924d9a"), new Guid("8adf7591-c138-4a97-b890-4cc778f2b1a6"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6402), new TimeSpan(0, 7, 0, 0, 0)), "Check out our new feature that enhances your experience!", false, 0, new Guid("728c6518-6fd6-4b15-8a08-b41b84706c7a"), new Guid("cc702a42-ce0e-4ed3-81ca-e850d69f5a4a"), "New Feature Available", new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6403), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "RequestApartments",
                columns: new[] { "RequestApartmentID", "AccountID", "ApartmentID", "CreateDate", "Note", "RequestMessage", "ResponseDate", "ResponseMessage" },
                values: new object[,]
                {
                    { new Guid("197b8a44-5321-4c22-b9d5-ff6d4aecb1e1"), new Guid("0806bf44-b0f6-41cf-8c81-7507752daabd"), new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5935), new TimeSpan(0, 7, 0, 0, 0)), "Looking forward to your response.", "Is this apartment still available for booking?", new DateTimeOffset(new DateTime(2024, 9, 29, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5936), new TimeSpan(0, 7, 0, 0, 0)), "The apartment is still available." },
                    { new Guid("b99dddb1-e1a1-4b2d-96a2-57414202cede"), new Guid("8adf7591-c138-4a97-b890-4cc778f2b1a6"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5924), new TimeSpan(0, 7, 0, 0, 0)), "Please respond as soon as possible.", "I would like to know more about this apartment.", new DateTimeOffset(new DateTime(2024, 9, 29, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5925), new TimeSpan(0, 7, 0, 0, 0)), "Your request has been received." }
                });

            migrationBuilder.InsertData(
                table: "VRExperiences",
                columns: new[] { "VRExperienceID", "AccountID", "ApartmentID", "CreateDate", "UpdateDate", "video_url_file" },
                values: new object[,]
                {
                    { new Guid("9050603b-375d-40f2-abd3-45937f53641e"), new Guid("e6831c1c-ed9e-44c9-851d-52451fda6c51"), new Guid("3a0fcb89-b0d2-4e2b-b5d9-be552b45203c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5736), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience1.mp4" },
                    { new Guid("d12c972d-0a6a-4ef5-8583-323465b9cabe"), new Guid("e6831c1c-ed9e-44c9-851d-52451fda6c51"), new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5741), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5743), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/vr-experience2.mp4" }
                });

            migrationBuilder.InsertData(
                table: "DepositCancel",
                columns: new[] { "DepositCancelID", "AccountID", "CancelDate", "DepositCancelTypeID", "DepositID", "RecoveryPrice", "RefundDate", "updateAt" },
                values: new object[] { new Guid("89cca6d0-51d4-42d5-975c-3ffcf2dc7fe3"), new Guid("461453f7-a527-4df3-bac5-7394fa8f0691"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6289), new TimeSpan(0, 7, 0, 0, 0)), new Guid("fc9d149d-34d5-480d-9ce5-a8f46941dc5b"), new Guid("579fe412-44da-4086-a8bc-631d60e8d68b"), "45000", new DateTimeOffset(new DateTime(2024, 10, 3, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6290), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6294), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "ProjectApartments",
                columns: new[] { "ProjectApartmentID", "AccountId", "ApartmentProjectProviderID", "CreateDate", "Price_range", "ProjectApartmentDescription", "ProjectApartmentName", "ProjectApartmentStatus", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("32855b2d-41b3-4d91-b077-9e3f2e9330d5"), null, new Guid("8746b54f-3968-43b1-9b29-81e0a2ad14f0"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5157), new TimeSpan(0, 7, 0, 0, 0)), "1,000,000 - 2,000,000 USD", "A luxurious penthouse suite with stunning views.", "Penthouse Suite", 0, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5158), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("a2c7e609-7c85-41d4-b218-2f70c741fdbd"), null, new Guid("8746b54f-3968-43b1-9b29-81e0a2ad14f0"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(4878), new TimeSpan(0, 7, 0, 0, 0)), "500,000 - 1,000,000 USD", "A spacious luxury apartment with modern amenities.", "Luxury Apartment", 0, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(4879), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "CreateDate", "DepositID", "PaymentMethods", "TransactionDate", "TransactionStatus", "UpdateDate", "ammount", "description", "note" },
                values: new object[] { new Guid("9d2c2d5a-86bc-429e-8c4d-4dd91357ed03"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6250), new TimeSpan(0, 7, 0, 0, 0)), new Guid("579fe412-44da-4086-a8bc-631d60e8d68b"), 0, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6253), new TimeSpan(0, 7, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, 7, 0, 0, 0)), 50000.0, "Payment for initial deposit.", "Deposit payment" });

            migrationBuilder.InsertData(
                table: "VR_Access_Logs",
                columns: new[] { "VR_Access_LogID", "CreateDate", "VRExperienceID" },
                values: new object[,]
                {
                    { new Guid("cd6eac7c-019b-4c7c-9fc7-7d6b37b91f06"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9050603b-375d-40f2-abd3-45937f53641e") },
                    { new Guid("fe25189e-0f70-43f1-8c36-e5432de01e35"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5786), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d12c972d-0a6a-4ef5-8583-323465b9cabe") }
                });

            migrationBuilder.InsertData(
                table: "ProjectAccessLogs",
                columns: new[] { "ProjectAccessLogID", "ProjectApartmentID", "accessDate" },
                values: new object[,]
                {
                    { new Guid("4093fd29-162e-46c3-b8ba-e3a6dea16f49"), new Guid("a2c7e609-7c85-41d4-b218-2f70c741fdbd"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5242), new TimeSpan(0, 7, 0, 0, 0)) },
                    { new Guid("64e5ad4c-feff-4c10-9c61-d58b798ce4da"), new Guid("32855b2d-41b3-4d91-b077-9e3f2e9330d5"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5245), new TimeSpan(0, 7, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProjectApartmentApartments",
                columns: new[] { "Id", "ApartmentID", "ProjectApartmentID" },
                values: new object[] { new Guid("d44a9003-a2a4-49a8-8fed-3e1673918d8b"), new Guid("8c7a54a5-ff16-4303-badc-a136eaf3b1b6"), new Guid("a2c7e609-7c85-41d4-b218-2f70c741fdbd") });

            migrationBuilder.InsertData(
                table: "ProjectImages",
                columns: new[] { "ProjectImageID", "CreateDate", "Description", "Name", "ProjectApartmentID", "UpdateDate", "Url" },
                values: new object[,]
                {
                    { new Guid("2ea80b11-b32f-4994-b444-f649b48bb73c"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5312), new TimeSpan(0, 7, 0, 0, 0)), "Image of the penthouse suite", "Penthouse Suite Image", new Guid("32855b2d-41b3-4d91-b077-9e3f2e9330d5"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5313), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/penthouse-suite.jpg" },
                    { new Guid("92b9eace-c3f9-46c6-ae6c-8a7729edf6f7"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5308), new TimeSpan(0, 7, 0, 0, 0)), "Image of the luxury apartment", "Luxury Apartment Image", new Guid("a2c7e609-7c85-41d4-b218-2f70c741fdbd"), new DateTimeOffset(new DateTime(2024, 9, 28, 3, 41, 32, 454, DateTimeKind.Unspecified).AddTicks(5309), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/luxury-apartment.jpg" }
                });
        }
    }
}
