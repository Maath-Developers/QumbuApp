using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class proj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39488394-0766-4b4f-9f54-204a45dd0d78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf15a21-f6b1-4bf1-828f-7af49591d381");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abfd386d-d153-4d57-89fe-ca5c60253278");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8179f3a8-9420-49c3-93d0-681e6c9232fa", "e7320701-2587-4761-9241-1dbf2b9cb1d8", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ad656bf-47db-4e69-a6c5-5566bcfe9b5e", "2d4757d8-5882-4a74-afd2-34885e600c12", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6c43095-9cc8-4327-a9bf-9432303dd1ef", "1cccc760-d96a-4b48-a19e-0e3e863b087b", "Nurse", "NURSE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8179f3a8-9420-49c3-93d0-681e6c9232fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ad656bf-47db-4e69-a6c5-5566bcfe9b5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6c43095-9cc8-4327-a9bf-9432303dd1ef");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39488394-0766-4b4f-9f54-204a45dd0d78", "9e7b5f43-5561-4704-ba31-629831ce3a50", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3cf15a21-f6b1-4bf1-828f-7af49591d381", "0e8527be-b840-40d7-bf68-54fba7e1eb24", "Nurse", "NURSE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abfd386d-d153-4d57-89fe-ca5c60253278", "a031c5eb-9f66-4311-a00b-9a96726cbe5a", "Patient", "PATIENT" });
        }
    }
}
