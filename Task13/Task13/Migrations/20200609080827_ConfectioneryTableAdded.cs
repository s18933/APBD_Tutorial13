using Microsoft.EntityFrameworkCore.Migrations;

namespace Task13.Migrations
{
    public partial class ConfectioneryTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Confectioneries",
                columns: table => new
                {
                    IdConfecti = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    PricePerIte = table.Column<int>(nullable: false),
                    Type = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Confectioneries", x => x.IdConfecti);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Confectioneries");
        }
    }
}
