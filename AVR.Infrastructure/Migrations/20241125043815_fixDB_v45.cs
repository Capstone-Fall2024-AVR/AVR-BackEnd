using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v45 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StaffID",
                table: "DepositRequest",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "DepositRequest");
        }
    }
}
