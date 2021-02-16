using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class Initial_Database_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b420d000-d172-4299-9f2c-6375f6b6a7d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c830d179-16b1-4018-81b8-48875161d381");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfad9392-847c-41db-8e4b-cc59635fe333");

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

            migrationBuilder.AlterColumn<string>(
                name: "Services",
                table: "Types",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Amortires",
                table: "Types",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Enginewash",
                table: "Types",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Freshner",
                table: "Types",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Leatherconditioner",
                table: "Types",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Polish",
                table: "Types",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Vacuum",
                table: "Types",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e9cfaf7-1e9e-4204-93cb-b0b83033aaf0", "608c67d3-3197-452c-a523-efc2dc0596da", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "faed0d38-0206-48e4-85e2-1b4fb4fbf53b", "cab0de03-703c-4056-ae61-6be7f42afcba", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d049f2bd-a06c-4e65-bf7c-d971f97ff71a", "a9f72536-f5e4-4d1d-bb5b-361bb61c034f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e9cfaf7-1e9e-4204-93cb-b0b83033aaf0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d049f2bd-a06c-4e65-bf7c-d971f97ff71a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "faed0d38-0206-48e4-85e2-1b4fb4fbf53b");

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

            migrationBuilder.AlterColumn<string>(
                name: "Services",
                table: "Types",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<bool>(
                name: "Amortires",
                table: "Reservation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "Amount",
                table: "Reservation",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "Enginewash",
                table: "Reservation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Freshner",
                table: "Reservation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Leatherconditioner",
                table: "Reservation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Polish",
                table: "Reservation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Vacuum",
                table: "Reservation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c830d179-16b1-4018-81b8-48875161d381", "56e8c9c5-4566-4b83-85d9-d7041f172262", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b420d000-d172-4299-9f2c-6375f6b6a7d2", "cd42bc0e-5fc6-4893-8fbb-e65caf39bf05", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dfad9392-847c-41db-8e4b-cc59635fe333", "ef131759-bd83-4ea3-812c-9ebe1bd571ad", "Administrator", "ADMINISTRATOR" });
        }
    }
}
