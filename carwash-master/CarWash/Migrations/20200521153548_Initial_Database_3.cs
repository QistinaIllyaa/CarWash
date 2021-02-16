using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class Initial_Database_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Type_TypeId",
                table: "Reservation");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_TypeId",
                table: "Reservation");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ed513a2-9065-4ab4-9fe7-c9201a64291b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "549453e0-d882-4061-b6bc-ddb594057557");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec19f7a1-e76b-4c20-8e55-f14508cbf5de");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Reservation");

            migrationBuilder.AddColumn<int>(
                name: "TypesId",
                table: "Reservation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Services = table.Column<string>(nullable: true),
                    Prices = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "600ef763-8282-45c1-b512-3e06f852feb3", "3ad46043-c0a4-45a8-88eb-4359e6fa30be", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "22f35853-63a2-4523-9356-fb8a38665440", "b2ad595b-1f2f-47a2-a9d4-d4006d68ba6a", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa419c6a-6124-4d89-aa2b-4f8d2538dff8", "1aa59c3a-df7e-41ec-b1cc-0ae251984f40", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_TypesId",
                table: "Reservation",
                column: "TypesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Types_TypesId",
                table: "Reservation",
                column: "TypesId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Types_TypesId",
                table: "Reservation");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_TypesId",
                table: "Reservation");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22f35853-63a2-4523-9356-fb8a38665440");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "600ef763-8282-45c1-b512-3e06f852feb3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa419c6a-6124-4d89-aa2b-4f8d2538dff8");

            migrationBuilder.DropColumn(
                name: "TypesId",
                table: "Reservation");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prices = table.Column<double>(type: "float", nullable: false),
                    Services = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "549453e0-d882-4061-b6bc-ddb594057557", "7912bcfa-6418-4306-8364-039129055dbc", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec19f7a1-e76b-4c20-8e55-f14508cbf5de", "0453dd96-b625-45ae-ade0-2cffb561f7b1", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ed513a2-9065-4ab4-9fe7-c9201a64291b", "4f248ce1-2e00-4155-b1a5-d53d3a83ada3", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_TypeId",
                table: "Reservation",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Type_TypeId",
                table: "Reservation",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
