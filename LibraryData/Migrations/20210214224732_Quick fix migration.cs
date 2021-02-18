using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class Quickfixmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CheckecIn",
                table: "CheckoutHistories",
                newName: "CheckedIn");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CheckedIn",
                table: "CheckoutHistories",
                newName: "CheckecIn");
        }
    }
}
