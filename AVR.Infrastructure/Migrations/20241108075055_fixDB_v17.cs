using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TeamID",
                table: "ProjectApartments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssignedTeamMemberID",
                table: "Apartments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    TeamMemberID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeamID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.TeamMemberID);
                    table.ForeignKey(
                        name: "FK_TeamMembers_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectApartments_TeamID",
                table: "ProjectApartments",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_AssignedTeamMemberID",
                table: "Apartments",
                column: "AssignedTeamMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_AccountID",
                table: "TeamMembers",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_TeamID",
                table: "TeamMembers",
                column: "TeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_TeamMembers_AssignedTeamMemberID",
                table: "Apartments",
                column: "AssignedTeamMemberID",
                principalTable: "TeamMembers",
                principalColumn: "TeamMemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectApartments_Teams_TeamID",
                table: "ProjectApartments",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "TeamID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_TeamMembers_AssignedTeamMemberID",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectApartments_Teams_TeamID",
                table: "ProjectApartments");

            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_ProjectApartments_TeamID",
                table: "ProjectApartments");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_AssignedTeamMemberID",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "TeamID",
                table: "ProjectApartments");

            migrationBuilder.DropColumn(
                name: "AssignedTeamMemberID",
                table: "Apartments");
        }
    }
}
