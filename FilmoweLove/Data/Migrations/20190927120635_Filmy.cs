using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmoweLove.Data.Migrations
{
    public partial class Filmy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "src",
                table: "NewMovies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "src",
                table: "NewMovies");
        }
    }
}
