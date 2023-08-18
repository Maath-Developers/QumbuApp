using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class addtbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34c658dc-289f-4b10-9fe7-f411ec05fc50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2df7941-ae42-49ff-aad5-09a9f798aec4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc43eb65-ca4d-4022-9092-034f583df2ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c504c394-4aae-43ce-a817-327fb04a165a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdc1db99-103e-48f5-9693-b4e1a1e3749e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5dcd612-3e6d-4360-be92-1dc9af7d8579");

            migrationBuilder.CreateTable(
                name: "VaccinationAppointment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationAppointment", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2985c289-822e-42e5-b2a7-97959551fbf0", "d970d05c-bf46-48e8-9f18-8fa8d970ec85", "Patient", "PATIENT" },
                    { "330abd45-a05a-4890-bd4b-443bde7cdea7", "6643d9bd-21cd-41c2-a0a2-f1c8b1085a4c", "Counsellor", "COUNSELLOR" },
                    { "aceaa539-2965-4fb3-85a6-877fed2ed029", "b382a6bf-146f-4e2a-b8f4-7a336475401b", "Nurse", "NURSE" },
                    { "b4e9ed80-46a5-4099-8225-501514bae5da", "49924e9a-d2a0-4b48-a3f1-72bed623d7f0", "Doctor", "DOCTOR" },
                    { "ca5c48c2-226b-443f-8750-3022002837f0", "a22aa1dc-eca4-4e9b-9c89-38bfed90f45b", "Unit-Manager", "UNIT-MANAGER" },
                    { "d4c49465-9f33-4754-b4c8-3734089fdcc2", "2a363fa0-6567-4bde-b2d1-f3552e830e31", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VaccinationAppointment");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2985c289-822e-42e5-b2a7-97959551fbf0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "330abd45-a05a-4890-bd4b-443bde7cdea7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aceaa539-2965-4fb3-85a6-877fed2ed029");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e9ed80-46a5-4099-8225-501514bae5da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca5c48c2-226b-443f-8750-3022002837f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4c49465-9f33-4754-b4c8-3734089fdcc2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34c658dc-289f-4b10-9fe7-f411ec05fc50", "655e9f62-8f3b-4581-a0de-ade19485772d", "Unit-Manager", "UNIT-MANAGER" },
                    { "b2df7941-ae42-49ff-aad5-09a9f798aec4", "55235a35-47d6-459d-8f03-dbcafcd2e210", "Patient", "PATIENT" },
                    { "bc43eb65-ca4d-4022-9092-034f583df2ce", "2b8fa196-2584-4d12-a9fe-261451297417", "Counsellor", "COUNSELLOR" },
                    { "c504c394-4aae-43ce-a817-327fb04a165a", "70d51ab8-6822-489c-b004-cca44b57fade", "Doctor", "DOCTOR" },
                    { "cdc1db99-103e-48f5-9693-b4e1a1e3749e", "16feb546-0db5-47b7-a4e7-a479e566a71e", "Nurse", "NURSE" },
                    { "e5dcd612-3e6d-4360-be92-1dc9af7d8579", "eea9251e-8d60-4c10-a8a7-b7eff9b81d19", "Admin", "ADMIN" }
                });
        }
    }
}
