using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_PropertyVerification_VerificationID",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyVerification_PropertyRequest_PropertyRequestID",
                table: "PropertyVerification");

            migrationBuilder.DropIndex(
                name: "IX_PropertyVerification_PropertyRequestID",
                table: "PropertyVerification");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_VerificationID",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "VerificationID",
                table: "Apartments");

            migrationBuilder.RenameColumn(
                name: "PropertyRequestID",
                table: "PropertyVerification",
                newName: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyVerification_ApartmentID",
                table: "PropertyVerification",
                column: "ApartmentID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyVerification_Apartments_ApartmentID",
                table: "PropertyVerification",
                column: "ApartmentID",
                principalTable: "Apartments",
                principalColumn: "ApartmentID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyVerification_Apartments_ApartmentID",
                table: "PropertyVerification");

            migrationBuilder.DropIndex(
                name: "IX_PropertyVerification_ApartmentID",
                table: "PropertyVerification");

            migrationBuilder.RenameColumn(
                name: "ApartmentID",
                table: "PropertyVerification",
                newName: "PropertyRequestID");

            migrationBuilder.AddColumn<Guid>(
                name: "VerificationID",
                table: "Apartments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyVerification_PropertyRequestID",
                table: "PropertyVerification",
                column: "PropertyRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_VerificationID",
                table: "Apartments",
                column: "VerificationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_PropertyVerification_VerificationID",
                table: "Apartments",
                column: "VerificationID",
                principalTable: "PropertyVerification",
                principalColumn: "VerificationID");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyVerification_PropertyRequest_PropertyRequestID",
                table: "PropertyVerification",
                column: "PropertyRequestID",
                principalTable: "PropertyRequest",
                principalColumn: "RequestID");
        }
    }
}
