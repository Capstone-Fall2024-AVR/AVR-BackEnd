using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyRequest_TeamMembers_AssignedTeamMemberID",
                table: "PropertyRequest",
                column: "AssignedTeamMemberID",
                principalTable: "TeamMembers",
                principalColumn: "TeamMemberID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyRequest_AspNetUsers_StaffId",
                table: "PropertyRequest",
                column: "StaffId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
