using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlightSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class DTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "40758e32-049f-4092-882e-a0e21450c571");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7630441d-792c-4c1f-9c30-bb3f43470c00");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "97aebfe1-1fed-413e-99b5-3a135eb62f58");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b85be2ff-da63-4fbf-aa75-c12a91398605");

            migrationBuilder.AlterColumn<string>(
                name: "FromCity",
                table: "TblFlightBook",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddColumn<int>(
                name: "Flight_Id",
                table: "TblFlightBook",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PlaneInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0784806d-d1d1-404f-a713-f5cee08433a4", "1", "Admin", "Admin" },
                    { "9b50678d-a951-4dae-8a56-2bbe44d72bf6", "1", "Tiếp viên", "Tiếp viên" },
                    { "d0a9a97b-e725-4021-ad86-c91f6401f88b", "1", "Phi công", "Phi công" },
                    { "e00010d7-01bf-42d1-b379-4f248a35b797", "1", "Nhân viên Go", "Nhân viên Go" }
                });

            migrationBuilder.UpdateData(
                table: "PlaneInfo",
                keyColumn: "PlaneID",
                keyValue: 1,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PlaneInfo",
                keyColumn: "PlaneID",
                keyValue: 2,
                column: "Id",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0784806d-d1d1-404f-a713-f5cee08433a4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9b50678d-a951-4dae-8a56-2bbe44d72bf6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d0a9a97b-e725-4021-ad86-c91f6401f88b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e00010d7-01bf-42d1-b379-4f248a35b797");

            migrationBuilder.DropColumn(
                name: "Flight_Id",
                table: "TblFlightBook");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PlaneInfo");

            migrationBuilder.AlterColumn<string>(
                name: "FromCity",
                table: "TblFlightBook",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40758e32-049f-4092-882e-a0e21450c571", "1", "Admin", "Admin" },
                    { "7630441d-792c-4c1f-9c30-bb3f43470c00", "1", "Phi công", "Phi công" },
                    { "97aebfe1-1fed-413e-99b5-3a135eb62f58", "1", "Nhân viên Go", "Nhân viên Go" },
                    { "b85be2ff-da63-4fbf-aa75-c12a91398605", "1", "Tiếp viên", "Tiếp viên" }
                });
        }
    }
}
