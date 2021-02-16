using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class Initial_Database_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cd7fec9-68c0-4fef-990d-fbbada61e7f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1ab962c-6a96-4cbe-b09a-ad7129b330cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f17e486e-d8c0-40dd-ac4b-df885bb28597");

            migrationBuilder.DropColumn(
                name: "Amortires",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "Enginewash",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "Freshner",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "Leatherconditioner",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "Polish",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "Vacuum",
                table: "Types");

            migrationBuilder.AddColumn<bool>(
                name: "Amortires",
                table: "Reservation",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "Amount",
                table: "Reservation",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "Enginewash",
                table: "Reservation",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Freshner",
                table: "Reservation",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Leatherconditioner",
                table: "Reservation",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Polish",
                table: "Reservation",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Vacuum",
                table: "Reservation",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Amortires",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "Enginewash",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "Freshner",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "Leatherconditioner",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "Polish",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "Vacuum",
                table: "Reservation");

            migrationBuilder.AddColumn<bool>(
                name: "Amortires",
                table: "Types",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Enginewash",
                table: "Types",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Freshner",
                table: "Types",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Leatherconditioner",
                table: "Types",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Polish",
                table: "Types",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Vacuum",
                table: "Types",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f17e486e-d8c0-40dd-ac4b-df885bb28597", "1bf5bcf6-83fb-4ce8-8b77-76e49261c794", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1ab962c-6a96-4cbe-b09a-ad7129b330cf", "79b915ea-6e5c-49a4-94e6-66781fba83f9", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7cd7fec9-68c0-4fef-990d-fbbada61e7f5", "9e36c497-6da6-4abb-8edb-ff54a4c693af", "Administrator", "ADMINISTRATOR" });
        }
    }
}
