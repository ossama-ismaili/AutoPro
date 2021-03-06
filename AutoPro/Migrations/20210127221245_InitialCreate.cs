using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoPro.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_demande_voitureid",
                table: "demande",
                column: "voitureid");

            migrationBuilder.AddForeignKey(
                name: "FK_demande_Voiture_voitureid",
                table: "demande",
                column: "voitureid",
                principalTable: "Voiture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_demande_Voiture_voitureid",
                table: "demande");

            migrationBuilder.DropIndex(
                name: "IX_demande_voitureid",
                table: "demande");
        }
    }
}
