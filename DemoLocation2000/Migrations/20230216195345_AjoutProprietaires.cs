using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoLocation2000.Migrations
{
    public partial class AjoutProprietaires : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProprietaireId",
                table: "Voitures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Proprietaires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietaires", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Voitures_ProprietaireId",
                table: "Voitures",
                column: "ProprietaireId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voitures_Proprietaires_ProprietaireId",
                table: "Voitures",
                column: "ProprietaireId",
                principalTable: "Proprietaires",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voitures_Proprietaires_ProprietaireId",
                table: "Voitures");

            migrationBuilder.DropTable(
                name: "Proprietaires");

            migrationBuilder.DropIndex(
                name: "IX_Voitures_ProprietaireId",
                table: "Voitures");

            migrationBuilder.DropColumn(
                name: "ProprietaireId",
                table: "Voitures");
        }
    }
}
