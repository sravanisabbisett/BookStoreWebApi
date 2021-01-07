using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReposistryLayer.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adminUserRegistrations",
                columns: table => new
                {
                    EmployeeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fullName = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    phone = table.Column<string>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adminUserRegistrations", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "customerDetails",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    addressType = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    fullAddress = table.Column<string>(nullable: false),
                    city = table.Column<string>(nullable: false),
                    state = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerDetails", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    product_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    bookName = table.Column<string>(nullable: false),
                    bookImage = table.Column<string>(nullable: true),
                    admin_user_id = table.Column<string>(nullable: true),
                    author = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: false),
                    quantity = table.Column<long>(nullable: false),
                    price = table.Column<long>(nullable: false),
                    discountPrice = table.Column<long>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.product_id);
                });

            migrationBuilder.CreateTable(
                name: "userRegistrations",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fullName = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    phone = table.Column<string>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: true),
                    updatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRegistrations", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "newOrders",
                columns: table => new
                {
                    orderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newOrders", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_newOrders_customerDetails_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customerDetails",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cartItems",
                columns: table => new
                {
                    cartItem_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    product_id = table.Column<int>(nullable: false),
                    loginUser = table.Column<string>(nullable: true),
                    quantityToBuy = table.Column<int>(nullable: false),
                    NewOrderorderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartItems", x => x.cartItem_id);
                    table.ForeignKey(
                        name: "FK_cartItems_newOrders_NewOrderorderId",
                        column: x => x.NewOrderorderId,
                        principalTable: "newOrders",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cartItems_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cartItems_NewOrderorderId",
                table: "cartItems",
                column: "NewOrderorderId");

            migrationBuilder.CreateIndex(
                name: "IX_cartItems_product_id",
                table: "cartItems",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_newOrders_CustomerId",
                table: "newOrders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adminUserRegistrations");

            migrationBuilder.DropTable(
                name: "cartItems");

            migrationBuilder.DropTable(
                name: "userRegistrations");

            migrationBuilder.DropTable(
                name: "newOrders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "customerDetails");
        }
    }
}
