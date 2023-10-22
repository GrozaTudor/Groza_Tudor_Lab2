using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Groza_Tudor_Lab2.Migrations
{
    public partial class FistLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Book",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Book",
                newName: "Author");
        }
    }
}
