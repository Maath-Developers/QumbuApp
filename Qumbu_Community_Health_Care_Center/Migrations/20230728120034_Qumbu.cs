﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qumbu_Community_Health_Care_Center.Migrations
{
    public partial class Qumbu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cfb7e7f-6d65-4f3b-b7bf-bd96d17917ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57c163b8-1229-49f3-b1be-97b3c64c904e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "736b724a-3030-4a19-98c8-f8472418e71d", "669cd3b7-e75e-4885-a941-5d54c7175d14", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc1dc30c-d1f4-46fd-aec8-b22d9a702df8", "eb56b45b-99ad-4a58-a510-56b4b74b17d9", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e72cd88d-8c84-44ec-90f0-6d862a4c5c3c", "ba469217-47f5-4f3f-8390-389e6d35c129", "Nurse", "NURSE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "736b724a-3030-4a19-98c8-f8472418e71d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc1dc30c-d1f4-46fd-aec8-b22d9a702df8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e72cd88d-8c84-44ec-90f0-6d862a4c5c3c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2cfb7e7f-6d65-4f3b-b7bf-bd96d17917ad", "f20c4edc-b918-4d70-8b20-96754607b22c", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57c163b8-1229-49f3-b1be-97b3c64c904e", "7c7df2a3-0659-4ee8-ae71-2c5177cffc85", "Admin", "ADMIN" });
        }
    }
}
