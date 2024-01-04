using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class addedReletionBetweenABookAndEBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ABookid",
                table: "EBooks",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 4, 19, 2, 5, 991, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 4, 19, 2, 5, 991, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ABookid", "Released" },
                values: new object[] { 1, new DateTime(2024, 1, 4, 19, 2, 5, 991, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 4, 19, 2, 5, 991, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.CreateIndex(
                name: "IX_EBooks_ABookid",
                table: "EBooks",
                column: "ABookid",
                unique: true,
                filter: "[ABookid] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_EBooks_ABooks_ABookid",
                table: "EBooks",
                column: "ABookid",
                principalTable: "ABooks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EBooks_ABooks_ABookid",
                table: "EBooks");

            migrationBuilder.DropIndex(
                name: "IX_EBooks_ABookid",
                table: "EBooks");

            migrationBuilder.DropColumn(
                name: "ABookid",
                table: "EBooks");

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 4, 17, 8, 25, 808, DateTimeKind.Local).AddTicks(2135));

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
    }
}
