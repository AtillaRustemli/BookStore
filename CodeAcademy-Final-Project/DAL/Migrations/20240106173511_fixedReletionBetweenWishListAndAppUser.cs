using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class fixedReletionBetweenWishListAndAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishList_AspNetUsers_AppUserId1",
                table: "WishList");

            migrationBuilder.DropIndex(
                name: "IX_WishList_AppUserId1",
                table: "WishList");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0099b685-0ced-4c57-ae70-26659ad9e441");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ccb8c2c-4e69-4f20-815d-06d7bb7dd937");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9da86d99-21ad-45ab-9b2b-c3e8864b4bac");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "WishList");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "WishList",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_WishList_AppUserId",
                table: "WishList",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_AspNetUsers_AppUserId",
                table: "WishList",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishList_AspNetUsers_AppUserId",
                table: "WishList");

            migrationBuilder.DropIndex(
                name: "IX_WishList_AppUserId",
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

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "WishList",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "WishList",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 5, 22, 16, 34, 810, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0099b685-0ced-4c57-ae70-26659ad9e441", "9c335fb8-a3ff-4f39-b4b8-63c06cec1137", "SuperAdmin", "SUPERADMIN" },
                    { "2ccb8c2c-4e69-4f20-815d-06d7bb7dd937", "7aaa900f-e0ab-4a1d-bd84-1613b62565dc", "Admin", "ADMIN" },
                    { "9da86d99-21ad-45ab-9b2b-c3e8864b4bac", "51d097a6-4f06-4f7f-b7ac-cf62e2295137", "Member", "MEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 5, 22, 16, 34, 810, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 1, 5, 22, 16, 34, 810, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 1, 5, 22, 16, 34, 810, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.CreateIndex(
                name: "IX_WishList_AppUserId1",
                table: "WishList",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_AspNetUsers_AppUserId1",
                table: "WishList",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
