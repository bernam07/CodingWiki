using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addMappingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMap_Authors_Author_Id",
                table: "BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMap_Books_Book_Id",
                table: "BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Author_Author_Id",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Book_Book_Id",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_BookAuthorMap",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthorMap",
                table: "BookAuthorMap");

            migrationBuilder.RenameTable(
                name: "Fluent_BookAuthorMap",
                newName: "Fluent_BookAuthors");

            migrationBuilder.RenameTable(
                name: "BookAuthorMap",
                newName: "BookAuthors");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_BookAuthorMap_Book_Id",
                table: "Fluent_BookAuthors",
                newName: "IX_Fluent_BookAuthors_Book_Id");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthorMap_Book_Id",
                table: "BookAuthors",
                newName: "IX_BookAuthors_Book_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_BookAuthors",
                table: "Fluent_BookAuthors",
                columns: new[] { "Author_Id", "Book_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors",
                columns: new[] { "Author_Id", "Book_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Authors_Author_Id",
                table: "BookAuthors",
                column: "Author_Id",
                principalTable: "Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Books_Book_Id",
                table: "BookAuthors",
                column: "Book_Id",
                principalTable: "Books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthors_Fluent_Author_Author_Id",
                table: "Fluent_BookAuthors",
                column: "Author_Id",
                principalTable: "Fluent_Author",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthors_Fluent_Book_Book_Id",
                table: "Fluent_BookAuthors",
                column: "Book_Id",
                principalTable: "Fluent_Book",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Authors_Author_Id",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Books_Book_Id",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthors_Fluent_Author_Author_Id",
                table: "Fluent_BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthors_Fluent_Book_Book_Id",
                table: "Fluent_BookAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_BookAuthors",
                table: "Fluent_BookAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors");

            migrationBuilder.RenameTable(
                name: "Fluent_BookAuthors",
                newName: "Fluent_BookAuthorMap");

            migrationBuilder.RenameTable(
                name: "BookAuthors",
                newName: "BookAuthorMap");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_BookAuthors_Book_Id",
                table: "Fluent_BookAuthorMap",
                newName: "IX_Fluent_BookAuthorMap_Book_Id");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthors_Book_Id",
                table: "BookAuthorMap",
                newName: "IX_BookAuthorMap_Book_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_BookAuthorMap",
                table: "Fluent_BookAuthorMap",
                columns: new[] { "Author_Id", "Book_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthorMap",
                table: "BookAuthorMap",
                columns: new[] { "Author_Id", "Book_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMap_Authors_Author_Id",
                table: "BookAuthorMap",
                column: "Author_Id",
                principalTable: "Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMap_Books_Book_Id",
                table: "BookAuthorMap",
                column: "Book_Id",
                principalTable: "Books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Author_Author_Id",
                table: "Fluent_BookAuthorMap",
                column: "Author_Id",
                principalTable: "Fluent_Author",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Book_Book_Id",
                table: "Fluent_BookAuthorMap",
                column: "Book_Id",
                principalTable: "Fluent_Book",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
