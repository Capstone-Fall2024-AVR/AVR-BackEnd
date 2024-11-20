using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v35 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisbursementStatus",
                table: "DepositRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "TeamMemberID",
                table: "DepositRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepositRequest_TeamMemberID",
                table: "DepositRequest",
                column: "TeamMemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_DepositRequest_TeamMembers_TeamMemberID",
                table: "DepositRequest",
                column: "TeamMemberID",
                principalTable: "TeamMembers",
                principalColumn: "TeamMemberID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepositRequest_TeamMembers_TeamMemberID",
                table: "DepositRequest");

            migrationBuilder.DropIndex(
                name: "IX_DepositRequest_TeamMemberID",
                table: "DepositRequest");

            migrationBuilder.DropColumn(
                name: "DisbursementStatus",
                table: "DepositRequest");

            migrationBuilder.DropColumn(
                name: "TeamMemberID",
                table: "DepositRequest");
        }
    }
}
