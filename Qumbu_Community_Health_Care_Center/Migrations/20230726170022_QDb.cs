using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class QDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e951c706-b1c2-4b18-82cf-4336ff2faa9e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "619c3c46-6c72-4d3d-8bea-8ea6c0a104c2", "112801e0-b4a6-4ae4-b324-a630af2cd250", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9069578f-91f5-4933-891b-432fe785817c", "23624cde-b5b5-4240-aa95-9ded2ec7fe3e", "Patient", "PATIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "619c3c46-6c72-4d3d-8bea-8ea6c0a104c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9069578f-91f5-4933-891b-432fe785817c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e951c706-b1c2-4b18-82cf-4336ff2faa9e", "b4a37ae2-2ad0-4222-bb56-b6f65437fde9", "Patient", "PATIENT" });
        }
    }
}
