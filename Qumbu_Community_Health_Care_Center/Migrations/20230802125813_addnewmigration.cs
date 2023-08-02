using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class addnewmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "236f36f1-c64c-4fca-b8bd-5d7de308a1ad", "8f1edeeb-5c91-4b0a-8314-b98a0966e883", "Nurse", "NURSE" },
                    { "25c9cf82-67f4-431a-9638-e4eddd77e4b0", "5da15e83-c3cf-4d79-8af0-bb6c8fb99f96", "Admin", "ADMIN" },
                    { "2a01099b-44de-4b3d-9be2-70b2f3d79292", "c12117c0-0e31-4068-8ff9-903b5c905fd5", "UNIT-MANAGER", "Unit-Manager" },
                    { "80d5f9bb-7d2d-4a99-9d49-eaf555dd631a", "4fca8e25-e5b4-4524-b5af-8a17ed80041a", "DOCTOR", "Doctor" },
                    { "f7f839d7-655b-45b2-962e-1d41387a1e5d", "ccc0ec77-0be9-43af-ad30-84cea5aa9023", "Patient", "PATIENT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "70671434-cf2b-4f04-bdcc-bddcfbd0bf7c", "8e87017e-7e04-48d0-b45d-2cb0487b9675", "Nurse", "NURSE" },
                    { "71e1c885-9972-4f3b-8285-1e3a1a5b0c3c", "907b8ab8-8e67-402c-a4c4-0a636c1e86fe", "Admin", "ADMIN" },
                    { "860ffbc7-5b0a-44cb-b50d-b9e26a479820", "65c53a1a-4ca5-4c9d-8275-bf3114dc04ec", "DOCTOR", "Doctor" },
                    { "f18671aa-8b0a-421b-831c-e830838f3651", "9a755a3d-fb80-4132-beb0-6ab5f5c3a24b", "Patient", "PATIENT" },
                    { "f992b05b-78c4-4449-a06e-233234c624fd", "8aec7e30-7c8b-4de1-a5cc-429b7f824a3a", "UNIT-MANAGER", "Unit-Manager" }
                });
        }
    }
}
