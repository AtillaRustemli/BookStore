using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class changedSomething : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Book_BookId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Book_BookId",
                table: "BookCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Book_BookId",
                table: "BookGenre");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a782457-8eef-40ef-b6f3-acc83ceb0b30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13a6143e-a18d-4ece-b92d-f8fff2ccd4ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa535a0c-6a59-458f-9cba-79f1abfe358e");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "BookGenre",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "BookCategory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "BookAuthor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 7, 23, 32, 6, 552, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "692625ce-a64e-4b7f-94d0-0ab714047f87", "e78f2076-e67d-4e0d-925b-a65ecf88c155", "Member", "MEMBER" },
                    { "78345004-8a73-43b6-b46a-68434dde6d08", "6ed4d670-7c47-4797-a81a-607e7c215c61", "SuperAdmin", "SUPERADMIN" },
                    { "b5baa6d3-0d99-40a7-bd92-c5d497b66119", "b4c7c7d5-eb78-448b-ba70-e5839750a0b0", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 7, 23, 32, 6, 552, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 7, 23, 32, 6, 552, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 7, 23, 32, 6, 552, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Book_BookId",
                table: "BookAuthor",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Book_BookId",
                table: "BookCategory",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Book_BookId",
                table: "BookGenre",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Book_BookId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Book_BookId",
                table: "BookCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Book_BookId",
                table: "BookGenre");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "692625ce-a64e-4b7f-94d0-0ab714047f87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78345004-8a73-43b6-b46a-68434dde6d08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5baa6d3-0d99-40a7-bd92-c5d497b66119");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "BookGenre",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "BookCategory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "BookAuthor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 7, 21, 42, 27, 851, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a782457-8eef-40ef-b6f3-acc83ceb0b30", "371701c3-37cf-481b-9f95-426aacba3228", "SuperAdmin", "SUPERADMIN" },
                    { "13a6143e-a18d-4ece-b92d-f8fff2ccd4ba", "8120677e-32d4-4620-af99-10d8a5fdd16a", "Member", "MEMBER" },
                    { "fa535a0c-6a59-458f-9cba-79f1abfe358e", "29545daf-febb-4bcb-8c97-556d5149ffa0", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 7, 21, 42, 27, 851, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 7, 21, 42, 27, 851, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 7, 21, 42, 27, 851, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Book_BookId",
                table: "BookAuthor",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Book_BookId",
                table: "BookCategory",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Book_BookId",
                table: "BookGenre",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
