using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class delete_sellerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentRequest_AspNetUsers_SellerID",
                table: "AppointmentRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyRequest_AspNetUsers_SellerID",
                table: "PropertyRequest");

            migrationBuilder.DropIndex(
                name: "IX_PropertyRequest_SellerID",
                table: "PropertyRequest");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentRequest_SellerID",
                table: "AppointmentRequest");

            migrationBuilder.DropColumn(
                name: "SellerID",
                table: "PropertyRequest");

            migrationBuilder.DropColumn(
                name: "SellerID",
                table: "AppointmentRequest");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SellerID",
                table: "PropertyRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SellerID",
                table: "AppointmentRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRequest_SellerID",
                table: "PropertyRequest",
                column: "SellerID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentRequest_SellerID",
                table: "AppointmentRequest",
                column: "SellerID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentRequest_AspNetUsers_SellerID",
                table: "AppointmentRequest",
                column: "SellerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyRequest_AspNetUsers_SellerID",
                table: "PropertyRequest",
                column: "SellerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
