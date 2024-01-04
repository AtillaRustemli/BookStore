using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class addedAndChangedSomeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EBooks_ABooks_ABookid",
                table: "EBooks");

            migrationBuilder.DropIndex(
                name: "IX_EBooks_ABookid",
                table: "EBooks");

            migrationBuilder.RenameColumn(
                name: "ABookid",
                table: "EBooks",
                newName: "ABookId");

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 4, 19, 37, 29, 969, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 4, 19, 37, 29, 969, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 4, 19, 37, 29, 969, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 4, 19, 37, 29, 969, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.CreateIndex(
                name: "IX_EBooks_ABookId",
                table: "EBooks",
                column: "ABookId",
                unique: true,
                filter: "[ABookId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_EBooks_ABooks_ABookId",
                table: "EBooks",
                column: "ABookId",
                principalTable: "ABooks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EBooks_ABooks_ABookId",
                table: "EBooks");

            migrationBuilder.DropIndex(
                name: "IX_EBooks_ABookId",
                table: "EBooks");

            migrationBuilder.RenameColumn(
                name: "ABookId",
                table: "EBooks",
                newName: "ABookid");

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
                column: "Released",
                value: new DateTime(2024, 1, 4, 19, 2, 5, 991, DateTimeKind.Local).AddTicks(6040));

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
    }
}
