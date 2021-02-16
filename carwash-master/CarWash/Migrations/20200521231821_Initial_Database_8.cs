using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class Initial_Database_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e9cfaf7-1e9e-4204-93cb-b0b83033aaf0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d049f2bd-a06c-4e65-bf7c-d971f97ff71a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "faed0d38-0206-48e4-85e2-1b4fb4fbf53b");

            migrationBuilder.DropColumn(
                name: "Vacuum",
                table: "Types");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdcfcb14-1956-45dc-bb1a-08462ad6da7d", "76fb00e1-8be9-483c-a3d0-98e9169bb100", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "86ad33a0-3bcd-4883-b6d9-0f74ca0bf54a", "962b346b-30aa-49f8-8af1-f9a65eea845e", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cec80b08-c624-410e-87a5-9090a264f60b", "578422c9-f0e8-4417-a638-dfb710a293c4", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86ad33a0-3bcd-4883-b6d9-0f74ca0bf54a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cec80b08-c624-410e-87a5-9090a264f60b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdcfcb14-1956-45dc-bb1a-08462ad6da7d");

            migrationBuilder.AddColumn<string>(
                name: "Vacuum",
                table: "Types",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e9cfaf7-1e9e-4204-93cb-b0b83033aaf0", "608c67d3-3197-452c-a523-efc2dc0596da", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "faed0d38-0206-48e4-85e2-1b4fb4fbf53b", "cab0de03-703c-4056-ae61-6be7f42afcba", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d049f2bd-a06c-4e65-bf7c-d971f97ff71a", "a9f72536-f5e4-4d1d-bb5b-361bb61c034f", "Administrator", "ADMINISTRATOR" });
        }
    }
}
