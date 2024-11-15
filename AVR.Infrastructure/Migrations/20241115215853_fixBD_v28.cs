using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixBD_v28 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommissionFee_1",
                table: "ProjectFee",
                newName: "CommissionFee");

            migrationBuilder.AddColumn<string>(
                name: "DepositCode",
                table: "DepositRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DepositType",
                table: "DepositRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ProcedureFee",
                table: "ApplicationSettings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepositCode",
                table: "DepositRequest");

            migrationBuilder.DropColumn(
                name: "DepositType",
                table: "DepositRequest");

            migrationBuilder.DropColumn(
                name: "ProcedureFee",
                table: "ApplicationSettings");

            migrationBuilder.RenameColumn(
                name: "CommissionFee",
                table: "ProjectFee",
                newName: "CommissionFee_1");
        }
    }
}
