using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task13.Migrations
{
    public partial class UpdatedSeedingAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "IdClient", "Name", "Surname" },
                values: new object[] { 2, "Chara", "Error" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1,
                column: "IdClient",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Confectionery_Orders",
                keyColumns: new[] { "IdConfection", "IdOrder" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "IdClient",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "IdOrder", "DateAccepted", "DateFinished", "IdClient", "IdEmployee", "Notes" },
                values: new object[] { 1, new DateTime(2012, 3, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 3, 9, 10, 5, 0, 0, DateTimeKind.Unspecified), 1, 1, "For increasing HP" });

            migrationBuilder.InsertData(
                table: "Confectionery_Orders",
                columns: new[] { "IdConfection", "IdOrder", "Notes", "Quantity" },
                values: new object[] { 1, 1, "Eat food made by spiders, for spiders, of spiders!", 2 });
        }
    }
}
