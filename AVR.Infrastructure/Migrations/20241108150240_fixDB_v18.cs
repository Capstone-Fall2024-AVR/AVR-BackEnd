using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Xóa khóa ngoại cũ liên kết với AccountID
            migrationBuilder.DropForeignKey(
                name: "FK_VRExperiences_AspNetUsers_AccountID",
                table: "VRExperiences");

            // Đổi tên cột AccountID thành AssignedTeamMemberID
            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "VRExperiences",
                newName: "AssignedTeamMemberID");

            // Tạo index mới cho AssignedTeamMemberID
            migrationBuilder.CreateIndex(
                name: "IX_VRExperiences_AssignedTeamMemberID",
                table: "VRExperiences",
                column: "AssignedTeamMemberID");

            // Thêm khóa ngoại mới liên kết AssignedTeamMemberID với TeamMembers
            migrationBuilder.AddForeignKey(
                name: "FK_VRExperiences_TeamMembers_AssignedTeamMemberID",
                table: "VRExperiences",
                column: "AssignedTeamMemberID",
                principalTable: "TeamMembers",
                principalColumn: "TeamMemberID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Xóa khóa ngoại liên kết với AssignedTeamMemberID
            migrationBuilder.DropForeignKey(
                name: "FK_VRExperiences_TeamMembers_AssignedTeamMemberID",
                table: "VRExperiences");

            // Xóa index mới
            migrationBuilder.DropIndex(
                name: "IX_VRExperiences_AssignedTeamMemberID",
                table: "VRExperiences");

            // Đổi tên cột AssignedTeamMemberID trở lại AccountID
            migrationBuilder.RenameColumn(
                name: "AssignedTeamMemberID",
                table: "VRExperiences",
                newName: "AccountID");

            // Tạo lại index cũ cho AccountID
            migrationBuilder.CreateIndex(
                name: "IX_VRExperiences_AccountID",
                table: "VRExperiences",
                column: "AccountID");

            // Thêm lại khóa ngoại liên kết với AccountID
            migrationBuilder.AddForeignKey(
                name: "FK_VRExperiences_AspNetUsers_AccountID",
                table: "VRExperiences",
                column: "AccountID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
