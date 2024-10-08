using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class extendedidentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a331ac0-cf0e-49d1-8a18-6f7298ca90a0",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42e1243f-2ede-4ab4-a756-48506c622a3b", new DateOnly(1950, 12, 1), "Default", "Admim", "AQAAAAIAAYagAAAAEOociL9jR7k8YWYUF4o2+bV171DYsIKYPRAeh0bvkHABnekg3QwXq8EeF1Cl06JihQ==", "3ba65c24-ab58-46cd-a449-0b25e040ecce" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a331ac0-cf0e-49d1-8a18-6f7298ca90a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fa46713-f63f-46a8-b5e6-9162d6120eb4", "AQAAAAIAAYagAAAAEN2/S2ApK7yKx6iIeAGRiPZ9v8g9u5DtbucsXVSHNIQ/pK8EPaG2BbPzwMeaRdKe4g==", "637e4dab-5110-44ad-a847-dc9a27201aba" });
        }
    }
}
