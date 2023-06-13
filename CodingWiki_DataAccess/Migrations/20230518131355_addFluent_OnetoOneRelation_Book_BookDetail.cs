using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addFluent_OnetoOneRelation_Book_BookDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Book_Id",
                table: "BookDetails_Fluent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_Fluent_Book_Id",
                table: "BookDetails_Fluent",
                column: "Book_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_Fluent_Book_Fluent_Book_Id",
                table: "BookDetails_Fluent",
                column: "Book_Id",
                principalTable: "Book_Fluent",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_Fluent_Book_Fluent_Book_Id",
                table: "BookDetails_Fluent");

            migrationBuilder.DropIndex(
                name: "IX_BookDetails_Fluent_Book_Id",
                table: "BookDetails_Fluent");

            migrationBuilder.DropColumn(
                name: "Book_Id",
                table: "BookDetails_Fluent");
        }
    }
}
