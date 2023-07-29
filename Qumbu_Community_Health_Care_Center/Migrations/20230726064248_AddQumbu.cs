using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class AddQumbu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81f2ea5c-74c1-45f4-a142-5cb6345f85a9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "329f05b2-3b05-4386-be4b-e92f0e63822b", "9a096bfb-e680-4ac8-91a4-e02f5dd74fd3", "Patient", "PATIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "329f05b2-3b05-4386-be4b-e92f0e63822b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81f2ea5c-74c1-45f4-a142-5cb6345f85a9", "f8561441-fc6d-4510-a388-8d8e6fd439fc", "Patient", "PATIENT" });
        }
    }
}
