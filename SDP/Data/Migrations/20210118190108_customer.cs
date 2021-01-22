using Microsoft.EntityFrameworkCore.Migrations;

namespace SDP.Data.Migrations
{
    public partial class customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productName",
                table: "customers");

            migrationBuilder.RenameColumn(
                name: "contact",
                table: "customers",
                newName: "Contact");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "customers",
                newName: "contact");

            migrationBuilder.AddColumn<string>(
                name: "productName",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
