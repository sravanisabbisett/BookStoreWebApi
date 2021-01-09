using Microsoft.EntityFrameworkCore.Migrations;

namespace ReposistryLayer.Migrations
{
    public partial class add_CustomerDetails_pincode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "addressType",
                table: "customerDetails",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "pincode",
                table: "customerDetails",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pincode",
                table: "customerDetails");

            migrationBuilder.AlterColumn<string>(
                name: "addressType",
                table: "customerDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
