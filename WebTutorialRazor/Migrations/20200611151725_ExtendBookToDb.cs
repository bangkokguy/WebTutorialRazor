using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTutorialRazor.Migrations
{
    public partial class ExtendBookToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Neme",
                table: "Book");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Book",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Book",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Book");

            migrationBuilder.AlterColumn<int>(
                name: "Author",
                table: "Book",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Neme",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
