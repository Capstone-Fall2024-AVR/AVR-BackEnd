using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_NotificationTypes_NotificationTypeID",
                table: "Notifications");

            migrationBuilder.DropTable(
                name: "NotificationTypes");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_NotificationTypeID",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "NotificationTypeID",
                table: "Notifications");

            migrationBuilder.AddColumn<int>(
                name: "NotificationTypes",
                table: "Notifications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ReferenceId",
                table: "Notifications",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationTypes",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "ReferenceId",
                table: "Notifications");

            migrationBuilder.AddColumn<Guid>(
                name: "NotificationTypeID",
                table: "Notifications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "NotificationTypes",
                columns: table => new
                {
                    NotificationTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotificationTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTypes", x => x.NotificationTypeID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationTypeID",
                table: "Notifications",
                column: "NotificationTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_NotificationTypes_NotificationTypeID",
                table: "Notifications",
                column: "NotificationTypeID",
                principalTable: "NotificationTypes",
                principalColumn: "NotificationTypeID");
        }
    }
}
