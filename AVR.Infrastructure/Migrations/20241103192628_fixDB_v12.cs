using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "paymentAmount",
                table: "DepositRequest",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "paymentAmount",
                table: "DepositRequest");
        }
    }
}
