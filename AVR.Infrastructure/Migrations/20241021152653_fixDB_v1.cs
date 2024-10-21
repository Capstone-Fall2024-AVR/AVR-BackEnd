using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgreementUpdateRequests_ApartmentProjectProvider_ApartmentProjectProviderID",
                table: "AgreementUpdateRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentProjectProvider_AspNetUsers_AccountID",
                table: "ApartmentProjectProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_AspNetUsers_ApartmentOwnerID",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_AspNetUsers_ProjectProviderID",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectApartments_ApartmentProjectProvider_ApartmentProjectProviderID",
                table: "ProjectApartments");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_ApartmentOwnerID",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_AgreementUpdateRequests_ApartmentProjectProviderID",
                table: "AgreementUpdateRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentProjectProvider",
                table: "ApartmentProjectProvider");

            migrationBuilder.DropColumn(
                name: "ApartmentOwnerID",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "ApartmentProjectProviderID",
                table: "AgreementUpdateRequests");

            migrationBuilder.RenameTable(
                name: "ApartmentProjectProvider",
                newName: "ProjectProvider");

            migrationBuilder.RenameColumn(
                name: "ProjectProviderID",
                table: "Appointment",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_ProjectProviderID",
                table: "Appointment",
                newName: "IX_Appointment_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentProjectProvider_AccountID",
                table: "ProjectProvider",
                newName: "IX_ProjectProvider_AccountID");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AgreementUpdateStatus",
                table: "AgreementUpdateRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgreementUpdateType",
                table: "AgreementUpdateRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AgreementUpdateRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RequestTitle",
                table: "AgreementUpdateRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdateDate",
                table: "AgreementUpdateRequests",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectProvider",
                table: "ProjectProvider",
                column: "ApartmentProjectProviderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_AspNetUsers_AccountId",
                table: "Appointment",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectApartments_ProjectProvider_ApartmentProjectProviderID",
                table: "ProjectApartments",
                column: "ApartmentProjectProviderID",
                principalTable: "ProjectProvider",
                principalColumn: "ApartmentProjectProviderID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectProvider_AspNetUsers_AccountID",
                table: "ProjectProvider",
                column: "AccountID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_AspNetUsers_AccountId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectApartments_ProjectProvider_ApartmentProjectProviderID",
                table: "ProjectApartments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectProvider_AspNetUsers_AccountID",
                table: "ProjectProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectProvider",
                table: "ProjectProvider");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "AgreementUpdateStatus",
                table: "AgreementUpdateRequests");

            migrationBuilder.DropColumn(
                name: "AgreementUpdateType",
                table: "AgreementUpdateRequests");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AgreementUpdateRequests");

            migrationBuilder.DropColumn(
                name: "RequestTitle",
                table: "AgreementUpdateRequests");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AgreementUpdateRequests");

            migrationBuilder.RenameTable(
                name: "ProjectProvider",
                newName: "ApartmentProjectProvider");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Appointment",
                newName: "ProjectProviderID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_AccountId",
                table: "Appointment",
                newName: "IX_Appointment_ProjectProviderID");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectProvider_AccountID",
                table: "ApartmentProjectProvider",
                newName: "IX_ApartmentProjectProvider_AccountID");

            migrationBuilder.AddColumn<Guid>(
                name: "ApartmentOwnerID",
                table: "Appointment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApartmentProjectProviderID",
                table: "AgreementUpdateRequests",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentProjectProvider",
                table: "ApartmentProjectProvider",
                column: "ApartmentProjectProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ApartmentOwnerID",
                table: "Appointment",
                column: "ApartmentOwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_AgreementUpdateRequests_ApartmentProjectProviderID",
                table: "AgreementUpdateRequests",
                column: "ApartmentProjectProviderID");

            migrationBuilder.AddForeignKey(
                name: "FK_AgreementUpdateRequests_ApartmentProjectProvider_ApartmentProjectProviderID",
                table: "AgreementUpdateRequests",
                column: "ApartmentProjectProviderID",
                principalTable: "ApartmentProjectProvider",
                principalColumn: "ApartmentProjectProviderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentProjectProvider_AspNetUsers_AccountID",
                table: "ApartmentProjectProvider",
                column: "AccountID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_AspNetUsers_ApartmentOwnerID",
                table: "Appointment",
                column: "ApartmentOwnerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_AspNetUsers_ProjectProviderID",
                table: "Appointment",
                column: "ProjectProviderID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectApartments_ApartmentProjectProvider_ApartmentProjectProviderID",
                table: "ProjectApartments",
                column: "ApartmentProjectProviderID",
                principalTable: "ApartmentProjectProvider",
                principalColumn: "ApartmentProjectProviderID");
        }
    }
}
