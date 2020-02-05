using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmoweLove.Data.Migrations
{
    public partial class okladeczka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "okladka",
                table: "NewMovies",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "okladka",
                table: "NewMovies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
