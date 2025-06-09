using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APBD_Test.Migrations
{
    /// <inheritdoc />
    public partial class MatchMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "MatchId", "BestRating", "MapId", "MatchDate", "Team1Score", "Team2Score", "TournamentId" },
                values: new object[,]
                {
                    { 1, 3.22m, 1, new DateTime(2020, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 20, 30, 1 },
                    { 2, 2.12m, 3, new DateTime(2022, 5, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), 10, 16, 2 },
                    { 3, 1.15m, 2, new DateTime(2022, 5, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), 15, 19, 2 },
                    { 4, null, 2, new DateTime(2025, 3, 5, 10, 5, 0, 0, DateTimeKind.Unspecified), 24, 12, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 4);
        }
    }
}
