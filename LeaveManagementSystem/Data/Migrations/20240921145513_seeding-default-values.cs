using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedingdefaultvalues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(150)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32f3dc8c-1884-407d-b938-362aa2b9d59e", null, "Employee", "EMPLOYEE" },
                    { "d485abbe-0f02-4bd1-ba44-6352659af68a", null, "Supervisor", "SUPERVISOR" },
                    { "f54935f0-7d3b-45aa-ae9b-b864e0170453", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6a331ac0-cf0e-49d1-8a18-6f7298ca90a0", 0, "1fa46713-f63f-46a8-b5e6-9162d6120eb4", "admin@email.com", true, false, null, "ADMIN@EMAIL.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEN2/S2ApK7yKx6iIeAGRiPZ9v8g9u5DtbucsXVSHNIQ/pK8EPaG2BbPzwMeaRdKe4g==", null, false, "637e4dab-5110-44ad-a847-dc9a27201aba", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f54935f0-7d3b-45aa-ae9b-b864e0170453", "6a331ac0-cf0e-49d1-8a18-6f7298ca90a0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32f3dc8c-1884-407d-b938-362aa2b9d59e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d485abbe-0f02-4bd1-ba44-6352659af68a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f54935f0-7d3b-45aa-ae9b-b864e0170453", "6a331ac0-cf0e-49d1-8a18-6f7298ca90a0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f54935f0-7d3b-45aa-ae9b-b864e0170453");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a331ac0-cf0e-49d1-8a18-6f7298ca90a0");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)");
        }
    }
}
