using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReposistryLayer.Migrations
{
    public partial class wishlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "price",
                table: "cartItems",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "wishlists",
                columns: table => new
                {
                    wishList_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    product_id = table.Column<int>(nullable: false),
                    loginUser = table.Column<string>(nullable: true),
                    addedToCart = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wishlists", x => x.wishList_id);
                    table.ForeignKey(
                        name: "FK_wishlists_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_wishlists_product_id",
                table: "wishlists",
                column: "product_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wishlists");

            migrationBuilder.DropColumn(
                name: "price",
                table: "cartItems");
        }
    }
}
