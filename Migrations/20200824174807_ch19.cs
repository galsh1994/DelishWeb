using Microsoft.EntityFrameworkCore.Migrations;

namespace delishapplication.Migrations
{
    public partial class ch19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoLink",
                table: "Dish",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoLink",
                table: "Chef",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoLink",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "PhotoLink",
                table: "Chef");
        }
    }
}
