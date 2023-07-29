using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "39488394-0766-4b4f-9f54-204a45dd0d78", "9e7b5f43-5561-4704-ba31-629831ce3a50", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3cf15a21-f6b1-4bf1-828f-7af49591d381", "0e8527be-b840-40d7-bf68-54fba7e1eb24", "Nurse", "NURSE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abfd386d-d153-4d57-89fe-ca5c60253278", "a031c5eb-9f66-4311-a00b-9a96726cbe5a", "Patient", "PATIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39488394-0766-4b4f-9f54-204a45dd0d78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf15a21-f6b1-4bf1-828f-7af49591d381");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abfd386d-d153-4d57-89fe-ca5c60253278");

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
    }
}
