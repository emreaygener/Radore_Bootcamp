using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Article.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WriterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "LastUpdate", "Title", "WriterId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 24, 22, 11, 37, 29, DateTimeKind.Local).AddTicks(1061), "Article 1", 1 },
                    { 2, new DateTime(2024, 8, 24, 22, 11, 37, 29, DateTimeKind.Local).AddTicks(1073), "Article 2", 2 },
                    { 3, new DateTime(2024, 8, 24, 22, 11, 37, 29, DateTimeKind.Local).AddTicks(1075), "Article 3", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
