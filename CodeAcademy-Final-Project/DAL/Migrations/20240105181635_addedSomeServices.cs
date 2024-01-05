using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class addedSomeServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0788f483-2b6a-4da2-be09-72380234f457");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12f078c2-074c-4e9e-b5a8-cb0a3bc237a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d519da1b-b6ae-4bbe-83dc-4d7522661644");

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 5, 22, 16, 34, 810, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0099b685-0ced-4c57-ae70-26659ad9e441", "9c335fb8-a3ff-4f39-b4b8-63c06cec1137", "SuperAdmin", "SUPERADMIN" },
                    { "2ccb8c2c-4e69-4f20-815d-06d7bb7dd937", "7aaa900f-e0ab-4a1d-bd84-1613b62565dc", "Admin", "ADMIN" },
                    { "9da86d99-21ad-45ab-9b2b-c3e8864b4bac", "51d097a6-4f06-4f7f-b7ac-cf62e2295137", "Member", "MEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 5, 22, 16, 34, 810, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 5, 22, 16, 34, 810, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 5, 22, 16, 34, 810, DateTimeKind.Local).AddTicks(5177));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0099b685-0ced-4c57-ae70-26659ad9e441");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ccb8c2c-4e69-4f20-815d-06d7bb7dd937");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9da86d99-21ad-45ab-9b2b-c3e8864b4bac");

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 5, 13, 29, 36, 419, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0788f483-2b6a-4da2-be09-72380234f457", "3de8299e-1721-4314-9286-1723782968e8", "SuperAdmin", "SUPERADMIN" },
                    { "12f078c2-074c-4e9e-b5a8-cb0a3bc237a8", "cbb5e1a4-1cca-441b-91b5-4f9e88e69c72", "Admin", "ADMIN" },
                    { "d519da1b-b6ae-4bbe-83dc-4d7522661644", "7f45b705-6c31-4a89-9f69-ad9cf0dc164c", "Member", "MEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 5, 13, 29, 36, 419, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 5, 13, 29, 36, 419, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 5, 13, 29, 36, 419, DateTimeKind.Local).AddTicks(3699));
        }
    }
}
