using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class addDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75063d75-8adb-4520-885d-5f81883e5446");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2a23ecc-0651-412c-a0a7-33d9001f86e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8763339-852e-457a-8eb7-dff3cd9bbc1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "deb76afc-9ff8-4d28-a358-b94f89ec1b2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0878eb0-f328-484f-b58a-e9e99ce325e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6b7a9f9-3c91-44fe-8960-31291b181181");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b37bd1c-3319-43e2-8a1a-6c98275ce46f", "61c5cde4-360d-4ddd-8dfa-a5dfbaa8b84e", "Admin", "ADMIN" },
                    { "4a5f9a53-4396-4ab6-943c-86c2a4e317f3", "06ced90f-40ee-4958-a946-484c5086d1d7", "Patient", "PATIENT" },
                    { "79c56d0e-dce1-44c2-a64a-2df20dc83db2", "0e4821fc-cf29-403f-8180-c26eef7899f5", "Unit-Manager", "UNIT-MANAGER" },
                    { "dc7e160c-d508-4dec-a6e0-cc67293e4cd9", "c0c59be1-4b17-4bbe-96d7-69319c0f32bb", "Doctor", "DOCTOR" },
                    { "e3106c8c-52ae-4a10-a8e7-83ceabdd4866", "6b66664d-8535-47e4-a0bb-dd87cd57911d", "Nurse", "NURSE" },
                    { "e5304194-e4d4-4f6d-9be8-b0dda5c5a5e2", "def7bc08-102a-4e38-a946-48687ebf22b5", "Counsellor", "COUNSELLOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b37bd1c-3319-43e2-8a1a-6c98275ce46f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a5f9a53-4396-4ab6-943c-86c2a4e317f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79c56d0e-dce1-44c2-a64a-2df20dc83db2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc7e160c-d508-4dec-a6e0-cc67293e4cd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3106c8c-52ae-4a10-a8e7-83ceabdd4866");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5304194-e4d4-4f6d-9be8-b0dda5c5a5e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "75063d75-8adb-4520-885d-5f81883e5446", "21fc4552-d95d-47d9-a32c-63b936671f41", "Nurse", "NURSE" },
                    { "b2a23ecc-0651-412c-a0a7-33d9001f86e3", "280ac7ba-1707-4201-92ba-aa613b2c066f", "Unit-Manager", "UNIT-MANAGER" },
                    { "b8763339-852e-457a-8eb7-dff3cd9bbc1c", "035bf7ab-ad27-4233-bca4-e80dabd8a749", "Doctor", "DOCTOR" },
                    { "deb76afc-9ff8-4d28-a358-b94f89ec1b2a", "654ec683-f6ce-4cf9-b647-a92c3d8186b0", "Admin", "ADMIN" },
                    { "f0878eb0-f328-484f-b58a-e9e99ce325e8", "76b465df-c481-47be-bb17-2ab1a91af2f3", "Patient", "PATIENT" },
                    { "f6b7a9f9-3c91-44fe-8960-31291b181181", "9a7ccd0b-b6aa-45dd-ab9e-7fce644e17dc", "Counsellor", "COUNSELLOR" }
                });
        }
    }
}
