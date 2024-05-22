using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShirtShooping.PoductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "Football T-Shirt", "Camisa São Paulo Oficial - XG", "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/S%C3%A3o-Paulo-FC.jpg?raw=true", "Camisa São Paulo", 120.9m },
                    { 3L, "Football T-Shirt", "Camisa Corinthians Oficial - XG", "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/Corinthians-FC.jpg?raw=true", "Camisa Corinthians", 120.9m },
                    { 4L, "Football T-Shirt", "Camisa Santos Oficial - XG", "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/Santos-FC.jpeg?raw=true", "Camisa Santos", 120.9m },
                    { 5L, "Football T-Shirt", "Camisa Flamengo Oficial - XG", "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/Flamengo-FC.jpg?raw=true", "Camisa Flamengo", 120.9m },
                    { 6L, "Football T-Shirt", "Camisa Cruzeiro Oficial - XG", "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/Cruzeiro-FC.jpg?raw=true", "Camisa Cruzeiro", 120.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);
        }
    }
}
