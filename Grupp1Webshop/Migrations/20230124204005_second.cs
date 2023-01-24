using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grupp1Webshop.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SelectedForWelcomeScreen",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedForWelcomeScreen",
                table: "Products");
        }
    }
}
