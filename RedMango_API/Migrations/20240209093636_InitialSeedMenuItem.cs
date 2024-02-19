using Microsoft.EntityFrameworkCore.Migrations;

namespace RedMango_API.Migrations
{
    public partial class InitialSeedMenuItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Indulge in our crispy Spring Rolls -a burst of flavor in every bite, perfect for savoring the season!", "https://redmangoimgs.blob.core.windows.net/redmango/spring roll.jpg", "Spring Roll", 7.9900000000000002, "" },
                    { 2, "Appetizer", "Elevate your taste buds with our fluffy idlis - a South Indian delight that's light,airy and bursting with flavour.", "https://redmangoimgs.blob.core.windows.net/redmango/idli.jpg", "Idli", 8.9900000000000002, "" },
                    { 3, "Appetizer", "Experience the explosion of flavours with our tangy Panipuris-a street food favorite that's sure to initialize your taste buds!.", "https://redmangoimgs.blob.core.windows.net/redmango/pani puri.jpg", "Pani Puri", 8.9900000000000002, "Best Seller" },
                    { 4, "Entrée", "Satisfy your cravings with our slurp-worthy noodles!", "https://redmangoimgs.blob.core.windows.net/redmango/hakka noodles.jpg", "Hakka Noodles", 10.99, "" },
                    { 5, "Entrée", "Indulge in the richness of our creamy explosion of taste!", "https://redmangoimgs.blob.core.windows.net/redmango/malai kofta.jpg", "Malai Kofta", 12.99, "Top Rated" },
                    { 6, "Entrée", "Get a taste of India in this fusion delicacy!", "https://redmangoimgs.blob.core.windows.net/redmango/paneer pizza.jpg", "Paneer Pizza", 11.99, "" },
                    { 7, "Entrée", "Grilled to Perfection!", "https://redmangoimgs.blob.core.windows.net/redmango/paneer tikka.jpg", "Paneer Tikka", 13.99, "Chef's Special" },
                    { 8, "Dessert", "Delight your senses with our decadent Carrot heaven!", "https://redmangoimgs.blob.core.windows.net/redmango/carrot%20love.jpg", "Carrot Love", 4.9900000000000002, "" },
                    { 9, "Dessert", "Dive into bowl of pure bliss with our velvety Rasmalai!", "https://redmangoimgs.blob.core.windows.net/redmango/rasmalai.jpg", "Rasmalai", 4.9900000000000002, "Chef's Special" },
                    { 10, "Dessert", "Roll into sweetness with our irresistable Sweet Rolls for satisfying your sweet tooth cravings!", "https://redmangoimgs.blob.core.windows.net/redmango/sweet rolls.jpg", "Sweet Rolls", 3.9900000000000002, "Top Rated" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
