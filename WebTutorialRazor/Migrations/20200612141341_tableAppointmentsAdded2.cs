using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTutorialRazor.Migrations
{
    public partial class tableAppointmentsAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Appointment",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Appointment");
        }
    }
}
