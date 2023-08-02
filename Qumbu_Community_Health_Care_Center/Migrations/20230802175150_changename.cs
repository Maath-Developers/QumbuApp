using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class changename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "236f36f1-c64c-4fca-b8bd-5d7de308a1ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25c9cf82-67f4-431a-9638-e4eddd77e4b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a01099b-44de-4b3d-9be2-70b2f3d79292");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80d5f9bb-7d2d-4a99-9d49-eaf555dd631a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7f839d7-655b-45b2-962e-1d41387a1e5d");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "236f36f1-c64c-4fca-b8bd-5d7de308a1ad", "8f1edeeb-5c91-4b0a-8314-b98a0966e883", "Nurse", "NURSE" },
                    { "25c9cf82-67f4-431a-9638-e4eddd77e4b0", "5da15e83-c3cf-4d79-8af0-bb6c8fb99f96", "Admin", "ADMIN" },
                    { "2a01099b-44de-4b3d-9be2-70b2f3d79292", "c12117c0-0e31-4068-8ff9-903b5c905fd5", "UNIT-MANAGER", "Unit-Manager" },
                    { "80d5f9bb-7d2d-4a99-9d49-eaf555dd631a", "4fca8e25-e5b4-4524-b5af-8a17ed80041a", "DOCTOR", "Doctor" },
                    { "f7f839d7-655b-45b2-962e-1d41387a1e5d", "ccc0ec77-0be9-43af-ad30-84cea5aa9023", "Patient", "PATIENT" }
                });
        }
    }
}
