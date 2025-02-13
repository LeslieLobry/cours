using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Exercice4.Migrations
{
    /// <inheritdoc />
    public partial class AdMigationInial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Marmosets",
                columns: new[] { "Id", "Nom", "Poids", "Taille" },
                values: new object[,]
                {
                    { 1, "Ouistiti commun", 0.35m, 20m },
                    { 2, "Ouistiti pygmée", 0.12m, 15m },
                    { 3, "Ouistiti à pinceaux blancs", 0.40m, 23m },
                    { 4, "Ouistiti argenté", 0.30m, 22m },
                    { 5, "Ouistiti à toupet noir", 0.38m, 21m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marmosets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marmosets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marmosets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Marmosets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Marmosets",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
