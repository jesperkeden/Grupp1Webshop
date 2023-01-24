using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grupp1Webshop.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
