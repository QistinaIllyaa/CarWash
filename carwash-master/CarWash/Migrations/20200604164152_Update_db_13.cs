using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class Update_db_13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_AspNetUsers_UserId1",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_UserId1",
                table: "Reservation");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58cc183a-1a39-4aff-b060-f291c17e5900");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a99c21b-e6fb-48ad-8490-26413269529e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "903188cc-955c-49aa-ad75-4a9f542f757f");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Reservation");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3fc29f1-832b-4957-a401-3e82ce6656d0", "a7bef2b9-3598-4e9c-a751-a59fc9e172d5", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7baedd48-e92c-46fa-beb7-76aaaa5f74a5", "36b1e922-1111-4d9e-b65b-f9e0de03328b", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd8c9084-06a3-4b65-9841-7fa1ffc42fc9", "1af25d3d-9673-49d2-9874-d850d57be047", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7baedd48-e92c-46fa-beb7-76aaaa5f74a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3fc29f1-832b-4957-a401-3e82ce6656d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd8c9084-06a3-4b65-9841-7fa1ffc42fc9");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Reservation",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58cc183a-1a39-4aff-b060-f291c17e5900", "7429501d-7332-4ed3-a39a-47d9802a9079", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "903188cc-955c-49aa-ad75-4a9f542f757f", "32d50c35-cf35-4136-8048-72a6efe444ab", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a99c21b-e6fb-48ad-8490-26413269529e", "bec57a76-b1bd-4127-a08d-8bc58dbf7f91", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_UserId1",
                table: "Reservation",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_AspNetUsers_UserId1",
                table: "Reservation",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
