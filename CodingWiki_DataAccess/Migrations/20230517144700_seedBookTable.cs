using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IDBook", "ISBN", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "123B12", 10.99m, "Spider without Duty" },
                    { 2, "123B123", 11.99m, "Fortune of Time" },
                    { 3, "123B1234", 12.99m, "Fake Sunday" },
                    { 4, "123B12345", 13.99m, "Cookie Jar" },
                    { 5, "123B123456", 14.99m, "Cloudy Forest" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 5);
        }
    }
}
