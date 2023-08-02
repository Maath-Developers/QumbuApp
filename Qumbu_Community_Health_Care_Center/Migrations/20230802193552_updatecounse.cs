using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class updatecounse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "3ac3b817-0b83-4a84-9220-0c25a02fbb53", "27268dae-f471-48a6-9f3d-f6d269ab2363", "UNIT-MANAGER", "Unit-Manager" },
                    { "404045a9-ab16-4714-81a4-c4b25c4d468b", "f4d6b055-36fe-49da-89b1-c860f7f41f9c", "Nurse", "NURSE" },
                    { "ac588f46-00f0-4ad8-bf02-4d5df2f9ec2f", "d812c4f9-1334-43c5-bf99-951149375593", "COUNSELLOR", "Counsellor" },
                    { "c797b721-25e3-457c-97be-936dc94bef68", "cf31b263-09e7-4904-a6bf-c321320eadc5", "DOCTOR", "Doctor" },
                    { "c9454d57-6ee1-4045-ab0e-fa326f31f560", "e7d82d0b-b65e-4444-aa37-8f7dc614d241", "Patient", "PATIENT" },
                    { "cab5d4c8-4a0e-4541-951d-d094b3aa9e3b", "813909f8-cbe8-45da-bf24-33b432eb9226", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ac3b817-0b83-4a84-9220-0c25a02fbb53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "404045a9-ab16-4714-81a4-c4b25c4d468b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac588f46-00f0-4ad8-bf02-4d5df2f9ec2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c797b721-25e3-457c-97be-936dc94bef68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9454d57-6ee1-4045-ab0e-fa326f31f560");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cab5d4c8-4a0e-4541-951d-d094b3aa9e3b");

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
    }
}
