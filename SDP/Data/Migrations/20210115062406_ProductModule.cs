using Microsoft.EntityFrameworkCore.Migrations;

namespace SDP.Data.Migrations
{
    public partial class ProductModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isPurchase",
                table: "products");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "products");

            migrationBuilder.AddColumn<bool>(
                name: "isPurchase",
                table: "products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
