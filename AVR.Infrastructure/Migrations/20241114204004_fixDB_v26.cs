using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v26 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractFileUrl",
                table: "ProjectFinancialContract");

            migrationBuilder.DropColumn(
                name: "EffectiveDate",
                table: "ProjectFinancialContract");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "ProjectFinancialContract");

            migrationBuilder.RenameColumn(
                name: "CommissionFee_3",
                table: "ProjectFinancialContract",
                newName: "LowestPrice");

            migrationBuilder.RenameColumn(
                name: "CommissionFee_2",
                table: "ProjectFinancialContract",
                newName: "HighestPrice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LowestPrice",
                table: "ProjectFinancialContract",
                newName: "CommissionFee_3");

            migrationBuilder.RenameColumn(
                name: "HighestPrice",
                table: "ProjectFinancialContract",
                newName: "CommissionFee_2");

            migrationBuilder.AddColumn<string>(
                name: "ContractFileUrl",
                table: "ProjectFinancialContract",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "EffectiveDate",
                table: "ProjectFinancialContract",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "EndDate",
                table: "ProjectFinancialContract",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
