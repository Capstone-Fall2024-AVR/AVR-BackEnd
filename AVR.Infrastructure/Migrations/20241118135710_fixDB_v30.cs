using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "BrokerageFee",
                table: "DepositRequest",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CommissionFee",
                table: "DepositRequest",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TradeFee",
                table: "DepositRequest",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PossessionType",
                table: "Apartments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrokerageFee",
                table: "DepositRequest");

            migrationBuilder.DropColumn(
                name: "CommissionFee",
                table: "DepositRequest");

            migrationBuilder.DropColumn(
                name: "TradeFee",
                table: "DepositRequest");

            migrationBuilder.DropColumn(
                name: "PossessionType",
                table: "Apartments");
        }
    }
}
