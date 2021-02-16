using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class update_db_15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a4addf7-27a3-4cc2-a63e-1181991e1ce9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59bf36ee-f222-4ce2-bcda-406242c3f48b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc821b46-fa2e-4f85-841b-815a7cb389d1");

            migrationBuilder.AddColumn<string>(
                name: "Payment",
                table: "Reservation",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd27068e-2d74-4bff-99fa-7504ea2f8f05", "e7a307a6-1772-4777-bfda-0beeb4498a72", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aaca050d-7ed7-4ab6-b72e-c943c1a431b1", "4316272c-339d-4e98-9ec8-28ed4a009e3b", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f0c3a5e-50ac-4023-bb3b-7a44675b25a7", "3ad06ac2-a249-46e0-a964-4c5f76bacc2d", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f0c3a5e-50ac-4023-bb3b-7a44675b25a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaca050d-7ed7-4ab6-b72e-c943c1a431b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd27068e-2d74-4bff-99fa-7504ea2f8f05");

            migrationBuilder.DropColumn(
                name: "Payment",
                table: "Reservation");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc821b46-fa2e-4f85-841b-815a7cb389d1", "ccc264d8-4181-4955-af59-5ca9a5f0ff87", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59bf36ee-f222-4ce2-bcda-406242c3f48b", "35041843-f9d6-4c88-ad27-963fee4ce176", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a4addf7-27a3-4cc2-a63e-1181991e1ce9", "7736adf4-d703-4297-9ccb-68cbd2cc23ca", "Administrator", "ADMINISTRATOR" });
        }
    }
}
