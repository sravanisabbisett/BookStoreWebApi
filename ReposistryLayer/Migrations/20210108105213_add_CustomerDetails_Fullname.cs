using Microsoft.EntityFrameworkCore.Migrations;

namespace ReposistryLayer.Migrations
{
    public partial class add_CustomerDetails_Fullname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "customerDetails",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "customerDetails");
        }
    }
}
