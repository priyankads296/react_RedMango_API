using Microsoft.EntityFrameworkCore.Migrations;

namespace RedMango_API.Migrations
{
    public partial class EditaddShoppingCartandCartItemsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_ShoopingCarts_ShoppingCartId",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoopingCarts",
                table: "ShoopingCarts");

            migrationBuilder.RenameTable(
                name: "ShoopingCarts",
                newName: "ShoppingCarts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_ShoppingCarts_ShoppingCartId",
                table: "CartItems",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_ShoppingCarts_ShoppingCartId",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                newName: "ShoopingCarts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoopingCarts",
                table: "ShoopingCarts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_ShoopingCarts_ShoppingCartId",
                table: "CartItems",
                column: "ShoppingCartId",
                principalTable: "ShoopingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
