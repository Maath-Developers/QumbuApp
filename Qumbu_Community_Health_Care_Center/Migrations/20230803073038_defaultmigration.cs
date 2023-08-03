using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class defaultmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0e966b9b-5761-4d85-9f34-65eb2bbf654d", "fe251de5-220e-48ee-ad14-cf8dc0237180", "Nurse", "NURSE" },
                    { "17636507-9004-43df-ae9d-941429626f1d", "7a7f0be0-8caf-4412-92bb-adc04a065e3f", "Patient", "PATIENT" },
                    { "2769f9ec-bd79-4569-bcd1-bb1bccce00f0", "8a42f615-18f6-4b9c-9b49-674b1285836a", "Admin", "ADMIN" },
                    { "56e86a67-283f-4859-94bf-aa41facb9049", "a300f084-f42b-4392-b7e3-0c2ee9aaae2b", "COUNSELLOR", "Counsellor" },
                    { "5a46e3ae-25e3-46cc-913d-3793e2e62598", "9891f095-4b77-4d8c-aae4-341eba32a5c5", "UNIT-MANAGER", "Unit-Manager" },
                    { "6e680671-03fa-49a3-9397-a10e2f73de74", "a681e170-482b-441f-9ce3-59bfa1f81ec7", "DOCTOR", "Doctor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e966b9b-5761-4d85-9f34-65eb2bbf654d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17636507-9004-43df-ae9d-941429626f1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2769f9ec-bd79-4569-bcd1-bb1bccce00f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56e86a67-283f-4859-94bf-aa41facb9049");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a46e3ae-25e3-46cc-913d-3793e2e62598");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e680671-03fa-49a3-9397-a10e2f73de74");

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
    }
}
