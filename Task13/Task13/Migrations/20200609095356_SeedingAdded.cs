using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task13.Migrations
{
    public partial class SeedingAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Confectioneries",
                columns: new[] { "IdConfecti", "Name", "PricePerItem", "Type" },
                values: new object[,]
                {
                    { 1, "Spider Donut", 7, "Made with Spider Cider in the batter." },
                    { 2, "Hot Cat", 30, "Like a hot dog, but with cat ears." }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "IdClient", "Name", "Surname" },
                values: new object[] { 1, "Frisk", "TheHuman" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "IdEmpl", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Muffet", "TheSpider" },
                    { 2, "Sans", "TheSkeleton" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "IdOrder", "DateAccepted", "DateFinished", "IdClient", "IdEmployee", "Notes" },
                values: new object[] { 1, new DateTime(2012, 3, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 3, 9, 10, 5, 0, 0, DateTimeKind.Unspecified), 1, 1, "For increasing HP" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "IdOrder", "DateAccepted", "DateFinished", "IdClient", "IdEmployee", "Notes" },
                values: new object[] { 2, new DateTime(2012, 2, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 2, 9, 10, 20, 0, 0, DateTimeKind.Unspecified), 1, 2, "For placing food on the head" });

            migrationBuilder.InsertData(
                table: "Confectionery_Orders",
                columns: new[] { "IdConfection", "IdOrder", "Notes", "Quantity" },
                values: new object[] { 1, 1, "Eat food made by spiders, for spiders, of spiders!", 2 });

            migrationBuilder.InsertData(
                table: "Confectionery_Orders",
                columns: new[] { "IdConfection", "IdOrder", "Notes", "Quantity" },
                values: new object[] { 2, 2, "Thirty is just an excessive.", 30 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Confectionery_Orders",
                keyColumns: new[] { "IdConfection", "IdOrder" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Confectionery_Orders",
                keyColumns: new[] { "IdConfection", "IdOrder" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Confectioneries",
                keyColumn: "IdConfecti",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Confectioneries",
                keyColumn: "IdConfecti",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "IdClient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "IdEmpl",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "IdEmpl",
                keyValue: 2);
        }
    }
}
