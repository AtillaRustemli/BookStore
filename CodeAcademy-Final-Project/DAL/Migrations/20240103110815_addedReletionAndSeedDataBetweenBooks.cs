using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class addedReletionAndSeedDataBetweenBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ABookId",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EBookId",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 3, 15, 8, 14, 588, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ABookId", "EBookId", "Released" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 3, 15, 8, 14, 588, DateTimeKind.Local).AddTicks(5589) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Book_ABookId",
                table: "Book",
                column: "ABookId",
                unique: true,
                filter: "[ABookId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Book_EBookId",
                table: "Book",
                column: "EBookId",
                unique: true,
                filter: "[EBookId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_ABooks_ABookId",
                table: "Book",
                column: "ABookId",
                principalTable: "ABooks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_EBooks_EBookId",
                table: "Book",
                column: "EBookId",
                principalTable: "EBooks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_ABooks_ABookId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_EBooks_EBookId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_ABookId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_EBookId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "ABookId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "EBookId",
                table: "Book");

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 1, 15, 48, 13, 392, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 1, 15, 48, 13, 393, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 1, 15, 48, 13, 393, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 1, 15, 48, 13, 393, DateTimeKind.Local).AddTicks(1254));
        }
    }
}
