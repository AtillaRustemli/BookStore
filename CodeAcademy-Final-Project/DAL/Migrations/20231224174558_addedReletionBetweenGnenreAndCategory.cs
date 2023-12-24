using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class addedReletionBetweenGnenreAndCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Genre",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2023, 12, 24, 21, 45, 57, 556, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Fiction");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Genre_CategoryId",
                table: "Genre",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Categories_CategoryId",
                table: "Genre",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genre_Categories_CategoryId",
                table: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_Genre_CategoryId",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Genre");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2023, 12, 24, 20, 22, 50, 378, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "BestSeller");
        }
    }
}
