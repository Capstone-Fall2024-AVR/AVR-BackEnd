using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApartmentFacilitys");

            migrationBuilder.RenameColumn(
                name: "RecommendedPrice",
                table: "Apartments",
                newName: "Price");

            migrationBuilder.CreateTable(
                name: "ProjectFacilities",
                columns: table => new
                {
                    ProjectFacilityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacilityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectFacilities", x => x.ProjectFacilityID);
                    table.ForeignKey(
                        name: "FK_ProjectFacilities_Facilities_FacilityID",
                        column: x => x.FacilityID,
                        principalTable: "Facilities",
                        principalColumn: "FacilitiesID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectFacilities_ProjectApartments_ProjectApartmentId",
                        column: x => x.ProjectApartmentId,
                        principalTable: "ProjectApartments",
                        principalColumn: "ProjectApartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFacilities_FacilityID",
                table: "ProjectFacilities",
                column: "FacilityID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFacilities_ProjectApartmentId",
                table: "ProjectFacilities",
                column: "ProjectApartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectFacilities");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Apartments",
                newName: "RecommendedPrice");

            migrationBuilder.CreateTable(
                name: "ApartmentFacilitys",
                columns: table => new
                {
                    ApartmentFacilityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacilityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentFacilitys", x => x.ApartmentFacilityID);
                    table.ForeignKey(
                        name: "FK_ApartmentFacilitys_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApartmentFacilitys_Facilities_FacilityID",
                        column: x => x.FacilityID,
                        principalTable: "Facilities",
                        principalColumn: "FacilitiesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentFacilitys_ApartmentID",
                table: "ApartmentFacilitys",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentFacilitys_FacilityID",
                table: "ApartmentFacilitys",
                column: "FacilityID");
        }
    }
}
