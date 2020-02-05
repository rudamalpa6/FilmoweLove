using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmoweLove.Data.Migrations
{
    public partial class ZmianaBazyCzyCos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "Series",
                newName: "Ocena");

            migrationBuilder.RenameColumn(
                name: "NumberOfSeasons",
                table: "Series",
                newName: "LiczbaSezonow");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Series",
                newName: "Nazwa");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Series",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "Movies",
                newName: "Ocena");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "Nazwa");

            migrationBuilder.RenameColumn(
                name: "Length",
                table: "Movies",
                newName: "Dlugosc");

            migrationBuilder.AddColumn<int>(
                name: "Data",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "Ocena",
                table: "Series",
                newName: "Rate");

            migrationBuilder.RenameColumn(
                name: "Nazwa",
                table: "Series",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LiczbaSezonow",
                table: "Series",
                newName: "NumberOfSeasons");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Series",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Ocena",
                table: "Movies",
                newName: "Rate");

            migrationBuilder.RenameColumn(
                name: "Nazwa",
                table: "Movies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Dlugosc",
                table: "Movies",
                newName: "Length");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Movies",
                nullable: true);
        }
    }
}
