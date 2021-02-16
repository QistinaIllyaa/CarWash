using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class dbupdate_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24a9cd67-17dd-4ee5-a181-207a9dfaef6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3bf2909-696a-4557-9860-b7ab52270add");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db067bb0-a049-4426-b765-3062e15cbd38");

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "Reservation",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<float>(
                name: "Amount",
                table: "Reservation",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3bf2909-696a-4557-9860-b7ab52270add", "ae45eb95-10dd-462c-a2f4-3173aa36d36a", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db067bb0-a049-4426-b765-3062e15cbd38", "84f328da-55f0-40a3-85f7-7ac5fdb5e917", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24a9cd67-17dd-4ee5-a181-207a9dfaef6f", "cf4b6285-610e-41fb-bdbc-8c896356e2bb", "Administrator", "ADMINISTRATOR" });
        }
    }
}
