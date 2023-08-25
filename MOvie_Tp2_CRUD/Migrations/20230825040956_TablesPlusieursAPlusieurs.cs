using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP2.Migrations
{
    public partial class TablesPlusieursAPlusieurs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Parents",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Objectives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomObjective = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendeurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomVendeur = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendeurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjectivesVendeur",
                columns: table => new
                {
                    ObjectivesId = table.Column<int>(type: "int", nullable: false),
                    VendeursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectivesVendeur", x => new { x.ObjectivesId, x.VendeursId });
                    table.ForeignKey(
                        name: "FK_ObjectivesVendeur_Objectives_ObjectivesId",
                        column: x => x.ObjectivesId,
                        principalTable: "Objectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectivesVendeur_Vendeurs_VendeursId",
                        column: x => x.VendeursId,
                        principalTable: "Vendeurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "Id", "NomObjective" },
                values: new object[,]
                {
                    { 1, "Ventes les films nouveaux " },
                    { 2, "Ventes les films à venir " },
                    { 3, "Ventes les films plus vus " }
                });

            migrationBuilder.InsertData(
                table: "Vendeurs",
                columns: new[] { "Id", "NomVendeur" },
                values: new object[,]
                {
                    { 1, "VWilliam" },
                    { 2, "VLeo" },
                    { 3, "VLiam" },
                    { 4, "VThomas" },
                    { 5, "VLouis" },
                    { 6, "VArthur" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ObjectivesVendeur_VendeursId",
                table: "ObjectivesVendeur",
                column: "VendeursId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ObjectivesVendeur");

            migrationBuilder.DropTable(
                name: "Objectives");

            migrationBuilder.DropTable(
                name: "Vendeurs");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
