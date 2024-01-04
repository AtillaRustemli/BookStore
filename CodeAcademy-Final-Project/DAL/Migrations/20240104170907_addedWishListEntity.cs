using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class addedWishListEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WishListId",
                table: "EBooks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WishListId",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WishListId",
                table: "ABooks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WishList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishList", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 4, 21, 9, 6, 416, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 4, 21, 9, 6, 416, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 4, 21, 9, 6, 416, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 4, 21, 9, 6, 416, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.InsertData(
                table: "WishList",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsMain", "IsPrivate", "Name", "UpdatedAt" },
                values: new object[] { 1, null, null, true, true, "Wish List", null });

            migrationBuilder.CreateIndex(
                name: "IX_EBooks_WishListId",
                table: "EBooks",
                column: "WishListId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_WishListId",
                table: "Book",
                column: "WishListId");

            migrationBuilder.CreateIndex(
                name: "IX_ABooks_WishListId",
                table: "ABooks",
                column: "WishListId");

            migrationBuilder.AddForeignKey(
                name: "FK_ABooks_WishList_WishListId",
                table: "ABooks",
                column: "WishListId",
                principalTable: "WishList",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_WishList_WishListId",
                table: "Book",
                column: "WishListId",
                principalTable: "WishList",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EBooks_WishList_WishListId",
                table: "EBooks",
                column: "WishListId",
                principalTable: "WishList",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ABooks_WishList_WishListId",
                table: "ABooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_WishList_WishListId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_EBooks_WishList_WishListId",
                table: "EBooks");

            migrationBuilder.DropTable(
                name: "WishList");

            migrationBuilder.DropIndex(
                name: "IX_EBooks_WishListId",
                table: "EBooks");

            migrationBuilder.DropIndex(
                name: "IX_Book_WishListId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_ABooks_WishListId",
                table: "ABooks");

            migrationBuilder.DropColumn(
                name: "WishListId",
                table: "EBooks");

            migrationBuilder.DropColumn(
                name: "WishListId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "WishListId",
                table: "ABooks");

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
        }
    }
}
