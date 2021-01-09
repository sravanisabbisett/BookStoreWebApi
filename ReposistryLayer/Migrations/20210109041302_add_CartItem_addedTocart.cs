using Microsoft.EntityFrameworkCore.Migrations;

namespace ReposistryLayer.Migrations
{
    public partial class add_CartItem_addedTocart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "addedTocart",
                table: "products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "addedTocart",
                table: "cartItems",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "addedTocart",
                table: "products");

            migrationBuilder.DropColumn(
                name: "addedTocart",
                table: "cartItems");
        }
    }
}
