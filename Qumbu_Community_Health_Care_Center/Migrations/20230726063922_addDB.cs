using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class addDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be3e4fd-0ca7-4013-8e2d-e8d271163ea9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81f2ea5c-74c1-45f4-a142-5cb6345f85a9", "f8561441-fc6d-4510-a388-8d8e6fd439fc", "Patient", "PATIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81f2ea5c-74c1-45f4-a142-5cb6345f85a9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9be3e4fd-0ca7-4013-8e2d-e8d271163ea9", "f28e355c-8db2-4c69-8958-06c6f73d7e9b", "Patient", "PATIENT" });
        }
    }
}
