using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APBD_Test.Migrations
{
    /// <inheritdoc />
    public partial class PlayerMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2005, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe" },
                    { 2, new DateTime(2001, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julia", "Mako" },
                    { 3, new DateTime(2009, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", "Maski" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3);
        }
    }
}
