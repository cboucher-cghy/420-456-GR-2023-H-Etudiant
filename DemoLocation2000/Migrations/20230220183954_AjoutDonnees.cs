using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoLocation2000.Migrations
{
    public partial class AjoutDonnees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Modeles",
                columns: new[] { "Id", "MarqueId", "Nom" },
                values: new object[] { 1, null, "Edge" });

            migrationBuilder.InsertData(
                table: "Modeles",
                columns: new[] { "Id", "MarqueId", "Nom" },
                values: new object[] { 2, null, "Focus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
