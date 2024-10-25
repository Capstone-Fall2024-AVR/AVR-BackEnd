using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ApartmentOwnerApartment_AccountID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentOwnerApartment_ApartmentID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwnerApartment_AccountID",
                table: "ApartmentOwnerApartment",
                column: "AccountID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwnerApartment_ApartmentID",
                table: "ApartmentOwnerApartment",
                column: "ApartmentID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ApartmentOwnerApartment_AccountID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentOwnerApartment_ApartmentID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwnerApartment_AccountID",
                table: "ApartmentOwnerApartment",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwnerApartment_ApartmentID",
                table: "ApartmentOwnerApartment",
                column: "ApartmentID");
        }
    }
}
