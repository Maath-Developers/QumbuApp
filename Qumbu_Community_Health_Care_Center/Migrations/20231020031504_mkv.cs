using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class mkv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PatientID",
                table: "Referral",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Referral_PatientID",
                table: "Referral",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Referral_AspNetUsers_PatientID",
                table: "Referral",
                column: "PatientID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Referral_AspNetUsers_PatientID",
                table: "Referral");

            migrationBuilder.DropIndex(
                name: "IX_Referral_PatientID",
                table: "Referral");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Referral");
        }
    }
}
