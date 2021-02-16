using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class Initial_Database_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c38428b-ef31-4b5e-b1f2-80116b2eab31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57a5fcea-5148-4617-bab5-887062f00bc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81142ad8-7a94-4121-b1a2-0949466f5052");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57a5fcea-5148-4617-bab5-887062f00bc0", "6c1b1e0d-b182-4486-ab98-569133d6b617", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81142ad8-7a94-4121-b1a2-0949466f5052", "0fcdf7a4-18c9-4c2b-8757-212fe6320066", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c38428b-ef31-4b5e-b1f2-80116b2eab31", "8ff29811-f275-429a-98de-f39a89a7f0b0", "Administrator", "ADMINISTRATOR" });
        }
    }
}
