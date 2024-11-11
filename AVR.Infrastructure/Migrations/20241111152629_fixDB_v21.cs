using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyRequest_TeamMembers_AssignedTeamMemberID",
                table: "PropertyRequest");

            migrationBuilder.RenameColumn(
                name: "AssignedTeamMemberID",
                table: "PropertyRequest",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyRequest_AssignedTeamMemberID",
                table: "PropertyRequest",
                newName: "IX_PropertyRequest_StaffId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProjectApartmentID",
                table: "Apartments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyRequest_AspNetUsers_StaffId",
                table: "PropertyRequest",
                column: "StaffId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyRequest_AspNetUsers_StaffId",
                table: "PropertyRequest");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "PropertyRequest",
                newName: "AssignedTeamMemberID");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyRequest_StaffId",
                table: "PropertyRequest",
                newName: "IX_PropertyRequest_AssignedTeamMemberID");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProjectApartmentID",
                table: "Apartments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyRequest_TeamMembers_AssignedTeamMemberID",
                table: "PropertyRequest",
                column: "AssignedTeamMemberID",
                principalTable: "TeamMembers",
                principalColumn: "TeamMemberID");
        }
    }
}
