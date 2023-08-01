using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class addnewdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43241e92-0519-4c0f-b6c1-df69affccea9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d62ee67-2b36-4ef9-9aca-77340c9fdc09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4693250-137b-47b9-a4b0-081aca972f89");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64325158-0aa2-48ae-bc04-ec782b10a1c8", "aac99463-2dbc-48d2-b009-e4d52f929102", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "988b2202-0f8a-4ae5-9c7b-f3457fe855b3", "eceab874-9939-4bf5-802a-d5d12f59e4ee", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb711a29-1981-484c-9f5a-9f7b0605f100", "5ec51de9-29e1-424d-b670-59800d0d7502", "Nurse", "NURSE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64325158-0aa2-48ae-bc04-ec782b10a1c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "988b2202-0f8a-4ae5-9c7b-f3457fe855b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb711a29-1981-484c-9f5a-9f7b0605f100");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43241e92-0519-4c0f-b6c1-df69affccea9", "2a8758be-9f48-46b4-aa38-eabbac36fa5e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d62ee67-2b36-4ef9-9aca-77340c9fdc09", "6264bad8-2029-4216-8935-1fdefab00e6a", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4693250-137b-47b9-a4b0-081aca972f89", "5f7b07a8-150b-4e14-9402-4de126015a36", "Nurse", "NURSE" });
        }
    }
}
