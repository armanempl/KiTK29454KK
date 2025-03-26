using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KursWalutApp.Migrations
{
    /// <inheritdoc />
    public partial class CosSiePopsulo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "ExchangeRates",
                newName: "Mid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mid",
                table: "ExchangeRates",
                newName: "Rate");
        }
    }
}
