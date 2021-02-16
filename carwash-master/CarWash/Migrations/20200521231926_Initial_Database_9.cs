using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class Initial_Database_9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86ad33a0-3bcd-4883-b6d9-0f74ca0bf54a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cec80b08-c624-410e-87a5-9090a264f60b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdcfcb14-1956-45dc-bb1a-08462ad6da7d");

            migrationBuilder.AddColumn<bool>(
                name: "Vacuum",
                table: "Types",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Vacuum",
                table: "Types");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdcfcb14-1956-45dc-bb1a-08462ad6da7d", "76fb00e1-8be9-483c-a3d0-98e9169bb100", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "86ad33a0-3bcd-4883-b6d9-0f74ca0bf54a", "962b346b-30aa-49f8-8af1-f9a65eea845e", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cec80b08-c624-410e-87a5-9090a264f60b", "578422c9-f0e8-4417-a638-dfb710a293c4", "Administrator", "ADMINISTRATOR" });
        }
    }
}
