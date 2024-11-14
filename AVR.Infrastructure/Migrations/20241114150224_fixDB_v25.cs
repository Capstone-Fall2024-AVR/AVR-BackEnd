using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentOwnerApartment_Apartments_ApartmentID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentOwnerApartment_AspNetUsers_AccountID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyVerification_Apartments_ApartmentID",
                table: "PropertyVerification");

            migrationBuilder.DropIndex(
                name: "IX_PropertyVerification_ApartmentID",
                table: "PropertyVerification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentOwnerApartment",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentOwnerApartment_AccountID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentOwnerApartment_ApartmentID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.RenameColumn(
                name: "ApartmentID",
                table: "PropertyVerification",
                newName: "ApartmentOwnerApartmentID");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "ApartmentOwnerApartment",
                newName: "AssignedTeamMemberID");

            migrationBuilder.RenameColumn(
                name: "DocumentID",
                table: "ApartmentOwnerApartment",
                newName: "ApartmentOwnerID");

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "PropertyVerification",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "BrokerageFee",
                table: "PropertyVerification",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CommissionRate",
                table: "PropertyVerification",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DepositValue",
                table: "PropertyVerification",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "EffectiveDate",
                table: "PropertyVerification",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ExpiryDate",
                table: "PropertyVerification",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<decimal>(
                name: "PropertyValue",
                table: "PropertyVerification",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SecurityDeposit",
                table: "PropertyVerification",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "VerificationName",
                table: "PropertyVerification",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "EffectiveStartDate",
                table: "Apartments",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "ApartmentID",
                table: "ApartmentOwnerApartment",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ApartmentOwnerApartmentID",
                table: "ApartmentOwnerApartment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "OwnershipStatus",
                table: "ApartmentOwnerApartment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentOwnerApartment",
                table: "ApartmentOwnerApartment",
                column: "ApartmentOwnerApartmentID");

            migrationBuilder.CreateTable(
                name: "ApartmentOwner",
                columns: table => new
                {
                    ApartmentOwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentOwner", x => x.ApartmentOwnerID);
                    table.ForeignKey(
                        name: "FK_ApartmentOwner_AspNetUsers_AccountID",
                        column: x => x.AccountID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

           

            migrationBuilder.CreateIndex(
                name: "IX_PropertyVerification_ApartmentOwnerApartmentID",
                table: "PropertyVerification",
                column: "ApartmentOwnerApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwnerApartment_ApartmentID",
                table: "ApartmentOwnerApartment",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwnerApartment_ApartmentOwnerID",
                table: "ApartmentOwnerApartment",
                column: "ApartmentOwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwnerApartment_AssignedTeamMemberID",
                table: "ApartmentOwnerApartment",
                column: "AssignedTeamMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwner_AccountID",
                table: "ApartmentOwner",
                column: "AccountID",
                unique: true);



            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentOwnerApartment_ApartmentOwner_ApartmentOwnerID",
                table: "ApartmentOwnerApartment",
                column: "ApartmentOwnerID",
                principalTable: "ApartmentOwner",
                principalColumn: "ApartmentOwnerID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentOwnerApartment_Apartments_ApartmentID",
                table: "ApartmentOwnerApartment",
                column: "ApartmentID",
                principalTable: "Apartments",
                principalColumn: "ApartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentOwnerApartment_TeamMembers_AssignedTeamMemberID",
                table: "ApartmentOwnerApartment",
                column: "AssignedTeamMemberID",
                principalTable: "TeamMembers",
                principalColumn: "TeamMemberID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyVerification_ApartmentOwnerApartment_ApartmentOwnerApartmentID",
                table: "PropertyVerification",
                column: "ApartmentOwnerApartmentID",
                principalTable: "ApartmentOwnerApartment",
                principalColumn: "ApartmentOwnerApartmentID",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentOwnerApartment_ApartmentOwner_ApartmentOwnerID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentOwnerApartment_Apartments_ApartmentID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentOwnerApartment_TeamMembers_AssignedTeamMemberID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyVerification_ApartmentOwnerApartment_ApartmentOwnerApartmentID",
                table: "PropertyVerification");

            migrationBuilder.DropTable(
                name: "ApartmentOwner");


            migrationBuilder.DropIndex(
                name: "IX_PropertyVerification_ApartmentOwnerApartmentID",
                table: "PropertyVerification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentOwnerApartment",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentOwnerApartment_ApartmentID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentOwnerApartment_ApartmentOwnerID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentOwnerApartment_AssignedTeamMemberID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropColumn(
                name: "BrokerageFee",
                table: "PropertyVerification");

            migrationBuilder.DropColumn(
                name: "CommissionRate",
                table: "PropertyVerification");

            migrationBuilder.DropColumn(
                name: "DepositValue",
                table: "PropertyVerification");

            migrationBuilder.DropColumn(
                name: "EffectiveDate",
                table: "PropertyVerification");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "PropertyVerification");

            migrationBuilder.DropColumn(
                name: "PropertyValue",
                table: "PropertyVerification");

            migrationBuilder.DropColumn(
                name: "SecurityDeposit",
                table: "PropertyVerification");

            migrationBuilder.DropColumn(
                name: "VerificationName",
                table: "PropertyVerification");

            migrationBuilder.DropColumn(
                name: "EffectiveStartDate",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "ApartmentOwnerApartmentID",
                table: "ApartmentOwnerApartment");

            migrationBuilder.DropColumn(
                name: "OwnershipStatus",
                table: "ApartmentOwnerApartment");

            migrationBuilder.RenameColumn(
                name: "ApartmentOwnerApartmentID",
                table: "PropertyVerification",
                newName: "ApartmentID");

            migrationBuilder.RenameColumn(
                name: "AssignedTeamMemberID",
                table: "ApartmentOwnerApartment",
                newName: "AccountID");

            migrationBuilder.RenameColumn(
                name: "ApartmentOwnerID",
                table: "ApartmentOwnerApartment",
                newName: "DocumentID");

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "PropertyVerification",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ApartmentID",
                table: "ApartmentOwnerApartment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentOwnerApartment",
                table: "ApartmentOwnerApartment",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyVerification_ApartmentID",
                table: "PropertyVerification",
                column: "ApartmentID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwnerApartment_AccountID",
                table: "ApartmentOwnerApartment",
                column: "AccountID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwnerApartment_ApartmentID",
                table: "ApartmentOwnerApartment",
                column: "ApartmentID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentOwnerApartment_Apartments_ApartmentID",
                table: "ApartmentOwnerApartment",
                column: "ApartmentID",
                principalTable: "Apartments",
                principalColumn: "ApartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentOwnerApartment_AspNetUsers_AccountID",
                table: "ApartmentOwnerApartment",
                column: "AccountID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyVerification_Apartments_ApartmentID",
                table: "PropertyVerification",
                column: "ApartmentID",
                principalTable: "Apartments",
                principalColumn: "ApartmentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
