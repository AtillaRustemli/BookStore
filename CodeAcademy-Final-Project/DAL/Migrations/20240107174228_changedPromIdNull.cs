using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class changedPromIdNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ABooks_Promotions_PromotionId",
                table: "ABooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Promotions_PromotionId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_EBooks_Promotions_PromotionId",
                table: "EBooks");

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

            migrationBuilder.AlterColumn<int>(
                name: "PromotionId",
                table: "EBooks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PromotionId",
                table: "Book",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PromotionId",
                table: "ABooks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_ABooks_Promotions_PromotionId",
                table: "ABooks",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Promotions_PromotionId",
                table: "Book",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EBooks_Promotions_PromotionId",
                table: "EBooks",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ABooks_Promotions_PromotionId",
                table: "ABooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Promotions_PromotionId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_EBooks_Promotions_PromotionId",
                table: "EBooks");

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
                name: "PromotionId",
                table: "EBooks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PromotionId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PromotionId",
                table: "ABooks",
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
                name: "FK_ABooks_Promotions_PromotionId",
                table: "ABooks",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Promotions_PromotionId",
                table: "Book",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EBooks_Promotions_PromotionId",
                table: "EBooks",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
