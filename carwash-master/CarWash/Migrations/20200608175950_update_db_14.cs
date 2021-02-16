using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class update_db_14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "ReservationId",
                table: "Bill",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ReservationId",
                table: "Bill",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Reservation_ReservationId",
                table: "Bill",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Reservation_ReservationId",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_ReservationId",
                table: "Bill");

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

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Bill");

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
    }
}
