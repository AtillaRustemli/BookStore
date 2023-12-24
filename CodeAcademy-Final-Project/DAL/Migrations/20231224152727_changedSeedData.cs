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
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Released" },
                values: new object[] { 11.0, new DateTime(2023, 12, 24, 19, 27, 26, 579, DateTimeKind.Local).AddTicks(159) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Released" },
                values: new object[] { 1.0, new DateTime(2023, 12, 24, 19, 16, 3, 177, DateTimeKind.Local).AddTicks(5718) });
        }
    }
}
