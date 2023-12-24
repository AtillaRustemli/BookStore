using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class addedSomeSeedDataAndDefaultValueForBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PopularityCount", "Released", "SellCount" },
                values: new object[] { 0L, new DateTime(2023, 12, 24, 19, 16, 3, 177, DateTimeKind.Local).AddTicks(5718), 0L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PopularityCount", "Released", "SellCount" },
                values: new object[] { null, new DateTime(2023, 12, 23, 21, 54, 25, 549, DateTimeKind.Local).AddTicks(1944), null });
        }
    }
}
