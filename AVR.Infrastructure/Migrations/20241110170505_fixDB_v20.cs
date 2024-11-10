using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AssignedTeamMemberID",
                table: "RequestAssignment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AssignedTeamMemberID",
                table: "PropertyRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssignedTeamMemberID",
                table: "AppointmentRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssignedTeamMemberID",
                table: "Appointment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestAssignment_AssignedTeamMemberID",
                table: "RequestAssignment",
                column: "AssignedTeamMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRequest_AssignedTeamMemberID",
                table: "PropertyRequest",
                column: "AssignedTeamMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentRequest_AssignedTeamMemberID",
                table: "AppointmentRequest",
                column: "AssignedTeamMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_AssignedTeamMemberID",
                table: "Appointment",
                column: "AssignedTeamMemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_TeamMembers_AssignedTeamMemberID",
                table: "Appointment",
                column: "AssignedTeamMemberID",
                principalTable: "TeamMembers",
                principalColumn: "TeamMemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentRequest_TeamMembers_AssignedTeamMemberID",
                table: "AppointmentRequest",
                column: "AssignedTeamMemberID",
                principalTable: "TeamMembers",
                principalColumn: "TeamMemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyRequest_TeamMembers_AssignedTeamMemberID",
                table: "PropertyRequest",
                column: "AssignedTeamMemberID",
                principalTable: "TeamMembers",
                principalColumn: "TeamMemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestAssignment_TeamMembers_AssignedTeamMemberID",
                table: "RequestAssignment",
                column: "AssignedTeamMemberID",
                principalTable: "TeamMembers",
                principalColumn: "TeamMemberID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_TeamMembers_AssignedTeamMemberID",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentRequest_TeamMembers_AssignedTeamMemberID",
                table: "AppointmentRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyRequest_TeamMembers_AssignedTeamMemberID",
                table: "PropertyRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestAssignment_TeamMembers_AssignedTeamMemberID",
                table: "RequestAssignment");

            migrationBuilder.DropIndex(
                name: "IX_RequestAssignment_AssignedTeamMemberID",
                table: "RequestAssignment");

            migrationBuilder.DropIndex(
                name: "IX_PropertyRequest_AssignedTeamMemberID",
                table: "PropertyRequest");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentRequest_AssignedTeamMemberID",
                table: "AppointmentRequest");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_AssignedTeamMemberID",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "AssignedTeamMemberID",
                table: "RequestAssignment");

            migrationBuilder.DropColumn(
                name: "AssignedTeamMemberID",
                table: "PropertyRequest");

            migrationBuilder.DropColumn(
                name: "AssignedTeamMemberID",
                table: "AppointmentRequest");

            migrationBuilder.DropColumn(
                name: "AssignedTeamMemberID",
                table: "Appointment");
        }
    }
}
