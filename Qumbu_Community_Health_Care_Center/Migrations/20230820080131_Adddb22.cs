using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class Adddb22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "194cd65c-29a4-4ee4-bd23-288cdf32a2c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836e76a2-9afd-4cae-a494-3fec0eb78b69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b11e834-85b2-4705-8a74-b968e5890bd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "901d93af-93b5-4980-8ada-672c1235d756");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e82b406d-ce16-4ebb-b395-884c15c0a7cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3c01bda-099b-4861-9097-41ea139c9cee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ee39f24-d17a-4a62-8ff3-84830cd46853", "0da2ee78-43a8-404c-8796-218192cb1bf6", "Counsellor", "COUNSELLOR" },
                    { "61f1f1d4-38f2-4b35-b184-8a80af177862", "1108e4c5-4965-4f5f-9082-739aebcf8416", "Patient", "PATIENT" },
                    { "912c1adf-4fd6-4df8-b2ac-bb1143fd2f2e", "b4dfc81e-5e45-4bbd-a448-22b3aaab7bb7", "Doctor", "DOCTOR" },
                    { "9751b382-bc8f-47ce-81b7-c579d520cb57", "1182980f-1b16-4612-97db-413d90b8406d", "Admin", "ADMIN" },
                    { "9a490804-2991-4468-9313-f3b89de4668e", "59af76c8-78b6-4ba6-91ba-873dd4ba4ae3", "Unit-Manager", "UNIT-MANAGER" },
                    { "e6ff8fdd-125e-42b1-8dcc-8b4dcfb37eae", "0c818573-06b0-40d6-aa88-e41d76fcf475", "Nurse", "NURSE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee39f24-d17a-4a62-8ff3-84830cd46853");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61f1f1d4-38f2-4b35-b184-8a80af177862");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "912c1adf-4fd6-4df8-b2ac-bb1143fd2f2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9751b382-bc8f-47ce-81b7-c579d520cb57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a490804-2991-4468-9313-f3b89de4668e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6ff8fdd-125e-42b1-8dcc-8b4dcfb37eae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "194cd65c-29a4-4ee4-bd23-288cdf32a2c8", "72e49580-b625-4cde-a008-4c43ab053829", "Counsellor", "COUNSELLOR" },
                    { "836e76a2-9afd-4cae-a494-3fec0eb78b69", "5e6c88ef-2da7-42c3-834f-96f4cb87840b", "Unit-Manager", "UNIT-MANAGER" },
                    { "8b11e834-85b2-4705-8a74-b968e5890bd1", "bf994b06-e9fe-441a-a9a5-3d49457c02e5", "Admin", "ADMIN" },
                    { "901d93af-93b5-4980-8ada-672c1235d756", "7dcb0025-c9af-4489-9263-68f71c9cbbd5", "Doctor", "DOCTOR" },
                    { "e82b406d-ce16-4ebb-b395-884c15c0a7cd", "b7dec325-6313-4159-9eb2-6d43fef644f1", "Patient", "PATIENT" },
                    { "f3c01bda-099b-4861-9097-41ea139c9cee", "ca619226-d19d-4389-a8e7-9ca64f44f7d2", "Nurse", "NURSE" }
                });
        }
    }
}
