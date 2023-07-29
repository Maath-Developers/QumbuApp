using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "736b724a-3030-4a19-98c8-f8472418e71d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc1dc30c-d1f4-46fd-aec8-b22d9a702df8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e72cd88d-8c84-44ec-90f0-6d862a4c5c3c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e66f724-91de-447f-b366-caa534cb2a7b", "09030f2b-7f69-4b39-98b2-df05b26fcb71", "Nurse", "NURSE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a772f4de-77a8-4c78-adf3-7e47573430cf", "689d78e7-5489-45b0-913e-31fb41b4d7af", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f43201ca-88cf-4244-838e-219d9da20f7e", "87d5ab73-7c5d-4ab5-ba97-06fbb685a8e7", "Patient", "PATIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e66f724-91de-447f-b366-caa534cb2a7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a772f4de-77a8-4c78-adf3-7e47573430cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f43201ca-88cf-4244-838e-219d9da20f7e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "736b724a-3030-4a19-98c8-f8472418e71d", "669cd3b7-e75e-4885-a941-5d54c7175d14", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc1dc30c-d1f4-46fd-aec8-b22d9a702df8", "eb56b45b-99ad-4a58-a510-56b4b74b17d9", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e72cd88d-8c84-44ec-90f0-6d862a4c5c3c", "ba469217-47f5-4f3f-8390-389e6d35c129", "Nurse", "NURSE" });
        }
    }
}
