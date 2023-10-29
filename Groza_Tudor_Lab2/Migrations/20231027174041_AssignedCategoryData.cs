using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Groza_Tudor_Lab2.Migrations
{
    public partial class AssignedCategoryData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorID1",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_AuthorID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorID1",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AuthorID1",
                table: "Book");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherID",
                table: "Book",
                column: "PublisherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorID",
                table: "Book",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publisher_PublisherID",
                table: "Book",
                column: "PublisherID",
                principalTable: "Publisher",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorID",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_PublisherID",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "AuthorID1",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorID1",
                table: "Book",
                column: "AuthorID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorID1",
                table: "Book",
                column: "AuthorID1",
                principalTable: "Author",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publisher_AuthorID",
                table: "Book",
                column: "AuthorID",
                principalTable: "Publisher",
                principalColumn: "ID");
        }
    }
}
