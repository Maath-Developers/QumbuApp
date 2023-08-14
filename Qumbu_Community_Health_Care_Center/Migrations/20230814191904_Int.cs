using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class Int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "527406bc-f16a-4a56-92ef-8ffeddb38f39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76368a2c-2f41-46cd-b668-c34a595acaeb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b7ecc61-6cac-4766-8ac8-c4f85e56b031");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1456451-e8cb-40aa-adc3-40ba69e6ca07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f48433-7e98-4116-ad75-6d7809b427a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f51058f0-45d0-40d0-985e-667ffec2aca1");

            migrationBuilder.CreateTable(
                name: "HealthRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    BloodPressureSystolic = table.Column<int>(type: "int", nullable: false),
                    BloodPressureDiastolic = table.Column<int>(type: "int", nullable: false),
                    Symptoms = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRecords", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d97b1fb-cfd9-4a08-b384-08d5d83a6438", "26b6de12-cee5-4e51-9dab-189643426411", "Unit-Manager", "UNIT-MANAGER" },
                    { "292db766-75af-4350-8a9b-aa3f6ff5e663", "9c6a7eeb-a313-41b2-aa2e-a68d915dda04", "Patient", "PATIENT" },
                    { "3b9d824e-0972-472e-a41e-12389693073a", "6fd93828-9fdb-4512-8f9c-e72b3973a649", "Counsellor", "COUNSELLOR" },
                    { "a56c8547-aae5-4d86-9109-fc6ddda32aea", "a098d00e-ae16-4ebd-b24c-d595d80f84fa", "Doctor", "DOCTOR" },
                    { "e309b614-770b-4f31-afb6-9ea59b4926da", "b02f59da-e63a-4ce1-85ad-41a223df4ef2", "Admin", "ADMIN" },
                    { "f6d756e4-5830-4c0c-8cb8-5b3594315f74", "dfc0cf08-9242-4777-b78d-3b320c152621", "Nurse", "NURSE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HealthRecords");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d97b1fb-cfd9-4a08-b384-08d5d83a6438");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292db766-75af-4350-8a9b-aa3f6ff5e663");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b9d824e-0972-472e-a41e-12389693073a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a56c8547-aae5-4d86-9109-fc6ddda32aea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e309b614-770b-4f31-afb6-9ea59b4926da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6d756e4-5830-4c0c-8cb8-5b3594315f74");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "527406bc-f16a-4a56-92ef-8ffeddb38f39", "eec14654-645e-4bfc-8a72-6c4e3af3537a", "Doctor", "DOCTOR" },
                    { "76368a2c-2f41-46cd-b668-c34a595acaeb", "0092b44c-f3fc-4125-aaea-cee634ccb8e5", "Admin", "ADMIN" },
                    { "7b7ecc61-6cac-4766-8ac8-c4f85e56b031", "cd2e1f46-cecd-47ad-ba4c-fddd1062e01b", "Patient", "PATIENT" },
                    { "a1456451-e8cb-40aa-adc3-40ba69e6ca07", "14c411f2-08e4-4140-9eeb-194fcaa7735b", "Unit-Manager", "UNIT-MANAGER" },
                    { "a9f48433-7e98-4116-ad75-6d7809b427a9", "3312ba01-6169-436a-86f4-cf8548031ff9", "Counsellor", "COUNSELLOR" },
                    { "f51058f0-45d0-40d0-985e-667ffec2aca1", "afda5fac-8e15-4bd1-b9d6-63bc90a8857e", "Nurse", "NURSE" }
                });
        }
    }
}
