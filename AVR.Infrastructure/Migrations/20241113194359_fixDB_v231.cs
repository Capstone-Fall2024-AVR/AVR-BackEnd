using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v231 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "ProjectApartments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressUrl",
                table: "ProjectApartments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApartmentArea",
                table: "ProjectApartments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ConstructionEndYear",
                table: "ProjectApartments",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ConstructionStartYear",
                table: "ProjectApartments",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectCode",
                table: "ProjectApartments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProjectSize",
                table: "ProjectApartments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalApartment",
                table: "ProjectApartments",
                type: "nvarchar(max)",
                nullable: true);*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "ProjectApartments");

            migrationBuilder.DropColumn(
                name: "AddressUrl",
                table: "ProjectApartments");

            migrationBuilder.DropColumn(
                name: "ApartmentArea",
                table: "ProjectApartments");

            migrationBuilder.DropColumn(
                name: "ConstructionEndYear",
                table: "ProjectApartments");

            migrationBuilder.DropColumn(
                name: "ConstructionStartYear",
                table: "ProjectApartments");

            migrationBuilder.DropColumn(
                name: "ProjectCode",
                table: "ProjectApartments");

            migrationBuilder.DropColumn(
                name: "ProjectSize",
                table: "ProjectApartments");

            migrationBuilder.DropColumn(
                name: "TotalApartment",
                table: "ProjectApartments");
        }
    }
}
