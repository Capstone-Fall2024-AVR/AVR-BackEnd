using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "AssignedDate",
                table: "Appointment",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "AssignedDate",
                table: "Appointment",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
    }
}
