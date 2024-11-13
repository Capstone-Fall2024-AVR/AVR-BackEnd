using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectFinancialContract",
                columns: table => new
                {
                    FinancialContractID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrokerageFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommissionFee_1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommissionFee_2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommissionFee_3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EffectiveDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectFinancialContract", x => x.FinancialContractID);
                    table.ForeignKey(
                        name: "FK_ProjectFinancialContract_ProjectApartments_ProjectApartmentID",
                        column: x => x.ProjectApartmentID,
                        principalTable: "ProjectApartments",
                        principalColumn: "ProjectApartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFinancialContract_ProjectApartmentID",
                table: "ProjectFinancialContract",
                column: "ProjectApartmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectFinancialContract");
        }
    }
}
