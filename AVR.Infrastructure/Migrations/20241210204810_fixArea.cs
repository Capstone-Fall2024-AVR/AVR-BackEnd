using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixArea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Area",
                table: "Apartments",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Area",
                table: "Apartments",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");
        }
    }
}
