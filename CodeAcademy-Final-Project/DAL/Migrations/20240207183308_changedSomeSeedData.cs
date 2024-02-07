using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class changedSomeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "ABooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 2, 7, 22, 33, 7, 258, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b2caf5e-e162-4cd8-9779-71b540879b2d", "1445d481-4eb9-424d-b50e-fc88649b40de", "Member", "MEMBER" },
                    { "931ac004-2d84-43be-b84e-122853f6cf4a", "56497b4f-e5ff-42b4-a8db-0024656e05f6", "SuperAdmin", "SUPERADMIN" },
                    { "e8bba3b5-ab94-4dd6-bd93-85d02cbcde86", "30438e5d-2fcc-45be-971d-be48faced5f8", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 2, 7, 22, 33, 7, 258, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Released",
                value: new DateTime(2024, 2, 7, 22, 33, 7, 258, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2024, 2, 7, 22, 33, 7, 259, DateTimeKind.Local).AddTicks(476));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b2caf5e-e162-4cd8-9779-71b540879b2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "931ac004-2d84-43be-b84e-122853f6cf4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8bba3b5-ab94-4dd6-bd93-85d02cbcde86");

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
        }
    }
}
