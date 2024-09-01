using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Radore_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class sayfaSayisiChangedToSayfaSayisi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sayfaSayisi",
                table: "Kitap",
                newName: "SayfaSayisi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SayfaSayisi",
                table: "Kitap",
                newName: "sayfaSayisi");
        }
    }
}
