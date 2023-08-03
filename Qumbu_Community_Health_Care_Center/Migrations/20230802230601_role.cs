using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02dd68e3-f624-478e-8918-d8b4be3da0c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f7b3900-ff1b-49c6-bd99-48d7ced9a3d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52bcbcb5-a01b-4c37-bb2b-cd0beca326f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbeb3def-c552-4b82-835b-b2ad90f7b983");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d60fa02f-4e3b-4790-8d2f-8a0ef0c177f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd870980-0d7e-47d4-8214-03eb63c5c769");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "02dd68e3-f624-478e-8918-d8b4be3da0c2", "38bf58fb-aaa2-4d27-8c2e-34c65ad3aeb6", "Doctor", "DOCTOR" },
                    { "3f7b3900-ff1b-49c6-bd99-48d7ced9a3d4", "e6287034-051a-482c-9f5b-c7d9d79a4572", "Counsellor", "COUNSELLOR" },
                    { "52bcbcb5-a01b-4c37-bb2b-cd0beca326f5", "5b591b9b-d3da-4f73-a0cb-7f1685c5b942", "Admin", "ADMIN" },
                    { "cbeb3def-c552-4b82-835b-b2ad90f7b983", "23f7e921-4e12-4266-9587-c054fa7329f8", "Nurse", "NURSE" },
                    { "d60fa02f-4e3b-4790-8d2f-8a0ef0c177f9", "d684d026-89fa-4bd2-b63a-fd7ec32ecac3", "Patient", "PATIENT" },
                    { "fd870980-0d7e-47d4-8214-03eb63c5c769", "727f22a7-c555-469a-b6a9-ddfef7315748", "Unit-Manager", "UNIT-MANAGER" }
                });
        }
    }
}
