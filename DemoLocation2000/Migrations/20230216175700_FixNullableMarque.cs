using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoLocation2000.Migrations
{
    public partial class FixNullableMarque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voitures_Marques_MarqueId",
                table: "Voitures");

            migrationBuilder.AlterColumn<int>(
                name: "MarqueId",
                table: "Voitures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Voitures_Marques_MarqueId",
                table: "Voitures",
                column: "MarqueId",
                principalTable: "Marques",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voitures_Marques_MarqueId",
                table: "Voitures");

            migrationBuilder.AlterColumn<int>(
                name: "MarqueId",
                table: "Voitures",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Voitures_Marques_MarqueId",
                table: "Voitures",
                column: "MarqueId",
                principalTable: "Marques",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
