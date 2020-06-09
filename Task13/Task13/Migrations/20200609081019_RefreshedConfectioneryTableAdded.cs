using Microsoft.EntityFrameworkCore.Migrations;

namespace Task13.Migrations
{
    public partial class RefreshedConfectioneryTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PricePerIte",
                table: "Confectioneries");

            migrationBuilder.AddColumn<int>(
                name: "PricePerItem",
                table: "Confectioneries",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PricePerItem",
                table: "Confectioneries");

            migrationBuilder.AddColumn<int>(
                name: "PricePerIte",
                table: "Confectioneries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
