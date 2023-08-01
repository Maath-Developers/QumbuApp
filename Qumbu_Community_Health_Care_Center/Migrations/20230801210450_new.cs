using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "70671434-cf2b-4f04-bdcc-bddcfbd0bf7c", "8e87017e-7e04-48d0-b45d-2cb0487b9675", "Nurse", "NURSE" },
                    { "71e1c885-9972-4f3b-8285-1e3a1a5b0c3c", "907b8ab8-8e67-402c-a4c4-0a636c1e86fe", "Admin", "ADMIN" },
                    { "860ffbc7-5b0a-44cb-b50d-b9e26a479820", "65c53a1a-4ca5-4c9d-8275-bf3114dc04ec", "DOCTOR", "Doctor" },
                    { "f18671aa-8b0a-421b-831c-e830838f3651", "9a755a3d-fb80-4132-beb0-6ab5f5c3a24b", "Patient", "PATIENT" },
                    { "f992b05b-78c4-4449-a06e-233234c624fd", "8aec7e30-7c8b-4de1-a5cc-429b7f824a3a", "UNIT-MANAGER", "Unit-Manager" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70671434-cf2b-4f04-bdcc-bddcfbd0bf7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71e1c885-9972-4f3b-8285-1e3a1a5b0c3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "860ffbc7-5b0a-44cb-b50d-b9e26a479820");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f18671aa-8b0a-421b-831c-e830838f3651");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f992b05b-78c4-4449-a06e-233234c624fd");

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
    }
}
