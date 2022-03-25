using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class initDb44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "My_Property",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Books",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Stock",
                table: "Books",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "My_Property",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
