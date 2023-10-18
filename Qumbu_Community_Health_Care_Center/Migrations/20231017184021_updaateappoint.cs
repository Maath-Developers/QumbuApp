using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class updaateappoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Appointment");
        }
    }
}
