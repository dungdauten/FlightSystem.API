using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlightSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "UserLogins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "UserLogins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "UserLogins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "UserLogins",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "UserLogins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "UserLogins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "PlaneInfo",
                columns: new[] { "PlaneID", "APlaneCapity", "APlaneName", "Price" },
                values: new object[,]
                {
                    { 1, 1000, "Air Lines", 10000f },
                    { 2, 1500, "Vietjet", 500f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DeleteData(
                table: "PlaneInfo",
                keyColumn: "PlaneID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlaneInfo",
                keyColumn: "PlaneID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserLogins");
        }
    }
}
