using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class up_db_16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "Reservation",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9af2d80a-d96e-45a9-8af5-bc18c38aa4c9", "b467b894-993e-40b6-b7bd-1e7246977ea0", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8060a386-4545-49f7-b053-77d03c86ad70", "275b8ef1-d9d4-4c55-b341-165a27bcd509", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31566cfe-d15d-4673-bc9a-65319cef6596", "8287a516-0579-48c0-a08e-60fcf4e70977", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31566cfe-d15d-4673-bc9a-65319cef6596");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8060a386-4545-49f7-b053-77d03c86ad70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9af2d80a-d96e-45a9-8af5-bc18c38aa4c9");

            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Reservation");

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
    }
}
