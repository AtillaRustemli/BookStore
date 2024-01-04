using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class changedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ABookChapter",
                keyColumn: "Id",
                keyValue: 1,
                column: "ABookUrl",
                value: "Chapter1-audiobook.m4a");

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BTypeId", "Released" },
                values: new object[] { 3, new DateTime(2024, 1, 4, 17, 8, 25, 808, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 4, 17, 8, 25, 808, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 4, 17, 8, 25, 808, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 4, 17, 8, 25, 808, DateTimeKind.Local).AddTicks(4498));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ABookChapter",
                keyColumn: "Id",
                keyValue: 1,
                column: "ABookUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BTypeId", "Released" },
                values: new object[] { 2, new DateTime(2024, 1, 3, 15, 8, 14, 588, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 3, 15, 8, 14, 588, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 3, 15, 8, 14, 588, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 3, 15, 8, 14, 588, DateTimeKind.Local).AddTicks(6633));
        }
    }
}
