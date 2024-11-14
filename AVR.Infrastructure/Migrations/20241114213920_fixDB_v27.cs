using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v27 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectFinancialContract_ProjectApartments_ProjectApartmentID",
                table: "ProjectFinancialContract");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectFinancialContract",
                table: "ProjectFinancialContract");

            migrationBuilder.RenameTable(
                name: "ProjectFinancialContract",
                newName: "ProjectFee");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectFinancialContract_ProjectApartmentID",
                table: "ProjectFee",
                newName: "IX_ProjectFee_ProjectApartmentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectFee",
                table: "ProjectFee",
                column: "FinancialContractID");

            migrationBuilder.CreateTable(
                name: "ProjectFiles",
                columns: table => new
                {
                    ProjectFileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ProjectApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectFiles", x => x.ProjectFileID);
                    table.ForeignKey(
                        name: "FK_ProjectFiles_ProjectApartments_ProjectApartmentID",
                        column: x => x.ProjectApartmentID,
                        principalTable: "ProjectApartments",
                        principalColumn: "ProjectApartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFiles_ProjectApartmentID",
                table: "ProjectFiles",
                column: "ProjectApartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectFee_ProjectApartments_ProjectApartmentID",
                table: "ProjectFee",
                column: "ProjectApartmentID",
                principalTable: "ProjectApartments",
                principalColumn: "ProjectApartmentID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectFee_ProjectApartments_ProjectApartmentID",
                table: "ProjectFee");

            migrationBuilder.DropTable(
                name: "ProjectFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectFee",
                table: "ProjectFee");

            migrationBuilder.RenameTable(
                name: "ProjectFee",
                newName: "ProjectFinancialContract");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectFee_ProjectApartmentID",
                table: "ProjectFinancialContract",
                newName: "IX_ProjectFinancialContract_ProjectApartmentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectFinancialContract",
                table: "ProjectFinancialContract",
                column: "FinancialContractID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectFinancialContract_ProjectApartments_ProjectApartmentID",
                table: "ProjectFinancialContract",
                column: "ProjectApartmentID",
                principalTable: "ProjectApartments",
                principalColumn: "ProjectApartmentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
