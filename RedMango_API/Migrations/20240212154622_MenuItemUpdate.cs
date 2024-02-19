using Microsoft.EntityFrameworkCore.Migrations;

namespace RedMango_API.Migrations
{
    public partial class MenuItemUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A burst of flavor in every bite, perfect for savoring the season!");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Elevate your taste buds with our fluffy idlis.");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Experience the explosion of flavours with our tangy Panipuris.");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Roll into sweetness with our irresistable Sweet Rolls!");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Indulge in our crispy Spring Rolls -a burst of flavor in every bite, perfect for savoring the season!");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Elevate your taste buds with our fluffy idlis - a South Indian delight that's light,airy and bursting with flavour.");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Experience the explosion of flavours with our tangy Panipuris-a street food favorite that's sure to initialize your taste buds!.");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Roll into sweetness with our irresistable Sweet Rolls for satisfying your sweet tooth cravings!");
        }
    }
}
