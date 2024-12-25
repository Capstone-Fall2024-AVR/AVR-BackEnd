using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v53 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LegalDocument_PropertyVerification_PropertyVerificationVerificationID",
                table: "LegalDocument");

            migrationBuilder.DropIndex(
                name: "IX_LegalDocument_PropertyVerificationVerificationID",
                table: "LegalDocument");

            migrationBuilder.DropColumn(
                name: "PropertyVerificationVerificationID",
                table: "LegalDocument");

            migrationBuilder.CreateIndex(
                name: "IX_LegalDocument_VerificationID",
                table: "LegalDocument",
                column: "VerificationID");

            migrationBuilder.AddForeignKey(
                name: "FK_LegalDocument_PropertyVerification_VerificationID",
                table: "LegalDocument",
                column: "VerificationID",
                principalTable: "PropertyVerification",
                principalColumn: "VerificationID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LegalDocument_PropertyVerification_VerificationID",
                table: "LegalDocument");

            migrationBuilder.DropIndex(
                name: "IX_LegalDocument_VerificationID",
                table: "LegalDocument");

            migrationBuilder.AddColumn<Guid>(
                name: "PropertyVerificationVerificationID",
                table: "LegalDocument",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_LegalDocument_PropertyVerificationVerificationID",
                table: "LegalDocument",
                column: "PropertyVerificationVerificationID");

            migrationBuilder.AddForeignKey(
                name: "FK_LegalDocument_PropertyVerification_PropertyVerificationVerificationID",
                table: "LegalDocument",
                column: "PropertyVerificationVerificationID",
                principalTable: "PropertyVerification",
                principalColumn: "VerificationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
