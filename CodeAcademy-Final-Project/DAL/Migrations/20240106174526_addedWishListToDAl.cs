using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class addedWishListToDAl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_WishList_AspNetUsers_AppUserId",
                table: "WishList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishList",
                table: "WishList");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05ad565a-bf4e-493b-9b53-8ea505015a4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a56adc8-45b1-4f1f-8a2c-6c41c8a1d139");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6d9ff74-5c41-458b-9061-176e99568d3a");

            migrationBuilder.RenameTable(
                name: "WishList",
                newName: "WishLists");

            migrationBuilder.RenameIndex(
                name: "IX_WishList_AppUserId",
                table: "WishLists",
                newName: "IX_WishLists_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishLists",
                table: "WishLists",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 6, 21, 45, 25, 683, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b796b37-bc35-4c39-90e4-e97b0616124b", "cf5e4f56-2918-49c6-8bff-95117f7d69f6", "Admin", "ADMIN" },
                    { "5754234e-dbc1-4ae5-8d0d-89ead5ccad7a", "4774c4ec-f440-4b7d-81b4-f978d37f178f", "Member", "MEMBER" },
                    { "e07de3ef-5676-4ec8-9bf5-14fa223655ba", "450413ea-900a-4dfe-91c1-dd715893c76b", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 6, 21, 45, 25, 684, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 6, 21, 45, 25, 684, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 6, 21, 45, 25, 684, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.AddForeignKey(
                name: "FK_ABooks_WishLists_WishListId",
                table: "ABooks",
                column: "WishListId",
                principalTable: "WishLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_WishLists_WishListId",
                table: "Book",
                column: "WishListId",
                principalTable: "WishLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EBooks_WishLists_WishListId",
                table: "EBooks",
                column: "WishListId",
                principalTable: "WishLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_AspNetUsers_AppUserId",
                table: "WishLists",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ABooks_WishLists_WishListId",
                table: "ABooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_WishLists_WishListId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_EBooks_WishLists_WishListId",
                table: "EBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_AspNetUsers_AppUserId",
                table: "WishLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishLists",
                table: "WishLists");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b796b37-bc35-4c39-90e4-e97b0616124b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5754234e-dbc1-4ae5-8d0d-89ead5ccad7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e07de3ef-5676-4ec8-9bf5-14fa223655ba");

            migrationBuilder.RenameTable(
                name: "WishLists",
                newName: "WishList");

            migrationBuilder.RenameIndex(
                name: "IX_WishLists_AppUserId",
                table: "WishList",
                newName: "IX_WishList_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishList",
                table: "WishList",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 6, 21, 35, 10, 812, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05ad565a-bf4e-493b-9b53-8ea505015a4f", "b8bf0968-43a8-4d67-b7db-01d3aa7d5f90", "SuperAdmin", "SUPERADMIN" },
                    { "7a56adc8-45b1-4f1f-8a2c-6c41c8a1d139", "5352d1b8-673b-4d99-bf77-c5ecf9dbc964", "Member", "MEMBER" },
                    { "e6d9ff74-5c41-458b-9061-176e99568d3a", "442f12ce-cfed-4014-8311-0fb824f52d37", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 6, 21, 35, 10, 812, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 6, 21, 35, 10, 812, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 6, 21, 35, 10, 812, DateTimeKind.Local).AddTicks(3347));

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

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_AspNetUsers_AppUserId",
                table: "WishList",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
