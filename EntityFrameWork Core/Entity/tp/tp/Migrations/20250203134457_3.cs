using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Personnages",
                columns: new[] { "Id", "Armure", "DateCreation", "Degats", "NombrePersonnesTues", "PointdsDeVie", "Pseudo" },
                values: new object[] { 1, 150, new DateTime(2025, 2, 3, 14, 44, 57, 556, DateTimeKind.Local).AddTicks(613), 15, 0, 120, "the boss" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnages",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
