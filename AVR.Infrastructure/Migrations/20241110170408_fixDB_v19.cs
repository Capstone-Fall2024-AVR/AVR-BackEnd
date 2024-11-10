using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_AspNetUsers_StaffID",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentRequest_AspNetUsers_StaffID",
                table: "AppointmentRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyRequest_AspNetUsers_StaffID",
                table: "PropertyRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestAssignment_AspNetUsers_StaffId",
                table: "RequestAssignment");

            migrationBuilder.DropIndex(
                name: "IX_RequestAssignment_StaffId",
                table: "RequestAssignment");

            migrationBuilder.DropIndex(
                name: "IX_PropertyRequest_StaffID",
                table: "PropertyRequest");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentRequest_StaffID",
                table: "AppointmentRequest");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_StaffID",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "RequestAssignment");

            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "PropertyRequest");

            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "AppointmentRequest");

            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "Appointment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StaffId",
                table: "RequestAssignment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StaffID",
                table: "PropertyRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StaffID",
                table: "AppointmentRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StaffID",
                table: "Appointment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestAssignment_StaffId",
                table: "RequestAssignment",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRequest_StaffID",
                table: "PropertyRequest",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentRequest_StaffID",
                table: "AppointmentRequest",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_StaffID",
                table: "Appointment",
                column: "StaffID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_AspNetUsers_StaffID",
                table: "Appointment",
                column: "StaffID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentRequest_AspNetUsers_StaffID",
                table: "AppointmentRequest",
                column: "StaffID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyRequest_AspNetUsers_StaffID",
                table: "PropertyRequest",
                column: "StaffID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestAssignment_AspNetUsers_StaffId",
                table: "RequestAssignment",
                column: "StaffId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
