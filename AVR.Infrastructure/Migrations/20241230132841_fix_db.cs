using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fix_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disbursements");

            migrationBuilder.DropTable(
                name: "RequestAssignment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Disbursements",
                columns: table => new
                {
                    DisbursementID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disbursements", x => x.DisbursementID);
                    table.ForeignKey(
                        name: "FK_Disbursements_ProjectApartments_ProjectApartmentID",
                        column: x => x.ProjectApartmentID,
                        principalTable: "ProjectApartments",
                        principalColumn: "ProjectApartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestAssignment",
                columns: table => new
                {
                    AssignmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssignedTeamMemberID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssignedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CompleteDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    RequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestAssignment", x => x.AssignmentId);
                    table.ForeignKey(
                        name: "FK_RequestAssignment_TeamMembers_AssignedTeamMemberID",
                        column: x => x.AssignedTeamMemberID,
                        principalTable: "TeamMembers",
                        principalColumn: "TeamMemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disbursements_ProjectApartmentID",
                table: "Disbursements",
                column: "ProjectApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestAssignment_AssignedTeamMemberID",
                table: "RequestAssignment",
                column: "AssignedTeamMemberID");
        }
    }
}
