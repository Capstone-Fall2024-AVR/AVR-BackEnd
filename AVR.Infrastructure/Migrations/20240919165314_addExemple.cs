using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addExemple : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
