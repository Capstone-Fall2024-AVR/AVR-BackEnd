using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixPropertyVerification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyVerification_PropertyRequest_VerificationID",
                table: "PropertyVerification");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyVerification_PropertyRequestID",
                table: "PropertyVerification",
                column: "PropertyRequestID");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyVerification_PropertyRequest_PropertyRequestID",
                table: "PropertyVerification",
                column: "PropertyRequestID",
                principalTable: "PropertyRequest",
                principalColumn: "RequestID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyVerification_PropertyRequest_PropertyRequestID",
                table: "PropertyVerification");

            migrationBuilder.DropIndex(
                name: "IX_PropertyVerification_PropertyRequestID",
                table: "PropertyVerification");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyVerification_PropertyRequest_VerificationID",
                table: "PropertyVerification",
                column: "VerificationID",
                principalTable: "PropertyRequest",
                principalColumn: "RequestID");
        }
    }
}
