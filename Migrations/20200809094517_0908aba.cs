using Microsoft.EntityFrameworkCore.Migrations;

namespace delishapplication.Migrations
{
    public partial class _0908aba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Chef_ChefID1",
                table: "Dish");

            migrationBuilder.DropIndex(
                name: "IX_Dish_ChefID1",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "ChefID1",
                table: "Dish");

            migrationBuilder.AlterColumn<int>(
                name: "ChefID",
                table: "Dish",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dish_ChefID",
                table: "Dish",
                column: "ChefID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Chef_ChefID",
                table: "Dish",
                column: "ChefID",
                principalTable: "Chef",
                principalColumn: "ChefID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Chef_ChefID",
                table: "Dish");

            migrationBuilder.DropIndex(
                name: "IX_Dish_ChefID",
                table: "Dish");

            migrationBuilder.AlterColumn<string>(
                name: "ChefID",
                table: "Dish",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChefID1",
                table: "Dish",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dish_ChefID1",
                table: "Dish",
                column: "ChefID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Chef_ChefID1",
                table: "Dish",
                column: "ChefID1",
                principalTable: "Chef",
                principalColumn: "ChefID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
