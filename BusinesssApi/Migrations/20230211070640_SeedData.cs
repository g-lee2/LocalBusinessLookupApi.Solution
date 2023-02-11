using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinesssApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Description", "Name", "Rating", "Review" },
                values: new object[,]
                {
                    { 1, "123 Moole Street", "Fancy american restaurant", "Starz Restaurant", 4.5999999999999996, "Pricy and need to make reservations" },
                    { 2, "124 Moole Street", "Antique bookstore", "Rexie's Bookstore", 3.1000000000000001, "Not a lot of books" },
                    { 3, "125 Moole Street", "Local handmande jewlery shop", "Matilda Jewlers", 5.0, "Has a variety of jewlery and can customize" },
                    { 4, "126 Moole Street", "Unique ice cream flavor shop", "Pip's Ice Cream", 4.0999999999999996, "Can try all flavors" },
                    { 5, "127 Moole Street", "Pet Shop", "Over the Sea", 2.5, "Employee don't help out" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);
        }
    }
}
