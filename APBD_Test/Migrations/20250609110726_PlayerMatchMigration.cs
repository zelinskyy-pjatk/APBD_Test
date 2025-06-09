using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APBD_Test.Migrations
{
    /// <inheritdoc />
    public partial class PlayerMatchMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Player_Match",
                columns: new[] { "MatchId", "PlayerId", "MVPs", "Rating" },
                values: new object[,]
                {
                    { 1, 1, 1, 2.2m },
                    { 2, 3, 4, 1.2m },
                    { 3, 1, 2, 1.77m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Player_Match",
                keyColumns: new[] { "MatchId", "PlayerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Player_Match",
                keyColumns: new[] { "MatchId", "PlayerId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Player_Match",
                keyColumns: new[] { "MatchId", "PlayerId" },
                keyValues: new object[] { 3, 1 });
        }
    }
}
