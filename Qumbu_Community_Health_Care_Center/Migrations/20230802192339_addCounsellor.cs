using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class addCounsellor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a73280f-97ba-4a18-9079-8099b0dc4d4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56629d87-e1ba-4e38-ac96-f8a7b35272f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be01e09d-112c-4f9f-8fcd-06b7d0ec280f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d75acb37-e4ae-488b-a069-b231469029ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df7aeca4-27a4-491e-bdd4-d8a079bb1e35");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f436be4-460d-4d82-89f5-10556a7ba309", "e47ba2c2-a7e3-4069-b10a-b7c80eee33b8", "COUNSERLLOR", "Counsellor" },
                    { "1158a61e-1b8e-499d-baef-548df304f75c", "9ea0c281-b39a-4c59-96af-5ac5a1ab0496", "UNIT-MANAGER", "Unit-Manager" },
                    { "224b081a-7f22-4167-a1be-2553dc230126", "43457fe2-dfd7-44cf-b20a-a8f9b71a8f8a", "DOCTOR", "Doctor" },
                    { "3b185215-25de-4c4a-a12a-33b0d8b6529f", "0e8cf1a4-18d6-4f82-bff0-3115a5cce1ea", "Nurse", "NURSE" },
                    { "5861905b-c598-4441-b30e-6d1a00ccc51a", "9ae4dba4-01f2-4d49-a1a5-8b90e5f3e552", "Patient", "PATIENT" },
                    { "c4296ccd-c405-4d4c-9811-eaefe351ed78", "6f1cb1c3-cb47-4e0c-9b0c-7d817f2c9f62", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f436be4-460d-4d82-89f5-10556a7ba309");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1158a61e-1b8e-499d-baef-548df304f75c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "224b081a-7f22-4167-a1be-2553dc230126");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b185215-25de-4c4a-a12a-33b0d8b6529f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5861905b-c598-4441-b30e-6d1a00ccc51a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4296ccd-c405-4d4c-9811-eaefe351ed78");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a73280f-97ba-4a18-9079-8099b0dc4d4b", "e195da0d-5289-4300-81c9-faa17598a9e4", "Patient", "PATIENT" },
                    { "56629d87-e1ba-4e38-ac96-f8a7b35272f8", "38d152a5-96ea-4dd5-a526-a82415d238d6", "DOCTOR", "Doctor" },
                    { "be01e09d-112c-4f9f-8fcd-06b7d0ec280f", "97895160-7c2c-491a-80fd-dc77109a762d", "Admin", "ADMIN" },
                    { "d75acb37-e4ae-488b-a069-b231469029ae", "661634c7-5357-468a-8d32-007e897fbaeb", "Nurse", "NURSE" },
                    { "df7aeca4-27a4-491e-bdd4-d8a079bb1e35", "545c5254-7eb9-4d84-b42d-d67f1e473506", "UNIT-MANAGER", "Unit-Manager" }
                });
        }
    }
}
