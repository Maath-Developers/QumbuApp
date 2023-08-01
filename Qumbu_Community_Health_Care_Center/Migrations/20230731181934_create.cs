using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8179f3a8-9420-49c3-93d0-681e6c9232fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ad656bf-47db-4e69-a6c5-5566bcfe9b5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6c43095-9cc8-4327-a9bf-9432303dd1ef");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "8179f3a8-9420-49c3-93d0-681e6c9232fa", "e7320701-2587-4761-9241-1dbf2b9cb1d8", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ad656bf-47db-4e69-a6c5-5566bcfe9b5e", "2d4757d8-5882-4a74-afd2-34885e600c12", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6c43095-9cc8-4327-a9bf-9432303dd1ef", "1cccc760-d96a-4b48-a19e-0e3e863b087b", "Nurse", "NURSE" });
        }
    }
}
