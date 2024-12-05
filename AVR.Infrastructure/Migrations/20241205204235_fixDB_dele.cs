using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_dele : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepositCancel");

            migrationBuilder.DropTable(
                name: "RequestApartments");

            migrationBuilder.DropTable(
                name: "DepositCancelTypes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepositCancelTypes",
                columns: table => new
                {
                    DepositCancelTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DepositCancelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositCancelTypes", x => x.DepositCancelTypeID);
                });

            migrationBuilder.CreateTable(
                name: "RequestApartments",
                columns: table => new
                {
                    RequestApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ResponseMessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestApartments", x => x.RequestApartmentID);
                    table.ForeignKey(
                        name: "FK_RequestApartments_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentID");
                    table.ForeignKey(
                        name: "FK_RequestApartments_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepositCancel",
                columns: table => new
                {
                    DepositCancelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositCancelTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CancelDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RecoveryPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefundDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    updateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositCancel", x => x.DepositCancelID);
                    table.ForeignKey(
                        name: "FK_DepositCancel_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DepositCancel_DepositCancelTypes_DepositCancelTypeID",
                        column: x => x.DepositCancelTypeID,
                        principalTable: "DepositCancelTypes",
                        principalColumn: "DepositCancelTypeID");
                    table.ForeignKey(
                        name: "FK_DepositCancel_DepositRequest_DepositID",
                        column: x => x.DepositID,
                        principalTable: "DepositRequest",
                        principalColumn: "DepositID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepositCancel_AccountID",
                table: "DepositCancel",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_DepositCancel_DepositCancelTypeID",
                table: "DepositCancel",
                column: "DepositCancelTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DepositCancel_DepositID",
                table: "DepositCancel",
                column: "DepositID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestApartments_AccountID",
                table: "RequestApartments",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestApartments_ApartmentID",
                table: "RequestApartments",
                column: "ApartmentID");
        }
    }
}
