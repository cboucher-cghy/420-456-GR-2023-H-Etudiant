using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoLocation2000.Migrations
{
    public partial class CreationMarque_AjoutLienMarque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarqueId",
                table: "Voitures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Marques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marques", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Voitures_MarqueId",
                table: "Voitures",
                column: "MarqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voitures_Marques_MarqueId",
                table: "Voitures",
                column: "MarqueId",
                principalTable: "Marques",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voitures_Marques_MarqueId",
                table: "Voitures");

            migrationBuilder.DropTable(
                name: "Marques");

            migrationBuilder.DropIndex(
                name: "IX_Voitures_MarqueId",
                table: "Voitures");

            migrationBuilder.DropColumn(
                name: "MarqueId",
                table: "Voitures");
        }
    }
}
