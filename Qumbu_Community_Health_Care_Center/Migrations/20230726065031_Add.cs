using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "329f05b2-3b05-4386-be4b-e92f0e63822b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e951c706-b1c2-4b18-82cf-4336ff2faa9e", "b4a37ae2-2ad0-4222-bb56-b6f65437fde9", "Patient", "PATIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e951c706-b1c2-4b18-82cf-4336ff2faa9e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "329f05b2-3b05-4386-be4b-e92f0e63822b", "9a096bfb-e680-4ac8-91a4-e02f5dd74fd3", "Patient", "PATIENT" });
        }
    }
}
