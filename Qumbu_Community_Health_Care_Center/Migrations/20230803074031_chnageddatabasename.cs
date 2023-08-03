using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class chnageddatabasename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "1e976115-0001-4df7-a6ff-e0983bca2b31", "d24110d4-a295-4c41-b57a-1ae6c20c7639", "DOCTOR", "Doctor" },
                    { "4e98195a-7fac-4acf-824d-7debe307360a", "b387498a-0b0a-4bb3-b98d-1553f886d1bc", "UNIT-MANAGER", "Unit-Manager" },
                    { "75048efe-124a-4f68-8704-07e7b34dc034", "2829aa9b-2c3a-4e6c-b6b3-6f81c3d6f14d", "Nurse", "NURSE" },
                    { "7cb8dceb-e8f9-4ebf-b4c7-9a92c83431ba", "0dcde23e-0b2e-4d4a-8922-23840fa2ad15", "COUNSELLOR", "Counsellor" },
                    { "929e9674-4eb8-48cd-b7f9-813c69f78fa7", "a045def7-9642-4314-98c3-44b5fd7b6689", "Patient", "PATIENT" },
                    { "e799e8c9-75fe-459f-afc8-270e16356410", "299b69e1-f91e-4eee-bca2-fcc66163f5ca", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e976115-0001-4df7-a6ff-e0983bca2b31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e98195a-7fac-4acf-824d-7debe307360a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75048efe-124a-4f68-8704-07e7b34dc034");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cb8dceb-e8f9-4ebf-b4c7-9a92c83431ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "929e9674-4eb8-48cd-b7f9-813c69f78fa7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e799e8c9-75fe-459f-afc8-270e16356410");

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
    }
}
