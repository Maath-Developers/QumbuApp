using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class QumbuDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2cfb7e7f-6d65-4f3b-b7bf-bd96d17917ad", "f20c4edc-b918-4d70-8b20-96754607b22c", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57c163b8-1229-49f3-b1be-97b3c64c904e", "7c7df2a3-0659-4ee8-ae71-2c5177cffc85", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cfb7e7f-6d65-4f3b-b7bf-bd96d17917ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57c163b8-1229-49f3-b1be-97b3c64c904e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "619c3c46-6c72-4d3d-8bea-8ea6c0a104c2", "112801e0-b4a6-4ae4-b324-a630af2cd250", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9069578f-91f5-4933-891b-432fe785817c", "23624cde-b5b5-4240-aa95-9ded2ec7fe3e", "Patient", "PATIENT" });
        }
    }
}
