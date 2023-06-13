using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class renameFluent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Fluent_Publisher_Fluent_Publisher_Id",
                table: "Book_Fluent");

            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_Fluent_Book_Fluent_Book_Id",
                table: "BookDetails_Fluent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publisher_Fluent",
                table: "Publisher_Fluent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookDetails_Fluent",
                table: "BookDetails_Fluent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_Fluent",
                table: "Book_Fluent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author_Fluent",
                table: "Author_Fluent");

            migrationBuilder.RenameTable(
                name: "Publisher_Fluent",
                newName: "Fluent_Publisher");

            migrationBuilder.RenameTable(
                name: "BookDetails_Fluent",
                newName: "Fluent_BookDetails");

            migrationBuilder.RenameTable(
                name: "Book_Fluent",
                newName: "Fluent_Book");

            migrationBuilder.RenameTable(
                name: "Author_Fluent",
                newName: "Fluent_Author");

            migrationBuilder.RenameIndex(
                name: "IX_BookDetails_Fluent_Book_Id",
                table: "Fluent_BookDetails",
                newName: "IX_Fluent_BookDetails_Book_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Fluent_Publisher_Id",
                table: "Fluent_Book",
                newName: "IX_Fluent_Book_Publisher_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_Publisher",
                table: "Fluent_Publisher",
                column: "Publisher_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_BookDetails",
                table: "Fluent_BookDetails",
                column: "BookDetail_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_Book",
                table: "Fluent_Book",
                column: "Book_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_Author",
                table: "Fluent_Author",
                column: "Author_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Book_Fluent_Publisher_Publisher_Id",
                table: "Fluent_Book",
                column: "Publisher_Id",
                principalTable: "Fluent_Publisher",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookDetails_Fluent_Book_Book_Id",
                table: "Fluent_BookDetails",
                column: "Book_Id",
                principalTable: "Fluent_Book",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Book_Fluent_Publisher_Publisher_Id",
                table: "Fluent_Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookDetails_Fluent_Book_Book_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_Publisher",
                table: "Fluent_Publisher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_BookDetails",
                table: "Fluent_BookDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_Book",
                table: "Fluent_Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_Author",
                table: "Fluent_Author");

            migrationBuilder.RenameTable(
                name: "Fluent_Publisher",
                newName: "Publisher_Fluent");

            migrationBuilder.RenameTable(
                name: "Fluent_BookDetails",
                newName: "BookDetails_Fluent");

            migrationBuilder.RenameTable(
                name: "Fluent_Book",
                newName: "Book_Fluent");

            migrationBuilder.RenameTable(
                name: "Fluent_Author",
                newName: "Author_Fluent");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_BookDetails_Book_Id",
                table: "BookDetails_Fluent",
                newName: "IX_BookDetails_Fluent_Book_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_Book_Publisher_Id",
                table: "Book_Fluent",
                newName: "IX_Book_Fluent_Publisher_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publisher_Fluent",
                table: "Publisher_Fluent",
                column: "Publisher_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookDetails_Fluent",
                table: "BookDetails_Fluent",
                column: "BookDetail_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Fluent",
                table: "Book_Fluent",
                column: "Book_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author_Fluent",
                table: "Author_Fluent",
                column: "Author_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Fluent_Publisher_Fluent_Publisher_Id",
                table: "Book_Fluent",
                column: "Publisher_Id",
                principalTable: "Publisher_Fluent",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_Fluent_Book_Fluent_Book_Id",
                table: "BookDetails_Fluent",
                column: "Book_Id",
                principalTable: "Book_Fluent",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
