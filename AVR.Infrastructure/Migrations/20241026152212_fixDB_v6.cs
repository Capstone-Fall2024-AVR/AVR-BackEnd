using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "AssignedDate",
                table: "AppointmentRequest",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "PreferredTime",
                table: "AppointmentRequest",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "Appointment",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "Appointment",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedDate",
                table: "AppointmentRequest");

            migrationBuilder.DropColumn(
                name: "PreferredTime",
                table: "AppointmentRequest");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Appointment");
        }
    }
}
