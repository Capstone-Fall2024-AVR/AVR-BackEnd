using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addDepositProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropColumn(
                name: "constractNumber",
                table: "DepositRequest");

            migrationBuilder.CreateTable(
                name: "DepositProfile",
                columns: table => new
                {
                    ProfileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityCardFrontImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityCardBackImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepositID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositProfile", x => x.ProfileID);
                    table.ForeignKey(
                        name: "FK_DepositProfile_DepositRequest_DepositID",
                        column: x => x.DepositID,
                        principalTable: "DepositRequest",
                        principalColumn: "DepositID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepositProfile_DepositID",
                table: "DepositProfile",
                column: "DepositID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepositProfile");

            migrationBuilder.AddColumn<double>(
                name: "constractNumber",
                table: "DepositRequest",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            
        }
    }
}
