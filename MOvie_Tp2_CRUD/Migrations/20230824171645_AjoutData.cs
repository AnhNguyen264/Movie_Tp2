using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP2.Migrations
{
    public partial class AjoutData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Enfants",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Description", "ImageURL", "Nom" },
                values: new object[] { 1, "Le loremuite de mots sans  utilisée à titre provisoire pour calibrer une mise en page le texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page.", "/Image/parent top.jpeg", "NOUVEAUX" });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Description", "ImageURL", "Nom" },
                values: new object[] { 2, "Le loremuite de mots sans  utilisée à titre provisoire pour calibrer une mise en page le texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page.", "/Image/parent-is comming.jpeg", "À VENIR" });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Description", "ImageURL", "Nom" },
                values: new object[] { 3, "Le loremuite de mots sans  utilisée à titre provisoire pour calibrer une mise en page le texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page.", "/Image/parent plus vus.jpeg", "LES PLUS VUS" });

            migrationBuilder.InsertData(
                table: "Enfants",
                columns: new[] { "Id", "Date", "Description", "GenreDeFilm", "IdParent", "ImageURL", "Nom", "Vus" },
                values: new object[,]
                {
                    { 1, 2023, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 1, "/Image/MOVIES_nouveau1.png", "Spider Man", 1000 },
                    { 2, 2023, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 1, "/Image/MOVIES_nouveau2.png", "About my father", 2000 },
                    { 3, 2023, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 1, "/Image/MOVIES_nouveau3.png", "Blue Reette", 3000 },
                    { 4, 2023, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 1, "/Image/MOVIES_nouveau4.png", "Annihilation", 4000 },
                    { 5, 2022, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 2, "/Image/MOVIES_avenir1.png", "World Collide", 5000 },
                    { 6, 2022, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 2, "/Image/MOVIES_avenir2.png", "World Collide 2", 6000 },
                    { 7, 2022, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 2, "/Image/MOVIES_avenir3.png", "Mutant Mayhem", 7000 },
                    { 8, 2022, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 2, "/Image/MOVIES_avenir4.png", "Titanic", 8000 },
                    { 9, 2021, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 3, "/Image/MOVIES_lesplusvus1.png", "Inception", 9000 },
                    { 10, 2021, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 3, "/Image/MOVIES_lesplusvus2.png", "Batman Begins", 10000 },
                    { 11, 2021, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 3, "/Image/MOVIES_lesplusvus3.png", "Die hard", 11000 },
                    { 12, 2021, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 3, "/Image/MOVIES_lesplusvus4.png", "Cold Souls", 12000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Enfants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
