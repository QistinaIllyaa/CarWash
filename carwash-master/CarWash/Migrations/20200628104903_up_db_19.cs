using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWash.Migrations
{
    public partial class up_db_19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Reservation",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dateCreated",
                table: "Reservation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "dateCreated",
                table: "Reservation");
        }
    }
}
