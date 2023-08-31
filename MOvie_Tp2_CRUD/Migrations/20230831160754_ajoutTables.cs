using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP2.Migrations
{
    public partial class ajoutTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "Id", "Commentaires", "NbFimsVendus", "NomObjective", "VendeursId" },
                values: new object[] { 4, "Très bon", 180, "Ventes les films Juillet ", 1 });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "Id", "Commentaires", "NbFimsVendus", "NomObjective", "VendeursId" },
                values: new object[] { 5, "Très bon", 160, "Ventes les films Mai ", 2 });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "Id", "Commentaires", "NbFimsVendus", "NomObjective", "VendeursId" },
                values: new object[] { 6, "Très bon", 200, "Ventes les films Juin ", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
