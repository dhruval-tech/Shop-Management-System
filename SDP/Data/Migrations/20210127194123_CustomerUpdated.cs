using Microsoft.EntityFrameworkCore.Migrations;

namespace SDP.Data.Migrations
{
    public partial class CustomerUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "contact",
                table: "customers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "contact",
                table: "customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
