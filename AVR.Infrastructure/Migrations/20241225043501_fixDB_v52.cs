using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v52 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.CreateTable(
                name: "LegalDocument",
                columns: table => new
                {
                    LegalDocumentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    VerificationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyVerificationVerificationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalDocument", x => x.LegalDocumentID);
                    table.ForeignKey(
                        name: "FK_LegalDocument_PropertyVerification_PropertyVerificationVerificationID",
                        column: x => x.PropertyVerificationVerificationID,
                        principalTable: "PropertyVerification",
                        principalColumn: "VerificationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LegalDocument_PropertyVerificationVerificationID",
                table: "LegalDocument",
                column: "PropertyVerificationVerificationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LegalDocument");

            migrationBuilder.AddColumn<string>(
                name: "LegalDocumentsURL",
                table: "PropertyVerification",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
