using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstExercise.Migrations
{
    /// <inheritdoc />
    public partial class AddFKinNews2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "C_Id",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_News_C_Id",
                table: "News",
                column: "C_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Cateories_C_Id",
                table: "News",
                column: "C_Id",
                principalTable: "Cateories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Cateories_C_Id",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_C_Id",
                table: "News");

            migrationBuilder.DropColumn(
                name: "C_Id",
                table: "News");
        }
    }
}
