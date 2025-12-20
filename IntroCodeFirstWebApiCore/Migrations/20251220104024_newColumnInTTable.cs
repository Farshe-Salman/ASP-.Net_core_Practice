using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroCodeFirstWebApiCore.Migrations
{
    /// <inheritdoc />
    public partial class newColumnInTTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Teachers");
        }
    }
}
