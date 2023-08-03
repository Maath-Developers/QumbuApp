using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34e26d83-129b-4f4e-91e7-d62a1dd97f07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "445f405b-ed81-4081-a3c4-0c26f12a2eec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "652c534b-a955-4b92-8400-da17d1bd7cd5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c7c1f89-99c1-4d4f-ae8e-d484a72170f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f817bf0-d20d-48fa-9401-b5b3d6b245f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fea40a05-52ba-4c85-bc5c-007a73e25033");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "67dff5de-a7e4-4a47-8b3e-b15b757fa48d", "26d44192-cb8c-4a12-b616-6174cf851c1c", "Doctor", "DOCTOR" },
                    { "7f4bb193-0b80-4ae7-8427-6d70172d3312", "8faa6c2f-f8ad-4b71-bc9f-b13f9ced21a6", "Patient", "PATIENT" },
                    { "a8752a26-1988-456c-b760-ec1d530a5676", "3676e9fd-0a1c-4cbc-bc95-d0874413b112", "Counsellor", "COUNSELLOR" },
                    { "c67acea7-c8e0-4547-90e1-669113865d93", "91fc8e41-1f26-4594-a619-b2f4ed32f4f2", "Unit-Manager", "UNIT-MANAGER" },
                    { "e7fe49ae-fb0f-4e4d-8cb4-024db05a0b84", "a7301694-ebe8-4543-99a4-2cca4c3eb05b", "Nurse", "NURSE" },
                    { "f0454760-589e-4249-9b28-f3971ede376a", "3185d669-d8b3-4742-8560-55b35e521959", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67dff5de-a7e4-4a47-8b3e-b15b757fa48d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f4bb193-0b80-4ae7-8427-6d70172d3312");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8752a26-1988-456c-b760-ec1d530a5676");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c67acea7-c8e0-4547-90e1-669113865d93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7fe49ae-fb0f-4e4d-8cb4-024db05a0b84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0454760-589e-4249-9b28-f3971ede376a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34e26d83-129b-4f4e-91e7-d62a1dd97f07", "f62afd04-8839-49ed-a8f5-ec63d69639c3", "Patient", "PATIENT" },
                    { "445f405b-ed81-4081-a3c4-0c26f12a2eec", "8913a768-c056-4dfe-b281-ed8ed4e225f6", "ADMIN", "Admin" },
                    { "652c534b-a955-4b92-8400-da17d1bd7cd5", "91fb7fed-26a8-40a6-a894-c755b52c35d2", "Counsellor", "COUNSELLOR" },
                    { "6c7c1f89-99c1-4d4f-ae8e-d484a72170f5", "f5aec878-050d-49bd-9649-2fd536846c52", "Unit-Manager", "UNIT-MANAGER" },
                    { "6f817bf0-d20d-48fa-9401-b5b3d6b245f4", "8656808f-4b33-4b01-882e-216f9297ff64", "Doctor", "DOCTOR" },
                    { "fea40a05-52ba-4c85-bc5c-007a73e25033", "108f225c-8442-438f-8620-734099298384", "Nurse", "NURSE" }
                });
        }
    }
}
