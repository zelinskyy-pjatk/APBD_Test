using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APBD_Test.Migrations
{
    /// <inheritdoc />
    public partial class TournamentMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "TournamentId", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Tournament 1", new DateTime(2020, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 5, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), "Tournament 2", new DateTime(2022, 5, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tournament 3", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "TournamentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "TournamentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "TournamentId",
                keyValue: 3);
        }
    }
}
