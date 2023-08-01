using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class muz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64325158-0aa2-48ae-bc04-ec782b10a1c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "988b2202-0f8a-4ae5-9c7b-f3457fe855b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb711a29-1981-484c-9f5a-9f7b0605f100");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25ab65f4-e5eb-40f4-acb3-d77483875e5a", "0f576ff8-720d-4c87-a075-c3f49a262ec9", "DOCTOR", "Doctor" },
                    { "2e88e3d6-0a0f-4e9b-a913-08c128c09f6d", "71b99109-d493-44c2-8fd5-6f1ddf5b908f", "Nurse", "NURSE" },
                    { "53f5511f-fd3d-4883-95e5-41c073b97e90", "27dcd30f-7c4f-45ec-80f0-c38e265d6973", "UNIT-MANAGER", "Unit-Manager" },
                    { "c99e4815-59e4-4110-a056-7a32867b1c50", "e5356f65-6c31-47f1-8d2b-8f8b4cc94bf6", "Admin", "ADMIN" },
                    { "eb60d584-393b-483b-918d-113246a95d46", "f81c0984-571e-4c76-aa26-01ac9243be06", "Patient", "PATIENT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25ab65f4-e5eb-40f4-acb3-d77483875e5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e88e3d6-0a0f-4e9b-a913-08c128c09f6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53f5511f-fd3d-4883-95e5-41c073b97e90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c99e4815-59e4-4110-a056-7a32867b1c50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb60d584-393b-483b-918d-113246a95d46");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64325158-0aa2-48ae-bc04-ec782b10a1c8", "aac99463-2dbc-48d2-b009-e4d52f929102", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "988b2202-0f8a-4ae5-9c7b-f3457fe855b3", "eceab874-9939-4bf5-802a-d5d12f59e4ee", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb711a29-1981-484c-9f5a-9f7b0605f100", "5ec51de9-29e1-424d-b670-59800d0d7502", "Nurse", "NURSE" });
        }
    }
}
