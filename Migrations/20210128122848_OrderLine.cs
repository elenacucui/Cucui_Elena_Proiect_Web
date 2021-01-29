using Microsoft.EntityFrameworkCore.Migrations;

namespace Cucui_Elena_Proiect_Web.Migrations
{
    public partial class OrderLine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "OrderLine",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderLine");
        }
    }
}
