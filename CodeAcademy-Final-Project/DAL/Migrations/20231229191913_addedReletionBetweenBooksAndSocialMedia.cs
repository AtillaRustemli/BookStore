using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class addedReletionBetweenBooksAndSocialMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SocialMediaId",
                table: "EBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Book",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Length",
                table: "Book",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SocialMediaId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "Book",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SocialMediaId",
                table: "ABooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Released", "SocialMediaId" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 19, 12, 756, DateTimeKind.Local).AddTicks(9120), 1 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Height", "Length", "Released", "SocialMediaId", "Width" },
                values: new object[] { 5.4000000000000004, 20.300000000000001, new DateTime(2023, 12, 29, 23, 19, 12, 756, DateTimeKind.Local).AddTicks(9825), 1, 15.1 });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Released", "SocialMediaId" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 19, 12, 757, DateTimeKind.Local).AddTicks(514), 1 });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2023, 12, 29, 23, 19, 12, 757, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.CreateIndex(
                name: "IX_EBooks_SocialMediaId",
                table: "EBooks",
                column: "SocialMediaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_SocialMediaId",
                table: "Book",
                column: "SocialMediaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ABooks_SocialMediaId",
                table: "ABooks",
                column: "SocialMediaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ABooks_SocialMedias_SocialMediaId",
                table: "ABooks",
                column: "SocialMediaId",
                principalTable: "SocialMedias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_SocialMedias_SocialMediaId",
                table: "Book",
                column: "SocialMediaId",
                principalTable: "SocialMedias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EBooks_SocialMedias_SocialMediaId",
                table: "EBooks",
                column: "SocialMediaId",
                principalTable: "SocialMedias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ABooks_SocialMedias_SocialMediaId",
                table: "ABooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_SocialMedias_SocialMediaId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_EBooks_SocialMedias_SocialMediaId",
                table: "EBooks");

            migrationBuilder.DropIndex(
                name: "IX_EBooks_SocialMediaId",
                table: "EBooks");

            migrationBuilder.DropIndex(
                name: "IX_Book_SocialMediaId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_ABooks_SocialMediaId",
                table: "ABooks");

            migrationBuilder.DropColumn(
                name: "SocialMediaId",
                table: "EBooks");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "SocialMediaId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "SocialMediaId",
                table: "ABooks");

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2023, 12, 29, 22, 20, 44, 408, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2023, 12, 29, 22, 20, 44, 408, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2023, 12, 29, 22, 20, 44, 408, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2023, 12, 29, 22, 20, 44, 408, DateTimeKind.Local).AddTicks(3083));
        }
    }
}
