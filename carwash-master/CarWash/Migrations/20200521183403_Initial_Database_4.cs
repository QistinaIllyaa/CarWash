using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class Initial_Database_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22f35853-63a2-4523-9356-fb8a38665440");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "600ef763-8282-45c1-b512-3e06f852feb3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa419c6a-6124-4d89-aa2b-4f8d2538dff8");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Reservation",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "600ef763-8282-45c1-b512-3e06f852feb3", "3ad46043-c0a4-45a8-88eb-4359e6fa30be", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "22f35853-63a2-4523-9356-fb8a38665440", "b2ad595b-1f2f-47a2-a9d4-d4006d68ba6a", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa419c6a-6124-4d89-aa2b-4f8d2538dff8", "1aa59c3a-df7e-41ec-b1cc-0ae251984f40", "Administrator", "ADMINISTRATOR" });
        }
    }
}
