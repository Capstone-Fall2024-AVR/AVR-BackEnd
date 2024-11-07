using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDB_v16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApartmentCode",
                table: "Apartments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            // Thêm dữ liệu vào cột ApartmentCode cho các bản ghi hiện có
            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("1ae7ec1e-cda1-4b96-bbde-7499f8919409"),
                column: "ApartmentCode",
                value: "SKY123" // Giá trị mẫu cho mã Skyline Apartment
            );

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("4250f817-581f-47d4-a806-50d1324b61e3"),
                column: "ApartmentCode",
                value: "OCE456" // Giá trị mẫu cho mã Ocean View Apartment
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApartmentCode",
                table: "Apartments");

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("1ae7ec1e-cda1-4b96-bbde-7499f8919409"),
                column: "ApartmentCode",
                value: "" // Trả về giá trị mặc định
            );

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "ApartmentID",
                keyValue: new Guid("4250f817-581f-47d4-a806-50d1324b61e3"),
                column: "ApartmentCode",
                value: "" // Trả về giá trị mặc định
            );
        }
    }
}
