using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f73fa4f2-2193-45d5-a643-6c153abead3e"), new Guid("425c14dd-dea5-44cc-bcd8-e18063b8dd38") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f73fa4f2-2193-45d5-a643-6c153abead3e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("425c14dd-dea5-44cc-bcd8-e18063b8dd38"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("07f32acd-dfc2-401e-8b86-c03f73314a81"), null, "Staff", "STAFF" },
                    { new Guid("0e806b7d-5022-4c46-ae77-98a23fa82b40"), null, "Admin", "ADMIN" },
                    { new Guid("2871417e-fb97-429a-9766-696bfbcda5a9"), null, "Project Provider", "PROJECT PROVIDER" },
                    { new Guid("31886176-a919-4c46-ad54-b0c23761e349"), null, "Apartment Onwer", "APARTMENT ONWER" },
                    { new Guid("bacd3427-fd71-49ec-a455-912c6af427df"), null, "Management", "MANAGEMENT" },
                    { new Guid("f4f46b24-54f6-4fa9-8c7d-f4680c601d20"), null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0cbb6c8b-06ef-420c-a0d2-bd7f0658458b"), 0, 0, "", "b4a4928b-032a-4970-8609-bcce80661de6", "quansongngu13@gmail.com", true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", "AQAAAAIAAYagAAAAEEkW1IMsso7MaEf5+p2ButGdeyxpwHrsTGjeS54qQy2imhgVp6HxlUoQTGNTEa4R8A==", "0949035672", true, "61d1b9e2-207a-415d-9be9-bbb4afccf74d", false, "quansongngu13@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("0e806b7d-5022-4c46-ae77-98a23fa82b40"), new Guid("0cbb6c8b-06ef-420c-a0d2-bd7f0658458b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("07f32acd-dfc2-401e-8b86-c03f73314a81"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2871417e-fb97-429a-9766-696bfbcda5a9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("31886176-a919-4c46-ad54-b0c23761e349"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bacd3427-fd71-49ec-a455-912c6af427df"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f4f46b24-54f6-4fa9-8c7d-f4680c601d20"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0e806b7d-5022-4c46-ae77-98a23fa82b40"), new Guid("0cbb6c8b-06ef-420c-a0d2-bd7f0658458b") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0e806b7d-5022-4c46-ae77-98a23fa82b40"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0cbb6c8b-06ef-420c-a0d2-bd7f0658458b"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("f73fa4f2-2193-45d5-a643-6c153abead3e"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("425c14dd-dea5-44cc-bcd8-e18063b8dd38"), 0, 0, "", "5a5fdcaa-181d-4211-b97f-33a7e8f02fa9", "quansongngu13@gmail.com", true, false, null, "Quan", "QUANSONGNGU13@GMAIL.COM", "QUANSONGNGU13@GMAIL.COM", "AQAAAAIAAYagAAAAEB1Nzz/BLT9fqu5Pa9Mj+yqE5rlNj6Ex7rGAJPfZajj6YCLGuiYnRgE7NqXMW/XIQw==", "0949035672", true, "47bf8592-2c67-4ede-8f79-51a36e3c25b0", false, "quansongngu13@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("f73fa4f2-2193-45d5-a643-6c153abead3e"), new Guid("425c14dd-dea5-44cc-bcd8-e18063b8dd38") });
        }
    }
}
