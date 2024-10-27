using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationStatus",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "ReferenceID",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Notifications");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NotificationStatus",
                table: "Notifications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ReferenceID",
                table: "Notifications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Updated",
                table: "Notifications",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
