using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class Update_db_12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c2bb0e2-8f42-4318-951a-0230b3a70182");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d9f9886-3e98-4694-8d63-0257857db98a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b64f475d-422e-4565-b184-5cb6eea08ca0");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Reservation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Reservation",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0c2bb0e2-8f42-4318-951a-0230b3a70182", "04f2a091-43bf-4d17-adc7-2e3b7baf17ee", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d9f9886-3e98-4694-8d63-0257857db98a", "bcc4b188-4854-43cf-837f-171a5eae1199", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b64f475d-422e-4565-b184-5cb6eea08ca0", "d9609ea8-a523-4354-a476-d8900adf4908", "Administrator", "ADMINISTRATOR" });
        }
    }
}
