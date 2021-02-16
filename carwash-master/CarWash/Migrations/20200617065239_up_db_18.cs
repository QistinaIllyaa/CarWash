using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class up_db_18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Reservation",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Reservation",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Reservation");

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
    }
}
